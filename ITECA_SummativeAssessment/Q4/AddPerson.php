<?php


$user = 'root';
$pass = '';
$db = 'ecommercesite';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");


if(isset($_POST['CFullName']))
{

$FullName= $_POST['CFullName'];
$userEmail=$POST['CEmail'];
$phoneNum= $POST_['CPhoneNum'];
$password= $_POST['CPassword'];
$repPassword= $POST_['CRedoPassword'];

try{

$sql = "INSERT INTO `customer`(`CFullname`, `CEmail`,'CPhoneNum', `CPassword`) VALUES ('$FullName','$userEmail','$phoneNum','$password')";

mysqli_query($conn,$sql);
}

catch(Exception $e)
{
header("location: ../ITECA_SummativeAssessment/Register.php?AccountNotCreated");
alert("Could Not Sign Up");
}

header("location: ../ITECA_SummativeAssessment/Home.php?AccountCreatedSuccessfully");
}
