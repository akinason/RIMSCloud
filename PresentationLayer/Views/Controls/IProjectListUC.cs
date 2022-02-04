using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views.Controls
{
    public interface IProjectListUC
    {
        event EventHandler ProjectListLoadEventRaised;

        void LoadProjectListToGrid(BindingSource projectListBindingSource, Dictionary<string, string> headingsDictionary);
        void ReloadProjectListGrid(BindingSource projectListBindingSource);
    }
}