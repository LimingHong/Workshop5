<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerSignUp.aspx.cs" Inherits="Workshop5.App.CustomerSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
    <div class="container" style="padding: 8vh 15vw 3vh 15vw;">

        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputFirstName" class="LeftLabel">First Name</label>
                <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="uxFirstName" Display="Dynamic" ErrorMessage="First Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group col-md-6">
                <label for="inputLastName" class="LeftLabel">Last Name</label>
                <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxLastName" Display="Dynamic" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        

        <div class="form-group">
            <label for="inputAddress" class="LeftLabel">Address</label>
            <asp:TextBox ID="uxAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="uxAddress" ErrorMessage="Address is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        
        
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputCity" class="LeftLabel">City</label>
                <asp:TextBox ID="uxCity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="uxCity" ErrorMessage="City is reuired" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group col-md-4">
                <label for="inputProvince" class="LeftLabel">Province</label>
                <asp:TextBox ID="uxProv" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uxProv" ErrorMessage="Province is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            
            <div class="form-group col-md-2">
                <label for="inputPostalCode" class="LeftLabel">Postal Code</label>
                 <asp:TextBox ID="uxPostal" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="uxPostal" Display="Dynamic" ErrorMessage="Postal Code is required" ForeColor="Red"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="uxPostal" ErrorMessage="Use T1T 1T1 Format " ValidationExpression="^[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
        </div>
        
        <div class="form-group">            
            <label for="inputHomePhone" class="LeftLabel">Home Phone</label>
            <asp:TextBox ID="uxHomePhone" runat="server"></asp:TextBox>
        </div>
            
        <div class="form-group">           
            <label for="inputBusinessPhone" class="LeftLabel">Business Phone</label>
             <asp:TextBox ID="uxBusPhone" runat="server"></asp:TextBox>
        </div>
            
        <div class="form-group">           
            <label for="inputEmail" class="LeftLabel">Email</label>
            <asp:TextBox ID="uxEmail" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">           
            <label for="inputAgentId" class="LeftLabel">AgentId</label>
             <asp:TextBox ID="uxAgentId" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group">           
            <label for="inputUsername" class="LeftLabel">Username</label>
            <asp:TextBox ID="uxUsername" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="uxUsername" ErrorMessage="The username can only have letters and numbers" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9]*$" ViewStateMode="Enabled"></asp:RegularExpressionValidator>

        </div>
        
     <div class="form-group">                  
         <label for="inputPassword" class="LeftLabel">Password</label>
         <asp:TextBox ID="uxPassword" runat="server" TextMode="Password"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="uxPassword" ErrorMessage="Need 1 number 1 letter and 6-15 digit long" ForeColor="Red" ValidationExpression="^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{4,15}$"></asp:RegularExpressionValidator>
    </div>

      <div class="form-group">       
         <label for="inputRepassword" class="LeftLabel">Re-password</label>
         <asp:TextBox ID="uxRePassword" runat="server" TextMode="Password"></asp:TextBox>
         <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="uxPassword" ControlToValidate="uxRePassword" Display="Dynamic" ErrorMessage="The password doesn't match" ForeColor="Red"></asp:CompareValidator>
      </div>

        <asp:Button ID="uxSignUp" runat="server" Text="Sign Up" OnClick="uxSignUp_Click" />
   
    </div> <!-- for div.container -->
    </section>
</asp:Content>
