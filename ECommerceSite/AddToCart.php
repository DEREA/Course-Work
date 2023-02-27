<?php


$user = 'root';
$pass = '';
$db = 'ecommercesite';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");




if(isset($_POST['CUserName']))
{

$userName= $_POST['CUserName'];
$userEmail=$POST['CEmail'];
$password= $_POST['CPassword'];
}

$ProdID= $POST['PId'];



$amount= "select * from customer where CUserName='".$userName."'and CPassword='".$password."'limit 1";;

$res= mysqli_query($conn,$amount);


/*
if(! $conn ) {
     die('Could not connect: ' . mysql_error());
  }


  if(mysqli_num_rows($res) > 0){

                      while($row = mysqli_fetch_array($res)){
                          $PId    = $row['PId'];
                          $PName   = $row['PName'];
                          $PImage = $row['PImage'];
                          $PPrice = $row['PPrice'];


}
}
*/










/*
try{

$sql = "INSERT INTO `customer`(`CUsername`, `CEmail`, `CPassword`, `IsAdmin`) VALUES ('$userName','$userEmail','$password',0)";

mysqli_query($conn,$sql);
}

catch(Exception $e)
{
header("location: ../ECommerceSite/Home.php?ItemNotAdded");
alert("Could Not Sign Up");
}

header("location: ../ECommerceSite/Home.php?ItemAddedSuccessfully");
}
*/
