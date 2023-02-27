<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="AdminLanding.css">
  </head>

  <body style="background-image: url('Background.jpg');" style="height: 100px;">

  <div>

<br><br><br><br><br><br><br><br>


  </div>

<center>
<div class="logdiv" style="background-color:#33475b;" style="width:300px;">

<h style="color:white;" class="tHead">Welcome to the Admin Page</h>
<br><br>
<br><br>
<br><br>

<form action="AdminLanding.php" method="POST" class="f1">

<p>Username:</p> <br>
<input type="carchar" id="user" name="CUserName" >
<br>


<p>Email:</p> <br>
<input type="varchar" id="email" name="CEmail" >
<br>


<p>Password:</p> <br>
<input type="varchar" id="pass" name="CPassword" required >

<br><br><br>

<button class="btn" type="submit" name="submit" onclick="DeleteUser()" >Delete User</button>

<p></p>




</form>



<form action="Home.php" method="POST" class="f2">

<p>ProductID:</p> <br>
<input type="varchar" id="PID" name="PID" >
<br>


<p>ProductName:</p> <br>
<input type="varchar" id="PName" name="PName" >
<br>

<br><br><br>

<button class="btn" type="submit" name="submit" onclick="DeleteProduct()" >Delete Product</button>

<p></p>




</form>

<br><br>
<br><br>
<br><br>

<form action="Login.php" method="POST">

  <button class="btnLogout" type="submit" name="submit" >Logout</button>


</form>

</div>
</center>


<br><br><br><br><br><br>
<br><br><br><br><br><br>



<?php
    function DeleteUser(){

      if(isset($_POST['CUserName']))
      {

      $userName= $_POST['CUserName'];
      $password= $_POST['CPassword'];



      $user = 'root';
      $pass = '';
      $db = 'ecommercesite';

      $conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");

      try{

      $sql = "Delete from 'customer' where 'CUserName'='$userName' and 'CPassword'='$password'";

      mysqli_query($conn,$sql);
      }

      catch(Exception $e)
      {
      header("location: ../ECommerceSite/AdminLanding.php?AccountNotDeleted");
      alert("Could Delete");
      }

}
    }
    function DeleteProduct(){


      $user = 'root';
      $pass = '';
      $db = 'ecommercesite';

      $conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");


      try{

      $sql = "Delete from 'product' where 'PId'='$PId' ";

      mysqli_query($conn,$sql);
      }

      catch(Exception $e)
      {
      header("location: ../ECommerceSite/AdminLanding.php?ProductNotDeleted");
      alert("Could Delete");
      }

    }
?>






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
</html>
