namespace PresentationLayer.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.RIMSBasePalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.passwordTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.signInButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.invalidCredentialsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::PresentationLayer.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(100, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(147, 152);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(26, 249);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 40);
            this.usernameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.usernameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usernameTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.usernameTextBox.StateCommon.Border.Rounding = 20;
            this.usernameTextBox.StateCommon.Border.Width = 1;
            this.usernameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.usernameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "Username";
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
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(26, 295);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 40);
            this.passwordTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordTextBox.StateCommon.Border.Rounding = 20;
            this.passwordTextBox.StateCommon.Border.Width = 1;
            this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            // 
            // signInButton
            // 
            this.signInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInButton.Location = new System.Drawing.Point(81, 358);
            this.signInButton.Name = "signInButton";
            this.signInButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.signInButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(96)))));
            this.signInButton.OverrideDefault.Back.ColorAngle = 45F;
            this.signInButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.signInButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(96)))));
            this.signInButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signInButton.OverrideDefault.Border.Rounding = 20;
            this.signInButton.OverrideDefault.Border.Width = 1;
            this.signInButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.signInButton.Size = new System.Drawing.Size(155, 45);
            this.signInButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.signInButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(96)))));
            this.signInButton.StateCommon.Back.ColorAngle = 45F;
            this.signInButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.signInButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(96)))));
            this.signInButton.StateCommon.Border.ColorAngle = 45F;
            this.signInButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signInButton.StateCommon.Border.Rounding = 20;
            this.signInButton.StateCommon.Border.Width = 1;
            this.signInButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.signInButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.signInButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(135)))));
            this.signInButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(205)))), ((int)(((byte)(149)))));
            this.signInButton.StatePressed.Back.ColorAngle = 135F;
            this.signInButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(135)))));
            this.signInButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(205)))), ((int)(((byte)(149)))));
            this.signInButton.StatePressed.Border.ColorAngle = 135F;
            this.signInButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.StatePressed.Border.Rounding = 20;
            this.signInButton.StatePressed.Border.Width = 1;
            this.signInButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.signInButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(96)))));
            this.signInButton.StateTracking.Back.ColorAngle = 45F;
            this.signInButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.signInButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(180)))), ((int)(((byte)(96)))));
            this.signInButton.StateTracking.Border.ColorAngle = 45F;
            this.signInButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signInButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.signInButton.StateTracking.Border.Rounding = 20;
            this.signInButton.StateTracking.Border.Width = 1;
            this.signInButton.TabIndex = 4;
            this.signInButton.Values.Text = "SIGN IN";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // invalidCredentialsLabel
            // 
            this.invalidCredentialsLabel.AutoSize = true;
            this.invalidCredentialsLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidCredentialsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidCredentialsLabel.Location = new System.Drawing.Point(46, 406);
            this.invalidCredentialsLabel.Name = "invalidCredentialsLabel";
            this.invalidCredentialsLabel.Size = new System.Drawing.Size(245, 26);
            this.invalidCredentialsLabel.TabIndex = 5;
            this.invalidCredentialsLabel.Text = "Invalid username or password!";
            this.invalidCredentialsLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(135, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIGN IN";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invalidCredentialsLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.Palette = this.RIMSBasePalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette RIMSBasePalette;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton signInButton;
        private System.Windows.Forms.Label invalidCredentialsLabel;
        private System.Windows.Forms.Label label2;
    }
}