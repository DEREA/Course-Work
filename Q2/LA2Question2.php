
<?php

include_once 'Connect.php';

?>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>

<form action="AddPeople.php" method="POST">
<fieldset>

  <legend>Add new book</legend>
    Enter the book ISBN:
    <input type="varchar" id="ISBN" name="bookISBN" required> <br>
<br>
    Enter the book title:
    <input type="varchar" id="title" name="bookTitle" required> <br>
<br>
    Enter the book edition:
    <input type="number" id="edition" name="bookEdition" required> <br>
<br>
    Enter the book author:
    <input type="varchar" id="author" name="bookAuthor" required> <br>
<br>
<button type="submit" name="submit">Add new book</button>



</fieldset>
</form>
  </body>
</html>
