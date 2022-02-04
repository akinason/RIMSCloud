using CommonLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views.Controls
{
    public partial class ProjectListUC : UserControl, IProjectListUC
    {
        public event EventHandler ProjectListLoadEventRaised;

        public ProjectListUC()
        {
            InitializeComponent();
        }


        public void LoadProjectListToGrid(BindingSource projectListBindingSource, Dictionary<string, string> headingsDictionary)
        {
            this.ProjectListDataGridView.DataSource = projectListBindingSource;
            this.ProjectListDataGridView.AllowUserToAddRows = false;
            this.ProjectListDataGridView.ReadOnly = true;
            this.ProjectListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetGridHeaderText(headingsDictionary);
        }

        private void SetGridHeaderText(Dictionary<string, string> headingsDictionary)
        {
            Dictionary<string, string>.KeyCollection keyColl = headingsDictionary.Keys;

            foreach (string s in keyColl)
            {
                this.ProjectListDataGridView.Columns[s].HeaderText = s;
            }
        }

        public void ReloadProjectListGrid(BindingSource projectListBindingSource)
        {
            this.ProjectListDataGridView.DataSource = projectListBindingSource;
        }

        private void ProjectListUC_Load(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, ProjectListLoadEventRaised, e);
        }
    }
}
