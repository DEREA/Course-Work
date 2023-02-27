<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>

  <body>

<form action="Welcome.php" method="POST">

Username: <br>
<input type="carchar" id="user" name="userName" required><br>

Password: <br>
<input type="varchar" id="pass" name="password" required><br>

<br>

<button class="btn" type="submit" name="submit" >Login</button>

</form>

</body>

<style>

.btn{

background-color:#4CAF50;
padding: 15px 32px;
text-align: center;
font-size: 20px;
}

</style>


<?php


$user = 'root';
$pass = '';
$db = 'logindb';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");

if($db)
{
  echo "Connected successfully";
}

else
{
  echo "Could not connect";
}


?>



</html>
