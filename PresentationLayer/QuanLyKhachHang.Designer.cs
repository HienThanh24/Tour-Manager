namespace PresentationLayer
{
    partial class QuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.grBTimKiem = new System.Windows.Forms.GroupBox();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.grBTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.grbTTKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(845, 223);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 47);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(641, 226);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 44);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTimKH
            // 
            this.txtTimKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKH.Location = new System.Drawing.Point(356, 29);
            this.txtTimKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(334, 34);
            this.txtTimKH.TabIndex = 20;
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.Silver;
            this.btnTimKH.FlatAppearance.BorderSize = 0;
            this.btnTimKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKH.ForeColor = System.Drawing.Color.Black;
            this.btnTimKH.Location = new System.Drawing.Point(720, 29);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(109, 37);
            this.btnTimKH.TabIndex = 21;
            this.btnTimKH.Text = "🔎Lọc";
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenKH.Location = new System.Drawing.Point(198, 31);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(150, 28);
            this.lbTenKH.TabIndex = 22;
            this.lbTenKH.Text = "Tên khách hàng:";
            // 
            // grBTimKiem
            // 
            this.grBTimKiem.Controls.Add(this.txtTimKH);
            this.grBTimKiem.Controls.Add(this.btnTimKH);
            this.grBTimKiem.Controls.Add(this.lbTenKH);
            this.grBTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grBTimKiem.Location = new System.Drawing.Point(395, 3);
            this.grBTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grBTimKiem.Name = "grBTimKiem";
            this.grBTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grBTimKiem.Size = new System.Drawing.Size(837, 76);
            this.grBTimKiem.TabIndex = 44;
            this.grBTimKiem.TabStop = false;
            this.grBTimKiem.Text = "Tìm kiếm:";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 140F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SDT";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 130F;
            this.HoTen.HeaderText = "Tên KH";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.GioiTinh,
            this.Sdt,
            this.Email});
            this.dgvKH.Location = new System.Drawing.Point(54, 96);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1178, 217);
            this.dgvKH.TabIndex = 45;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // grbTTKH
            // 
            this.grbTTKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.grbTTKH.Controls.Add(this.btnSua);
            this.grbTTKH.Controls.Add(this.btnXoa);
            this.grbTTKH.Controls.Add(this.rdoNu);
            this.grbTTKH.Controls.Add(this.lbMaKH);
            this.grbTTKH.Controls.Add(this.rdoNam);
            this.grbTTKH.Controls.Add(this.txtMaKH);
            this.grbTTKH.Controls.Add(this.lbGioiTinh);
            this.grbTTKH.Controls.Add(this.lbTen);
            this.grbTTKH.Controls.Add(this.lbSdt);
            this.grbTTKH.Controls.Add(this.txtTenKH);
            this.grbTTKH.Controls.Add(this.lbEmail);
            this.grbTTKH.Controls.Add(this.txtEmail);
            this.grbTTKH.Controls.Add(this.txtSdt);
            this.grbTTKH.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.grbTTKH.Location = new System.Drawing.Point(54, 319);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(1178, 301);
            this.grbTTKH.TabIndex = 47;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin khách hàng";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaKH.ForeColor = System.Drawing.Color.Black;
            this.lbMaKH.Location = new System.Drawing.Point(58, 51);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(149, 28);
            this.lbMaKH.TabIndex = 48;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoNu.ForeColor = System.Drawing.Color.Black;
            this.rdoNu.Location = new System.Drawing.Point(251, 238);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(60, 32);
            this.rdoNu.TabIndex = 58;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoNam.ForeColor = System.Drawing.Color.Black;
            this.rdoNam.Location = new System.Drawing.Point(132, 238);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(75, 32);
            this.rdoNam.TabIndex = 57;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lbGioiTinh.Location = new System.Drawing.Point(58, 206);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(91, 28);
            this.lbGioiTinh.TabIndex = 56;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(63, 94);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(381, 34);
            this.txtMaKH.TabIndex = 49;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.ForeColor = System.Drawing.Color.Black;
            this.lbTen.Location = new System.Drawing.Point(58, 128);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(150, 28);
            this.lbTen.TabIndex = 50;
            this.lbTen.Text = "Tên khách hàng:";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSdt.ForeColor = System.Drawing.Color.Black;
            this.lbSdt.Location = new System.Drawing.Point(636, 128);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(132, 28);
            this.lbSdt.TabIndex = 51;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(641, 94);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 34);
            this.txtEmail.TabIndex = 55;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(636, 51);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 28);
            this.lbEmail.TabIndex = 52;
            this.lbEmail.Text = "Email:";
            // 
            // txtSdt
            // 
            this.txtSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSdt.Location = new System.Drawing.Point(641, 164);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(381, 34);
            this.txtSdt.TabIndex = 54;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(63, 164);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(381, 34);
            this.txtTenKH.TabIndex = 53;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1292, 679);
            this.Controls.Add(this.grbTTKH);
            this.Controls.Add(this.grBTimKiem);
            this.Controls.Add(this.dgvKH);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.grBTimKiem.ResumeLayout(false);
            this.grBTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.GroupBox grBTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenKH;
    }
}