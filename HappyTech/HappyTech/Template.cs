using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Template
    {
        public string templateTitle;
        public string templateText;
        public string templateCategory;
        public int templateSuccessful;

        public Template(string templateTitle, string templateText, string templateCategory, int templateSuccessful)
        {
            this.templateTitle = templateTitle;
            this.templateText = templateText;
            this.templateCategory = templateCategory;
            this.templateSuccessful = templateSuccessful;
        }
        public override string ToString()
        {
            return templateTitle + " " + templateCategory + " " + templateText + " " + templateSuccessful;
        }
    }
}

