<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateUserAcc.aspx.cs" Inherits="Workshop5.App.UpdateUserAcc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
       
<div id="main" class="wrapper style1 " style="background-color: black;">
					<div class="container" >
						<header class="major">
							<h2>Update <span runat="server" id="uxUserNameTitle"></span> Information</h2>
							<p>Please fill in this form to update your account.</p>
						</header>

						<!-- Form -->
							<section>
									    <div class="row gtr-uniform gtr-50">

										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxFirstNameUp" type="text" name="FirstName" placeholder="First Name" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="uxFirstNameUp" Display="Dynamic" ErrorMessage="First Name only use letter" ForeColor="Red" ValidationExpression="^[A-Za-z]{1,20}$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uxFirstNameUp" Display="Dynamic" ErrorMessage="First Name missing" ForeColor="Red"></asp:RequiredFieldValidator>
										    
                                            </div>
										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxLastNameUp" type="text" name="LastName" placeholder="Last Name" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="uxLastNameUp" Display="Dynamic" ErrorMessage="Last name only use letter" ForeColor="Red" ValidationExpression="^[A-Za-z]{1,20}$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="uxLastNameUp" Display="Dynamic" ErrorMessage="Last Name is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										    </div>

										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxAddressUp" type="text" name="Address" placeholder="Address" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="uxAddressUp" Display="Dynamic" ErrorMessage="Address contain invalid character" ForeColor="Red" ValidationExpression="^[A-Za-z0-9'\.\-\s\,]{1,30}$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="uxAddressUp" Display="Dynamic" ErrorMessage="Address is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										    </div>
										    
										    <!-- city and prov --> 
										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxCityUp" type="text" name="City"  placeholder="City" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="uxCityUp" Display="Dynamic" ErrorMessage="Invalid city name" ForeColor="Red" ValidationExpression="^[A-Za-z]{1,20}$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="uxCityUp" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
										    </div>

										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxProvUp" type="text" name="Province" placeholder="Province" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="uxProvUp" ErrorMessage="Province use format AB" ForeColor="Red" ValidationExpression="^[A-Z][A-Z]$" Display="Dynamic"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uxProvUp" Display="Dynamic" ErrorMessage="Province is mssing" ForeColor="Red"></asp:RequiredFieldValidator>
										    </div>
										    
										    <!-- Post -->
										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxPostalUp" type="text" name="PostalCode"  placeholder="Postal Code" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="uxPostalUp" Display="Dynamic" ErrorMessage="Postal code T1T 1T1 format" ForeColor="Red" ValidationExpression="^[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="uxPostalUp" Display="Dynamic" ErrorMessage="Postal Code is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										    </div>
										    
										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxBusPhoneUp"  type="text" name="BusiPhone"  placeholder="Business Phone Number" runat="server"></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="uxBusPhoneUp" Display="Dynamic" ErrorMessage="only number 4034004444" ForeColor="Red" ValidationExpression="^[0-9]{0,10}$"></asp:RegularExpressionValidator>
										    </div>

										    <div class="col-6 col-12-xsmall">
											    <asp:TextBox ID="uxHomePhoneUp" type="text" name="HomePhone" placeholder="Home Phone Number" runat="server" ></asp:TextBox>
											    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="uxHomePhoneUp" Display="Dynamic" ErrorMessage="only number 4034004444" ForeColor="Red" ValidationExpression="^[0-9]{0,10}$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="uxHomePhoneUp" Display="Dynamic" ErrorMessage="Home phone is missing" ForeColor="Red"></asp:RequiredFieldValidator>
										    </div>
										    
										    <div class="col-12">
											    <asp:TextBox ID="uxEmailUp" type="text" name="Email" placeholder="Email" runat="server" ></asp:TextBox>
										    </div>
										    
										    <div class="col-12">
											    <asp:TextBox ID="uxUsernameUp" type="text" name="UserName" placeholder="User Name" runat="server"></asp:TextBox>
											    
                                            </div>
                                            <div class="col-12">
                                                <asp:TextBox ID="uxOldPassUp" type="text" name="OldPassword" placeholder="Old Password" runat="server" TextMode="Password"></asp:TextBox>

                                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="uxOldPass" Display="Dynamic" ErrorMessage="Need 1 number 1 letter and 6-15 digit long" ForeColor="Red" ValidationExpression="^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{4,15}$"></asp:RegularExpressionValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="uxOldPass" Display="Dynamic" ErrorMessage="Password is missing" ForeColor="Red"></asp:RequiredFieldValidator>--%>

                                            </div>
										    <div class="col-12">
											    <asp:TextBox ID="uxPasswordUp" type="text" name="Password" placeholder="Password"  runat="server" TextMode="Password"></asp:TextBox>

											    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="uxPassword" Display="Dynamic" ErrorMessage="Need 1 number 1 letter and 6-15 digit long" ForeColor="Red" ValidationExpression="^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{4,15}$"></asp:RegularExpressionValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="uxPassword" Display="Dynamic" ErrorMessage="Password is missing" ForeColor="Red"></asp:RequiredFieldValidator>--%>

										    </div>
											    
										    <div class="col-12">
											    <asp:TextBox ID="uxRePasswordUp" type="text" name="RePassword" placeholder="Confirm Password"  runat="server" TextMode="Password"></asp:TextBox>

											    <%--<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="uxPassword" ControlToValidate="uxRePassword" ErrorMessage="Password does not match" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
											    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="uxRePassword" ErrorMessage="Re-tpye your password" ForeColor="Red"></asp:RequiredFieldValidator>--%>

										    </div>                                            
                                            
									    </div>
										    
                                <div class="col-12">
                                    <ul class="actions">
                                        <li><asp:Button ID="uxUpdateBtn"  Class="button primary fit" Text="Update" runat="server" OnClick="uxUpdateBtn_Click" UseSubmitBehavior="False"/></li>
                                        <li><asp:Button ID="uxCancel" Class="button" runat="server" Text="Cancel"  CausesValidation="False" OnClick="uxCancel_Click"/></li>
                                    </ul>
                                </div>
							</section>
					</div>
				</div>
</asp:Content>
