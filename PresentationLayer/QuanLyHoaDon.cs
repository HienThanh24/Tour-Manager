using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyHoaDon: Form
    {
        private HoaDonBL hdBL;

        public QuanLyHoaDon()
        {
            InitializeComponent();
            hdBL = new HoaDonBL();
        }


        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHD.AutoGenerateColumns = true;
                dgvHD.DataSource = hdBL.GetHoaDons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message);
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtSoHD.Text = dgvHD.Rows[i].Cells[0].Value.ToString();
                txtMaTour.Text = dgvHD.Rows[i].Cells[3].Value.ToString();

                dptNgayLapHD.Text = dgvHD.Rows[i].Cells[6].Value.ToString();
                txtThanhTien.Text = dgvHD.Rows[i].Cells[7].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string soHD = txtSoHD.Text.Trim(); // Lấy từ label đang hiển thị mã hóa đơn

                if (string.IsNullOrEmpty(soHD))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool kq = hdBL.XoaHoaDon(soHD);
                    if (kq)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!");
                        dgvHD.DataSource = hdBL.GetHoaDons(); // Load lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa hóa đơn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
            }
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            if (dgvHD.SelectedRows.Count == 0 || dgvHD.CurrentRow == null || dgvHD.CurrentRow.Cells[0].Value == null || string.IsNullOrEmpty(dgvHD.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soHD = dgvHD.CurrentRow.Cells[0].Value.ToString();

            ChiTietHoaDon frm = new ChiTietHoaDon(soHD);
            frm.ShowDialog();
        }
    }
}
