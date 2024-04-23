using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DTO.BaiDang;
using static DTO.LichHenTho;
using BLL;
using DAL;

namespace GUI.All_Tho_Control
{
    public partial class UC_LichHen : UserControl
    {
        //private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";

        public UC_LichHen()
        {
            InitializeComponent();
            btnChuaxuly.PerformClick();
        }


       /* private List<LichHenTho> GetDanhSachLichHenTho()
        {
            List<LichHenTho> danhSachLichHen = new List<LichHenTho>();

            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT IDCongViec, Ten, SDT, DiaChi, LichThoDen,Gio, MoTaChiTiet, GhiChu, TrangThaiCongViecTho, GiaTien, LinhVuc " +
                                   "FROM CongViec" ;

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        LichHenTho lichhen = new LichHenTho();
                        lichhen.IDLichHen = Convert.ToInt32(reader["IDCongViec"]);
                        lichhen.Ten = reader["Ten"].ToString();
                        lichhen.DiaChi = reader["DiaChi"].ToString();
                        lichhen.SDT = reader["SDT"].ToString();
                        lichhen.LichHenDen = (DateTime)reader["LichThoDen"];
                        lichhen.MoTaChiTiet = reader["MoTaChiTiet"].ToString();
                        lichhen.GhiChu = reader["GhiChu"].ToString();
                        lichhen.TrangThaiCongViecTho = reader["TrangThaiCongViecTho"].ToString();
                        lichhen.TrangThaiCongViecNguoiDung = reader["TrangThaiCongViecNguoiDung"].ToString();
                        lichhen.GiaTien = Convert.ToDecimal(reader["GiaTien"]);
                        lichhen.Gio = reader["Gio"].ToString();
                        lichhen.LinhVuc = reader["LinhVuc"].ToString();

                        danhSachLichHen.Add(lichhen);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }*/

        private void HienThiDanhSachLichHen(List<LichHenTho> danhSach)
        {
            pnlxemhen.Controls.Clear();

            foreach (LichHenTho lichHen in danhSach)
            {
                UC_Lich ucLich = new UC_Lich(lichHen);


                if (lichHen.TrangThaiCongViecTho == "Đã hoàn thành")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnChapNhan().Visible = false;
                }

                if (lichHen.TrangThaiCongViecTho == "Đã hủy")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnChapNhan().Visible = false;
                }

                if (lichHen.TrangThaiCongViecTho == "Đã chấp nhận")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnChapNhan().Visible = false;
                    ucLich.GetBtnHoanThanh().Visible = true;
                }

                if (lichHen.TrangThaiCongViecTho == "Từ chối")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnChapNhan().Visible = false;
                }

                if (lichHen.TrangThaiCongViecTho == "Đã hoàn thành")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnChapNhan().Visible = false;

                    ucLich.GetBtnXemDanhGia().Visible = true;

                }

                /*if (lichHen.TrangThaiCongViecNguoiDung == "Đã xác nhận")
                {
                    //ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                }*/

                ucLich.Dock = DockStyle.Top;
                pnlxemhen.Controls.Add(ucLich);
            }
        }

        private void UpdateDanhSachLichHen(string trangThai)
        {
            List<LichHenTho> danhSachLichHen = GetDanhSachLichHenThoTheoTrangThai(trangThai, BLL.LoginBLL.IDTho);
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private List<LichHenTho> GetDanhSachLichHenThoTheoTrangThai(string trangThai, int idTho)
        {
            List<LichHenTho> danhSachLichHen = new List<LichHenTho>();

            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT IDCongViec, Ten, SDT, DiaChi, LichThoDen, Gio, MoTaChiTiet, GhiChu, TrangThaiCongViecTho, GiaTien, LinhVuc " +
                                   "FROM CongViec " +
                                   "WHERE CongViec.TrangThaiCongViecTho = @TrangThai AND CongViec.IDTho = @idTho";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                    command.Parameters.AddWithValue("@idTho", idTho);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        LichHenTho lichhen = new LichHenTho();
                        lichhen.IDLichHen = Convert.ToInt32(reader["IDCongViec"]);
                        lichhen.Ten = reader["Ten"].ToString();
                        lichhen.DiaChi = reader["DiaChi"].ToString();
                        lichhen.SDT = reader["SDT"].ToString();
                        lichhen.LichHenDen = (DateTime)reader["LichThoDen"];
                        lichhen.MoTaChiTiet = reader["MoTaChiTiet"].ToString();
                        lichhen.GhiChu = reader["GhiChu"].ToString();
                        lichhen.TrangThaiCongViecTho = reader["TrangThaiCongViecTho"].ToString();
                        lichhen.GiaTien = Convert.ToDecimal(reader["GiaTien"]);
                        lichhen.Gio = reader["Gio"].ToString();
                        lichhen.LinhVuc = reader["LinhVuc"].ToString();

                        danhSachLichHen.Add(lichhen);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }


        private void btnChuaxuly_Click(object sender, EventArgs e)
        {
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Chưa xử lý");
        }

        private void btnchapnhan_Click(object sender, EventArgs e)
        {
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Đã chấp nhận");
        }

        private void bttuchoi_Click(object sender, EventArgs e)
        {
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Từ chối");
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            // Xử lý logic khi người dùng nhấn nút "Hoàn thành"
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Đã hoàn thành");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xử lý logic
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Đã hủy");
        }
    }
}
