<?php
include_once 'Connect.php';


try{

$ISBN = $_POST['bookISBN'];
$Title = $_POST['bookTitle'];
$Edition = $_POST['bookEdition'];
$Author = $_POST['bookAuthor'];

$sql = "INSERT INTO `book`(`ISBN`, `bookTitle`, `edition`, `author`) VALUES ('$ISBN','$Title','$Edition','$Author')";

mysqli_query($conn,$sql);
}

catch(Exception $e)
{
header("location: ../Q2/LA2Question2.php?BookNotAdded");
alert("Book not added");
}

header("location: ../Q2/LA2Question2.php?BookAddedSuccessfully");
