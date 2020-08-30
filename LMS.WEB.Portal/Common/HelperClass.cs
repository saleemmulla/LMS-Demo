using LMSUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.Common
{
    public class HelperClass
    {
        public static bool SendEmailFromEmployee(string EmployeeMgrNM, string EmployeeNM, DateTime FromDate, DateTime ToDate, string EmailId)
        {
            bool result = false;
            try
            {
                string HtmlBody = @"<p>Hi  " + EmployeeMgrNM + @"</p>
                                <p>
                                    This email is to initimate you that <b> " + EmployeeNM + @" </b> has requested for leave for the below mentioned dates<br />
                                    Start Date : " + FromDate.ToString("yyyy-MM-dd") + @"<br />
                                    End Date : " + ToDate.ToString("yyyy-MM-dd") + @" <br />
                                    Kindly approve/reject the request at the following  LMS link https://localhost:44331/Account/LogIn
                                <br />";

                Email.body = HtmlBody;
                Email.subject = EmployeeMgrNM + " leave request";
                Email.emailToAddress = EmailId;
                Email.SendEmail();
                result = true;
                return result;
            }
            catch
            {
                return false;
            }
        }

        public static bool SendEmailFromManager(string EmployeeName, DateTime fromDate, DateTime todate, string status, string emailId)
        {
            bool result = false;
            try
            {
                string HtmlBody = @"<p>Hi  " + EmployeeName + @"</p>
                                <p>
                                    Kindly note the following update regarding your leave request. <br /><br/>
                                    Start Date : " + fromDate.ToString("yyyy-MM-dd") + @"<br /><br />
                                    End Date : " + fromDate.ToString("yyyy-MM-dd") + @" <br /><br />
                                    Status : " + status + @"<br/><br/>

                                    LMS link https://localhost:44331/Account/LogIn
                                <br />";
                Email.body = HtmlBody;
                Email.subject = EmployeeName + " leave request " + status;
                Email.emailToAddress = emailId;
                Email.SendEmail();
                result = true;
                return result;
            }
            catch
            {
                return false;
            }
        }
    }
}
