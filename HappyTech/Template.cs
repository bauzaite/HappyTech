using System;
namespace HappyTech
{
    public class Template
    {
        int templateID;
        string templateName;
        int categoryID;
        int textID;
        bool templateSucc;
        int employee;

        public Template(int templateID, string templateName, int categoryID, int textID, bool templateSucc, int employee)
        {
            this.templateID = templateID;
            this.templateName = templateName;
            this.categoryID = categoryID;
            this.textID = textID;
            this.templateSucc = templateSucc;
            this.employee = employee;
        }
    }
}
