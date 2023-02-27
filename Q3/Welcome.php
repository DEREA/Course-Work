<?php
if (!session_id()) @session_start();

include_once 'Connect.php';

if(isset($_POST['userName'])) {
   $_SESSION['userName'] = $_POST['userName'];
}

?>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>

  <body>


<h1>Welcome <?php echo $_SESSION['userName']; ?></h1>
<p1>You logged in at:  <span id='date-time'></span>.</p1>
<form method="get" action="LA2Question3.php">

<br><br>
    <button type="submit">Logout</button>


</form>

<script>
var dt = new Date();
document.getElementById('date-time').innerHTML=dt;
</script>



  </body>

</html>
