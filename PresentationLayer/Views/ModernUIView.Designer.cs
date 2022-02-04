namespace PresentationLayer.Views
{
    partial class ModernUIView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernUIView));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.documentRjDropdownMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharedDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectRjDropdownMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.personalProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invitedProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.userMgtButton = new FontAwesome.Sharp.IconButton();
            this.reportsButton = new FontAwesome.Sharp.IconButton();
            this.projectButton = new FontAwesome.Sharp.IconButton();
            this.documentButton = new FontAwesome.Sharp.IconButton();
            this.dashboarButton = new FontAwesome.Sharp.IconButton();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.documentRjDropdownMenu.SuspendLayout();
            this.ProjectRjDropdownMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.userMgtButton);
            this.menuPanel.Controls.Add(this.reportsButton);
            this.menuPanel.Controls.Add(this.projectButton);
            this.menuPanel.Controls.Add(this.documentButton);
            this.menuPanel.Controls.Add(this.dashboarButton);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.menuPanel.Size = new System.Drawing.Size(230, 561);
            this.menuPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 114);
            this.panel1.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.White;
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.maximizeButton);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(230, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(904, 60);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(230, 60);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(904, 501);
            this.desktopPanel.TabIndex = 2;
            // 
            // documentRjDropdownMenu
            // 
            this.documentRjDropdownMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.documentRjDropdownMenu.IsMainMenu = false;
            this.documentRjDropdownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.documentsToolStripMenuItem});
            this.documentRjDropdownMenu.MenuItemHeight = 50;
            this.documentRjDropdownMenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.documentRjDropdownMenu.Name = "documentRjDropdownMenu";
            this.documentRjDropdownMenu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.documentRjDropdownMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDocumentsToolStripMenuItem,
            this.sharedDocumentsToolStripMenuItem});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // personalDocumentsToolStripMenuItem
            // 
            this.personalDocumentsToolStripMenuItem.Name = "personalDocumentsToolStripMenuItem";
            this.personalDocumentsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.personalDocumentsToolStripMenuItem.Text = "Personal Documents";
            // 
            // sharedDocumentsToolStripMenuItem
            // 
            this.sharedDocumentsToolStripMenuItem.Name = "sharedDocumentsToolStripMenuItem";
            this.sharedDocumentsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sharedDocumentsToolStripMenuItem.Text = "Shared Documents";
            // 
            // ProjectRjDropdownMenu
            // 
            this.ProjectRjDropdownMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProjectRjDropdownMenu.IsMainMenu = false;
            this.ProjectRjDropdownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalProjectsToolStripMenuItem,
            this.invitedProjectsToolStripMenuItem});
            this.ProjectRjDropdownMenu.MenuItemHeight = 50;
            this.ProjectRjDropdownMenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ProjectRjDropdownMenu.Name = "ProjectRjDropdownMenu";
            this.ProjectRjDropdownMenu.PrimaryColor = System.Drawing.Color.Empty;
            this.ProjectRjDropdownMenu.Size = new System.Drawing.Size(165, 48);
            // 
            // personalProjectsToolStripMenuItem
            // 
            this.personalProjectsToolStripMenuItem.Name = "personalProjectsToolStripMenuItem";
            this.personalProjectsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.personalProjectsToolStripMenuItem.Text = "Personal Projects";
            // 
            // invitedProjectsToolStripMenuItem
            // 
            this.invitedProjectsToolStripMenuItem.Name = "invitedProjectsToolStripMenuItem";
            this.invitedProjectsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.invitedProjectsToolStripMenuItem.Text = "Invited Projects";
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(252)))));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeButton.IconColor = System.Drawing.Color.White;
            this.maximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeButton.IconSize = 20;
            this.maximizeButton.Location = new System.Drawing.Point(828, 3);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(34, 25);
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.White;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 20;
            this.minimizeButton.Location = new System.Drawing.Point(792, 3);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(36, 25);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 20;
            this.closeButton.Location = new System.Drawing.Point(862, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(39, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 30;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 507);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(230, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.Tag = "Exit";
            this.exitButton.Text = "   IconBotton";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userMgtButton
            // 
            this.userMgtButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userMgtButton.FlatAppearance.BorderSize = 0;
            this.userMgtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userMgtButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMgtButton.ForeColor = System.Drawing.Color.White;
            this.userMgtButton.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.userMgtButton.IconColor = System.Drawing.Color.White;
            this.userMgtButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userMgtButton.IconSize = 30;
            this.userMgtButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userMgtButton.Location = new System.Drawing.Point(0, 270);
            this.userMgtButton.Name = "userMgtButton";
            this.userMgtButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userMgtButton.Size = new System.Drawing.Size(230, 39);
            this.userMgtButton.TabIndex = 5;
            this.userMgtButton.TabStop = false;
            this.userMgtButton.Tag = "User Management";
            this.userMgtButton.Text = "   User Management";
            this.userMgtButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userMgtButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userMgtButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.reportsButton.IconColor = System.Drawing.Color.White;
            this.reportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportsButton.IconSize = 30;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 231);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportsButton.Size = new System.Drawing.Size(230, 39);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Tag = "Reports";
            this.reportsButton.Text = "   Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // projectButton
            // 
            this.projectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectButton.FlatAppearance.BorderSize = 0;
            this.projectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectButton.ForeColor = System.Drawing.Color.White;
            this.projectButton.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.projectButton.IconColor = System.Drawing.Color.White;
            this.projectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.projectButton.IconSize = 30;
            this.projectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectButton.Location = new System.Drawing.Point(0, 192);
            this.projectButton.Name = "projectButton";
            this.projectButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.projectButton.Size = new System.Drawing.Size(230, 39);
            this.projectButton.TabIndex = 3;
            this.projectButton.Tag = "Project Management";
            this.projectButton.Text = "   Project Management";
            this.projectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // documentButton
            // 
            this.documentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.documentButton.FlatAppearance.BorderSize = 0;
            this.documentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.documentButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentButton.ForeColor = System.Drawing.Color.White;
            this.documentButton.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.documentButton.IconColor = System.Drawing.Color.White;
            this.documentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.documentButton.IconSize = 30;
            this.documentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documentButton.Location = new System.Drawing.Point(0, 153);
            this.documentButton.Name = "documentButton";
            this.documentButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.documentButton.Size = new System.Drawing.Size(230, 39);
            this.documentButton.TabIndex = 2;
            this.documentButton.Tag = "Documents";
            this.documentButton.Text = "   Documents";
            this.documentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.documentButton.UseVisualStyleBackColor = true;
            this.documentButton.Click += new System.EventHandler(this.documentButton_Click);
            // 
            // dashboarButton
            // 
            this.dashboarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboarButton.FlatAppearance.BorderSize = 0;
            this.dashboarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboarButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboarButton.ForeColor = System.Drawing.Color.White;
            this.dashboarButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.dashboarButton.IconColor = System.Drawing.Color.White;
            this.dashboarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboarButton.IconSize = 30;
            this.dashboarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboarButton.Location = new System.Drawing.Point(0, 114);
            this.dashboarButton.Name = "dashboarButton";
            this.dashboarButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboarButton.Size = new System.Drawing.Size(230, 39);
            this.dashboarButton.TabIndex = 1;
            this.dashboarButton.Tag = "Dashboard";
            this.dashboarButton.Text = "   Dashboard";
            this.dashboarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboarButton.UseVisualStyleBackColor = true;
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menuButton.IconColor = System.Drawing.Color.White;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.IconSize = 30;
            this.menuButton.Location = new System.Drawing.Point(170, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(60, 60);
            this.menuButton.TabIndex = 1;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::PresentationLayer.Properties.Resources.logo_transparent;
            this.logoPictureBox.Location = new System.Drawing.Point(37, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(111, 100);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // ModernUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModernUIView";
            this.Text = "ModernUIView";
            this.Resize += new System.EventHandler(this.ModernUIView_Resize);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.documentRjDropdownMenu.ResumeLayout(false);
            this.ProjectRjDropdownMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton userMgtButton;
        private FontAwesome.Sharp.IconButton reportsButton;
        private FontAwesome.Sharp.IconButton projectButton;
        private FontAwesome.Sharp.IconButton documentButton;
        private FontAwesome.Sharp.IconButton dashboarButton;
        private FontAwesome.Sharp.IconButton menuButton;
        private FontAwesome.Sharp.IconButton maximizeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJDropdownMenu documentRjDropdownMenu;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharedDocumentsToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu ProjectRjDropdownMenu;
        private System.Windows.Forms.ToolStripMenuItem personalProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invitedProjectsToolStripMenuItem;
    }
}