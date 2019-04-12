//Author: Liming Hong


using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class UserReg : System.Web.UI.Page
    {
        private List<Agents> allAgents = AgentsDB.GetAllAgents();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                uxAgentId.DataSource = allAgents;
                uxAgentId.DataValueField = "AgentId";
                uxAgentId.DataTextField = "AgtFullName";
                uxAgentId.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void uxRegisterBtn_Click(object sender, EventArgs e)
        {
            if (
                Validator.IsNameValid(uxFirstName.Text.Trim(), "First Name") &&
                     Validator.IsNameValid(uxLastName.Text.Trim(), "Last Name") &&
                     Validator.IsPostalValid(uxPostal.Text.Trim(), "Postal Code") &&
                     Validator.IsStateValid(uxProv.Text.Trim(), "Province") &&
                     Validator.IsNameValid(uxUsername.Text.Trim(), "User Name") &&
                     Validator.IsPasswordValid(uxPassword.Text.Trim(), "Password"))
            {
                try
                {

                    Customers customer = new Customers();


                    customer.CustFirstName = uxFirstName.Text;
                    customer.CustLastName = uxLastName.Text;
                    customer.CustAddress = uxAddress.Text;
                    customer.CustCity = uxCity.Text;
                    customer.CustProv = uxProv.Text;
                    customer.CustPostal = uxPostal.Text;
                    customer.CustHomePhone = uxHomePhone.Text;

                    if (uxBusPhone.Text.Trim() == "")
                    {
                        customer.CustBusPhone = "";
                    }
                    else
                        customer.CustBusPhone = uxBusPhone.Text;

                    if (uxEmail.Text.Trim() == "")
                    {
                        customer.CustEmail = "";
                    }
                    else
                        customer.CustEmail = uxEmail.Text;


                    customer.AgentId = uxAgentId.SelectedIndex;



                    customer.username = uxUsername.Text;
                    customer.userPass = uxPassword.Text;



                    CustomersDB.AddCustomer(customer);
                    HttpCookie cookie = null;//create a vaireble on stack and store null reference
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

                    Response.Write("<script language='javascript'>window.alert('Registration Complete');window.location='Default.aspx';</script>");



                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message, ex.GetType().ToString());
                    MessageBox.Show(ex.ToString());
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
            Response.Redirect("Default.aspx");

        }

        protected void uxHomePhone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void uxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}