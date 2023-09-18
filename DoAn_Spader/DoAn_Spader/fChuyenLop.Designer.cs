namespace DoAn_Spader
{
    partial class fChuyenLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChuyenLop));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ddHocSinh = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXacNhan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddLopMoi = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.bunifuPanel1.Controls.Add(this.groupBox2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.groupBox4);
            this.bunifuPanel1.Controls.Add(this.btnThoat);
            this.bunifuPanel1.Controls.Add(this.btnXacNhan);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(500, 424);
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
            this.label1.Text = "Chuyển Học Sinh Vào Lớp Khác";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ddHocSinh);
            this.groupBox4.Location = new System.Drawing.Point(12, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên Học Sinh";
            // 
            // ddHocSinh
            // 
            this.ddHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.ddHocSinh.BackgroundColor = System.Drawing.Color.White;
            this.ddHocSinh.BorderColor = System.Drawing.Color.Silver;
            this.ddHocSinh.BorderRadius = 1;
            this.ddHocSinh.Color = System.Drawing.Color.Silver;
            this.ddHocSinh.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddHocSinh.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddHocSinh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddHocSinh.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddHocSinh.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddHocSinh.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddHocSinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddHocSinh.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddHocSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddHocSinh.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddHocSinh.FillDropDown = true;
            this.ddHocSinh.FillIndicator = false;
            this.ddHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddHocSinh.ForeColor = System.Drawing.Color.Black;
            this.ddHocSinh.FormattingEnabled = true;
            this.ddHocSinh.Icon = null;
            this.ddHocSinh.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddHocSinh.IndicatorColor = System.Drawing.Color.Gray;
            this.ddHocSinh.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddHocSinh.ItemBackColor = System.Drawing.Color.White;
            this.ddHocSinh.ItemBorderColor = System.Drawing.Color.White;
            this.ddHocSinh.ItemForeColor = System.Drawing.Color.Black;
            this.ddHocSinh.ItemHeight = 26;
            this.ddHocSinh.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddHocSinh.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddHocSinh.ItemTopMargin = 3;
            this.ddHocSinh.Location = new System.Drawing.Point(6, 37);
            this.ddHocSinh.Name = "ddHocSinh";
            this.ddHocSinh.Size = new System.Drawing.Size(464, 32);
            this.ddHocSinh.TabIndex = 2;
            this.ddHocSinh.Text = null;
            this.ddHocSinh.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddHocSinh.TextLeftMargin = 5;
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
            this.btnThoat.Location = new System.Drawing.Point(283, 352);
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
            this.btnXacNhan.Location = new System.Drawing.Point(62, 352);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddLopMoi);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên Lớp Mới";
            // 
            // ddLopMoi
            // 
            this.ddLopMoi.BackColor = System.Drawing.Color.Transparent;
            this.ddLopMoi.BackgroundColor = System.Drawing.Color.White;
            this.ddLopMoi.BorderColor = System.Drawing.Color.Silver;
            this.ddLopMoi.BorderRadius = 1;
            this.ddLopMoi.Color = System.Drawing.Color.Silver;
            this.ddLopMoi.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddLopMoi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddLopMoi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddLopMoi.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddLopMoi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddLopMoi.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddLopMoi.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddLopMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLopMoi.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddLopMoi.FillDropDown = true;
            this.ddLopMoi.FillIndicator = false;
            this.ddLopMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddLopMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddLopMoi.ForeColor = System.Drawing.Color.Black;
            this.ddLopMoi.FormattingEnabled = true;
            this.ddLopMoi.Icon = null;
            this.ddLopMoi.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddLopMoi.IndicatorColor = System.Drawing.Color.Gray;
            this.ddLopMoi.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddLopMoi.ItemBackColor = System.Drawing.Color.White;
            this.ddLopMoi.ItemBorderColor = System.Drawing.Color.White;
            this.ddLopMoi.ItemForeColor = System.Drawing.Color.Black;
            this.ddLopMoi.ItemHeight = 26;
            this.ddLopMoi.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddLopMoi.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddLopMoi.ItemTopMargin = 3;
            this.ddLopMoi.Location = new System.Drawing.Point(6, 37);
            this.ddLopMoi.Name = "ddLopMoi";
            this.ddLopMoi.Size = new System.Drawing.Size(464, 32);
            this.ddLopMoi.TabIndex = 2;
            this.ddLopMoi.Text = null;
            this.ddLopMoi.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddLopMoi.TextLeftMargin = 5;
            // 
            // fChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 424);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "fChuyenLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Học Sinh Vào Lớp Khác";
            this.Load += new System.EventHandler(this.fChuyenLop_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThoat;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.UI.WinForms.BunifuDropdown ddHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuDropdown ddLopMoi;
    }
}