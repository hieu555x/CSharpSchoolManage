﻿namespace DoAn_Spader
{
    partial class fThemPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemPhanCong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ddLop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXacNhan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddGiaoVien = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.groupBox4);
            this.bunifuPanel1.Controls.Add(this.btnThoat);
            this.bunifuPanel1.Controls.Add(this.btnXacNhan);
            this.bunifuPanel1.Controls.Add(this.groupBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(500, 481);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 100);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thêm Phân Công Giáo Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ddLop);
            this.groupBox4.Location = new System.Drawing.Point(12, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên Lớp";
            // 
            // ddLop
            // 
            this.ddLop.BackColor = System.Drawing.Color.Transparent;
            this.ddLop.BackgroundColor = System.Drawing.Color.White;
            this.ddLop.BorderColor = System.Drawing.Color.Silver;
            this.ddLop.BorderRadius = 1;
            this.ddLop.Color = System.Drawing.Color.Silver;
            this.ddLop.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddLop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddLop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddLop.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddLop.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddLop.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddLop.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLop.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddLop.FillDropDown = true;
            this.ddLop.FillIndicator = false;
            this.ddLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddLop.ForeColor = System.Drawing.Color.Black;
            this.ddLop.FormattingEnabled = true;
            this.ddLop.Icon = null;
            this.ddLop.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddLop.IndicatorColor = System.Drawing.Color.Gray;
            this.ddLop.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddLop.ItemBackColor = System.Drawing.Color.White;
            this.ddLop.ItemBorderColor = System.Drawing.Color.White;
            this.ddLop.ItemForeColor = System.Drawing.Color.Black;
            this.ddLop.ItemHeight = 26;
            this.ddLop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddLop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddLop.ItemTopMargin = 3;
            this.ddLop.Location = new System.Drawing.Point(6, 37);
            this.ddLop.Name = "ddLop";
            this.ddLop.Size = new System.Drawing.Size(464, 32);
            this.ddLop.TabIndex = 2;
            this.ddLop.Text = null;
            this.ddLop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddLop.TextLeftMargin = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.AllowAnimations = true;
            this.btnThoat.AllowMouseEffects = true;
            this.btnThoat.AllowToggling = false;
            this.btnThoat.AnimationSpeed = 200;
            this.btnThoat.AutoGenerateColors = false;
            this.btnThoat.AutoRoundBorders = false;
            this.btnThoat.AutoSizeLeftIcon = true;
            this.btnThoat.AutoSizeRightIcon = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.ButtonTextMarginLeft = 0;
            this.btnThoat.ColorContrastOnClick = 45;
            this.btnThoat.ColorContrastOnHover = 45;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnThoat.CustomizableEdges = borderEdges1;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThoat.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThoat.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThoat.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThoat.IconMarginLeft = 11;
            this.btnThoat.IconPadding = 10;
            this.btnThoat.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThoat.IconSize = 25;
            this.btnThoat.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.IdleBorderRadius = 1;
            this.btnThoat.IdleBorderThickness = 1;
            this.btnThoat.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.IdleIconLeftImage = null;
            this.btnThoat.IdleIconRightImage = null;
            this.btnThoat.IndicateFocus = false;
            this.btnThoat.Location = new System.Drawing.Point(283, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThoat.OnDisabledState.BorderRadius = 1;
            this.btnThoat.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnDisabledState.BorderThickness = 1;
            this.btnThoat.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnThoat.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnThoat.OnDisabledState.IconLeftImage = null;
            this.btnThoat.OnDisabledState.IconRightImage = null;
            this.btnThoat.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThoat.onHoverState.BorderRadius = 1;
            this.btnThoat.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.onHoverState.BorderThickness = 1;
            this.btnThoat.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThoat.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.onHoverState.IconLeftImage = null;
            this.btnThoat.onHoverState.IconRightImage = null;
            this.btnThoat.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnIdleState.BorderRadius = 1;
            this.btnThoat.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnIdleState.BorderThickness = 1;
            this.btnThoat.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.OnIdleState.IconLeftImage = null;
            this.btnThoat.OnIdleState.IconRightImage = null;
            this.btnThoat.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThoat.OnPressedState.BorderRadius = 1;
            this.btnThoat.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThoat.OnPressedState.BorderThickness = 1;
            this.btnThoat.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThoat.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.OnPressedState.IconLeftImage = null;
            this.btnThoat.OnPressedState.IconRightImage = null;
            this.btnThoat.Size = new System.Drawing.Size(150, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.TextMarginLeft = 0;
            this.btnThoat.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThoat.UseDefaultRadiusAndThickness = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AllowAnimations = true;
            this.btnXacNhan.AllowMouseEffects = true;
            this.btnXacNhan.AllowToggling = false;
            this.btnXacNhan.AnimationSpeed = 200;
            this.btnXacNhan.AutoGenerateColors = false;
            this.btnXacNhan.AutoRoundBorders = false;
            this.btnXacNhan.AutoSizeLeftIcon = true;
            this.btnXacNhan.AutoSizeRightIcon = true;
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.BackgroundImage")));
            this.btnXacNhan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.ButtonText = "Xác Nhận";
            this.btnXacNhan.ButtonTextMarginLeft = 0;
            this.btnXacNhan.ColorContrastOnClick = 45;
            this.btnXacNhan.ColorContrastOnHover = 45;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnXacNhan.CustomizableEdges = borderEdges2;
            this.btnXacNhan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXacNhan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXacNhan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXacNhan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXacNhan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXacNhan.IconMarginLeft = 11;
            this.btnXacNhan.IconPadding = 10;
            this.btnXacNhan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXacNhan.IconSize = 25;
            this.btnXacNhan.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.IdleBorderRadius = 1;
            this.btnXacNhan.IdleBorderThickness = 1;
            this.btnXacNhan.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.IdleIconLeftImage = null;
            this.btnXacNhan.IdleIconRightImage = null;
            this.btnXacNhan.IndicateFocus = false;
            this.btnXacNhan.Location = new System.Drawing.Point(62, 384);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXacNhan.OnDisabledState.BorderRadius = 1;
            this.btnXacNhan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnDisabledState.BorderThickness = 1;
            this.btnXacNhan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXacNhan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXacNhan.OnDisabledState.IconLeftImage = null;
            this.btnXacNhan.OnDisabledState.IconRightImage = null;
            this.btnXacNhan.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXacNhan.onHoverState.BorderRadius = 1;
            this.btnXacNhan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.onHoverState.BorderThickness = 1;
            this.btnXacNhan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXacNhan.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.onHoverState.IconLeftImage = null;
            this.btnXacNhan.onHoverState.IconRightImage = null;
            this.btnXacNhan.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnIdleState.BorderRadius = 1;
            this.btnXacNhan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnIdleState.BorderThickness = 1;
            this.btnXacNhan.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXacNhan.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.OnIdleState.IconLeftImage = null;
            this.btnXacNhan.OnIdleState.IconRightImage = null;
            this.btnXacNhan.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXacNhan.OnPressedState.BorderRadius = 1;
            this.btnXacNhan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXacNhan.OnPressedState.BorderThickness = 1;
            this.btnXacNhan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXacNhan.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.OnPressedState.IconLeftImage = null;
            this.btnXacNhan.OnPressedState.IconRightImage = null;
            this.btnXacNhan.Size = new System.Drawing.Size(150, 39);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXacNhan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXacNhan.TextMarginLeft = 0;
            this.btnXacNhan.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXacNhan.UseDefaultRadiusAndThickness = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên Giáo Viên";
            // 
            // ddGiaoVien
            // 
            this.ddGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.ddGiaoVien.BackgroundColor = System.Drawing.Color.White;
            this.ddGiaoVien.BorderColor = System.Drawing.Color.Silver;
            this.ddGiaoVien.BorderRadius = 1;
            this.ddGiaoVien.Color = System.Drawing.Color.Silver;
            this.ddGiaoVien.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddGiaoVien.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddGiaoVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddGiaoVien.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddGiaoVien.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddGiaoVien.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddGiaoVien.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddGiaoVien.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddGiaoVien.FillDropDown = true;
            this.ddGiaoVien.FillIndicator = false;
            this.ddGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.ddGiaoVien.FormattingEnabled = true;
            this.ddGiaoVien.Icon = null;
            this.ddGiaoVien.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddGiaoVien.IndicatorColor = System.Drawing.Color.Gray;
            this.ddGiaoVien.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddGiaoVien.ItemBackColor = System.Drawing.Color.White;
            this.ddGiaoVien.ItemBorderColor = System.Drawing.Color.White;
            this.ddGiaoVien.ItemForeColor = System.Drawing.Color.Black;
            this.ddGiaoVien.ItemHeight = 26;
            this.ddGiaoVien.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddGiaoVien.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddGiaoVien.ItemTopMargin = 3;
            this.ddGiaoVien.Location = new System.Drawing.Point(6, 37);
            this.ddGiaoVien.Name = "ddGiaoVien";
            this.ddGiaoVien.Size = new System.Drawing.Size(464, 32);
            this.ddGiaoVien.TabIndex = 2;
            this.ddGiaoVien.Text = null;
            this.ddGiaoVien.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddGiaoVien.TextLeftMargin = 5;
            // 
            // fThemPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 481);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "fThemPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phân Công Giáo Viên";
            this.Load += new System.EventHandler(this.fThemPhanCong_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThoat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDropdown ddGiaoVien;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.UI.WinForms.BunifuDropdown ddLop;
        private System.Windows.Forms.Label label1;
    }
}