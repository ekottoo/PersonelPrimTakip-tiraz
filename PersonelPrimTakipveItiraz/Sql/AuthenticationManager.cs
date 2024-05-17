using PersonelPrimTakipveItiraz.Model;
using PersonelPrimTakipveItiraz.Sql;
using System.Data.SqlClient;
using System.Data;

public class AuthenticationManager
{
    public Object GetUserInfo(string email, string password)
    {
        SqlConnectionManager sqlConnectionManager = new SqlConnectionManager();
        Object userInfo = null;

        using (SqlConnection connection = sqlConnectionManager.GetConnection())
        {
            using (SqlCommand command = new SqlCommand("GetUserInformation", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() && reader.VisibleFieldCount > 1)
                {
                  
                    string role = reader.GetString(0);
                    if (role == "Asistan")
                    {
                        userInfo = new Asistan
                        {
                            Asistan_Id = reader.GetInt32(1),
                            Ad = reader.GetString(2),
                            Soyad = reader.GetString(3),
                            Kullanici_Id = reader.GetInt32(5),
                            Sicil_Numarasi = reader.GetInt32(4)
                        };
                    }
                    else if (role == "Takim Lideri")
                    {
                        userInfo = new TakimLideri
                        {
                            TakimLideriId = reader.GetInt32(1),
                            Ad = reader.GetString(2),
                            Soyad = reader.GetString(3),
                            Kullanici_Id = reader.GetInt32(4)
                        };
                    }
                }

                reader.Close();
            }
        }

        return userInfo;
    }
}