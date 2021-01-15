using System;
namespace HappyTech
{
    public class Applicant
    {
        int applicantID;
        string jobInfo;
        int applicantInfo;

        public Applicant(int applicantID, string jobInfo, int applicantInfo)
        {
            this.applicantID = applicantID;
            this.jobInfo = jobInfo;
            this.applicantInfo = applicantInfo;
        }
    }
}
