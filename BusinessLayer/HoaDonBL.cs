using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class HoaDonBL
    {
        private HoaDonDL hoaDonDL = new HoaDonDL();

        public List<HoaDon> GetHoaDons()
        {
            try
            {
                return hoaDonDL.GetHoaDon();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool XoaHoaDon(string soHD)
        {
            return hoaDonDL.DeleteHoaDon(soHD);
        }
        public string XuLyThanhToan(HoaDon hd)
        {
            string soHD = hoaDonDL.ThemHoaDon(hd);
            return soHD;
        }

    }
}
