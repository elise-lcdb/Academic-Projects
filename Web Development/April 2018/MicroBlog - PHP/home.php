<?php
session_start();
require_once('Functions/functions.php');
secondverification();
saveposts();

?>

<!DOCTYPE html>
<html>
<head>
	<title>Microblog</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
  	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
  	<link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet"> 
  	<link rel="stylesheet" type="text/css" href="CSS/profile.css">
</head>
<body>

<!-- Navigation bar -->
<nav class="navbar navbar-expand-sm navbar-dark">
  <ul class="navbar-nav">
    <li class="nav-item active">
      <a class="nav-link" href="#"><?php echo "Welome, ".$_SESSION["username"];?></a>
    </li>
    <li class="nav-active">
      <a class="nav-link" href="home.php">Home</a>
    </li>
    <li class="nav-active">
    	<li class="nav-active">
      <a class="nav-link" href="profile.php">My Posts</a>
    </li>
      <a class="nav-link" href="logout.php">Log-Out</a>
    </li>
  </ul>
</nav>
<br>
<br>

<!-- Form to write posts -->
<center><div class="col-md-8" id="posting">
	<form method="POST" action="home.php" enctype="multipart/form-data">
		<h3>Hello, <?php echo $_SESSION["username"]; ?>! What would you like to post?</h3>
		<br>
		<center><input type="text" name="text" id="text"></center>
		<br>
		<center><input type="submit" name="submit" value="Post"></center>
		<br>
	</form>
</div></center>

<!-- Show posts -->
<?php 
require_once('Functions/functions.php');
showposts(); 
?>
</body>
</html>