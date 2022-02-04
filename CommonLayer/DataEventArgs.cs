using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class DataEventArgs : EventArgs
    {
        Dictionary<string, string> Data { get; set; }
    }
}
