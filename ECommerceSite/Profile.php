<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Profile.css">
  </head>

  <body style="background-image: url('Background.jpg');" style="height: 100px;">




    <div class="topnav">
      <a class="active" href="Home.php">Home</a>
      <a href="Cart.php">Cart</a>
      <a href="Profile.php">Profile</a>
      <a href="Login.php">Log out</a>
    </div>


<?php

if(isset($_POST['userName'])) {
   $_SESSION['CUserName'] = $_POST['CUserName'];

   $oldUser=$_POST['CUserName'];
   $oldEmail=$_POST['CEmail'];
   $oldPass=$_POST['CPassword'];
}
/*
<h1>Welcome <?php echo $_POST['CUserName']; ?></h1>
 <p1>You logged in at:  <span id='date-time'></span>.</p1>
*/
?>

<div>

<br><br><br><br><br><br><br><br>


</div>


<center>
<div class="logdiv" style="background-color:#33475b;" style="width:400px;">

<br><br>

<h style="color:white;" class="tHead">Welcome to the Profile Page</h>
<br><br>
<br><br>
<br><br>

<div class="profile">

	<img src="ProfilePicture.jpg" style='max-width: 400px;' alt=''>


</div>

<form action="Profile.php" method="POST" class="f1">

<p>Username:</p> <br>
<input type="carchar" id="user" name="CUserName" >
<br>


<p>Email:</p> <br>
<input type="varchar" id="email" name="CEmail" >
<br>


<p>Password:</p> <br>
<input type="varchar" id="pass" name="CPassword" required >

<br><br><br>

<button class="btn" type="submit" name="submit" onclick="UpdateUser()" >Update Information</button>

<p></p>

<br><br>


</form>


</div>


<?php
    function UpdateUser(){

      if(isset($_POST['CUserName']))
      {

      $userName= $_POST['CUserName'];
      $password= $_POST['CPassword'];
      $email= $_POST['CEmail'];


      $user = 'root';
      $pass = '';
      $db = 'ecommercesite';

      $conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");

      try{

      $sql = "Update 'customer' set 'CUserName'='$userName', 'CEmail'='$email' 'CPassword'='$password' where 'CUserName'='$oldUser' and 'CPassword'='$oldPass'";


      mysqli_query($conn,$sql);

      header("location: ../ECommerceSite/Profile.php?AccountUpdated");
      
      }

      catch(Exception $e)
      {

      alert("Could Update");
      }

}
    }

?>

</body>
</html>
