using System;
using System.Globalization;
using System.Threading;
using System.Web.UI;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class SiteMaster : MasterPage
    {

        public bool validUser = false;
        public Customers currentCustomer = new Customers();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxSignInBtn_Click(object sender, EventArgs e)
        {
            Customers inputUser = new Customers();
            string inputUserName, inputPassword;
            if (Validator.IsPresent(uxUserNameLogin.Text, "Username")
                && Validator.IsPresent(uxPasswordLogin.Text, "Password")
            )
            {
                inputUserName = uxUserNameLogin.Text.Trim();
                inputPassword = uxPasswordLogin.Text.Trim();

                if (CustomersDB.FindExistingAcc(inputUserName, inputPassword, out inputUser))
                {
                    currentCustomer = new Customers
                    {
                        CustomerId = inputUser.CustomerId,
                        CustFirstName = inputUser.CustFirstName,
                        CustLastName = inputUser.CustLastName,
                        CustAddress = inputUser.CustAddress,
                        CustCity = inputUser.CustCity,
                        CustProv = inputUser.CustProv,
                        CustPostal = inputUser.CustPostal,
                        CustHomePhone = inputUser.CustHomePhone,
                        CustBusPhone = inputUser.CustBusPhone,
                        CustEmail = inputUser.CustEmail,
                        AgentId = inputUser.AgentId
                    };

                    CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                    TextInfo textInfo = cultureInfo.TextInfo;
                    string fullName =
                        textInfo.ToTitleCase(currentCustomer.CustFirstName + " " + currentCustomer.CustLastName);
                    Session["UserFullName"] = fullName;
                    Session["CustomerId"] = currentCustomer.CustomerId;
                    Session["CustFirstName"] = currentCustomer.CustFirstName;
                    Session["CustLastName"] = currentCustomer.CustLastName;
                    Session["CustAddress"] = currentCustomer.CustAddress;
                    Session["CustCity"] = currentCustomer.CustCity;
                    Session["CustProv"] = currentCustomer.CustProv;
                    Session["CustPostal"] = currentCustomer.CustPostal;
                    Session["CustHomePhone"] = currentCustomer.CustHomePhone;
                    Session["CustBusPhone"] = currentCustomer.CustBusPhone;
                    Session["CustEmail"] = currentCustomer.CustEmail;
                    Session["AgentId"] = currentCustomer.AgentId;

                    MessageBox.Show("Login Successful!" +
                                    "\n " + currentCustomer.CustomerId +
                                    "\n" + currentCustomer.CustFirstName + " " + currentCustomer.CustLastName);

                    validUser = true;
                    uxAccountNameLink.Text = fullName;
                }
                else
                {
                    MessageBox.Show("Login Fail !");
                }
            }
            else
            {
                MessageBox.Show("Empty Fields! Please fill in Username and Password. ");
            }

        }

        protected void uxSignInBtnNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
    }
}
