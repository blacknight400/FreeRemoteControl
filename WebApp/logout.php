<?php
include($_SERVER['DOCUMENT_ROOT']."/core_config.php");

$id = Decrypt($_COOKIE['core_id']);
$password = Decrypt($_COOKIE['core_password']);

setcookie("core_id", $id, time() - 3600);
setcookie("core_password", $password, time() - 3600);

header("Location: /");

?>