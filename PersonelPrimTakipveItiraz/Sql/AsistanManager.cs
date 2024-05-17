using PersonelPrimTakipveItiraz.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Sql
{
    public class AsistanManager
    {

        public List<Cagri> CagrilariGetir(int asistanId)
        {
            List<Cagri> cagrilar = new List<Cagri>();
            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                // Sorguyu hazırla
                string query = "EXEC GetAssignedCalls @asistan_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@asistan_id", asistanId);

                // Sorguyu çalıştır ve sonuçları al
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Verileri Cagri nesnelerine dönüştür
                    Cagri cagri = new Cagri();
                    cagri.CagriId = Convert.ToInt32(reader["cagri_id"]);
                    cagri.AsistanId = Convert.ToInt32(reader["asistan_id"]);
                    cagri.Konu = reader["konu"].ToString();
                    cagri.OlusturulmaTarihi = Convert.ToDateTime(reader["olusturuma_tarih"]);
                    cagri.CevaplamaTarihi = reader["cevaplama_tarih"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["cevaplama_tarih"]);
                    cagri.Durum = reader["durum"].ToString();

                    cagrilar.Add(cagri);
                }

                // Okuyucuyu kapat
                reader.Close();
            }

            return cagrilar;
        }

        public bool AddGorusmeDetay(int asistanId, string gorusmeDetay, DateTime tarih, TimeSpan baslamaSaati, TimeSpan bitisSaati, string durum, string musteriAdi, string musteriSoyadi,string gorusmeKonusu)
        {
            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("AddGorusmeDetay", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@asistan_id", asistanId);
                    command.Parameters.AddWithValue("@gorusme_detay", gorusmeDetay);
                    command.Parameters.AddWithValue("@tarih", tarih);
                    command.Parameters.AddWithValue("@baslama_saati", baslamaSaati);
                    command.Parameters.AddWithValue("@bitis_saati", bitisSaati);
                    command.Parameters.AddWithValue("@durum", durum);
                    command.Parameters.AddWithValue("@musteri_adi", musteriAdi);
                    command.Parameters.AddWithValue("@musteri_soyadi", musteriSoyadi);
                    command.Parameters.AddWithValue("@gorusme_konusu", gorusmeKonusu);
                    try
                    {
                        command.ExecuteNonQuery();
                        sqlConnectionManager.CloseConnection();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        return false;
                    }
                }
            }


        }

        public bool UpdateCallStatusAndResponseDate(int cagriId, DateTime cevaplamaTarih, string durum)
        {
            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("UpdateCallStatusAndResponseDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@cagri_id", cagriId);
                    command.Parameters.AddWithValue("@cevaplama_tarih", cevaplamaTarih);
                    command.Parameters.AddWithValue("@durum", durum);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

        }

        public List<PrimTakip> ListelePrimTakip(int asistanId)
        {
            List<PrimTakip> primListesi = new List<PrimTakip>();
            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                string query = @"SELECT prim_id, asistan_id, tarih, miktar FROM dbo.ListPrimTakip(@asistan_id) ORDER BY tarih DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@asistan_id", asistanId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PrimTakip prim = new PrimTakip
                            {
                                PrimId = Convert.ToInt32(reader["prim_id"]),
                                AsistanId = Convert.ToInt32(reader["asistan_id"]),
                                Tarih = Convert.ToDateTime(reader["tarih"]),
                                Miktar = Convert.ToDecimal(reader["miktar"])
                            };

                            primListesi.Add(prim);
                        }
                    }
                }
            }

            return primListesi;
        }

        public bool EkleItiraz(int asistanId, int primId, DateTime tarih, string aciklama, string durum)
        {

            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();


            try
            {
                using (SqlConnection connection = sqlConnectionManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EkleItiraz", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekleyin
                        command.Parameters.AddWithValue("@asistan_id", asistanId);
                        command.Parameters.AddWithValue("@prim_id", primId);
                        command.Parameters.AddWithValue("@tarih", tarih);
                        command.Parameters.AddWithValue("@aciklama", aciklama);
                        command.Parameters.AddWithValue("@durum", durum);

                        // Komutu çalıştırın
                        command.ExecuteNonQuery();
                    }
                }
                return true; // İşlem başarılıysa true dön
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
                return false; // İşlem başarısızsa false dön
            }

        }

        public string[] GetGrupYoneticisiEmailsByAsistanId(int asistanId)
        {
            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

            // Sonuçlar için bir liste oluştur
            var emails = new List<string>();

            // Veritabanı bağlantısı oluştur
            using (SqlConnection connection =  sqlConnectionManager.GetConnection())
            {
                // SQL komutunu oluştur
                string sqlQuery = "SELECT email FROM dbo.GetGrupYoneticisiByAsistanId(@asistan_id)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@asistan_id", asistanId);
                command.CommandType = CommandType.Text;

                // Komutu çalıştır ve sonuçları oku
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Her satır için e-posta adresini listeye ekle
                    while (reader.Read())
                    {
                        string email = reader["email"].ToString();
                        emails.Add(email);
                    }
                }
            }

            // Listeyi diziye dönüştür ve döndür
            return emails.ToArray();
        }

        SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

        public DataTable CekItirazlar(int asistanId)
        {
            // Veri tablosu oluşturma
            DataTable dataTable = new DataTable();


            // SQL sorgusu
            string query = "EXEC CekItirazlar @asistan_id";

            // Bağlantı oluşturma
            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                // Komut oluşturma
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleme
                    command.Parameters.AddWithValue("@asistan_id", asistanId);

                    // Adaptör oluşturma
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Verileri doldurma
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
