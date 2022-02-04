using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using PresentationLayer.Views.Controls;


namespace PresentationLayer.Views
{
    public partial class DashboardView : KryptonForm
    {
        static DashboardView _dashboardView;

        public static DashboardView Instance
        {
            get
            {
                if (_dashboardView == null)
                {
                    _dashboardView = new DashboardView();
                }
                return _dashboardView;
            }
            set { _dashboardView = value; }
        }

        public Panel PnlContainer
        {
            get { return contentPanel; }
            set { contentPanel = value; }
        }

        public DashboardView()
        {
            InitializeComponent();

            RunCustomInitializedSetup();
        }

        private void RunCustomInitializedSetup()
        {
            this.expandMenuButton.Visible = false;
            this.MinimumSize = new Size(1000, 500);
        }

        private void CollapseMenu()
        {
           if(this.menuPanel.Width > 200)
            { // Collapse
                this.menuPanel.Width = 100;
                this.collapseMenuButton.Visible = false;
                this.expandMenuButton.Visible = true;

                foreach(Button menuButton in this.menuPanel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
        }

        private void expandMenu()
        {
            if(this.menuPanel.Width <= 100)
            {
                this.menuPanel.Width = 225;
                this.collapseMenuButton.Visible = true;
                this.expandMenuButton.Visible = false;
                foreach (Button menuButton in this.menuPanel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,0,0);
                }
            }
        }

        private void collapseMenuButton_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void expandMenuButton_Click(object sender, EventArgs e)
        {
            expandMenu();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            DashboardUC dashboardUC = new DashboardUC();
            dashboardUC.Dock = DockStyle.Fill;
            LoadContentUserControl(sender, dashboardUC);
        }

        private void LoadContentUserControl(object sender, UserControl userControl)
        {
            foreach(Control ctl in contentPanel.Controls)
            {
                contentPanel.Controls.Remove(ctl);
            }

            if (!contentPanel.Controls.Contains(userControl))
            {
                contentPanel.Controls.Add(userControl);
            }
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            _dashboardView = this;

            DashboardUC dashboardUC = new DashboardUC();
            dashboardUC.Dock = DockStyle.Fill;
            LoadContentUserControl(sender, dashboardUC);
        }

        private void documentsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void projectMgtButton_Click(object sender, EventArgs e)
        {
            ProjectListUC projectListUC = new ProjectListUC();
            projectListUC.Dock = DockStyle.Fill;
            LoadContentUserControl(sender, projectListUC);

        }
    }


}
