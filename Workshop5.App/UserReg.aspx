<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserReg.aspx.cs" Inherits="Workshop5.App.UserReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<form id="register-form" name="register-form" method="POST">
    <table>
 <tr>
     <td>
         First Name
     </td>
     <td>
         <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox>
     </td>
 </tr>   
    <tr>
        <td>
            Last Name
        </td>
        <td>
            <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox>
        </td>
    </tr>   
    <tr>
        <td>
            Address
        </td>
        <td>
            <asp:TextBox ID="uxAddress" runat="server"></asp:TextBox>
        </td>
    </tr>   
    <tr>
        <td>
            City
        </td>
        <td>
            <asp:TextBox ID="uxCity" runat="server"></asp:TextBox>
        </td>
    </tr>   
    <tr>
        <td>
            Province
        </td>
        <td>
            <asp:TextBox ID="uxProv" runat="server"></asp:TextBox>
        </td>
    </tr>   
    <tr>
        <td>
            Postal Code
        </td>
        <td>
            <asp:TextBox ID="uxPostal" runat="server"></asp:TextBox>
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
        </td>
    </tr>   
    <tr>
        <td>
            User Password
        </td>
        <td>
            <asp:TextBox ID="uxPassword" runat="server"></asp:TextBox>
        </td>
    </tr>   
    <tr>
        <td>
            Re-password
        </td>
        <td>
            <asp:TextBox ID="uxRePassword" runat="server"></asp:TextBox>
        </td>
    </tr>   
  


</table>    
</form>
    <%--<asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" />   --%> 
    <asp:Button ID="uxRegisterBtn" Class="btn btn-primary" runat="server" Text="Register" OnClick="uxRegisterBtn_Click" />
    

</asp:Content>
