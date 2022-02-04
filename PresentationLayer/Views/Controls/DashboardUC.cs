using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.Views.Controls
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();

            LoadRecentProjects();
            this.recentProjectsLabel.Text = ConfigurationManager.AppSettings["baseURL"];
        }

       public void LoadRecentProjects()
        {
            for (int i = 1; i <3; i++)
            {
                RecentProjectUC rpc = new RecentProjectUC();
                rpc.ProjectName = "Test Project No: " + i;
                rpc.ProjectProgress = i * 25;
                rpc.Margin = new Padding(0, 0, 5, 3);
                rpc.AutoSize = false;
                rpc.Dock = DockStyle.Top;
                rpc.MaximumSize = new Size(210, 70);
                recentProjectsPanel.Controls.Add(rpc);
                recentProjectsPanel.Controls.SetChildIndex(rpc, 0);
            }
        }

        private void activePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, activePanel.ClientRectangle,
                Color.White, 1, ButtonBorderStyle.Solid, // left
                Color.White, 1, ButtonBorderStyle.Solid, // top 
                Color.White, 1, ButtonBorderStyle.Solid, // right
                Color.White, 1, ButtonBorderStyle.Solid); // bottom
        }
    }
}
