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
		    <li><a runat="server" href="~/Service.aspx">Learn More</a></li>
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
		    <li><a runat="server" href="~/Service.aspx">Learn More</a></li>
	    </ul>
    </div>
    <a href="#four" class="goto-next scrolly">Next</a>
    </section>
    
    

    <!-- Edit Below -->

    <!-- Four -->
    <section id="four" class="spotlight style2 right">
        <span class="image fit main"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/social.jpg") %>" alt="" /></span>
        <div class="content">
            <header>
                <h2>Friends Reuion</h2>
                <p>The Best Places To Plan A Getaway With Your Long Distance BFFs</p>
            </header>
            <p>
                For the crew who want to live like they never left college, New Orleans is the perfect meetup. And beyond the obvious awesomeness of Mardi Gras, JazzFest, and the French Quarter, there's plenty more to see and do (and eat!). It's just as much fun in winter as it is in the summer, with the Lake Placid Olympic Sports Complex offering the experience of your dreams.
            </p>
            
            <ul class="actions">
                
                <li><a runat="server" href="~/Service.aspx">Learn More</a></li>
            </ul>
        </div>
        <a href="#three" class="goto-next scrolly">Next</a>
    </section>
    

    <!-- Five -->
    <section id="five" class="spotlight style3 left">
        <span class="image fit main bottom"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/NorthernLight.jpg") %>" alt="" /></span>
        <div class="content">
            <header>
                <h2>Aurora</h2>
                <p>Aurora australis, The Northern Light </p>
            </header>
            <p>
                The resulting ionization and excitation of atmospheric constituents emits light of varying color and complexity. The form of the aurora, occurring within bands around both polar regions, is also dependent on the amount of acceleration imparted to the precipitating particles. Precipitating protons generally produce optical emissions as incident hydrogen atoms after gaining electrons from the atmosphere. Proton auroras are usually observed at lower latitudes.
            </p>
            <ul class="actions">
                <li><a runat="server" href="~/Service.aspx">Learn More</a></li>
            </ul>
        </div>
        <a href="#four" class="goto-next scrolly">Next</a>
    </section>
    
    <!-- Six -->
    <section id="six" class="spotlight style2 right">
        <span class="image fit main"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/SpainBeach.jpg") %>" alt="" /></span>
        <div class="content">
            <header>
                <h2>Ibiza</h2>
                <p>Island in the Mediterranean Sea</p>
            </header>
            <p>
                Ibiza is one of the Balearic islands, an archipelago of Spain in the Mediterranean Sea. It's well known for the lively nightlife in Ibiza Town and Sant Antoni, where major European nightclubs have summer outposts. It’s also home to quiet villages, yoga retreats and beaches, from Platja d'en Bossa, lined with hotels, bars and shops, to quieter sandy coves backed by pine-clad hills found all around the coast.
            </p>
            <ul class="actions">
                <li><a runat="server" href="~/Service.aspx">Learn More</a></li>
            </ul>
        </div>
        <a href="#three" class="goto-next scrolly">Next</a>
    </section>
    
    <!-- Seven -->
    <section id="seven" class="spotlight style3 left">
        <span class="image fit main bottom"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/DivingRedSea.jpg") %>" alt="" /></span>
        <div class="content">
            <header>
                <h2>Erythraean Sea</h2>
                <p>Barka River, Haddas River</p>
            </header>
            <p>
                The Red Sea is between arid land, desert and semi-desert. Reef systems are better developed along the Red Sea mainly because of its greater depths and an efficient water circulation pattern. The Red Sea water mass-exchanges its water with the Arabian Sea, Indian Ocean via the Gulf of Aden. These physical factors reduce the effect of high salinity caused by evaporation in the north and relatively hot water in the south.
            </p>
            <ul class="actions">
                <li><a runat="server" href="~/Service.aspx">Learn More</a></li>
            </ul>
        </div>
        <a href="#four" class="goto-next scrolly">Next</a>
    </section>
    
    <section id="eight" class="spotlight style1 bottom">

        <span class="image fit main"><img src="<%=VirtualPathUtility.ToAbsolute("~/assets/media/images/CliffDive.jpg") %>" alt="" /></span>

        <div class="content">
            <div class="container">
                <div class="row">
                    <div class="col-4 col-12-medium">
                        <header>
                            <h2>Philippines</h2>
                            <p>Get Ready for a Season Open of the Red Bull cliff diving championship</p>
                        </header>
                    </div>
                    <div class="col-4 col-12-medium">
                        <p>
                            Stunning scenery awaits the world's best cliff divers as they leap into the 11th season of the Red Bull Cliff Diving World Series in El Nido; a first-time location on the calendar. The 24 athletes will face the challenge of an off-the-cliff competition right in the first event of the year, while at the same time they will be welcomed by dazzlingly clear emerald waters.
                        </p>
                    </div>
                    <div class="col-4 col-12-medium">
                        <p>
                            Whether the reigning champions Rhiannan Iffland (AUS) and Gary Hunt (GBR) will continue where they left off in 2018 and can find the right formula to defend the King Kahekili Trophy against the increased competition will soon be witnessed by turtles and kayakers around the limestone formations of the Small and Big Lagoon on Miniloc Island.
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <a href="#two" class="goto-next scrolly">Next</a>
    </section>


</asp:Content>
