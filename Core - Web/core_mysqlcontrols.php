<?php
$database_server = "localhost";
$database_name = "";
$database_username = "";
$database_password = "";
$Key = "0X8BADSJGF23!!^?=)";

$connect = new mysqli($database_server, $database_username, $database_password, $database_name);
if($connect->connect_error)
{
   die("[MySQL] Connection failed!");
}

function CreateDevices($connect,$id,$password,$status,$device_data,$task){
    $sql = "INSERT INTO devices (id, password, status, device_data, task)
    VALUES ('$id', '$password', '$status' , '$device_data' , '$task')";  
    if (mysqli_query($connect, $sql)) {
        return $id;
      }
      else {
        return "FALSE";
      }
}

function DeleteDevices($connect,$id){
  $sql = "DELETE FROM devices WHERE id='$id'";
  if (mysqli_query($connect, $sql)) {
    return "TRUE";
  }
  else {
    return "FALSE";
  }
}

function UploadDevicesTask($connect,$id,$newtask){
  $sql = "UPDATE devices SET task='$newtask' WHERE id='$id'";
  if (mysqli_query($connect, $sql)) {
    return "TRUE";
  }
  else {
    return "FALSE";
  }
}

function UploadDevicesStatus($connect,$id,$newstatus){
  $sql = "UPDATE devices SET status='$newstatus' WHERE id='$id'";
  if (mysqli_query($connect, $sql)) {
    return "TRUE";
  }
  else {
    return "FALSE";
  }
}

function UploadDevicesData($connect,$id,$newdata){
  $sql = "UPDATE devices SET device_data='$newdata' WHERE id='$id'";
  if (mysqli_query($connect, $sql)) {
    return "TRUE";
  }
  else {
    return "FALSE";
  }
}

function FindDevices($connect,$id){
  $sql = "SELECT * FROM devices WHERE id LIKE '$id';";
  $result = $connect->query($sql);
  if ($result->num_rows > 0) {
      return $result->fetch_assoc();
  }
}

function CheckCookie($connect,$id,$password){
  if($id != "" && $password != ""){
    if($password == FindDevices($connect, $id)["password"]){
      return "TRUE";
    }
    else{
      return "FALSE";
    }
  }
  else{
    return "FALSE";
  }
}


function DevicesStatus($connect, $id){
  $string = FindDevices($connect, $id)["status"];
  $check = CustomDate() - $string;
  if($check > 60){
      return "Offline";
  }
  else{
      return "Online";
  }
}


function DevicesLastUpload($connect, $id){
  $string = FindDevices($connect, $id)["status"];
  return date('H:i / d.m.Y', $string);
}
//echo CreateDevices($connect,RandomNumber(10), sha1(md5("123456")), "0" , "0" , "0");
//echo FindDevices($connect, "id1")["password"];
//echo DeleteDevices($connect, "id");
//echo UploadDevicesStatus($connect, "id", "newstatus");
?>