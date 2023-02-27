<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="">
  </head>

  <body  style="height: 100px;">

<div style="background-color:#547e8f;">
<h1>Register with Manaka Family<h2>
</div>


<div class="logdiv" style="background-color:white;" style="border-style:solid black 2px;">

<h style="color:white;">Signup</h>
<br><br>

<form action="AddPerson.php" name="f2" onsubmit="validateForm()" method="POST">

<p>Full Name:</p> <br>
<input type="varchar" id="fullName" name="CFullName" required>
<br>


<p>Email:</p> <br>
<input type="varchar" id="email" name="CEmail" required >
<br>

<p>Phone Number:</p> <br>
<input type="varchar" id="phoneNum" name="CPhoneNum" required >

<br>


<p>Password:</p> <br>
<input type="varchar" id="pass" name="CPassword" required >

<br>

<p>Confirm Password:</p> <br>
<input type="varchar" id="redoPassword" name="CRedoPassword" required >

<br><br><br>

<button class="btn" type="submit" name="submit" >Register</button>

<p>already have an account?</p>


<a href="Login.php">Login</a>


</form>

</div>


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


<script>

function validateForm() {
  let x = document.forms["f2"]["CUsername"].value;
  if (x == "") {
    alert("Name must be filled out");
    return false;
  }
  else
  {
    alert "success";
  }


  let x = document.forms["f2"]["CEmail"].value;
  if (x == "") {
    alert("Email must be filled out");
    return false;

    else
    {
      alert "success";
    }
  }



      let x = document.forms["f2"]["CPhoneNum"].value;
      if (x == "") {
        alert("Phone must be filled out");
        return false;

        else
        {
          alert "success";
        }
      }


    let x = document.forms["f2"]["CPassword"].value;
    if (x == "") {
      alert("Password must be filled out");
      return false;

      else
      {
        alert "success";
      }
    }




}

</script>




<?php


$user = 'root';
$pass = '';
$db = 'UserDB';

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
