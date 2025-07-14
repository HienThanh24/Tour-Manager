using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class HoaDonDL : DataProvider
    {

        public List<HoaDon> GetHoaDon()
        {
            List<HoaDon> lHoaDon = new List<HoaDon>();

            string sql = "SELECT * FROM HOADON";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string soHD = reader["SoHD"].ToString();
                    string maNV = reader["MaNV"].ToString();
                    string maKH = reader["MaKH"].ToString();
                    string maTour = reader["MaTour"].ToString();
                    int soLuongVe = reader["SoLuongVe"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongVe"]) : 0;
                    DateTime ngayDangKy = reader["NgayDangKy"] != DBNull.Value ? Convert.ToDateTime(reader["NgayDangKy"]) : DateTime.MinValue;
                    DateTime ngayLap = reader["NgayLapHD"] != DBNull.Value ? Convert.ToDateTime(reader["NgayLapHD"]) : DateTime.MinValue;
                    decimal thanhTien = reader["ThanhTien"] != DBNull.Value ? Convert.ToDecimal(reader["ThanhTien"]) : 0;

                    HoaDon hd = new HoaDon(soHD, maNV, maKH, maTour, soLuongVe, ngayDangKy, ngayLap, thanhTien);
                    lHoaDon.Add(hd);
                }
                reader.Close();
                return lHoaDon;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL khi lấy danh sách hóa đơn: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }

        }

        public bool DeleteHoaDon(string soHD)
        {
            string sql = "uspDeleteHoaDon";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@SoHD", soHD)
            };

            try
            {
                int result = MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi xóa hóa đơn: " + ex.Message);
            }
        }
        public string ThemHoaDon(HoaDon hoaDon)
        {
            string sql = "uspAddHoaDon";  // Thủ tục thêm hóa đơn
            string newInvoiceNumber = GetNewInvoiceNumber();  // Hàm lấy mã hóa đơn mới

            List<SqlParameter> parameters = new List<SqlParameter>

            {
                new SqlParameter("@SoHD", newInvoiceNumber),
        new SqlParameter("@MaNV", hoaDon.MaNV),
        new SqlParameter("@MaKH", hoaDon.MaKH),
        new SqlParameter("@MaTour", hoaDon.MaTour),
        new SqlParameter("@NgayLapHD", hoaDon.NgayLapHD),
        new SqlParameter("@NgayDangKy", hoaDon.NgayDangKy),
        new SqlParameter("@ThanhTien", hoaDon.ThanhTien),
        new SqlParameter("@SoLuongVe", hoaDon.SoLuongVe)
            };

            try
            {
                int result = MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);

                if (result > 0)
                    return newInvoiceNumber;  // Trả về mã hóa đơn mới
                else
                    return null;  // Trả về null nếu thêm thất bại
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
        }

        private string GetNewInvoiceNumber()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(SoHD, 3, 3) AS INT)) FROM HOADON";
            object maxValue = MyExcuteScalar(query, CommandType.Text);

            int currentMax = 0;
            if (maxValue != null && maxValue != DBNull.Value)
            {
                currentMax = Convert.ToInt32(maxValue);
            }

            int newInvoiceNumber = currentMax + 1;
            return "HD" + newInvoiceNumber.ToString("D3");
        }
    }
}

