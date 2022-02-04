using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views.Controls
{
    public partial class RecentProjectUC : UserControl
    {
        private static RecentProjectUC _obj;

        public static RecentProjectUC Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new RecentProjectUC();
                }
                return _obj;
            }

            set { _obj = value; }
        }


        public int ProjectProgress{ set { projectProgressBar.Value = value; }}

        public DateTime DueDate { set { dueDateLabel.Text = value.ToString(); }}

        public string ProjectName {set { projectNameLabel.Text = value; }}

        public RecentProjectUC()
        {
            InitializeComponent();
        }
    }
}
