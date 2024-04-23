using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SaoDanhGia
    {

        public (int, double) GetSaoDanhGia(int idTho)
        {
            int soBai = 0;
            double saoTB = 0;

            try
            {
                using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
                {
                    connection.Open();

                    string query = "SELECT Count(*) as SoBai, avg(SoSao) as SaoTB " +
                                   "FROM DanhGia " +
                                   "INNER JOIN CongViec ON DanhGia.IDCongViec = CongViec.IDCongViec " +
                                   "WHERE CongViec.IDTho = @IDTho";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDTho", idTho);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            soBai = Convert.ToInt32(reader["SoBai"]);
                            saoTB = Convert.ToDouble(reader["SaoTB"]);  
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }

            return (soBai, saoTB);
        }
    }

}
