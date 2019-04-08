<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Workshop5.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Banner -->
    <section id="banner">
    <div class="content">
	    <header>
		    <h2>Seize Your Moment</h2>
		    <p>We strive to provide you the vocation of a lifetime.<br />
                Come and find your best travel experience with us!</p>
	    </header>
	    <span class="image" ><img style="transform: translate(0, 50%);" src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/travelExpertLogo.png") %>" alt="" /></span>

    </div>
    <a href="#one" class="goto-next scrolly">Next</a>
    </section>

    <!-- One -->
    <section id="one" class="spotlight style1 bottom">

    <span class="image fit main"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/india.jpg") %>" alt="" /></span>

    <div class="content">
	    <div class="container">
		    <div class="row">
			    <div class="col-4 col-12-medium">
				    <header>
					    <h2>Holi Festival of Colours</h2>
					    <p>A popular ancient Hindu festival of which originates from the Indian subcontinent</p>
				    </header>
			    </div>
			    <div class="col-4 col-12-medium">
				    <p>The Holi festival has a cultural significance among various Hindu traditions of the Indian subcontinent. It is the festive day to end and rid oneself of past errors, to end conflicts by meeting others, a day to forget and forgive. </p>
			    </div>
			    <div class="col-4 col-12-medium">
				    <p>Holi is an ancient Hindu religious festival which has become popular with non-Hindus as well in many parts of South Asia, as well as people of other communities outside Asia. In Mughal India, Holi was celebrated with such exuberance that commoners of all castes could throw colour on the Emperor.</p>
			    </div>
		    </div>
	    </div>
    </div>
    <a href="#two" class="goto-next scrolly">Next</a>
    </section>

    <!-- Two -->
    <section id="two" class="spotlight style2 right">
    <span class="image fit main"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/banffTour.jpg") %>" alt="" /></span>
    <div class="content">
	    <header>
		    <h2>Banff Adventure</h2>
		    <p>Banff National Park in Alberta, Canada</p>
	    </header>
	    <p>Banff is a resort town in the province of Alberta, located within Banff National Park. The peaks of Mt. Rundle and Mt. Cascade, part of the Rocky Mountains, dominate its skyline. On Banff Avenue, the main thoroughfare, boutiques and restaurants mix with château-style hotels and souvenir shops. The surrounding 6,500 square kilometres of parkland are home to wildlife including elk and grizzly bears.</p>
	    <ul class="actions">
		    <li><a href="#" class="button">Learn More</a></li>
	    </ul>
    </div>
    <a href="#three" class="goto-next scrolly">Next</a>
    </section>

    <!-- Three -->
    <section id="three" class="spotlight style3 left">
    <span class="image fit main bottom"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/norwayDiving.jpg") %>" alt="" /></span>
    <div class="content">
	    <header>
		    <h2>Killary Harbor</h2>
		    <p>Below our waves we're hiding amazing marine life, wrecks and reefs – worth diving in for</p>
	    </header>
	    <p>Want to know about diving in Ireland? Well, don't just take our word for it… Take Jacques Cousteau's. The underwater superhero was pretty descriptive in his enthusiasm: "Some of the best diving in the world is at the northern side of the Dingle Peninsula where the Atlantic Ocean meets the Brandon Mountains in a landscape of exceptional beauty."</p>
	    <ul class="actions">
		    <li><a href="#" class="button">Learn More</a></li>
	    </ul>
    </div>
    <a href="#four" class="goto-next scrolly">Next</a>
    </section>


</asp:Content>
