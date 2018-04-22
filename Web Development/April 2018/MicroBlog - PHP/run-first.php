<?php
//The database and the table only need to be created once, so I created this page to run one time. That is also why there is litle HTML/CSS, and a quick link to the sign up page.
require_once('Functions/functions.php');
createdb();
createtable();

?>
<!DOCTYPE html>
<html>
<head>
	<title>MicroBlog</title>
</head>
<body>
	<br>
<a href="signup.php">Go to the sign-up page</a>
</body>
</html>