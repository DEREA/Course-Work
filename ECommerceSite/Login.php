<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Login.css">
  </head>

  <body style="background-image: url('Background.jpg');" style="height: 100px;">

  <div>

<br><br><br><br><br><br><br><br>
<br><br><br><br><br><br><br><br>

  </div>

<center>
<div class="logdiv" style="background-color:#33475b;" style="width:50px;">

<h style= color:white;>Login</h>
<br><br>


<form action="Home.php" method="POST">

<p>Username:</p> <br>
<input type="varchar" id="user" name="CUserName" >
<br>

<p>Password:</p> <br>
<input type="varchar" id="pass" name="CPassword" required >

<br><br><br>

<button class="btn" type="submit" name="submit" >Login</button>


<p>Don't have an account?</p> <a href="Signup.php">click here</a>


</form>

</div>
</center>

<br><br><br><br><br><br>
<br><br><br><br><br><br>
</body>

<style>

.btn{

background-color:#869fc4;
padding: 15px 32px;
text-align: center;
font-size: 20px;
color: white;
}

</style>


<?php


$user = 'root';
$pass = '';
$db = 'ecommercesite';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");


if($db)
{
  echo '<span style="color:white;">Connected</span>';
}

else
{
  echo "Could not connect";
}


?>



</html>
