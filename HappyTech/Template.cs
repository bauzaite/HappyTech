﻿using System;
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

