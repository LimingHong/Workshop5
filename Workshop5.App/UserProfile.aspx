<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="Workshop5.App.UserProfile" %>
<asp:Content ID="Profile" ContentPlaceHolderID="MainContent" runat="server">

    <div id="main" class="wrapper style1" style="background-attachment: fixed;
                                     background-color: #272833;
                                     background-image: url('../../assets/media/images/vegasDark.jpg');
                                     background-position: center center;
                                     background-size: cover;
                                     box-shadow: 0 0.25em 0.5em 0 rgba(0, 0, 0, 1);">
    
    <div class="container" >
    <header class="major">
        <h2>User Profile</h2>
        <p>All Information are of current status.</p>
    </header>
    <section class="container emp-profile">
            <form method="post">
                <div class="row">
                    <div class="col-md-4">
                        <div class="profile-img" >
                            <img src="https://images.unsplash.com/photo-1554963984-67eb1b95f33f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" alt=""/>
                            <div class="file btn btn-lg btn-primary" style="color: white; cursor: pointer;">
                                Change Photo 
                                <input type="file" name="file" style="cursor: pointer;"/>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="profile-head">
                                    <h2 class="BlackLabel" id="uxUserFullNameTitle" runat="server">
                                        testing
                                    </h2>
                                    <h4 class="BlackLabel">
                                        Role: <br/>
                                        Customer
                                    </h4>
                                    <p class="proile-rating" style="font-weight: 700; color: black;">RANKINGS : <span>8/10</span></p>
                            <ul class="navProfile nav-tabs" id="myTab" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">About</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Timeline</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-2">
                        <a href="UserUpdate.aspx" class="inputEdit" > Edit Profile </a>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="profile-work">
                            <p>WORK LINK</p>
                            <a href="">Website Link</a><br/>
                            <a href="">Bootsnipp Profile</a><br/>
                            <a href="">Bootply Profile</a>
                            <p>SKILLS</p>
                            <a href="">Web Designer</a><br/>
                            <a href="">Applicaion Developer</a><br/>
                            <a href="">WordPress</a><br/>
                            <a href="">Boostrap</a><br/>
                            <a href="">PHP, ASP.Net</a><br/>
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="tab-content profile-tab" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">First Name</label>
                                            </div>
                                            <div class="col-md-6">
                                         <input class="inputEdit" id="uxUserFirstnameInput" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Last Name</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxUserLastNameInput" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Last Name</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxUserAddress" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">City</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxCityInput" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Province</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxProvInput" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Postal Code</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxPostalInput" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                
                                
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Home Phone</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxHomePhone" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Business Phone</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxBusiPhone" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>
                                
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Email</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxEmailInput" type="text"  value="" runat="server"/>
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-6">
                                                <label class="BlackLabel">Username</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input class="inputEdit" id="uxUsernameInput" type="text"  value="" runat="server"/>

                                            </div>
                                        </div>
                            
                        </div>
                    </div>
                </div>
            </div>
            </form> 
        </section>
    </div>
    </div>
</asp:Content>
