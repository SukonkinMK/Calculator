using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MathModel : Model
    {
        private string _expression;

        public string Execute()
        {
            double res = MathExpressionParser.Parse(_expression);
            return res.ToString();
        }

        public void SetText(string text)
        {
            _expression = text;
        }
    }
}
