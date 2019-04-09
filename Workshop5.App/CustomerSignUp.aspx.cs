using System;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class CustomerSignUp : System.Web.UI.Page
    {
        public void RegCust()
        {

            if (
                      Validator.IsNameValid(uxFirstName.Text, "First Name") &&
                      Validator.IsNameValid(uxLastName.Text, "Last Name") &&
                      Validator.IsPostalValid(uxPostal.Text, "Postal Code") &&
                      Validator.IsStateValid(uxProv.Text, "Province") &&
                      Validator.IsNameValid(uxUsername.Text, "User Name") &&
                      Validator.IsPasswordValid(uxPassword.Text, "Password"))
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


                    if (uxAgentId.Text.Trim() == "")
                        customer.AgentId = null;
                    else
                        customer.AgentId = Convert.ToInt16(uxAgentId.Text);



                    customer.username = uxUsername.Text;
                    customer.userPass = uxPassword.Text;



                    CustomersDB.AddCustomer(customer);
                    //HttpCookie cookie = null;//create a vaireble on stack and store null reference
                    //cookie = new HttpCookie("customerName"); // create customer obj
                    //cookie.Expires = DateTime.Now.AddMinutes(30);
                    //cookie.Value = $"{customer.CustFirstName}{customer.CustLastName}";
                    //Response.Cookies.Add(cookie);

                    //// add customer object to session
                    //// var cust = CustomerManager.Find(uxFirstName.Text, uxLastName.Text);
                    //// Session.Add("customer", cust);
                    //var customerID = CustomersDB.GetCustomerId(uxFirstName.Text, uxLastName.Text);
                    //cookie = new HttpCookie("customerID");
                    //cookie.Expires = DateTime.Now.AddMinutes(30);
                    //cookie.Value = $"{customerID}";
                    //Response.Cookies.Add(cookie);

                    Response.Write("<script language='javascript'>window.alert('Registration Complete');window.location='Default.aspx';</script>");



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        public void uxSignUp_Click(object sender, EventArgs e)
        {
            RegCust();
        }
    }
}