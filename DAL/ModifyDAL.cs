using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ModifyDAL
    {
        public ModifyDAL()
        {
        }

        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh insert,update,dête,...
        SqlDataReader dataReader; //dùng để đọc dữ liệu trong bảng 
        public List<DTO.TaiKhoan> TaiKhoans(string query)//dùng để check tài khoản 
        {
            List<DTO.TaiKhoan> taiKhoans = new List<DTO.TaiKhoan>();
            using (SqlConnection sqlConnection = ConnectionDAL.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }

        public void Command(string query)//dùng để đăng ký tài  khoản 
        {
            using (SqlConnection sqlConnection = ConnectionDAL.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn 
                sqlConnection.Close();
            }
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số nếu có
                    command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
