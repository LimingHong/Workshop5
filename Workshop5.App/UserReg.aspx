<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserReg.aspx.cs" Inherits="Workshop5.App.UserReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div id="main" class="wrapper style1" style="background-attachment: fixed;
                                     background-color: #272833;
                                     background-image: url('../../assets/media/images/vegasDark.jpg');
     background-position: center center;
     background-size: cover;
     box-shadow: 0 0.25em 0.5em 0 rgba(0, 0, 0, 1);">
					<div class="container" >
						<header class="major">
							<h2>Registering User</h2>
							<p>Please fill in this form to create an account.</p>
						</header>

						<!-- Form -->
							<section>
                                <form id="register-form" name="register-form" method="POST">
									<div class="row gtr-uniform gtr-50">

										<div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxFirstName" type="text" name="FirstName" value="" placeholder="First Name" runat="server"></asp:TextBox>
										</div>
										<div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxLastName" type="text" name="LastName" value="" placeholder="Last Name" runat="server"></asp:TextBox>
										</div>

                                        <div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxAddress" type="text" name="Address" value="" placeholder="Address" runat="server"></asp:TextBox>
                                        </div>
                                        
                                        <!-- city and prov --> 
                                        <div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxCity" type="text" name="City" value="" placeholder="City" runat="server"></asp:TextBox>
                                        </div>

                                        <div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxProv" type="text" name="Province" value="" placeholder="Province" runat="server"></asp:TextBox>
                                        </div>
                                        
                                        <!-- Post -->
                                        <div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxPostal" type="text" name="PostalCode" value="" placeholder="Postal Code" runat="server"></asp:TextBox>
                                        </div>
                                        
                                        <div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxBusPhone"  type="text" name="BusiPhone" value="" placeholder="Business Phone Number" runat="server"></asp:TextBox>
                                        </div>

                                        <div class="col-6 col-12-xsmall">
                                            <asp:TextBox ID="uxHomePhone" type="text" name="HomePhone" value="" placeholder="Home Phone Number" runat="server"></asp:TextBox>
                                        </div>
                                        
                                        <div class="col-12">
                                            <asp:TextBox ID="uxEmail" type="text" name="Email" value="" placeholder="Email" runat="server"></asp:TextBox>
                                        </div>
                                        
                                        <div class="col-12">
                                            <asp:TextBox ID="uxUsername" type="text" name="UserName" value="" placeholder="User Name" runat="server"></asp:TextBox>
                                        </div>
                                        
                                        <div class="col-12">
                                            <asp:TextBox ID="uxPassword" type="text" name="Password" value="" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        </div>
                                            
                                        <div class="col-12">
                                            <asp:TextBox ID="uxRePassword" type="text" name="RePassword" value="" placeholder="Confirm Password" runat="server" TextMode="Password"></asp:TextBox>
                                        </div>                                            

										<div class="col-12">
                                            <asp:DropDownList ID="uxAgentId" name="AgentSelect" placeholder="Select an agent" runat="server"></asp:DropDownList>
										</div>

										<div class="col-12">
											<ul class="actions">
												<li><asp:Button ID="uxRegisterBtn" Class="button primary fit" runat="server" Text="Register" OnClick="uxRegisterBtn_Click" /></li>
												<li><asp:Button ID="uxCancel" Class="button" runat="server" Text="Cancel" OnClick="uxCancel_Click" /></li>
											</ul>
										</div>
									</div>
								</form>

							</section>
					</div>
    			</div>
    

<%--<form id="register-form" name="register-form" method="POST">
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
    
    

</asp:Content>
