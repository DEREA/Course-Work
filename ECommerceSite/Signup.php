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

<h style="color:white;">Signup</h>
<br><br>

<form action="AddUser.php" method="POST">

<p>Username:</p> <br>
<input type="carchar" id="user" name="CUserName" >
<br>


<p>Email:</p> <br>
<input type="varchar" id="email" name="CEmail" >
<br>


<p>Password:</p> <br>
<input type="varchar" id="pass" name="CPassword" required >

<br><br><br>

<button class="btn" type="submit" name="submit" >Signup</button>

<p></p>

<a href="Login.php">Login</a>


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
