<?php
//Since the "Log-out" in the nav bar is a link, I linked it to a short program to destroy the session.
session_start();
session_destroy();
header("Location: login.php");

?>