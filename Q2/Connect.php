<?php


$user = 'root';
$pass = '';
$db = 'library';

$conn = mysqli_connect('localhost',$user,$pass,$db) or die("Could not connect");

if($db)
{
  echo "Connected successfully";
}

else
{
  echo "Could not connect";
}
