<?php


$user = 'root';
$pass = '';
$db = 'logindb';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");


if(isset($_POST['userName']))
{

$userName= $_POST['userName'];
$password= $_POST['password'];


$sql= "select * from tbluser where userName='".$userName."'and password='".$password."'limit 1";

$result= mysqli_query($conn,$sql);

if(mysqli_num_rows($result)==1)
{
  echo "Sucessful Login";
  header("location: ../Q3/Welcome.php?LoginSuccess");
}

else
{
echo "Incorrect information";
header("location: ../Q3/LA2Question3.php?LoginUnsuccessful");

}




}
