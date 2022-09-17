<?php 
include($_SERVER['DOCUMENT_ROOT']."/core_config.php");
$id = $_GET["id"];
$data = $_GET["data"];

if($_GET["key"] != $Key){
    ReturnHome();
}
else{
    if($id == ""){
        ReturnHome();
    }
    else{
        UploadDevicesData($connect, $id, $data);
    }
}
?>