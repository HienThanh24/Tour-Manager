using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class DatTourBL
    {
        private DatTourDL vedl = new DatTourDL();

        public Ve LayThongTinTour(string maTour)
        {
            return vedl.LayThongTinTour(maTour);
        }


        public decimal TinhThanhTien(Ve ve, int soLuongVe)
        {
            ve.CapNhatThanhTien(soLuongVe);
            return ve.ThanhTien;
        }
    }
}

