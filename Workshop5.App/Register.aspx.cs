using System;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class Register : System.Web.UI.Page
    {
        protected Customer customer;
        int count = 0;
        protected void CreateUser_Click(object sender, EventArgs e)
        {

            Customer c = new Customer();

            c.CustFirstName = txtFirstName.Text;
            c.CustLastName = txtLastName.Text;
            c.CustAddress = txtAddress.Text;
            c.CustCity = txtCity.Text;
            c.CustProv = txtProvince.Text;
            c.CustPostal = txtPostal.Text;
            c.CustCountry = txtCountry.Text;
            c.CustHomePhone = txtHomePhone.Text;
            c.CustBusPhone = txtBusPhone.Text;
            c.CustEmail = txtEmail.Text;
            c.UserName = txtUserName.Text;

            //call hashing method to store hashed password in object
            string hash = TravelExpertsClassLib.Validator.CalculateMD5(txtPassword.Text);
            c.Password = hash;

            try
            {
                if (IsDataValid())
                {
                    count = CustomerDB.InsertCustomer(c);

                    if (count > 0)
                    {
                        Session["customer"] = c; //set object to customer session variable
                    }

                    else
                    {
                        lblUserName.Text = "User name in use. Please select another user name.";
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        public bool IsDataValid()
        {
            return
                // Validate the data entered by the user to make sure the mandatory fields are present and data is in the correct format
                TravelExpertsClassLib.Validator.IsPresentWeb(txtFirstName, "First Name") &&
                TravelExpertsClassLib.Validator.IsString(txtFirstName, "First Name") &&

                TravelExpertsClassLib.Validator.IsPresent(txtLastName, "Last Name") &&
                TravelExpertsClassLib.Validator.IsString(txtLastName, "First Name") &&
                TravelExpertsClassLib.Validator.IsPresent(txtAddress, "Address") &&
                TravelExpertsClassLib.Validator.IsPresent(txtCity, "City") &&
                TravelExpertsClassLib.Validator.IsCity(txtCity, "City") &&
                TravelExpertsClassLib.Validator.IsPresentWeb(txtProvince, "Province") &&
                TravelExpertsClassLib.Validator.IsString(txtProvince, "Province") &&
                TravelExpertsClassLib.Validator.IsProvince(txtProvince, "Province") &&
                TravelExpertsClassLib.Validator.IsPresentWeb(txtPostal, "Postal Code") &&
                TravelExpertsClassLib.Validator.IsPostal(txtPostal, "Postal Code") &&
                TravelExpertsClassLib.Validator.IsPresentWeb(txtCountry, "Country") &&
                TravelExpertsClassLib.Validator.IsCountry(txtCountry, "Country") &&
                TravelExpertsClassLib.Validator.IsPresentWeb(txtHomePhone, "Home Phone") &&
                TravelExpertsClassLib.Validator.IsPresent(txtEmail, "Email") &&
                TravelExpertsClassLib.Validator.IsEmailWeb(txtEmail, "Email");

        }

    }
}