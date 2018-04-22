<?php
session_start();
require_once('Functions/functions.php');
signup();

?>

<!DOCTYPE html>
<html>
<head>
	<title>Microblog</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
  	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
  	<link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet"> 
  	<link rel="stylesheet" type="text/css" href="CSS/connection.css">
</head>
<body>

<!-- Background -->
<!-- The background isn't mine, it is a cool lightweight Javasript library I found here: https://vincentgarreau.com/particles.js/ -->
	<div id="particles-js"></div> 
	<!-- stats - count particles --> 
	<div class="count-particles"> 
	<span class="js-count-particles">--</span> particles </div> 

  <!-- Form -->
  <br>
  <br>
  <br>
  <br>
  <br>
  <br>
  <div id="signup" class="col-md-5">
    <center><h1>Sign-Up</h1></center>
    <hr>
    <form method="POST" action="signup.php" enctype="multipart/form-data">
    <center><h4>Username</h4></center>
    <center><input pattern="[^\s]+" type="text" name="user" id="user" required></center>
    <br>
    <center><h4>Password</h4></center>
    <center><input pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z].{8,}" type="password" name="psswd" id="psswd" required title="It is recommended to have atleast 8 characters in which 1 is a capital letter, 1 is a lower case letter, and contains 1 number"></center>
    <br>
    <center><h4>Verify Password</h4></center>
    <center><input pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z].{8,}" type="password" name="psswdv" id="psswdv" required></center>
    <br>
    <!-- The "verify password" is a security thing just to ensure that the user correctly entered the password they want -->
    <center><input type="submit" name="connect" value="Sign Up"></center>
    <br>
    <h6><a href="login.php">Already have an account? Sign in</a></h6>
    <br>
    

  </form> 
    
  </div>


<!-- Scripts -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
  	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
  	<script src="http://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js"></script> 
  	<script src="http://threejs.org/examples/js/libs/stats.min.js"></script>
  	<script type="text/javascript">
  		particlesJS("particles-js", {"particles":{"number":{"value":85,"density":{"enable":true,"value_area":552.1244961863977}},"color":{"value":"#ffffff"},"shape":{"type":"circle","stroke":{"width":0,"color":"#000000"},"polygon":{"nb_sides":5},"image":{"src":"img/github.svg","width":100,"height":100}},"opacity":{"value":0.5,"random":false,"anim":{"enable":false,"speed":1,"opacity_min":0.1,"sync":false}},"size":{"value":3,"random":true,"anim":{"enable":false,"speed":40,"size_min":0.1,"sync":false}},"line_linked":{"enable":true,"distance":150,"color":"#ffffff","opacity":0.4,"width":1},"move":{"enable":true,"speed":6,"direction":"none","random":false,"straight":false,"out_mode":"out","bounce":false,"attract":{"enable":false,"rotateX":600,"rotateY":1200}}},"interactivity":{"detect_on":"canvas","events":{"onhover":{"enable":true,"mode":"repulse"},"onclick":{"enable":true,"mode":"push"},"resize":true},"modes":{"grab":{"distance":400,"line_linked":{"opacity":1}},"bubble":{"distance":400,"size":40,"duration":2,"opacity":8,"speed":3},"repulse":{"distance":200,"duration":0.4},"push":{"particles_nb":4},"remove":{"particles_nb":2}}},"retina_detect":true});var count_particles, stats, update; stats = new Stats; stats.setMode(0); stats.domElement.style.position = 'absolute'; stats.domElement.style.left = '0px'; stats.domElement.style.top = '0px'; document.body.appendChild(stats.domElement); count_particles = document.querySelector('.js-count-particles'); update = function() { stats.begin(); stats.end(); if (window.pJSDom[0].pJS.particles && window.pJSDom[0].pJS.particles.array) { count_particles.innerText = window.pJSDom[0].pJS.particles.array.length; } requestAnimationFrame(update); }; requestAnimationFrame(update);;
  	</script>
</body>
</html>