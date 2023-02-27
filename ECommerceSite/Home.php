<?php
if (!session_id()) @session_start();

include_once 'Connect.php';

if(isset($_POST['CUserName'])) {
   $_SESSION['CUserName'] = $_POST['CUserName'];
}


?>


<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Home.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>

		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>


  </head>

  <body style="background-image: url('Background.jpg');">

    <div class="topnav">
      <a class="active" href="Home.php">Home</a>
      <a href="Cart.php">Cart</a>
      <a href="Profile.php">Profile</a>
      <a href="Login.php">Log out</a>

    </div>

<center>
<br><br><br><br>
<br><br><br><br>
<input class="searchBar" id="searchbar" type="text" placeholder="Search..">
<button class="btn" type="submit" name="submit" >Go</button>

</center>

<br><br><br><br>

<div class="bigdiv">
<div name="divgrid" class="grid-container">

<?php

///IIIIMPPORTANT

$user = 'root';
$pass = '';
$db = 'ecommercesite';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");



$amount= "select * from product";

$res= mysqli_query($conn,$amount);

//echo (string)$res;

if(! $conn ) {
     die('Could not connect: ' . mysql_error());
  }


  if(mysqli_num_rows($res) > 0){

                      while($row = mysqli_fetch_array($res)){
                          $PId    = $row['PId'];
                          $PName   = $row['PName'];
                          $PImage = $row['PImage'];
                          $PPrice = $row['PPrice'];

                          echo "


                    <div class='grid-container'>
                      <div >


                  	<img src='$PImage' style='max-width: 400px;' alt=''>

                  	<div >

											<p>$PName</p>

                      <h4>R$PPrice</h4>

                      <button onclick='myFunction()' class='btn'>Add To Cart</button>

										</div>
									</div>

								</div>


                ";
//
/*
 <form method='POST' action='AddToCart.php'class='grid-container'>
   <button  value='<?php echo $PId;?>' name='PId' id='productID' class='btn' href='AddToCart.php'><i class='fa fa-shopping-cart'></i> add to cart</button>
   </form>
*/

}
}
?>

<script>
function myFunction() {
  alert("Added To Cart");
}
</script>

</div>
</div>

  </body>

</html>
