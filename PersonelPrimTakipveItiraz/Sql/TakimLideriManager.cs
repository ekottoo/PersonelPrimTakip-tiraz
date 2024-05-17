using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelPrimTakipveItiraz.Sql
{
    public class TakimLideriManager
    {


        public DataTable GetItirazlarByTakimLideriId(int takimLideriId)
        {

            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                string query = @"SELECT Itirazlar.itiraz_id, Asistan.ad as 'Asistan Adı', Asistan.soyad as 'Asistan Soyadı',
                                Asistan.sicil_numarasi as 'Sicil Numarası',
                                Itirazlar.tarih as 'İtiraz Tarihi',
                                Itirazlar.aciklama as 'İtiraz Açıklama', 
                                Itirazlar.durum as 'İtiraz Durum', 
                                itiraz_cevabi as 'İtiraz Cevabı'

                                FROM Itirazlar
                                JOIN Asistan ON Itirazlar.asistan_id = Asistan.asistan_id
                                JOIN AsistanTakimLideri ON Asistan.asistan_id = AsistanTakimLideri.asistan_id
                                WHERE AsistanTakimLideri.takim_lideri_id = @takimLideriId;
                                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TakimLideriId", takimLideriId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public void UpdateItirazDurumVeCevap(int itirazId, string yeniDurum, string yeniItirazCevabi)
        {
            SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();

            using (SqlConnection connection = sqlConnectionManager.GetConnection())
            {
                string query = @"UPDATE Itirazlar
                             SET durum = @YeniDurum,
                                 itiraz_cevabi = @YeniItirazCevabi
                             WHERE itiraz_id = @ItirazId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@YeniDurum", yeniDurum);
                    command.Parameters.AddWithValue("@YeniItirazCevabi", yeniItirazCevabi);
                    command.Parameters.AddWithValue("@ItirazId", itirazId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
