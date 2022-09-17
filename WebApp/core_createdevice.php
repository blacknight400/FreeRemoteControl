<?php 
include($_SERVER['DOCUMENT_ROOT']."/core_config.php");
$Password = $_GET["password"];


if($_GET["key"] != $Key){
    ReturnHome();
}
else{
    if($Password == ""){
        ReturnHome();
    }
    else{
        echo CreateDevices($connect,RandomNumber(3), sha1(md5($Password)), "0" , "0" , "0");
    }
}
?>