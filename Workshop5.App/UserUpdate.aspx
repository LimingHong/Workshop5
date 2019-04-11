<%@ Page Title="UserUpdate" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserUpdate.aspx.cs" Inherits="Workshop5.App.UserUpdate" %>
<asp:Content ID="UserUpdate" ContentPlaceHolderID="MainContent" runat="server">
    
<div id="main" class="wrapper style1 " style="background-color: black;">
					<div class="container" >
						<header class="major">
							<h2>Update <span runat="server" id="uxUserNameTitle"></span> Information</h2>
							<p>Please fill in this form to update your account.</p>
						</header>

						<!-- Form -->
							<section>
								<form id="update-form" name="update-form" method="POST">
									<div class="row gtr-uniform gtr-50">

										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxFirstName" type="text" name="FirstName" value="" placeholder="First Name" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="uxFirstName" Display="Dynamic" ErrorMessage="First Name only use letter" ForeColor="Red" ValidationExpression="^[A-Za-z]{1,20}$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxFirstName" Display="Dynamic" ErrorMessage="First Name missing" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>
										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxLastName" type="text" name="LastName" value="" placeholder="Last Name" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="uxLastName" Display="Dynamic" ErrorMessage="Last name only use letter" ForeColor="Red" ValidationExpression="^[A-Za-z]{1,20}$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="uxLastName" Display="Dynamic" ErrorMessage="Last Name is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>

										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxAddress" type="text" name="Address" value="" placeholder="Address" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="uxAddress" Display="Dynamic" ErrorMessage="Address contain invalid character" ForeColor="Red" ValidationExpression="^[A-Za-z0-9'\.\-\s\,]{1,30}$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="uxAddress" Display="Dynamic" ErrorMessage="Address is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>
										
										<!-- city and prov --> 
										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxCity" type="text" name="City" value="" placeholder="City" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="uxCity" Display="Dynamic" ErrorMessage="Invalid city name" ForeColor="Red" ValidationExpression="^[A-Za-z]{1,20}$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="uxCity" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>

										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxProv" type="text" name="Province" value="" placeholder="Province" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="uxProv" ErrorMessage="Province use format AB" ForeColor="Red" ValidationExpression="^[A-Z][A-Z]$" Display="Dynamic"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uxProv" Display="Dynamic" ErrorMessage="Province is mssing" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>
										
										<!-- Post -->
										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxPostal" type="text" name="PostalCode" value="" placeholder="Postal Code" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="uxPostal" Display="Dynamic" ErrorMessage="Postal code T1T 1T1 format" ForeColor="Red" ValidationExpression="^[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="uxPostal" Display="Dynamic" ErrorMessage="Postal Code is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>
										
										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxBusPhone"  type="text" name="BusiPhone" value="" placeholder="Business Phone Number" runat="server"></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="uxBusPhone" Display="Dynamic" ErrorMessage="only number 4034004444" ForeColor="Red" ValidationExpression="^[0-9]{0,10}$"></asp:RegularExpressionValidator>
										</div>

										<div class="col-6 col-12-xsmall">
											<asp:TextBox ID="uxHomePhone" type="text" name="HomePhone" value="" placeholder="Home Phone Number" runat="server" ></asp:TextBox>
											<asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="uxHomePhone" Display="Dynamic" ErrorMessage="only number 4034004444" ForeColor="Red" ValidationExpression="^[0-9]{0,10}$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="uxHomePhone" Display="Dynamic" ErrorMessage="Home phone is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										</div>
										
										<div class="col-12">
											<asp:TextBox ID="uxEmail" type="text" name="Email" value="" placeholder="Email" runat="server" ></asp:TextBox>
										</div>
										
										<div class="col-12">
											<asp:TextBox ID="uxUsername" type="text" name="UserName" value="" placeholder="User Name" runat="server"></asp:TextBox>
											
                                        </div>
										
										<div class="col-12">
											<asp:TextBox ID="uxPassword" type="text" name="Password" value="" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>

											<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="uxPassword" Display="Dynamic" ErrorMessage="Need 1 number 1 letter and 6-15 digit long" ForeColor="Red" ValidationExpression="^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{4,15}$"></asp:RegularExpressionValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="uxPassword" Display="Dynamic" ErrorMessage="Password is missing" ForeColor="Red"></asp:RequiredFieldValidator>

										</div>
											
										<div class="col-12">
											<asp:TextBox ID="uxRePassword" type="text" name="RePassword" value="" placeholder="Confirm Password" runat="server" TextMode="Password"></asp:TextBox>

											<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="uxPassword" ControlToValidate="uxRePassword" ErrorMessage="Password does not match" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="uxRePassword" ErrorMessage="Re-tpye your password" ForeColor="Red"></asp:RequiredFieldValidator>

										</div>                                            

										<div class="col-12">
											<asp:DropDownList ID="uxAgentId" name="AgentSelect" placeholder="Select an agent" runat="server"></asp:DropDownList>
										</div>

										<div class="col-12">
											<ul class="actions">
												<li><asp:Button ID="uxUpdateBtn" Class="button primary fit" runat="server" Text="Update" OnClick="uxUpdateBtn_Click" /></li>
												<li><asp:Button ID="uxCancel" Class="button" runat="server" Text="Cancel" OnClick="uxCancel_Click" /></li>
											</ul>
										</div>
									</div>
								</form>

							</section>
					</div>
				</div>
</asp:Content>
