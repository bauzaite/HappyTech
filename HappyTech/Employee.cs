using System;
namespace HappyTech
{
    public class Employee
    {
            private int employeeID;
            private string employeeLogin;
            private int employeeInfoID;

            public Employee(int employeeID, string employeeLogin, int employeeInfoID)
            {
                this.employeeID = employeeID;
                this.employeeLogin = employeeLogin;
                this.employeeInfoID = employeeInfoID;
            }

    }
}
