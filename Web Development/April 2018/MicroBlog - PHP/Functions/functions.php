<?php

//First we have to create the Database
//This will be only run once since we only need one database 
function createdb(){
	try{
		$connection = new PDO('mysql:host=localhost;port=3306',"root","");
		$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	}catch(PDOException $e){
		echo $e->getMessage();
	}
	$connection->exec("CREATE DATABASE elisemblog3");
    echo "The database has been created <br>";
    
}

//We need to create a table but again this only needs to be run once
function createtable(){
	try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }catch(PDOException $e){
		echo $e->getMessage();
	}
	$connection->exec("CREATE TABLE users(id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, username VARCHAR(32), password VARCHAR(100))");
    echo "User table has been created <br>";
    $connection->exec("CREATE TABLE posts(id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, username VARCHAR(32), post VARCHAR(1000), thetime VARCHAR(50))");
    echo "Posts table has been created";
}

// Sign up code
function signup(){
	try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }catch(PDOException $e){
		echo $e->getMessage();
	}
if(isset($_POST["user"]) && ($_POST["psswd"]) && isset($_POST["psswdv"]) && $_POST["psswd"] != $_POST["psswdv"]) {
	//password check.
	echo "<div class=\"col-md-12\" style=\"text-align:center; background:black; color:red;\">
		The passwords do not match </div>";

}
if(isset($_POST["user"]) && isset($_POST["psswd"]) && isset($_POST["psswdv"]) && $_POST["psswd"] == $_POST["psswdv"]){
	$sql = "INSERT INTO users (username, password) VALUES (?,?)";
	$hash= password_hash($_POST["psswd"], PASSWORD_DEFAULT);
	$addd= $connection->prepare($sql);
	$addd->bindValue(1,$_POST["user"], PDO::PARAM_STR);
	$addd->bindValue(2,$hash, PDO::PARAM_STR);
	$addd->execute();

	//Save this in the session, so it can be used throughout all of the pages
	$_SESSION["username"] = $_POST["username"];
	$_SESSION["password"] = $hash;


	//Redirect to the profile page since the person has been successfully signed up
	header("Location: profile.php");
	

}if(!isset($_POST["user"]) || !isset($_POST["psswd"]) || !isset($_POST["psswdv"])){
	//Do nothing since the person didn't do anything 
}

}

//Make sure that all of the info that the username and password that the user put in is correct
function login(){
		try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }catch(PDOException $e){
		echo $e->getMessage();
	}
	if (isset($_POST["username"]) && isset($_POST["password"])) {
	//Define the variables
	$sql = "SELECT username, password FROM users WHERE username=?";
	$_SESSION["username"] = $_POST["username"];
	$_SESSION["password"] = $_POST["password"];
	//First, we need to check whether or not the username exists in the database table
	$find = $connection->prepare($sql);
	$find->bindValue(1,$_SESSION["username"], PDO::PARAM_STR);
	$find->execute();
	$userverify = $find->fetch(PDO::FETCH_ASSOC);
if ($userverify == false) {
	echo("<div class=\"col-md-12\" style=\"text-align:center; background:black; color:red;\">
		The username or password is incorrect </div>");
}if ($userverify == true) {
	$passwordverification = password_verify($_SESSION["password"], $userverify["password"]);
	if ($passwordverification) {
		header("Location:home.php");
	}else{
		echo"<div class=\"col-md-12\" style=\"text-align:center; background:black; color:red;\">
		The username or password is incorrect </div>";
	}
}

}

}


//Makes sure that the person logged in should be logged in and not allow non-users to post.
function secondverification(){
		try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }catch(PDOException $e){
		echo $e->getMessage();
	}
	$sql = "SELECT username, password FROM users WHERE username=?";
	$find = $connection->prepare($sql);
	$find->bindValue(1,$_SESSION["username"], PDO::PARAM_STR);
	$find->execute();
	$userverify = $find->fetch(PDO::FETCH_ASSOC);
