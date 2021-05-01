using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    /// <summary>
    /// This class contains a constructor which stores the information
    /// about the usrs chosen applicant so other forms can access this
    /// information.
    /// </summary>
    public class Applicant
    {

        public string applicantFName;
        public string applicantLName;
        public string applicantEmail;
        public string applicantStage;
        public string applicantSuccessful;

        public Applicant(){}

        public override string ToString()
        {
            return applicantFName + " " + applicantLName + " " + applicantEmail + " " + applicantStage + " " + applicantSuccessful;
        }
    }
}
