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


try{
/*
$Emailst= "select 'CEmail' from 'customer' where 'CUsername'='$userName' and CPassword='$password'";

$userEmail= mysqli_query($conn,$Emailst);
*/
$sql = "INSERT INTO `customer`(`CUsername`, `CEmail`, `CPassword`, `IsAdmin`) VALUES ('$userName','$userEmail','$password',0)";

mysqli_query($conn,$sql);
}

catch(Exception $e)
{
header("location: ../ECommerceSite/Signup.php?AccountNotCreated");
alert("Could Not Sign Up");
}

header("location: ../ECommerceSite/Home.php?AccountCreatedSuccessfully");
}
