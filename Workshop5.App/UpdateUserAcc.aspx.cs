using System;
using System.Linq;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class UpdateUserAcc : System.Web.UI.Page
    {
        private bool correctInput = false;
        private Customers currentUser = new Customers();

        protected string FullNameCap(string fname, string lname)
        {
            if (String.IsNullOrEmpty(fname) || String.IsNullOrEmpty(lname))
                throw new ArgumentException("Invalid Input, result failed ! Please use nonempty string");
            return fname.First().ToString().ToUpper() + fname.Substring(1) + " " + lname.First().ToString().ToUpper() + lname.Substring(1);

        }

        protected void Info()
        {
            Customers inputUser = Session["validUser"] as Customers;

            currentUser.CustomerId = inputUser.CustomerId;
            currentUser.CustFirstName = inputUser.CustFirstName;
            currentUser.CustLastName = inputUser.CustLastName;
            currentUser.CustAddress = inputUser.CustAddress;
            currentUser.CustCity = inputUser.CustCity;
            currentUser.CustProv = inputUser.CustProv;
            currentUser.CustPostal = inputUser.CustPostal;
            currentUser.CustHomePhone = inputUser.CustHomePhone;
            currentUser.CustBusPhone = inputUser.CustBusPhone;
            currentUser.CustEmail = inputUser.CustEmail;
            currentUser.AgentId = inputUser.AgentId;
            currentUser.username = inputUser.username;
            currentUser.userPass = inputUser.userPass;

            uxFirstNameUp.Text = currentUser.CustFirstName.Trim();
            uxLastNameUp.Text = currentUser.CustLastName.Trim();
            uxCityUp.Text = currentUser.CustCity.Trim();
            uxAddressUp.Text = currentUser.CustAddress.Trim();
            uxProvUp.Text = currentUser.CustProv.Trim();
            uxPostalUp.Text = currentUser.CustPostal.Trim();
            uxHomePhoneUp.Text = currentUser.CustHomePhone.Trim();
            uxBusPhoneUp.Text = currentUser.CustBusPhone.Trim();
            uxUsernameUp.Text = currentUser.username.Trim();
            uxEmailUp.Text = currentUser.CustEmail.Trim();
            string firstName = currentUser.CustFirstName.Trim();
            string lastName = currentUser.CustLastName.Trim();
            uxUserNameTitle.InnerText = FullNameCap(firstName, lastName);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["validUser"] == null)
            {
                Response.Redirect("Default.aspx");
            }


            Info();



        }



        protected void uxUpdateBtn_Click(object sender, EventArgs e)
        {

            string CustFirstName = uxFirstNameUp.Text.Trim();
            string CustLastName = uxLastNameUp.Text.Trim();
            string CustAddress = uxAddressUp.Text.Trim();
            string CustCity = uxCityUp.Text.Trim();
            string CustProv = uxProvUp.Text.Trim();
            string CustPostal = uxPostalUp.Text.Trim();
            string CustHomePhone = uxHomePhoneUp.Text.Trim();
            string CustBusPhone = uxBusPhoneUp.Text.Trim();
            string CustEmail = uxEmailUp.Text.Trim();
            string username = uxUsernameUp.Text.Trim();
            string userPass = uxPasswordUp.Text.Trim();

            try
            {

                Customers customer = new Customers();
                customer.CustomerId = Convert.ToInt32(Session["CustomerId"]);
                customer.CustFirstName = CustFirstName;
                customer.CustLastName = CustLastName;
                customer.CustAddress = CustAddress;
                customer.CustCity = CustCity;
                customer.CustProv = CustProv;
                customer.CustPostal = CustPostal;
                customer.CustHomePhone = CustHomePhone;
                customer.CustBusPhone = CustBusPhone;
                customer.CustEmail = CustEmail;
                customer.username = username;
                customer.userPass = userPass;

                MessageBox.Show("Customer" + customer.CustomerId);

                string status = "Update Customer Failed";
                if (CustomersDB.UpdateCustomer(customer))
                {
                    Session["validUser"] = customer;
                    status = "Uppdate Customer successful.";
                }

                MessageBox.Show(status);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected void uxCancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("UserProfile.aspx");
        }


    }
}