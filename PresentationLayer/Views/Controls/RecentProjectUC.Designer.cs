namespace PresentationLayer.Views.Controls
{
    partial class RecentProjectUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectProgressBar
            // 
            this.projectProgressBar.Depth = 0;
            this.projectProgressBar.Location = new System.Drawing.Point(7, 32);
            this.projectProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.projectProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectProgressBar.Name = "projectProgressBar";
            this.projectProgressBar.Size = new System.Drawing.Size(190, 5);
            this.projectProgressBar.TabIndex = 52;
            this.projectProgressBar.Value = 25;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.dueDateLabel.ForeColor = System.Drawing.Color.Black;
            this.dueDateLabel.Location = new System.Drawing.Point(128, 15);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(78, 19);
            this.dueDateLabel.TabIndex = 51;
            this.dueDateLabel.Text = "27-Jan-2022";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(155, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Due";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.projectNameLabel.ForeColor = System.Drawing.Color.Black;
            this.projectNameLabel.Location = new System.Drawing.Point(3, 8);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(148, 19);
            this.projectNameLabel.TabIndex = 49;
            this.projectNameLabel.Text = "Water Purification Project";
            // 
            // RecentProjectUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.projectProgressBar);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectNameLabel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "RecentProjectUC";
            this.Size = new System.Drawing.Size(220, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar projectProgressBar;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectNameLabel;
    }
}
