namespace PresentationLayer.Views
{
    partial class DashboardView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            this.RIMSBasePalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.projectMgtButton = new FontAwesome.Sharp.IconButton();
            this.documentsButton = new FontAwesome.Sharp.IconButton();
            this.dashboardButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.expandMenuButton = new FontAwesome.Sharp.IconButton();
            this.userPictureBox = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.collapseMenuButton = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.actionButtonPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rjCircularPictureBox2 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.currentModuleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RIMSBasePalette
            // 
            this.RIMSBasePalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.RIMSBasePalette.ButtonSpecs.FormClose.Image = global::PresentationLayer.Properties.Resources.mc_red;
            this.RIMSBasePalette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::PresentationLayer.Properties.Resources.mc_red;
            this.RIMSBasePalette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::PresentationLayer.Properties.Resources.sign_error_icon;
            this.RIMSBasePalette.ButtonSpecs.FormMax.Image = global::PresentationLayer.Properties.Resources.mc_yellw;
            this.RIMSBasePalette.ButtonSpecs.FormMin.Image = global::PresentationLayer.Properties.Resources.mc_green;
            this.RIMSBasePalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.RIMSBasePalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.RIMSBasePalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RIMSBasePalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.RIMSBasePalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.RIMSBasePalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.RIMSBasePalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.RIMSBasePalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.RIMSBasePalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.iconButton6);
            this.menuPanel.Controls.Add(this.iconButton5);
            this.menuPanel.Controls.Add(this.iconButton4);
            this.menuPanel.Controls.Add(this.projectMgtButton);
            this.menuPanel.Controls.Add(this.documentsButton);
            this.menuPanel.Controls.Add(this.dashboardButton);
            this.menuPanel.Controls.Add(this.panel3);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(225, 461);
            this.menuPanel.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Transparent;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.Black;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 429);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(225, 32);
            this.iconButton6.TabIndex = 6;
            this.iconButton6.Tag = "Logout";
            this.iconButton6.Text = "   Logout";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Black;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 210);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(225, 32);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Tag = "User Managment";
            this.iconButton5.Text = "   User Management";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 178);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(225, 32);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Tag = "Reports";
            this.iconButton4.Text = "   Reports";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // projectMgtButton
            // 
            this.projectMgtButton.BackColor = System.Drawing.Color.Transparent;
            this.projectMgtButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectMgtButton.FlatAppearance.BorderSize = 0;
            this.projectMgtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectMgtButton.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectMgtButton.ForeColor = System.Drawing.Color.Black;
            this.projectMgtButton.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.projectMgtButton.IconColor = System.Drawing.Color.Black;
            this.projectMgtButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.projectMgtButton.IconSize = 30;
            this.projectMgtButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectMgtButton.Location = new System.Drawing.Point(0, 146);
            this.projectMgtButton.Name = "projectMgtButton";
            this.projectMgtButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.projectMgtButton.Size = new System.Drawing.Size(225, 32);
            this.projectMgtButton.TabIndex = 3;
            this.projectMgtButton.Tag = "Project Managemeht";
            this.projectMgtButton.Text = "   Project Management";
            this.projectMgtButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectMgtButton.UseVisualStyleBackColor = false;
            this.projectMgtButton.Click += new System.EventHandler(this.projectMgtButton_Click);
            // 
            // documentsButton
            // 
            this.documentsButton.BackColor = System.Drawing.Color.Transparent;
            this.documentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.documentsButton.FlatAppearance.BorderSize = 0;
            this.documentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.documentsButton.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsButton.ForeColor = System.Drawing.Color.Black;
            this.documentsButton.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.documentsButton.IconColor = System.Drawing.Color.Black;
            this.documentsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.documentsButton.IconSize = 30;
            this.documentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documentsButton.Location = new System.Drawing.Point(0, 114);
            this.documentsButton.Name = "documentsButton";
            this.documentsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.documentsButton.Size = new System.Drawing.Size(225, 32);
            this.documentsButton.TabIndex = 2;
            this.documentsButton.Tag = "Documents";
            this.documentsButton.Text = "   Documents";
            this.documentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.documentsButton.UseVisualStyleBackColor = false;
            this.documentsButton.Click += new System.EventHandler(this.documentsButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.Black;
            this.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.dashboardButton.IconColor = System.Drawing.Color.Black;
            this.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardButton.IconSize = 30;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 76);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(225, 38);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Tag = "Dashboard";
            this.dashboardButton.Text = "   Dashbaord";
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.expandMenuButton);
            this.panel3.Controls.Add(this.userPictureBox);
            this.panel3.Controls.Add(this.collapseMenuButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 76);
            this.panel3.TabIndex = 0;
            // 
            // expandMenuButton
            // 
            this.expandMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expandMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandMenuButton.ForeColor = System.Drawing.Color.White;
            this.expandMenuButton.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.expandMenuButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(225)))), ((int)(((byte)(161)))));
            this.expandMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.expandMenuButton.IconSize = 30;
            this.expandMenuButton.Location = new System.Drawing.Point(208, 23);
            this.expandMenuButton.Name = "expandMenuButton";
            this.expandMenuButton.Size = new System.Drawing.Size(17, 26);
            this.expandMenuButton.TabIndex = 2;
            this.expandMenuButton.UseVisualStyleBackColor = true;
            this.expandMenuButton.Click += new System.EventHandler(this.expandMenuButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userPictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.userPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
            this.userPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userPictureBox.BorderSize = 2;
            this.userPictureBox.GradientAngle = 50F;
            this.userPictureBox.Image = global::PresentationLayer.Properties.Resources.Judith;
            this.userPictureBox.Location = new System.Drawing.Point(76, 6);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(62, 62);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 1;
            this.userPictureBox.TabStop = false;
            // 
            // collapseMenuButton
            // 
            this.collapseMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseMenuButton.ForeColor = System.Drawing.Color.White;
            this.collapseMenuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.collapseMenuButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(225)))), ((int)(((byte)(161)))));
            this.collapseMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.collapseMenuButton.IconSize = 30;
            this.collapseMenuButton.Location = new System.Drawing.Point(170, 3);
            this.collapseMenuButton.Name = "collapseMenuButton";
            this.collapseMenuButton.Size = new System.Drawing.Size(55, 46);
            this.collapseMenuButton.TabIndex = 0;
            this.collapseMenuButton.UseVisualStyleBackColor = true;
            this.collapseMenuButton.Click += new System.EventHandler(this.collapseMenuButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.actionButtonPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // actionButtonPanel
            // 
            this.actionButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.actionButtonPanel.Location = new System.Drawing.Point(497, 34);
            this.actionButtonPanel.Name = "actionButtonPanel";
            this.actionButtonPanel.Size = new System.Drawing.Size(259, 33);
            this.actionButtonPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rjCircularPictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.currentModuleLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 64);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // rjCircularPictureBox2
            // 
            this.rjCircularPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox2.BorderColor = System.Drawing.Color.White;
            this.rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox2.BorderSize = 2;
            this.rjCircularPictureBox2.GradientAngle = 50F;
            this.rjCircularPictureBox2.Image = global::PresentationLayer.Properties.Resources.logo;
            this.rjCircularPictureBox2.Location = new System.Drawing.Point(3, 3);
            this.rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            this.rjCircularPictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rjCircularPictureBox2.Size = new System.Drawing.Size(62, 62);
            this.rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox2.TabIndex = 2;
            this.rjCircularPictureBox2.TabStop = false;
            // 
            // currentModuleLabel
            // 
            this.currentModuleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentModuleLabel.AutoSize = true;
            this.currentModuleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currentModuleLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentModuleLabel.ForeColor = System.Drawing.Color.Purple;
            this.currentModuleLabel.Location = new System.Drawing.Point(88, 20);
            this.currentModuleLabel.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.currentModuleLabel.Name = "currentModuleLabel";
            this.currentModuleLabel.Size = new System.Drawing.Size(105, 28);
            this.currentModuleLabel.TabIndex = 3;
            this.currentModuleLabel.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(225, 70);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(759, 38);
            this.panel1.TabIndex = 2;
            // 
            // footerPanel
            // 
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(225, 429);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.footerPanel.Size = new System.Drawing.Size(759, 32);
            this.footerPanel.TabIndex = 3;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Location = new System.Drawing.Point(225, 108);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(759, 321);
            this.contentPanel.TabIndex = 4;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardView";
            this.Palette = this.RIMSBasePalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardView_Load);
            this.menuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette RIMSBasePalette;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton collapseMenuButton;
        private RJCodeAdvance.RJControls.RJCircularPictureBox userPictureBox;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private System.Windows.Forms.Panel actionButtonPanel;
        private FontAwesome.Sharp.IconButton documentsButton;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton projectMgtButton;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox2;
        private System.Windows.Forms.Label currentModuleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel footerPanel;
        private FontAwesome.Sharp.IconButton expandMenuButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}