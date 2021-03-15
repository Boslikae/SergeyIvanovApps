using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IView
    {
        string Numb { get; }

        string Result { set; }

        string Counter { get; set; }

        string Task { get; }

       // bool Victory { get; set; }

    }
}
