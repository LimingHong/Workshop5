<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Workshop5.App.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main" class="wrapper style1">
					<div class="container">
						<header class="major">
							<h2>About Us</h2>
							<p>Ipsum dolor feugiat aliquam tempus sed magna lorem consequat accumsan</p>
						</header>
						<div class="row gtr-150">
							<div class="col-4 col-12-medium">

								<!-- Sidebar -->
									<section id="sidebar">
										<section>
                                            <a href="#" class="image fit"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/japan.jpg") %>"  alt="" /></a>
											<h3>Magna Feugiat</h3>
											<p>Sed tristique purus vitae volutpat commodo suscipit amet sed nibh. Proin a ullamcorper sed blandit. Sed tristique purus vitae volutpat commodo suscipit ullamcorper commodo suscipit amet sed nibh. Proin a ullamcorper sed blandit..</p>
											<footer>
												<ul class="actions">
													<li><a href="#" class="button">Learn More</a></li>
												</ul>
											</footer>
										</section>
										<hr />
										<section>
											<a href="#" class="image fit"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/banffTour.jpg") %>"  alt="" /></a>
											<h3>Top Ten Ranked Travel Company</h3>
											<p>
                                                Spears Travel/Travel Leaders has been assisting travelers since 1958 in both Bartlesville and Tulsa Oklahoma. We are a leader in both leisure and business travel. Spears is part of the Travel Leaders Group who was recently again named among the Top 10 on the Travel Weekly Power List. As professional travel agents, travel is our passion and our life work. It’s what we do all day every day. </p>
											<footer>
												<ul class="actions">
													<li><a href="#" class="button">Learn More</a></li>
												</ul>
											</footer>
										</section>
									</section>

							</div>
							<div class="col-8 col-12-medium imp-medium">

								<!-- Content -->
									<section id="content">
										<a href="#" class="image fit"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/Auckland.png") %>" alt="" /></a>
										<h3>Dolore Amet Consequat</h3>
										<p>Aliquam massa urna, imperdiet sit amet mi non, bibendum euismod est. Curabitur mi justo, tincidunt vel eros ullamcorper, porta cursus justo. Cras vel neque eros. Vestibulum diam quam, mollis at magna consectetur non, malesuada quis augue. Morbi tincidunt pretium interdum est. Curabitur mi justo, tincidunt vel eros ullamcorper, porta cursus justo. Cras vel neque eros. Vestibulum diam.</p>
										<p>Vestibulum diam quam, mollis at consectetur non, malesuada quis augue. Morbi tincidunt pretium interdum. Morbi mattis elementum orci, nec dictum porta cursus justo. Quisque ultricies lorem in ligula condimentum, et egestas turpis sagittis. Cras ac nunc urna. Nullam eget lobortis purus. Phasellus vitae tortor non est placerat tristique.</p>
										<h3>Sed Magna Ornare</h3>
										<p>In vestibulum massa quis arcu lobortis tempus. Nam pretium arcu in odio vulputate luctus. Suspendisse euismod lorem eget lacinia fringilla. Sed sed felis justo. Nunc sodales elit in laoreet aliquam. Nam gravida, nisl sit amet iaculis porttitor, risus nisi rutrum metus.</p>
										<ul>
											<li>Faucibus orci lobortis ac adipiscing integer.</li>
											<li>Col accumsan arcu mi aliquet placerat.</li>
											<li>Lobortis vestibulum ut magna tempor massa nascetur.</li>
											<li>Blandit massa non blandit tempor interdum.</li>
											<li>Lacinia mattis arcu nascetur lobortis.</li>
										</ul>
									</section>

							</div>
						</div>
					</div>
				</div>
</asp:Content>
