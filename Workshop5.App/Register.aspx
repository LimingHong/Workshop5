<%@ Page Title="Register" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.cs" Inherits="Workshop5.App.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <section id="banner">
        <div class="content">
         <h2 class="LeftLabel"><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4 class="LeftLabel">Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" HeaderText="* means that the field is required" CssClass="text-danger" />
         <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtFirstName" CssClass="col-md-2 control-label">First Name: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtFirstName" runat="server" ValidateRequestMode="Enabled" CssClass="form-control"></asp:TextBox>
                 &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="REValphaOnly" runat="server" ErrorMessage="Please enter only Letters." 
            ControlToValidate="txtFirstName" Display="Dynamic" ValidationExpression="^[a-zA-Z ]+$" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtLastName" CssClass="col-md-2 control-label">Last Name: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="REValphaOnly2" runat="server" ErrorMessage="Please enter only Letters." 
            ControlToValidate="txtLastName" Display="Dynamic" ValidationExpression="^[a-zA-Z ]+$" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtAddress" CssClass="col-md-2 control-label">Address: </asp:Label>
            <div class="col-md-10">
               <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCity" CssClass="col-md-2 control-label">City: </asp:Label>
            <div class="col-md-10">
               <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter only Letters." 
            ControlToValidate="txtCity" Display="Dynamic" ValidationExpression="^[a-zA-Z ]+$" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtProvince" CssClass="col-md-2 control-label">Province: </asp:Label>
            <div class="col-md-10">
                 <asp:TextBox ID="txtProvince" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtProvince" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter only Letters." 
            ControlToValidate="txtProvince" Display="Dynamic" ValidationExpression="^[a-zA-Z ]+$" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPostal" CssClass="col-md-2 control-label">Postal Code: </asp:Label>
            <div class="col-md-10">
               <asp:TextBox ID="txtPostal" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPostal" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPostal" Display="Dynamic" ErrorMessage="Invalid zip format. For example: R2R 1Q1" 
            ValidationExpression="\d{5}((-)?\d{4})?|([A-Za-z]\d[A-Za-z]( )?\d[A-Za-z]\d)" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCountry" CssClass="col-md-2 control-label">Country: </asp:Label>
            <div class="col-md-10">
                 <asp:TextBox ID="txtCountry" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCountry" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please enter only Letters." 
            ControlToValidate="txtCountry" Display="Dynamic" ValidationExpression="^[a-zA-Z ]+$" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtHomePhone" CssClass="col-md-2 control-label">Home Phone: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtHomePhone" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtHomePhone" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
               ControlToValidate="txtHomePhone" ErrorMessage="The format is not correct, example: (403)123-1234" 
               ValidationExpression="\(?\d{3}\)?-? *\d{3}-? *-?\d{4}" ForeColor="Red">
               </asp:RegularExpressionValidator>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtBusPhone" CssClass="col-md-2 control-label">Business Phone: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtBusPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-2 control-label">Email: </asp:Label>
            <div class="col-md-10">
                 <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtEmail" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>        
        &nbsp;<asp:RegularExpressionValidator ID="remail" runat="server" 
               ControlToValidate="txtEmail" ErrorMessage="The format for email is incorrect, example: ***@***.com" 
               ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red">
        </asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtUserName" CssClass="col-md-2 control-label">User Name: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtUserName" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:Label ID="lblUserName" runat="server"></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-md-2 control-label">Password: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtPassword" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="Regex5" runat="server" ControlToValidate="txtPassword"
             ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&amp;])[A-Za-z\d$@$!%*?&amp;]{8,50}"
             ErrorMessage="Password must contain: Minimum 8 and Maximum 10 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character. For example: PaSs@123"
             ForeColor="Red" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPasswordConfirm" CssClass="col-md-2 control-label">Confirm password: </asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPasswordConfirm" Display="Dynamic" ErrorMessage="Passwords must match" ForeColor="red"></asp:CompareValidator>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtPasswordConfirm" Display="Dynamic" Text="*" ForeColor="red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
        </div>
    </section>
</asp:Content>