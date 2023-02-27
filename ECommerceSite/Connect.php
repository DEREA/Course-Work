<?php


$user = 'root';
$pass = '';
$db = 'ecommercesite';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");


if(isset($_POST['CUserName']))
{

$userName= $_POST['CUserName'];
$password= $_POST['CPassword'];


$sql= "select * from customer where CUserName='".$userName."'and CPassword='".$password."'limit 1";



$result= mysqli_query($conn,$sql);


if(mysqli_num_rows($result) > 0){


                    while($row = mysqli_fetch_array($result)){

                      $CId    = $row['CId'];
                      $CUsername   = $row['PName'];
                      $CEmail = $row['PImage'];
                      $CPassword = $row['PPrice'];
                      $IsAdmin    = $row['CId'];



}

}

//mysql_fetch_object()

if(mysqli_num_rows($result)==1 && $IsAdmin==1)
{

  echo "Sucessful Login";
  header("location: ../ECommerceSite/AdminLanding.php?LoginSuccess");
}


else if(mysqli_num_rows($result)==1)
{
  echo "Sucessful Login";
  header("location: ../ECommerceSite/Home.php?LoginSuccess");
}

else
{
echo "Incorrect information";
header("location: ../ECommerceSite/Login.php?LoginUnsuccessful");

}




}
