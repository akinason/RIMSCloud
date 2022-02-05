using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class DataEventArgs : EventArgs
    {
        public Dictionary<string, string> data { get; set; }
    }
}
