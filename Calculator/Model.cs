using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface Model
    {
        public void SetText(string text);
        string Execute();
    }
}
