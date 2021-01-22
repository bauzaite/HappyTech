using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsTest
{
    public class constructor
    {
        private string cName;
        private bool cBool;

        public constructor(string cName, bool cBool)
        {
            this.cName = cName;
            this.cBool = cBool;
        }
        public override string ToString()
        {
            return cName + " " + cBool;
        }
    }
}
