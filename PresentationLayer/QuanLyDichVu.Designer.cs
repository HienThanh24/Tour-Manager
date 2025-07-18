﻿using System.Windows.Forms;

namespace PresentationLayer
{
    partial class QuanLyDichVu
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
            this.pnlDiemKhoiHanh = new System.Windows.Forms.Panel();
            this.lblMaDiemKhoiHanh = new System.Windows.Forms.Label();
            this.txtMaDiemKhoiHanh = new System.Windows.Forms.TextBox();
            this.lblTenDiemKhoiHanh = new System.Windows.Forms.Label();
            this.txtTenDiemKhoiHanh = new System.Windows.Forms.TextBox();
            this.dgvDiemKhoiHanh = new System.Windows.Forms.DataGridView();
            this.pnlDiemKhoiHanhHeader = new System.Windows.Forms.Panel();
            this.lblDiemKhoiHanh = new System.Windows.Forms.Label();
            this.pnlDiemKhoiHanhButtons = new System.Windows.Forms.Panel();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnUpdateKH = new System.Windows.Forms.Button();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.btnRefreshKH = new System.Windows.Forms.Button();
            this.pnlDiemDuLich = new System.Windows.Forms.Panel();
            this.dgvDiemDuLich = new System.Windows.Forms.DataGridView();
            this.lblMaDiemDuLich = new System.Windows.Forms.Label();
            this.txtMaDiemDuLich = new System.Windows.Forms.TextBox();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.txtTenDiemDen = new System.Windows.Forms.TextBox();
            this.lblLoaiTourDL = new System.Windows.Forms.Label();
            this.cmbLoaiTourDL = new System.Windows.Forms.ComboBox();
            this.pnlDiemDuLichHeader = new System.Windows.Forms.Panel();
            this.lblDiemDuLich = new System.Windows.Forms.Label();
            this.pnlDiemDuLichButtons = new System.Windows.Forms.Panel();
            this.btnThemDL = new System.Windows.Forms.Button();
            this.btnSuaDL = new System.Windows.Forms.Button();
            this.btnXoaDL = new System.Windows.Forms.Button();
            this.btnRefreshDL = new System.Windows.Forms.Button();
            this.pnlPhuongTien = new System.Windows.Forms.Panel();
            this.lblMaPhuongTien = new System.Windows.Forms.Label();
            this.txtMaPhuongTien = new System.Windows.Forms.TextBox();
            this.lblTenPhuongTien = new System.Windows.Forms.Label();
            this.txtTenPhuongTien = new System.Windows.Forms.TextBox();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.pnlPhuongTienHeader = new System.Windows.Forms.Panel();
            this.lblPhuongTien = new System.Windows.Forms.Label();
            this.pnlPhuongTienButtons = new System.Windows.Forms.Panel();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.btnSuaPT = new System.Windows.Forms.Button();
            this.btnXoaPT = new System.Windows.Forms.Button();
            this.btnRefreshPT = new System.Windows.Forms.Button();
            this.pnlDiemKhoiHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemKhoiHanh)).BeginInit();
            this.pnlDiemKhoiHanhHeader.SuspendLayout();
            this.pnlDiemKhoiHanhButtons.SuspendLayout();
            this.pnlDiemDuLich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDuLich)).BeginInit();
            this.pnlDiemDuLichHeader.SuspendLayout();
            this.pnlDiemDuLichButtons.SuspendLayout();
            this.pnlPhuongTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.pnlPhuongTienHeader.SuspendLayout();
            this.pnlPhuongTienButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDiemKhoiHanh
            // 
            this.pnlDiemKhoiHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiemKhoiHanh.Controls.Add(this.lblMaDiemKhoiHanh);
            this.pnlDiemKhoiHanh.Controls.Add(this.txtMaDiemKhoiHanh);
            this.pnlDiemKhoiHanh.Controls.Add(this.lblTenDiemKhoiHanh);
            this.pnlDiemKhoiHanh.Controls.Add(this.txtTenDiemKhoiHanh);
            this.pnlDiemKhoiHanh.Controls.Add(this.dgvDiemKhoiHanh);
            this.pnlDiemKhoiHanh.Controls.Add(this.pnlDiemKhoiHanhHeader);
            this.pnlDiemKhoiHanh.Controls.Add(this.pnlDiemKhoiHanhButtons);
            this.pnlDiemKhoiHanh.Location = new System.Drawing.Point(31, 36);
            this.pnlDiemKhoiHanh.Name = "pnlDiemKhoiHanh";
            this.pnlDiemKhoiHanh.Size = new System.Drawing.Size(1520, 216);
            this.pnlDiemKhoiHanh.TabIndex = 0;
            // 
            // lblMaDiemKhoiHanh
            // 
            this.lblMaDiemKhoiHanh.AutoSize = true;
            this.lblMaDiemKhoiHanh.Location = new System.Drawing.Point(15, 55);
            this.lblMaDiemKhoiHanh.Name = "lblMaDiemKhoiHanh";
            this.lblMaDiemKhoiHanh.Size = new System.Drawing.Size(119, 16);
            this.lblMaDiemKhoiHanh.TabIndex = 10;
            this.lblMaDiemKhoiHanh.Text = "Mã điểm khởi hành";
            // 
            // txtMaDiemKhoiHanh
            // 
            this.txtMaDiemKhoiHanh.Location = new System.Drawing.Point(13, 74);
            this.txtMaDiemKhoiHanh.Name = "txtMaDiemKhoiHanh";
            this.txtMaDiemKhoiHanh.ReadOnly = true;
            this.txtMaDiemKhoiHanh.Size = new System.Drawing.Size(259, 22);
            this.txtMaDiemKhoiHanh.TabIndex = 11;
            // 
            // lblTenDiemKhoiHanh
            // 
            this.lblTenDiemKhoiHanh.AutoSize = true;
            this.lblTenDiemKhoiHanh.Location = new System.Drawing.Point(10, 102);
            this.lblTenDiemKhoiHanh.Name = "lblTenDiemKhoiHanh";
            this.lblTenDiemKhoiHanh.Size = new System.Drawing.Size(124, 16);
            this.lblTenDiemKhoiHanh.TabIndex = 12;
            this.lblTenDiemKhoiHanh.Text = "Tên điểm khởi hành";
            // 
            // txtTenDiemKhoiHanh
            // 
            this.txtTenDiemKhoiHanh.Location = new System.Drawing.Point(13, 118);
            this.txtTenDiemKhoiHanh.Name = "txtTenDiemKhoiHanh";
            this.txtTenDiemKhoiHanh.Size = new System.Drawing.Size(259, 22);
            this.txtTenDiemKhoiHanh.TabIndex = 13;
            // 
            // dgvDiemKhoiHanh
            // 
            this.dgvDiemKhoiHanh.AllowUserToAddRows = false;
            this.dgvDiemKhoiHanh.AllowUserToDeleteRows = false;
            this.dgvDiemKhoiHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemKhoiHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemKhoiHanh.Location = new System.Drawing.Point(302, 37);
            this.dgvDiemKhoiHanh.MultiSelect = false;
            this.dgvDiemKhoiHanh.Name = "dgvDiemKhoiHanh";
            this.dgvDiemKhoiHanh.ReadOnly = true;
            this.dgvDiemKhoiHanh.RowHeadersWidth = 51;
            this.dgvDiemKhoiHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiemKhoiHanh.Size = new System.Drawing.Size(1216, 178);
            this.dgvDiemKhoiHanh.TabIndex = 3;
            this.dgvDiemKhoiHanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemKhoiHanh_CellContentClick);
            // 
            // pnlDiemKhoiHanhHeader
            // 
            this.pnlDiemKhoiHanhHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlDiemKhoiHanhHeader.Controls.Add(this.lblDiemKhoiHanh);
            this.pnlDiemKhoiHanhHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiemKhoiHanhHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDiemKhoiHanhHeader.Name = "pnlDiemKhoiHanhHeader";
            this.pnlDiemKhoiHanhHeader.Size = new System.Drawing.Size(1518, 30);
            this.pnlDiemKhoiHanhHeader.TabIndex = 0;
            // 
            // lblDiemKhoiHanh
            // 
            this.lblDiemKhoiHanh.AutoSize = true;
            this.lblDiemKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemKhoiHanh.ForeColor = System.Drawing.Color.White;
            this.lblDiemKhoiHanh.Location = new System.Drawing.Point(5, 5);
            this.lblDiemKhoiHanh.Name = "lblDiemKhoiHanh";
            this.lblDiemKhoiHanh.Size = new System.Drawing.Size(190, 25);
            this.lblDiemKhoiHanh.TabIndex = 0;
            this.lblDiemKhoiHanh.Text = "ĐIỂM KHỞI HÀNH";
            // 
            // pnlDiemKhoiHanhButtons
            // 
            this.pnlDiemKhoiHanhButtons.Controls.Add(this.btnAddKH);
            this.pnlDiemKhoiHanhButtons.Controls.Add(this.btnUpdateKH);
            this.pnlDiemKhoiHanhButtons.Controls.Add(this.btnDeleteKH);
            this.pnlDiemKhoiHanhButtons.Controls.Add(this.btnRefreshKH);
            this.pnlDiemKhoiHanhButtons.Location = new System.Drawing.Point(3, 174);
            this.pnlDiemKhoiHanhButtons.Name = "pnlDiemKhoiHanhButtons";
            this.pnlDiemKhoiHanhButtons.Size = new System.Drawing.Size(270, 32);
            this.pnlDiemKhoiHanhButtons.TabIndex = 2;
            // 
            // btnAddKH
            // 
            this.btnAddKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddKH.ForeColor = System.Drawing.Color.White;
            this.btnAddKH.Location = new System.Drawing.Point(5, 6);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(60, 23);
            this.btnAddKH.TabIndex = 4;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnUpdateKH
            // 
            this.btnUpdateKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateKH.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKH.Location = new System.Drawing.Point(71, 6);
            this.btnUpdateKH.Name = "btnUpdateKH";
            this.btnUpdateKH.Size = new System.Drawing.Size(60, 23);
            this.btnUpdateKH.TabIndex = 5;
            this.btnUpdateKH.Text = "Sửa";
            this.btnUpdateKH.UseVisualStyleBackColor = false;
            this.btnUpdateKH.Click += new System.EventHandler(this.btnUpdateKH_Click);
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteKH.ForeColor = System.Drawing.Color.White;
            this.btnDeleteKH.Location = new System.Drawing.Point(137, 6);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Size = new System.Drawing.Size(60, 23);
            this.btnDeleteKH.TabIndex = 6;
            this.btnDeleteKH.Text = "Xóa";
            this.btnDeleteKH.UseVisualStyleBackColor = false;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // btnRefreshKH
            // 
            this.btnRefreshKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRefreshKH.ForeColor = System.Drawing.Color.White;
            this.btnRefreshKH.Location = new System.Drawing.Point(203, 6);
            this.btnRefreshKH.Name = "btnRefreshKH";
            this.btnRefreshKH.Size = new System.Drawing.Size(60, 23);
            this.btnRefreshKH.TabIndex = 7;
            this.btnRefreshKH.Text = "⟳";
            this.btnRefreshKH.UseVisualStyleBackColor = false;
            this.btnRefreshKH.Click += new System.EventHandler(this.btnRefreshKH_Click);
            // 
            // pnlDiemDuLich
            // 
            this.pnlDiemDuLich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiemDuLich.Controls.Add(this.dgvDiemDuLich);
            this.pnlDiemDuLich.Controls.Add(this.lblMaDiemDuLich);
            this.pnlDiemDuLich.Controls.Add(this.txtMaDiemDuLich);
            this.pnlDiemDuLich.Controls.Add(this.lblDiemDen);
            this.pnlDiemDuLich.Controls.Add(this.txtTenDiemDen);
            this.pnlDiemDuLich.Controls.Add(this.lblLoaiTourDL);
            this.pnlDiemDuLich.Controls.Add(this.cmbLoaiTourDL);
            this.pnlDiemDuLich.Controls.Add(this.pnlDiemDuLichHeader);
            this.pnlDiemDuLich.Controls.Add(this.pnlDiemDuLichButtons);
            this.pnlDiemDuLich.Location = new System.Drawing.Point(31, 278);
            this.pnlDiemDuLich.Name = "pnlDiemDuLich";
            this.pnlDiemDuLich.Size = new System.Drawing.Size(1520, 206);
            this.pnlDiemDuLich.TabIndex = 1;
            // 
            // dgvDiemDuLich
            // 
            this.dgvDiemDuLich.AllowUserToAddRows = false;
            this.dgvDiemDuLich.AllowUserToDeleteRows = false;
            this.dgvDiemDuLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDuLich.Location = new System.Drawing.Point(301, 36);
            this.dgvDiemDuLich.MultiSelect = false;
            this.dgvDiemDuLich.Name = "dgvDiemDuLich";
            this.dgvDiemDuLich.ReadOnly = true;
            this.dgvDiemDuLich.RowHeadersWidth = 51;
            this.dgvDiemDuLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiemDuLich.Size = new System.Drawing.Size(1216, 169);
            this.dgvDiemDuLich.TabIndex = 12;
            this.dgvDiemDuLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemDuLich_CellContentClick);
            // 
            // lblMaDiemDuLich
            // 
            this.lblMaDiemDuLich.AutoSize = true;
            this.lblMaDiemDuLich.Location = new System.Drawing.Point(8, 36);
            this.lblMaDiemDuLich.Name = "lblMaDiemDuLich";
            this.lblMaDiemDuLich.Size = new System.Drawing.Size(100, 16);
            this.lblMaDiemDuLich.TabIndex = 6;
            this.lblMaDiemDuLich.Text = "Mã điểm du lịch";
            // 
            // txtMaDiemDuLich
            // 
            this.txtMaDiemDuLich.Location = new System.Drawing.Point(11, 52);
            this.txtMaDiemDuLich.Name = "txtMaDiemDuLich";
            this.txtMaDiemDuLich.ReadOnly = true;
            this.txtMaDiemDuLich.Size = new System.Drawing.Size(254, 22);
            this.txtMaDiemDuLich.TabIndex = 7;
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Location = new System.Drawing.Point(8, 80);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(64, 16);
            this.lblDiemDen.TabIndex = 8;
            this.lblDiemDen.Text = "Điểm đến";
            // 
            // txtTenDiemDen
            // 
            this.txtTenDiemDen.Location = new System.Drawing.Point(11, 96);
            this.txtTenDiemDen.Name = "txtTenDiemDen";
            this.txtTenDiemDen.Size = new System.Drawing.Size(254, 22);
            this.txtTenDiemDen.TabIndex = 9;
            // 
            // lblLoaiTourDL
            // 
            this.lblLoaiTourDL.AutoSize = true;
            this.lblLoaiTourDL.Location = new System.Drawing.Point(8, 124);
            this.lblLoaiTourDL.Name = "lblLoaiTourDL";
            this.lblLoaiTourDL.Size = new System.Drawing.Size(64, 16);
            this.lblLoaiTourDL.TabIndex = 10;
            this.lblLoaiTourDL.Text = "Loại Tour";
            // 
            // cmbLoaiTourDL
            // 
            this.cmbLoaiTourDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiTourDL.FormattingEnabled = true;
            this.cmbLoaiTourDL.Location = new System.Drawing.Point(11, 140);
            this.cmbLoaiTourDL.Name = "cmbLoaiTourDL";
            this.cmbLoaiTourDL.Size = new System.Drawing.Size(254, 24);
            this.cmbLoaiTourDL.TabIndex = 11;
            // 
            // pnlDiemDuLichHeader
            // 
            this.pnlDiemDuLichHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlDiemDuLichHeader.Controls.Add(this.lblDiemDuLich);
            this.pnlDiemDuLichHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiemDuLichHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDiemDuLichHeader.Name = "pnlDiemDuLichHeader";
            this.pnlDiemDuLichHeader.Size = new System.Drawing.Size(1518, 30);
            this.pnlDiemDuLichHeader.TabIndex = 0;
            // 
            // lblDiemDuLich
            // 
            this.lblDiemDuLich.AutoSize = true;
            this.lblDiemDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDuLich.ForeColor = System.Drawing.Color.White;
            this.lblDiemDuLich.Location = new System.Drawing.Point(5, 5);
            this.lblDiemDuLich.Name = "lblDiemDuLich";
            this.lblDiemDuLich.Size = new System.Drawing.Size(156, 25);
            this.lblDiemDuLich.TabIndex = 0;
            this.lblDiemDuLich.Text = "ĐIỂM DU LỊCH";
            // 
            // pnlDiemDuLichButtons
            // 
            this.pnlDiemDuLichButtons.Controls.Add(this.btnThemDL);
            this.pnlDiemDuLichButtons.Controls.Add(this.btnSuaDL);
            this.pnlDiemDuLichButtons.Controls.Add(this.btnXoaDL);
            this.pnlDiemDuLichButtons.Controls.Add(this.btnRefreshDL);
            this.pnlDiemDuLichButtons.Location = new System.Drawing.Point(3, 170);
            this.pnlDiemDuLichButtons.Name = "pnlDiemDuLichButtons";
            this.pnlDiemDuLichButtons.Size = new System.Drawing.Size(270, 32);
            this.pnlDiemDuLichButtons.TabIndex = 2;
            // 
            // btnThemDL
            // 
            this.btnThemDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemDL.ForeColor = System.Drawing.Color.White;
            this.btnThemDL.Location = new System.Drawing.Point(8, 6);
            this.btnThemDL.Name = "btnThemDL";
            this.btnThemDL.Size = new System.Drawing.Size(60, 23);
            this.btnThemDL.TabIndex = 0;
            this.btnThemDL.Text = "Thêm";
            this.btnThemDL.UseVisualStyleBackColor = false;
            this.btnThemDL.Click += new System.EventHandler(this.btnThemDL_Click);
            // 
            // btnSuaDL
            // 
            this.btnSuaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSuaDL.ForeColor = System.Drawing.Color.White;
            this.btnSuaDL.Location = new System.Drawing.Point(72, 6);
            this.btnSuaDL.Name = "btnSuaDL";
            this.btnSuaDL.Size = new System.Drawing.Size(60, 23);
            this.btnSuaDL.TabIndex = 1;
            this.btnSuaDL.Text = "Sửa";
            this.btnSuaDL.UseVisualStyleBackColor = false;
            this.btnSuaDL.Click += new System.EventHandler(this.btnSuaDL_Click);
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoaDL.ForeColor = System.Drawing.Color.White;
            this.btnXoaDL.Location = new System.Drawing.Point(133, 6);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.Size = new System.Drawing.Size(60, 23);
            this.btnXoaDL.TabIndex = 2;
            this.btnXoaDL.Text = "Xóa";
            this.btnXoaDL.UseVisualStyleBackColor = false;
            this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // btnRefreshDL
            // 
            this.btnRefreshDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRefreshDL.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDL.Location = new System.Drawing.Point(202, 6);
            this.btnRefreshDL.Name = "btnRefreshDL";
            this.btnRefreshDL.Size = new System.Drawing.Size(60, 23);
            this.btnRefreshDL.TabIndex = 3;
            this.btnRefreshDL.Text = "⟳";
            this.btnRefreshDL.UseVisualStyleBackColor = false;
            this.btnRefreshDL.Click += new System.EventHandler(this.btnRefreshDL_Click);
            // 
            // pnlPhuongTien
            // 
            this.pnlPhuongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhuongTien.Controls.Add(this.lblMaPhuongTien);
            this.pnlPhuongTien.Controls.Add(this.txtMaPhuongTien);
            this.pnlPhuongTien.Controls.Add(this.lblTenPhuongTien);
            this.pnlPhuongTien.Controls.Add(this.txtTenPhuongTien);
            this.pnlPhuongTien.Controls.Add(this.dgvPhuongTien);
            this.pnlPhuongTien.Controls.Add(this.pnlPhuongTienHeader);
            this.pnlPhuongTien.Controls.Add(this.pnlPhuongTienButtons);
            this.pnlPhuongTien.Location = new System.Drawing.Point(31, 512);
            this.pnlPhuongTien.Name = "pnlPhuongTien";
            this.pnlPhuongTien.Size = new System.Drawing.Size(1519, 206);
            this.pnlPhuongTien.TabIndex = 2;
            // 
            // lblMaPhuongTien
            // 
            this.lblMaPhuongTien.AutoSize = true;
            this.lblMaPhuongTien.Location = new System.Drawing.Point(10, 54);
            this.lblMaPhuongTien.Name = "lblMaPhuongTien";
            this.lblMaPhuongTien.Size = new System.Drawing.Size(98, 16);
            this.lblMaPhuongTien.TabIndex = 8;
            this.lblMaPhuongTien.Text = "Mã phương tiện";
            // 
            // txtMaPhuongTien
            // 
            this.txtMaPhuongTien.Location = new System.Drawing.Point(13, 70);
            this.txtMaPhuongTien.Name = "txtMaPhuongTien";
            this.txtMaPhuongTien.ReadOnly = true;
            this.txtMaPhuongTien.Size = new System.Drawing.Size(261, 22);
            this.txtMaPhuongTien.TabIndex = 9;
            // 
            // lblTenPhuongTien
            // 
            this.lblTenPhuongTien.AutoSize = true;
            this.lblTenPhuongTien.Location = new System.Drawing.Point(10, 98);
            this.lblTenPhuongTien.Name = "lblTenPhuongTien";
            this.lblTenPhuongTien.Size = new System.Drawing.Size(103, 16);
            this.lblTenPhuongTien.TabIndex = 10;
            this.lblTenPhuongTien.Text = "Tên phương tiện";
            // 
            // txtTenPhuongTien
            // 
            this.txtTenPhuongTien.Location = new System.Drawing.Point(13, 114);
            this.txtTenPhuongTien.Name = "txtTenPhuongTien";
            this.txtTenPhuongTien.Size = new System.Drawing.Size(259, 22);
            this.txtTenPhuongTien.TabIndex = 11;
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.AllowUserToAddRows = false;
            this.dgvPhuongTien.AllowUserToDeleteRows = false;
            this.dgvPhuongTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Location = new System.Drawing.Point(303, 36);
            this.dgvPhuongTien.MultiSelect = false;
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.ReadOnly = true;
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuongTien.Size = new System.Drawing.Size(1211, 173);
            this.dgvPhuongTien.TabIndex = 3;
            this.dgvPhuongTien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellContentClick);
            // 
            // pnlPhuongTienHeader
            // 
            this.pnlPhuongTienHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlPhuongTienHeader.Controls.Add(this.lblPhuongTien);
            this.pnlPhuongTienHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhuongTienHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlPhuongTienHeader.Name = "pnlPhuongTienHeader";
            this.pnlPhuongTienHeader.Size = new System.Drawing.Size(1517, 30);
            this.pnlPhuongTienHeader.TabIndex = 0;
            // 
            // lblPhuongTien
            // 
            this.lblPhuongTien.AutoSize = true;
            this.lblPhuongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuongTien.ForeColor = System.Drawing.Color.White;
            this.lblPhuongTien.Location = new System.Drawing.Point(5, 5);
            this.lblPhuongTien.Name = "lblPhuongTien";
            this.lblPhuongTien.Size = new System.Drawing.Size(159, 25);
            this.lblPhuongTien.TabIndex = 0;
            this.lblPhuongTien.Text = "PHƯƠNG TIỆN";
            // 
            // pnlPhuongTienButtons
            // 
            this.pnlPhuongTienButtons.Controls.Add(this.btnThemPT);
            this.pnlPhuongTienButtons.Controls.Add(this.btnSuaPT);
            this.pnlPhuongTienButtons.Controls.Add(this.btnXoaPT);
            this.pnlPhuongTienButtons.Controls.Add(this.btnRefreshPT);
            this.pnlPhuongTienButtons.Location = new System.Drawing.Point(6, 153);
            this.pnlPhuongTienButtons.Name = "pnlPhuongTienButtons";
            this.pnlPhuongTienButtons.Size = new System.Drawing.Size(270, 32);
            this.pnlPhuongTienButtons.TabIndex = 2;
            // 
            // btnThemPT
            // 
            this.btnThemPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThemPT.ForeColor = System.Drawing.Color.White;
            this.btnThemPT.Location = new System.Drawing.Point(6, 3);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(60, 23);
            this.btnThemPT.TabIndex = 0;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.UseVisualStyleBackColor = false;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // btnSuaPT
            // 
            this.btnSuaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSuaPT.ForeColor = System.Drawing.Color.White;
            this.btnSuaPT.Location = new System.Drawing.Point(69, 3);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(60, 23);
            this.btnSuaPT.TabIndex = 1;
            this.btnSuaPT.Text = "Sửa";
            this.btnSuaPT.UseVisualStyleBackColor = false;
            this.btnSuaPT.Click += new System.EventHandler(this.btnSuaPT_Click);
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoaPT.ForeColor = System.Drawing.Color.White;
            this.btnXoaPT.Location = new System.Drawing.Point(133, 3);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(60, 23);
            this.btnXoaPT.TabIndex = 2;
            this.btnXoaPT.Text = "Xóa";
            this.btnXoaPT.UseVisualStyleBackColor = false;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // btnRefreshPT
            // 
            this.btnRefreshPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefreshPT.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPT.Location = new System.Drawing.Point(199, 3);
            this.btnRefreshPT.Name = "btnRefreshPT";
            this.btnRefreshPT.Size = new System.Drawing.Size(60, 23);
            this.btnRefreshPT.TabIndex = 3;
            this.btnRefreshPT.Text = "⟳";
            this.btnRefreshPT.UseVisualStyleBackColor = false;
            this.btnRefreshPT.Click += new System.EventHandler(this.btnRefreshPT_Click);
            // 
            // QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1600, 747);
            this.Controls.Add(this.pnlDiemKhoiHanh);
            this.Controls.Add(this.pnlDiemDuLich);
            this.Controls.Add(this.pnlPhuongTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDichVu";
            this.Text = "Quản lý Tour";
            this.Load += new System.EventHandler(this.QuanLyDichVu_Load);
            this.pnlDiemKhoiHanh.ResumeLayout(false);
            this.pnlDiemKhoiHanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemKhoiHanh)).EndInit();
            this.pnlDiemKhoiHanhHeader.ResumeLayout(false);
            this.pnlDiemKhoiHanhHeader.PerformLayout();
            this.pnlDiemKhoiHanhButtons.ResumeLayout(false);
            this.pnlDiemDuLich.ResumeLayout(false);
            this.pnlDiemDuLich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDuLich)).EndInit();
            this.pnlDiemDuLichHeader.ResumeLayout(false);
            this.pnlDiemDuLichHeader.PerformLayout();
            this.pnlDiemDuLichButtons.ResumeLayout(false);
            this.pnlPhuongTien.ResumeLayout(false);
            this.pnlPhuongTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.pnlPhuongTienHeader.ResumeLayout(false);
            this.pnlPhuongTienHeader.PerformLayout();
            this.pnlPhuongTienButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiemKhoiHanh;
        private System.Windows.Forms.Panel pnlDiemKhoiHanhHeader;
        private System.Windows.Forms.Label lblDiemKhoiHanh;
        private System.Windows.Forms.Panel pnlDiemKhoiHanhButtons;
        private System.Windows.Forms.DataGridView dgvDiemKhoiHanh;

        private System.Windows.Forms.Panel pnlDiemDuLich;
        private System.Windows.Forms.Panel pnlDiemDuLichHeader;
        private System.Windows.Forms.Label lblDiemDuLich;
        private System.Windows.Forms.Panel pnlDiemDuLichButtons;
        private System.Windows.Forms.Button btnThemDL;
        private System.Windows.Forms.Button btnSuaDL;
        private System.Windows.Forms.Button btnXoaDL;
        private System.Windows.Forms.Button btnRefreshDL;

        private System.Windows.Forms.Panel pnlPhuongTien;
        private System.Windows.Forms.Panel pnlPhuongTienHeader;
        private System.Windows.Forms.Label lblPhuongTien;
        private System.Windows.Forms.Panel pnlPhuongTienButtons;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Button btnSuaPT;
        private System.Windows.Forms.Button btnXoaPT;
        private System.Windows.Forms.Button btnRefreshPT;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.Label lblMaDiemDuLich;
        private System.Windows.Forms.TextBox txtMaDiemDuLich;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.TextBox txtTenDiemDen;
        private System.Windows.Forms.Label lblLoaiTourDL;
        private System.Windows.Forms.ComboBox cmbLoaiTourDL;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnUpdateKH;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnRefreshKH;
        private Label lblMaDiemKhoiHanh;
        private TextBox txtMaDiemKhoiHanh;
        private Label lblTenDiemKhoiHanh;
        private TextBox txtTenDiemKhoiHanh;
        private DataGridView dgvDiemDuLich;
        private Label lblMaPhuongTien;
        private TextBox txtMaPhuongTien;
        private Label lblTenPhuongTien;
        private TextBox txtTenPhuongTien;
    }
}