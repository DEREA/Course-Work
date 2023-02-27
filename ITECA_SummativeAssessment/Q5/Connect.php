<?php


$user = 'root';
$pass = '';
$db = 'UserDB';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");


if(isset($_POST['CUserName']))
{

$userName= $_POST['CUserName'];
$password= $_POST['CPassword'];


$sql= "select * from User where CUserName='".$userName."'and CPassword='".$password."'limit 1";



$result= mysqli_query($conn,$sql);


if(mysqli_num_rows($result)==1)
{
  echo "Sucessful Login";
  header("location: ../ITECA_SummativeAssessment/Home.php?LoginSuccess");
}

else
{
echo "Incorrect information";
header("location: ../ITECA_SummativeAssessment/Login.php?LoginUnsuccessful");

}




}
