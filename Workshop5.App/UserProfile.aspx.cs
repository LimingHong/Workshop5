using System;
using System.Linq;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected string FullNameCap(string fname, string lname)
        {
            if (String.IsNullOrEmpty(fname) || String.IsNullOrEmpty(lname))
                throw new ArgumentException("Invalid Input, result failed ! Please use nonempty string");
            return fname.First().ToString().ToUpper() + fname.Substring(1) + " " + lname.First().ToString().ToUpper() + lname.Substring(1);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["validUser"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {


                    Customers currentUser = Session["validUser"] as Customers;
                    uxUserFirstnameInput.Value = currentUser.CustFirstName;
                    uxUserLastNameInput.Value = currentUser.CustLastName;
                    uxCityInput.Value = currentUser.CustCity;
                    uxUserAddress.Value = currentUser.CustAddress;
                    uxProvInput.Value = currentUser.CustProv;
                    uxPostalInput.Value = currentUser.CustPostal;
                    uxHomePhone.Value = currentUser.CustHomePhone;
                    uxBusiPhone.Value = currentUser.CustBusPhone;
                    uxUsernameInput.Value = currentUser.username;
                    uxEmailInput.Value = currentUser.CustEmail;
                    string firstName = currentUser.CustFirstName;
                    string lastName = currentUser.CustLastName;
                    uxUserFullNameTitle.InnerText = FullNameCap(firstName, lastName);

                    uxUserFirstnameInput.Attributes.Add("readonly", "true");
                    uxUserLastNameInput.Attributes.Add("readonly", "true");
                    uxCityInput.Attributes.Add("readonly", "true");
                    uxUserAddress.Attributes.Add("readonly", "true");
                    uxProvInput.Attributes.Add("readonly", "true");
                    uxPostalInput.Attributes.Add("readonly", "true");
                    uxHomePhone.Attributes.Add("readonly", "true");
                    uxBusiPhone.Attributes.Add("readonly", "true");
                    uxUsernameInput.Attributes.Add("readonly", "true");
                    uxEmailInput.Attributes.Add("readonly", "true");
                }

            }

        }


    }
}