using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class SiteMaster : MasterPage
    {
        public List<CustomerHistory> CurrentUserHistory = new List<CustomerHistory>();
        public Customers currentCustomer = new Customers();

        protected string FullNameCap(string fname, string lname)
        {
            if (String.IsNullOrEmpty(fname) || String.IsNullOrEmpty(lname))
                throw new ArgumentException("Invalid Input, result failed ! Please use nonempty string");
            return fname.First().ToString().ToUpper() + fname.Substring(1) + " " + lname.First().ToString().ToUpper() + lname.Substring(1);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["validUser"] == null)
                {
                    Session["AccStatus"] = false;
                }
                else
                {
                    int userId = Convert.ToInt32(Session["CustomerId"]);
                    string firstName = Session["CustFirstName"] as string;
                    string lastName = Session["CustLastName"] as string;
                    uxAccountNameLink.Text = FullNameCap(firstName, lastName);

                    if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
                    {
                        uxUserNameLogin.Text = Request.Cookies["UserName"].Value;
                        uxPasswordLogin.Text = Request.Cookies["Password"].Value;
                    }

                    foreach (CustomerHistory ch in CustomerHistoryDB.PurchaseList(userId))
                    {
                        CurrentUserHistory.Add(ch);
                    }

                }
            }

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
                    Session["validUser"] = currentCustomer;
                    Session["AccStatus"] = true;

                    string firstName = Session["CustFirstName"] as string;
                    string lastName = Session["CustLastName"] as string;
                    uxAccountNameLink.Text = FullNameCap(firstName, lastName);

                    if (uxSaveMyInfo.Checked)
                    {
                        Response.Cookies["UserName"].Value = uxUserNameLogin.Text;
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(20);

                        Response.Cookies["Password"].Value = uxPasswordLogin.Text;
                        Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(20);


                    }
                    else
                    {
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(-1);
                        Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);

                    }

                    // // for testing
                    //MessageBox.Show("Login Successful!" +
                    //                "\n " + currentCustomer.CustomerId +
                    //                "\n" + currentCustomer.CustFirstName + " " + currentCustomer.CustLastName);

                }
                else
                {
                    MessageBox.Show("Login Fail !");
                    Session["AccStatus"] = false;
                }
            }
            else
            {
                Session["AccStatus"] = false;
                MessageBox.Show("Empty Fields! Please fill in Username and Password. ");
            }

        }

        protected void uxSignInBtnNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void uxLogout_OnClick(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Default.aspx");
        }
    }
}
