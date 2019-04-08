<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerSignUp.aspx.cs" Inherits="Workshop5.App.CustomerSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class ="table" style="height: 561px">
<tr>
    <td>
        First Name
    </td>
     <td>
         <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="uxFirstName" Display="Dynamic" ErrorMessage="First Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>

<tr>
    <td>
        Last Name
    </td>
     <td>
         <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxLastName" Display="Dynamic" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>

<tr>
    <td>
        Address
    </td>
     <td>
         <asp:TextBox ID="uxAddress" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="uxAddress" ErrorMessage="Address is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        City
    </td>
     <td>
         <asp:TextBox ID="uxCity" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="uxCity" ErrorMessage="City is reuired" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        Province
    </td>
    <td>
        <asp:TextBox ID="uxProv" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uxProv" ErrorMessage="Province is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>

</tr>
<tr>
    <td>
        Postal Code
    </td>
     <td>
         <asp:TextBox ID="uxPostal" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="uxPostal" Display="Dynamic" ErrorMessage="Postal Code is required" ForeColor="Red"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="uxPostal" ErrorMessage="RegularExpressionValidator" ValidationExpression="^[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]$"></asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td>
       HomePhone
    </td>
     <td>
         <asp:TextBox ID="uxHomePhone" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        Business Phone
    </td>
     <td>
         <asp:TextBox ID="uxBusPhone" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
       Email
    </td>
     <td>
         <asp:TextBox ID="uxEmail" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
          AgentId
    </td>
     <td>
         <asp:TextBox ID="uxAgentId" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        Username
    </td>
     <td>
         <asp:TextBox ID="uxUsername" runat="server"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="uxUsername" ErrorMessage="The username can only have letters and numbers" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9]*$" ViewStateMode="Enabled"></asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td>
        User Password
    </td>
     <td>
         <asp:TextBox ID="uxPassword" runat="server" TextMode="Password"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="uxPassword" ErrorMessage="Need 1 number 1 letter and 6-15 digit long" ForeColor="Red" ValidationExpression="^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{4,15}$"></asp:RegularExpressionValidator>
    </td>
</tr>
        <tr>
            <td>
                Re-password
            </td>
            <td>
                <asp:TextBox ID="uxRePassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="uxPassword" ControlToValidate="uxRePassword" Display="Dynamic" ErrorMessage="The password doesn't match" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
<tr>
    <td class="modal-sm">
        <asp:Button ID="uxSignUp" runat="server" Text="Sign Up" OnClick="uxSignUp_Click" />
    </td>

</tr>
    </table>
        





</asp:Content>
