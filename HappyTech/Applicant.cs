using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Applicant
    {

        public string applicantFName;
        public string applicantLName;
        public string applicantEmail;
        public string applicantStage;
        public string applicantSuccessful;

        public Applicant()
        {

        }

        public Applicant(string fname, string lname, string email, string stage, string success)
        {
            this.applicantFName = fname;
            this.applicantLName = lname;
            this.applicantEmail = email;
            this.applicantStage = stage;
            this.applicantSuccessful = success;
        }

        public override string ToString()
        {
            return applicantFName + " " + applicantLName + " " + applicantEmail + " " + applicantStage + " " + applicantSuccessful;
        }
    }
}
