<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista.Default" %>

<!DOCTYPE HTML>
<html>
	<head runat="server">
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title>Sena</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="Free HTML5 Website Template by freehtml5.co" />
	<meta name="keywords" content="free website templates, free html5, free template, free bootstrap, free website template, html5, css3, mobile first, responsive" />
	<meta name="author" content="freehtml5.co" />

  	<!-- Facebook and Twitter integration -->
	<%--<meta property="og:title" content=""/>
	<meta property="og:image" content=""/>
	<meta property="og:url" content=""/>
	<meta property="og:site_name" content=""/>
	<meta property="og:description" content=""/>
	<meta name="twitter:title" content="" />
	<meta name="twitter:image" content="" />
	<meta name="twitter:url" content="" />
	<meta name="twitter:card" content="" />--%>

	<link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700" rel="stylesheet">
	<link href="https://fonts.googleapis.com/css?family=Roboto+Slab:300,400" rel="stylesheet">
	
	<!-- Animate.css -->
	<%--<link rel="stylesheet" href="css/animate.css">--%>
    <link href="recursos/css/animate.css" rel="stylesheet" />
	<!-- Icomoon Icon Fonts-->
	<%--<link rel="stylesheet" href="css/icomoon.css">--%>
    <link href="recursos/css/icomoon.css" rel="stylesheet" />
	<!-- Bootstrap  -->
	<%--<link rel="stylesheet" href="css/bootstrap.css">--%>
    <link href="recursos/css/bootstrap.css" rel="stylesheet" />
	<!-- Magnific Popup -->
	<%--<link rel="stylesheet" href="css/magnific-popup.css">--%>
    <link href="recursos/css/magnific-popup.css" rel="stylesheet" />
	<!-- Owl Carousel  -->
	<%--<link rel="stylesheet" href="css/owl.carousel.min.css">--%>
    <link href="recursos/css/owl.carousel.min.css" rel="stylesheet" />
	<%--<link rel="stylesheet" href="css/owl.theme.default.min.css">--%>
    <link href="recursos/css/owl.theme.default.min.css" rel="stylesheet" />
	<!-- Flexslider  -->
	<%--<link rel="stylesheet" href="css/flexslider.css">--%>
    <link href="recursos/css/flexslider.css" rel="stylesheet" />
	<!-- Pricing -->
	<%--<link rel="stylesheet" href="css/pricing.css">--%>
    <link href="recursos/css/pricing.css" rel="stylesheet" />
	<!-- Theme style  -->
	<%--<link rel="stylesheet" href="css/style.css">--%>
    <link href="recursos/css/style.css" rel="stylesheet" />
	<!-- Modernizr JS -->
	<%--<script src="js/modernizr-2.6.2.min.js"></script>--%>
    <script src="recursos/js/modernizr-2.6.2.min.js"></script>
	<!-- FOR IE9 below -->
	<!--[if lt IE 9]>
	<script src="js/respond.min.js"></script>
	<![endif]-->

	</head>
	<body>
		<form id="form1" runat="server">
	<div class="fh5co-loader"></div>
	
	<div id="page">
	<nav class="fh5co-nav" role="navigation">
		<div class="top-menu">
			<div class="container">
				<div class="row">
					<div class="col-xs-3">
                        <img class="img-responsive" src="recursos/imagenes/logolimpiada.png" />
					</div>
					<div class="col-xs-9 text-right menu-1">
						<ul>
							<li class="active"><a href="index.html">Inicio</a></li>
							<li><a href="courses.html">Cursos</a></li>
							<li class="has-dropdown">
								<a href="blog.html">Simulador</a>
								<ul class="dropdown">
									<li><a href="#">Prueba tus conocimientos</a></li>
									<li><a href="#">eCommerce</a></li>
									<li><a href="#">Branding</a></li>
									<li><a href="#">API</a></li>
								</ul>
							</li>
							<li><a href="about.html">Acerca de</a></li>
							<li class="btn-cta"><a href="#"><span>Ingresar</span></a></li>
							<!--<li class="btn-cta"><a href="#"><span>Create a Course</span></a></li>-->
						</ul>
					</div>
				</div>
				
			</div>
		</div>
	</nav>
	
	<aside id="fh5co-hero">
		<div class="flexslider">
			<ul class="slides">
		   	<li style="background-image: url(recursos/imagenes/img_bg_1.jpg);">
		   		<div class="overlay-gradient"></div>
		   		<div class="container">
		   			<div class="row">
			   			<div class="col-md-8 col-md-offset-2 text-center slider-text">
			   				<div class="slider-text-inner">
			   					<h1>Olimpiadas de Matemáticas</h1>
									<h2>Enterate <a href="http://olimpiadasmatematicascsf.blogspot.com.co/" target="_blank">Sena</a></h2>
									<p><a class="btn btn-primary btn-lg" href="registro.html">Comienza aprender ahora!</a></p>
			   				</div>
			   			</div>
			   		</div>
		   		</div>
		   	</li>
		   	<li style="background-image: url(recursos/imagenes/img_bg_8.jpg);">
		   		<div class="overlay-gradient"></div>
		   		<div class="container">
		   			<div class="row">
			   			<div class="col-md-8 col-md-offset-2 text-center slider-text">
			   				<div class="slider-text-inner">
			   					<h1>Nuevos conocimientos de matemáticas que le aportan al desarrollo de su perfil</h1>
									<h2>Enterate <a href="http://olimpiadasmatematicascsf.blogspot.com.co/" target="_blank">Sena</a></h2>
									<p><a class="btn btn-primary btn-lg" href="registro.html">Comienza aprender ahora!</a></p>
			   				</div>
			   			</div>
			   		</div>
		   		</div>
		   	</li>
		   	<li style="background-image: url(recursos/imagenes/img_bg_2.jpg);">
		   		<div class="overlay-gradient"></div>
		   		<div class="container">
		   			<div class="row">
			   			<div class="col-md-8 col-md-offset-2 text-center slider-text">
			   				<div class="slider-text-inner">
			   					<h1>La comunidad SENA reconoce la importancia de las matemáticas</h1>
									<h2>Enterate <a href="http://olimpiadasmatematicascsf.blogspot.com.co/" target="_blank">Sena</a></h2>
									<p><a class="btn btn-primary btn-lg" href="registro.html">Comienza aprender ahora!</a></p>
			   				</div>
			   			</div>
			   		</div>
		   		</div>
		   	</li>		   	
		  	</ul>
	  	</div>
	</aside>

	<div id="fh5co-course-categories">
		<div class="container">
			<div class="row animate-box">
				<div class="col-md-6 col-md-offset-3 text-center fh5co-heading">
					<h2>Categorías de los cursos</h2>
					<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
				</div>
			</div>
			<div class="row">
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-shop"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Números</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-heart4"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Geometria</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-banknote"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Combinatoria</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-lab2"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Algebra</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-photo"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Estadística</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-home-outline"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Analisis numerico</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-bubble3"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Language</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
				<div class="col-md-3 col-sm-6 text-center animate-box">
					<div class="services">
						<span class="icon">
							<i class="icon-world"></i>
						</span>
						<div class="desc">
							<h3><a href="#">Web &amp; Programming</a></h3>
							<p>Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius.</p>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>

	<div id="fh5co-counter" class="fh5co-counters" style="background-image: url(images/img_bg_8.jpg);" data-stellar-background-ratio="0.5">
		<div class="overlay"></div>
		<div class="container">
			<div class="row">
				<div class="col-md-10 col-md-offset-1">
					<div class="row">
						<div class="col-md-3 col-sm-6 text-center animate-box">
							<span class="icon"><i class="icon-world"></i></span>
							<span class="fh5co-counter js-counter" data-from="0" data-to="3297" data-speed="5000" data-refresh-interval="50"></span>
							<span class="fh5co-counter-label">Seguidores</span>
						</div>
						<div class="col-md-3 col-sm-6 text-center animate-box">
							<span class="icon"><i class="icon-study"></i></span>
							<span class="fh5co-counter js-counter" data-from="0" data-to="2700" data-speed="5000" data-refresh-interval="50"></span>
							<span class="fh5co-counter-label">Aprendizes</span>
						</div>
						<div class="col-md-3 col-sm-6 text-center animate-box">
							<span class="icon"><i class="icon-bulb"></i></span>
							<span class="fh5co-counter js-counter" data-from="0" data-to="503" data-speed="5000" data-refresh-interval="50"></span>
							<span class="fh5co-counter-label">Cursos</span>
						</div>
						<div class="col-md-3 col-sm-6 text-center animate-box">
							<span class="icon"><i class="icon-head"></i></span>
							<span class="fh5co-counter js-counter" data-from="0" data-to="180" data-speed="5000" data-refresh-interval="50"></span>
							<span class="fh5co-counter-label">Instructores</span>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>

	<footer id="fh5co-footer" role="contentinfo" style="background-color: #FFFFFF;">
		<div class="overlay"></div>
		<div class="container">
			<div class="row row-pb-md">
				<div class="col-md-4 fh5co-widget">
					<h3>Olimpiadas de Matemáticas</h3>
					<p>SERVICIO NACIONAL DE APRENDIZAJE - Línea gratuita nacional: 01 8000 9 10 270 </p>
				</div>
				<div class="col-md-2 col-sm-4 col-xs-6 col-md-push-1 fh5co-widget">
					<h3>Aprende</h3>
					<ul class="fh5co-footer-links">
						<li><a href="#">Course</a></li>
						<li><a href="#">Blog</a></li>
						<li><a href="#">Contact</a></li>
						<li><a href="#">Terms</a></li>
						<li><a href="#">Meetups</a></li>
					</ul>
				</div>
				<div class="col-md-2 col-sm-4 col-xs-6 col-md-push-1 fh5co-widget">
					<h3>Comunidad</h3>
					<ul class="fh5co-footer-links">
						<li><a href="#">Blog</a></li>
						<li><a href="#">Privacy</a></li>
						<li><a href="#">Testimonials</a></li>
						<li><a href="#">Handbook</a></li>
						<li><a href="#">Held Desk</a></li>
					</ul>
				</div>

				<div class="col-md-2 col-sm-4 col-xs-6 col-md-push-1 fh5co-widget">
					<h3>Redes sociales</h3>
					<ul class="fh5co-footer-links">
						<li><a href="https://www.facebook.com/SENAColombiaOficial/" target="_blank">Facebook</a></li>
						<li><a href="https://twitter.com/SENAComunica" target="_blank">Twitter</a></li>
						<li><a href="https://www.youtube.com/user/SENATV" target="_blank">Youtube</a></li>
						<li><a href="https://www.instagram.com/senacomunica/" target="_blank">Instagram</a></li>
					</ul>
				</div>
				<!--<div class="col-md-2 col-sm-4 col-xs-6 col-md-push-1 fh5co-widget">
					<h3>Legal</h3>
					<ul class="fh5co-footer-links">
						<li><a href="#">Find Designers</a></li>
						<li><a href="#">Find Developers</a></li>
						<li><a href="#">Teams</a></li>
						<li><a href="#">Advertise</a></li>
						<li><a href="#">API</a></li>
					</ul>
				</div>-->
			</div>

			<div class="row copyright">
				<div class="col-md-12 text-center">
					<p>
						<small class="block">&copy; 2017 Especialización Tecnológia Gestion y Seguridad de Base de Datos</small>
						<small class="block">Popayán - Cauca.</small>  
					</p>
				</div>
			</div>

		</div>
	</footer>
	</div>

	<div class="gototop js-top">
		<a href="#" class="js-gotop"><i class="icon-arrow-up"></i></a>
	</div>
	</form>
	<!-- jQuery -->
	<%--<script src="js/jquery.min.js"></script>--%>
    <script src="recursos/js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<%--<script src="js/jquery.easing.1.3.js"></script>--%>
    <script src="recursos/js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<%--<script src="js/bootstrap.min.js"></script>--%>
    <script src="recursos/js/bootstrap.min.js"></script>
	<!-- Waypoints -->
	<%--<script src="js/jquery.waypoints.min.js"></script>--%>
    <script src="recursos/js/jquery.waypoints.min.js"></script>
	<!-- Stellar Parallax -->
	<%--<script src="js/jquery.stellar.min.js"></script>--%>
    <script src="recursos/js/jquery.stellar.min.js"></script>
	<!-- Carousel -->
	<%--<script src="js/owl.carousel.min.js"></script>--%>
    <script src="recursos/js/owl.carousel.min.js"></script>
	<!-- Flexslider -->
	<%--<script src="js/jquery.flexslider-min.js"></script>--%>
    <script src="recursos/js/jquery.flexslider-min.js"></script>
	<!-- countTo -->
	<%--<script src="js/jquery.countTo.js"></script>--%>
    <script src="recursos/js/jquery.countTo.js"></script>
	<!-- Magnific Popup -->
	<%--<script src="js/jquery.magnific-popup.min.js"></script>--%>
    <script src="recursos/js/jquery.magnific-popup.min.js"></script>
	<%--<script src="js/magnific-popup-options.js"></script>--%>
	<!-- Count Down -->
	<%--<script src="js/simplyCountdown.js"></script>--%>
    <script src="recursos/js/simplyCountdown.js"></script>
	<!-- Main -->
	<%--<script src="js/main.js"></script>--%>
    <script src="recursos/js/main.js"></script>
	<script>
	   
    var d = new Date(new Date().getTime() + 1000 * 120 * 120 * 2000);

    // default example
    simplyCountdown('.simply-countdown-one', {
        year: d.getFullYear(),
        month: d.getMonth() + 1,
        day: d.getDate()
    });

    //jQuery example
    $('#simply-countdown-losange').simplyCountdown({
        year: d.getFullYear(),
        month: d.getMonth() + 1,
        day: d.getDate(),
        enableUtc: false
    });
	</script>
	</body>
</html>


<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>
