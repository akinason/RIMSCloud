namespace PresentationLayer.Views.Controls
{
    partial class DashboardUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recentProjectsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recentProjectsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.suspendedPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.archivedPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.activePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelledPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.circularIconPictureBox3 = new PresentationLayer.Common.CircularIconPictureBox();
            this.circularIconPictureBox2 = new PresentationLayer.Common.CircularIconPictureBox();
            this.circularIconPictureBox1 = new PresentationLayer.Common.CircularIconPictureBox();
            this.circularIconPictureBox4 = new PresentationLayer.Common.CircularIconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.suspendedPanel.SuspendLayout();
            this.archivedPanel.SuspendLayout();
            this.activePanel.SuspendLayout();
            this.cancelledPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recentProjectsPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 483);
            this.panel1.TabIndex = 0;
            // 
            // recentProjectsPanel
            // 
            this.recentProjectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentProjectsPanel.Location = new System.Drawing.Point(0, 87);
            this.recentProjectsPanel.Name = "recentProjectsPanel";
            this.recentProjectsPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.recentProjectsPanel.Size = new System.Drawing.Size(279, 396);
            this.recentProjectsPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.recentProjectsLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 87);
            this.panel2.TabIndex = 0;
            // 
            // recentProjectsLabel
            // 
            this.recentProjectsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recentProjectsLabel.AutoSize = true;
            this.recentProjectsLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentProjectsLabel.ForeColor = System.Drawing.Color.Black;
            this.recentProjectsLabel.Location = new System.Drawing.Point(3, 56);
            this.recentProjectsLabel.Name = "recentProjectsLabel";
            this.recentProjectsLabel.Size = new System.Drawing.Size(130, 26);
            this.recentProjectsLabel.TabIndex = 0;
            this.recentProjectsLabel.Text = "Recent projects";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.suspendedPanel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.archivedPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.activePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelledPanel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(279, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // suspendedPanel
            // 
            this.suspendedPanel.BackColor = System.Drawing.Color.White;
            this.suspendedPanel.Controls.Add(this.label7);
            this.suspendedPanel.Controls.Add(this.label8);
            this.suspendedPanel.Controls.Add(this.circularIconPictureBox3);
            this.suspendedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suspendedPanel.Location = new System.Drawing.Point(411, 3);
            this.suspendedPanel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.suspendedPanel.Name = "suspendedPanel";
            this.suspendedPanel.Size = new System.Drawing.Size(126, 81);
            this.suspendedPanel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "2500";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Suspended";
            // 
            // archivedPanel
            // 
            this.archivedPanel.BackColor = System.Drawing.Color.White;
            this.archivedPanel.Controls.Add(this.label3);
            this.archivedPanel.Controls.Add(this.label4);
            this.archivedPanel.Controls.Add(this.circularIconPictureBox2);
            this.archivedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archivedPanel.Location = new System.Drawing.Point(139, 3);
            this.archivedPanel.Name = "archivedPanel";
            this.archivedPanel.Size = new System.Drawing.Size(130, 81);
            this.archivedPanel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "2500";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Archived";
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.White;
            this.activePanel.Controls.Add(this.label1);
            this.activePanel.Controls.Add(this.label2);
            this.activePanel.Controls.Add(this.circularIconPictureBox1);
            this.activePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanel.Location = new System.Drawing.Point(10, 3);
            this.activePanel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(123, 81);
            this.activePanel.TabIndex = 9;
            this.activePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.activePanel_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "2500";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Active";
            // 
            // cancelledPanel
            // 
            this.cancelledPanel.BackColor = System.Drawing.Color.White;
            this.cancelledPanel.Controls.Add(this.label5);
            this.cancelledPanel.Controls.Add(this.label6);
            this.cancelledPanel.Controls.Add(this.circularIconPictureBox4);
            this.cancelledPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelledPanel.Location = new System.Drawing.Point(275, 3);
            this.cancelledPanel.Name = "cancelledPanel";
            this.cancelledPanel.Size = new System.Drawing.Size(130, 81);
            this.cancelledPanel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "2500";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cancelled";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(289, 103);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(527, 366);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // circularIconPictureBox3
            // 
            this.circularIconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circularIconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.circularIconPictureBox3.ForeColor = System.Drawing.Color.Red;
            this.circularIconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Icicles;
            this.circularIconPictureBox3.IconColor = System.Drawing.Color.Red;
            this.circularIconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.circularIconPictureBox3.IconSize = 37;
            this.circularIconPictureBox3.Location = new System.Drawing.Point(1, 40);
            this.circularIconPictureBox3.Name = "circularIconPictureBox3";
            this.circularIconPictureBox3.Size = new System.Drawing.Size(38, 37);
            this.circularIconPictureBox3.TabIndex = 10;
            this.circularIconPictureBox3.TabStop = false;
            // 
            // circularIconPictureBox2
            // 
            this.circularIconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circularIconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.circularIconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circularIconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.circularIconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circularIconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.circularIconPictureBox2.IconSize = 37;
            this.circularIconPictureBox2.Location = new System.Drawing.Point(1, 40);
            this.circularIconPictureBox2.Name = "circularIconPictureBox2";
            this.circularIconPictureBox2.Size = new System.Drawing.Size(38, 37);
            this.circularIconPictureBox2.TabIndex = 10;
            this.circularIconPictureBox2.TabStop = false;
            // 
            // circularIconPictureBox1
            // 
            this.circularIconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circularIconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.circularIconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.circularIconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.circularIconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.circularIconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.circularIconPictureBox1.IconSize = 37;
            this.circularIconPictureBox1.Location = new System.Drawing.Point(2, 40);
            this.circularIconPictureBox1.Name = "circularIconPictureBox1";
            this.circularIconPictureBox1.Rotation = 15D;
            this.circularIconPictureBox1.Size = new System.Drawing.Size(38, 37);
            this.circularIconPictureBox1.TabIndex = 10;
            this.circularIconPictureBox1.TabStop = false;
            // 
            // circularIconPictureBox4
            // 
            this.circularIconPictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circularIconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.circularIconPictureBox4.ForeColor = System.Drawing.Color.Red;
            this.circularIconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.circularIconPictureBox4.IconColor = System.Drawing.Color.Red;
            this.circularIconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.circularIconPictureBox4.IconSize = 37;
            this.circularIconPictureBox4.Location = new System.Drawing.Point(1, 40);
            this.circularIconPictureBox4.Name = "circularIconPictureBox4";
            this.circularIconPictureBox4.Size = new System.Drawing.Size(38, 37);
            this.circularIconPictureBox4.TabIndex = 10;
            this.circularIconPictureBox4.TabStop = false;
            // 
            // DashboardUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(826, 483);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.suspendedPanel.ResumeLayout(false);
            this.suspendedPanel.PerformLayout();
            this.archivedPanel.ResumeLayout(false);
            this.archivedPanel.PerformLayout();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            this.cancelledPanel.ResumeLayout(false);
            this.cancelledPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularIconPictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel cancelledPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Common.CircularIconPictureBox circularIconPictureBox4;
        private System.Windows.Forms.Panel suspendedPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Common.CircularIconPictureBox circularIconPictureBox3;
        private System.Windows.Forms.Panel archivedPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Common.CircularIconPictureBox circularIconPictureBox2;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Common.CircularIconPictureBox circularIconPictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label recentProjectsLabel;
        private System.Windows.Forms.FlowLayoutPanel recentProjectsPanel;
    }
}
