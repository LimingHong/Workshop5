<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Workshop5.App.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main" class="wrapper style1" style="
                                     background-attachment: fixed;
                                     background-color: #272833;
                                     background-image: url('../../assets/media/images/camping.png');
                                     background-position: center center;
                                     background-size: cover;
                                     box-shadow: 0 0.25em 0.5em 0 rgba(0, 0, 0, 1);
                                 ">
        

					<div class="container">
						<header class="major">
							<h2>Let's Start a Conversation</h2>
							<p>At Travel Experts, quality and service go hand-in-hand. We go above and beyond to ensure these two hallmarks are met at every step of your journey. To help achieve these core values, we closely monitor client satisfaction and are consistently seeking new ways to exceed our clients’ expectations. </p>
						</header>

						<!-- Form -->
							<section>
								<form method="post" action="#">
									<div class="row gtr-uniform gtr-50">
										<div class="col-6 col-12-xsmall">
											<input type="text" name="fullname" id="fullname" value="" placeholder="Full Name">
										</div>
										<div class="col-6 col-12-xsmall">
											<input type="email" name="email" id="email" value="" placeholder="Email">
										</div>
										<div class="col-12">
											<select name="category" id="category">
												<option value="">- Department -</option>
												<option value="1">Management</option>
												<option value="1">Customer Service</option>
												<option value="1">Administration</option>
												<option value="1">Human Resources</option>
											</select>
										</div>
										<div class="col-4 col-12-medium">
											<input type="radio" id="priority-low" name="priority" checked="">
											<label for="priority-low">Low Priority</label>
										</div>
										<div class="col-4 col-12-medium">
											<input type="radio" id="priority-normal" name="priority">
											<label for="priority-normal">Normal Priority</label>
										</div>
										<div class="col-4 col-12-medium">
											<input type="radio" id="priority-high" name="priority">
											<label for="priority-high">High Priority</label>
										</div>
										<div class="col-6 col-12-medium">
											<input type="checkbox" id="copy" name="copy">
											<label for="copy">Email me a copy of this message</label>
										</div>

										<div class="col-12">
											<textarea name="message" id="message" placeholder="Enter your message" rows="6"></textarea>
										</div>
										<div class="col-12">
											<ul class="actions">
												<li><input type="submit" value="Send Message" class="primary"></li>
												<li><input type="reset" value="Reset"></li>
											</ul>
										</div>
									</div>
								</form>
							</section>
					</div>
				</div>
</asp:Content>
