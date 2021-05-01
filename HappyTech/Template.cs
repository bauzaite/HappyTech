using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    /// <summary>
    /// Class with a constructor that creates new template
    /// </summary>
    public class Template
    {
        public string templateTitle;
        public string templateText;
        public string templateOwner;

        public Template()
        {

        }
        public Template(string templateTitle, string templateText, string templateOwner)
        {
            this.templateTitle = templateTitle;
            this.templateText = templateText;
            this.templateOwner = templateOwner;
        }
        public override string ToString()
        {
            return templateTitle + " " + templateText + " " + templateOwner;
        }
    }
}

