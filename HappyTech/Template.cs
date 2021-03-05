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
    class Template
    {
        public string templateTitle;
        public string templateText1;
        public string templateText2;
        public string templateText3;
        public string templateText4;
        public string templateText5;
        public string templateCategory;
        public int templateSuccessful;

        public Template(string templateTitle, string templateText1, string templateText2, string templateText3, string templateText4, string templateText5, string templateCategory, int templateSuccessful)
        {
            this.templateTitle = templateTitle;
            this.templateText1 = templateText1;
            this.templateText2 = templateText2;
            this.templateText3 = templateText3;
            this.templateText4 = templateText4;
            this.templateText5 = templateText5;
            this.templateCategory = templateCategory;
            this.templateSuccessful = templateSuccessful;
        }
        public override string ToString()
        {
            return templateTitle + " " + templateCategory + " " + templateText1 + " " + templateText2 + " " + templateText3 + " " + templateText4 + " " + templateText5 + " " + templateSuccessful;
        }
    }
}

