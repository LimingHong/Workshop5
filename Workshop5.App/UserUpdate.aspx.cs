using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class UserUpdate : System.Web.UI.Page
    {
        private List<Agents> allAgents = AgentsDB.GetAllAgents();

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
                    uxFirstName.Text = currentUser.CustFirstName;
                    uxLastName.Text = currentUser.CustLastName;
                    uxCity.Text = currentUser.CustCity;
                    uxAddress.Text = currentUser.CustAddress;
                    uxProv.Text = currentUser.CustProv;
                    uxPostal.Text = currentUser.CustPostal;
                    uxHomePhone.Text = currentUser.CustHomePhone;
                    uxBusPhone.Text = currentUser.CustBusPhone;
                    uxUsername.Text = currentUser.username;
                    uxEmail.Text = currentUser.CustEmail;
                    string firstName = currentUser.CustFirstName;
                    string lastName = currentUser.CustLastName;
                    uxUserNameTitle.InnerText = FullNameCap(firstName, lastName);
                    uxAgentId.DataSource = allAgents;
                    uxAgentId.DataValueField = "AgentId";
                    uxAgentId.DataTextField = "AgtFullName";
                    uxAgentId.DataBind();
                }
            }
        }
        protected void uxCancel_Click(object sender, EventArgs e)
        {
            uxAddress.Text =
                uxBusPhone.Text =
                    uxCity.Text =
                        uxEmail.Text =
                            uxFirstName.Text =
                                uxHomePhone.Text =
                                    uxLastName.Text =
                                        uxPassword.Text =
                                            uxPostal.Text =
                                                uxProv.Text =
                                                    uxUsername.Text =
                                                        uxRePassword.Text = "";
            Response.Redirect("UserProfile.aspx");

        }

        protected void uxUpdateBtn_Click(object sender, EventArgs e)
        {

            if (
                Validator.IsPresent(uxFirstName.Text.Trim(), "First Name") &&
                Validator.IsPresent(uxLastName.Text.Trim(), "Last Name") &&
                Validator.IsPresent(uxPostal.Text.Trim(), "Postal Code") &&
                Validator.IsPresent(uxProv.Text.Trim(), "Province") &&
                Validator.IsPresent(uxUsername.Text.Trim(), "User Name") &&
                Validator.IsPresent(uxPassword.Text.Trim(), "Password") &&
                Validator.IsNameValid(uxFirstName.Text.Trim(), "First Name") &&
                Validator.IsNameValid(uxLastName.Text.Trim(), "Last Name") &&
                Validator.IsPostalValid(uxPostal.Text.Trim(), "Postal Code") &&
                Validator.IsStateValid(uxProv.Text.Trim(), "Province") &&
                Validator.IsPasswordValid(uxPassword.Text.Trim(), "Password")
                )
            {
                try
                {

                    Customers customer = new Customers();


                    customer.CustFirstName = uxFirstName.Text.Trim();
                    customer.CustLastName = uxLastName.Text.Trim();
                    customer.CustAddress = uxAddress.Text.Trim();
                    customer.CustCity = uxCity.Text.Trim();
                    customer.CustProv = uxProv.Text.Trim();
                    customer.CustPostal = uxPostal.Text.Trim();
                    customer.CustHomePhone = uxHomePhone.Text.Trim();

                    if (String.IsNullOrEmpty(uxBusPhone.Text.Trim()))
                    {
                        customer.CustBusPhone = null;
                    }
                    else
                    {
                        customer.CustBusPhone = uxBusPhone.Text;
                    }


                    if (String.IsNullOrEmpty(uxEmail.Text.Trim()))
                    {
                        customer.CustEmail = null;
                    }
                    else
                    {
                        customer.CustEmail = uxEmail.Text;
                    }

                    customer.AgentId = uxAgentId.SelectedIndex;

                    customer.username = uxUsername.Text;
                    customer.userPass = uxPassword.Text;

                    CustomersDB.UpdateCustomer(customer);
                    Session["validUser"] = customer;
                    HttpCookie cookie = null; //create a vaireble on stack and store null reference
                    cookie = new HttpCookie("customerName"); // create customer obj
                    cookie.Expires = DateTime.Now.AddMinutes(30);
                    cookie.Value = $"{customer.CustFirstName}{customer.CustLastName}";
                    Response.Cookies.Add(cookie);

                    // add customer object to session
                    // var cust = CustomerManager.Find(uxFirstName.Text, uxLastName.Text);
                    // Session.Add("customer", cust);
                    var customerID = CustomersDB.GetCustomerId(uxFirstName.Text, uxLastName.Text);
                    cookie = new HttpCookie("customerID");
                    cookie.Expires = DateTime.Now.AddMinutes(30);
                    cookie.Value = $"{customerID}";
                    Response.Cookies.Add(cookie);

                    Response.Write(
                        "<script language='javascript'>window.alert('Update Complete');window.location='UserProfile.aspx';</script>");



                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message, ex.GetType().ToString());
                    MessageBox.Show(ex.ToString());
                }

            }

        }
    }
}