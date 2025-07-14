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
    public partial class QuanLyKhachHang: Form
    {
        private KhachHangBL khBL;

        public QuanLyKhachHang()
        {
            InitializeComponent();
            khBL = new KhachHangBL();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dgvKH.DataSource = khBL.GetKhachHangs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                txtMaKH.Text = dgvKH.Rows[i].Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dgvKH.Rows[i].Cells["HoTen"].Value.ToString();
                txtSdt.Text = dgvKH.Rows[i].Cells["Sdt"].Value.ToString();
                txtEmail.Text = dgvKH.Rows[i].Cells["Email"].Value.ToString();

                string gioiTinh = dgvKH.Rows[i].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam") rdoNam.Checked = true;
                else if (gioiTinh == "Nữ") rdoNu.Checked = true;

            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKH.Text.Trim();
            dgvKH.DataSource = khBL.SearchByName(keyword);
        }

        private void LamMoi(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            // Load lại danh sách KH nếu cần
            dgvKH.DataSource = khBL.GetKhachHangs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            KhachHang kh = new KhachHang(
                maKH,
                txtTenKH.Text.Trim(),
                gioiTinh,
                txtSdt.Text.Trim(),
                txtEmail.Text.Trim()
            );

            bool kq = khBL.Sua(kh);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvKH.DataSource = khBL.GetKhachHangs();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ràng buộc HOÁ ĐƠN (gọi BL)
            if (khBL.KiemTraKhachHangCoHoaDon(maKH))
            {
                MessageBox.Show("Không thể xóa khách hàng vì đang có hóa đơn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool ketQua = khBL.XoaKhachHang(maKH); // gọi BL xử lý xóa
                if (ketQua)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKH.DataSource = khBL.GetKhachHangs();
                    LamMoi(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