if ($userverify == false) {
	echo("The username or password is incorrect");
}if ($userverify == true) {
	$passwordverification = password_verify($_SESSION["password"], $userverify["password"]);
	if ($passwordverification) {
		//Do nothing. Stay on the page since the user has logged in and is allowed to be there
	}else{
		header("Location:login.php");
	}
}
else{
	header("Location:login.php");
}

}

function saveposts(){
	try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }catch(PDOException $e){
		echo $e->getMessage();
	}

//This is just to save the contents of the post
if (!empty($_POST['text'])) {
	$sql = "INSERT INTO posts (username, post, thetime) VALUES (?,?,?)";
	$addd= $connection->prepare($sql);
	$time = date('Y-m-d H:i:s');
	$addd->bindValue(1,$_SESSION["username"], PDO::PARAM_STR);
	$addd->bindValue(2,$_POST["text"], PDO::PARAM_STR);	
	$addd->bindValue(3,$time, PDO::PARAM_STR);
	$addd->execute();
	

} else{
	//do nothing 
}


}
//Show all of the posts from all of the users
function showposts(){
		try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }catch(PDOException $e){
		echo $e->getMessage();
	}
	//Order by ID DESC to show the most recent post at the top. 
	$sql = "SELECT id, username, post, thetime FROM posts ORDER BY ID DESC";
	
	$topost=$connection->query($sql)->fetchAll();
	foreach ($topost as $show) {
			echo "<br><div id=\"posting\" class=\"col-md-8\">
		<div class=\"row\">
			<h6 class=\"col-md-10\">".$show["username"]."</h6>
		</div>";
		
		//show the delete button if it is the user
		if($_SESSION["username"] == $show["username"]){
			echo " <form class=\"col-md-2\" method=\"POST\" action=\"home.php\" enctype=\"multipart/form-data\"><input type=\"submit\" value=\"Delete post\" id=\"".$show["id"]."\" name=\"".$show["id"]."\" >
			</form>";
		}
		
		echo "<div class=\"row\">
			<h6>".$show["thetime"]."</h6>
		</div>
		<hr>
		<p>".$show["post"]."</p> <br>		
	</div>";
	//delete the post by removing it from the table
	if (isset($_POST[$show["id"]])) {
		$sql2 = "DELETE FROM posts WHERE id=?";
	 	$delete = $connection->prepare($sql2);
		$delete->execute(array($show["id"]));
		header('location: home.php');
	}else{
		//do nothing. It should not delete the post

	}

	
	}


	}

//Show only the posts of the user
function indiposts(){
	try{
    	$connection = new PDO('mysql:host=localhost;dbname=elisemblog3;port=3306', "root", "");
    	$connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $sql = "SELECT id, username, post, thetime FROM posts WHERE username=? ORDER BY id desc";	
	$topost = $connection->prepare($sql);
	$topost->bindValue(1,$_SESSION["username"], PDO::PARAM_STR);
	$topost->execute();
	$thepost = $topost->fetchAll();
	foreach ($thepost as $show) {
			echo "<br><div id=\"posting\" class=\"col-md-8\">
		<div class=\"row\">
			<h6 class=\"col-md-10\">".$show["username"]."</h6>

			<form class=\"col-md-2\" method=\"POST\" action=\"profile.php\" enctype=\"multipart/form-data\">
				<input type=\"submit\" value=\"Delete post\" id=\"".$show["id"]."\" name=\"".$show["id"]."\">
			</form>
		</div>
		<div class=\"row\">
			<h6>".$show["thetime"]."</h6>
		</div>
		<hr>
		<p>".$show["post"]."</p> <br>		
	</div>";
	//Delete the posts by removing it from the table (each button is given a name and id that corresponds to the post)
if (isset($_POST[$show["id"]])) {
		$sql2 = "DELETE FROM posts WHERE id=?";
	 	$delete = $connection->prepare($sql2);
		$delete->execute(array($show["id"]));
		header('location: profile.php');
	}else{
		//do nothing. It should not delete the post

	}

}
	
    }catch(PDOException $e){
		echo $e->getMessage();
	}
	


}


	






?>