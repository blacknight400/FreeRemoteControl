<?php
include($_SERVER['DOCUMENT_ROOT']."/core_createkey.php");
include($_SERVER['DOCUMENT_ROOT']."/core_mysqlcontrols.php");
include($_SERVER['DOCUMENT_ROOT']."/core_encrypt-decrypt.php");
include($_SERVER['DOCUMENT_ROOT']."/core_date.php");


function ReturnHome(){
    header("Location: /");
}
?>