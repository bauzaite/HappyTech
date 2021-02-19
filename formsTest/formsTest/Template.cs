using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsTest
{
    class Template
    {
        public string templateTitle;
        public string templateText;

        public Template(string templateTitle, string templateText)
        {
            this.templateTitle = templateTitle;
            this.templateText = templateText;
        }
        public override string ToString()
        {
            return templateTitle + " " + templateText;
        }
    }
}
