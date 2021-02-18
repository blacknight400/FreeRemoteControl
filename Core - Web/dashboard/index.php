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
?>
<!DOCTYPE html>
<html dir="ltr" lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>General | Core Dashboard</title>
    <link rel="icon" type="image/png" sizes="16x16" href="dashboard-all/plugins/images/favicon.png">
    <link href="dashboard-all/plugins/bower_components/chartist/dist/chartist.min.css" rel="stylesheet">
    <link rel="stylesheet" href="dashboard-all/plugins/bower_components/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.css">
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
                            <a class="profile-pic" href="#">
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
                        <li class="sidebar-item pt-2">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "index.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "index.php";
                                }
                            ?>" aria-expanded="false">
                                <i class="fas fa-home" aria-hidden="true"></i>
                                <span class="hide-menu">General</span>
                            </a>
                        </li>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "device.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "device.php";
                                }
                            ?>" aria-expanded="false">
                                <i class="fas fa-desktop" aria-hidden="true"></i>
                                <span class="hide-menu">Device</span>
                            </a>
                        </li>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "running-applications.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "running-applications.php";
                                }
                            ?>" aria-expanded="false">
                                <i class="far fa-window-restore" aria-hidden="true"></i>
                                <span class="hide-menu">Running Applications</span>
                            </a>
                        </li>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "command-prompt.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "command-prompt.php";
                                }
                            ?>" aria-expanded="false">
                                <i class="fas fa-terminal" aria-hidden="true"></i>
                                <span class="hide-menu">Command Prompt</span>
                            </a>
                        </li>
                        <li class="sidebar-item">
                            <a class="sidebar-link waves-effect waves-dark sidebar-link" href="<?php
                                if($_GET["type"] == "watch"){
                                   echo "tasks.php?type=watch&core_id=$xxid&core_password=$xxpassword";
                                }
                                else{
                                   echo "tasks.php";
                                }
                            ?>" aria-expanded="false">
                                <i class="fas fa-tasks" aria-hidden="true"></i>
                                <span class="hide-menu">Tasks</span>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>
        </aside>
        <div class="page-wrapper">
            <div class="page-breadcrumb bg-white">
                <div class="row align-items-center">
                    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                        <h4 class="page-title text-uppercase font-medium font-14">General</h4>
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
                <div class="row justify-content-center">
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">Last Upload</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                                <li class="ml-auto"><span class="counter text-success"><?php echo DevicesLastUpload($connect, $xxid);?></span></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">Number of Running Applications</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                                <li class="ml-auto"><span class="counter text-purple">
                                <?php 
                                  if(DevicesStatus($connect, $xxid) == "Online"){
                                     echo count(array_filter($Apps));
                                  }
                                  else{
                                      echo "Offline";
                                  }
                                ?>
                                </span>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-4 col-sm-6 col-xs-12">
                        <div class="white-box analytics-info">
                            <h3 class="box-title">IP Adress</h3>
                            <ul class="list-inline two-part d-flex align-items-center mb-0">
                                <li class="ml-auto"><span class="counter text-info">
                                <?php 
                                  if(DevicesStatus($connect, $xxid) == "Online"){
                                     echo $IP;
                                  }
                                  else{
                                      echo "Offline";
                                  }
                                ?>
                                </span>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 col-lg-12 col-sm-12">
                        <div class="white-box">
                            <div class="d-md-flex mb-3">
                                <h3 class="box-title mb-0">Running Applications</h3>
                                <div class="col-md-3 col-sm-4 col-xs-6 ml-auto">
                                    
                                </div>
                            </div>
                            <div class="table-responsive">
                                <table class="table no-wrap">
                                    <thead>
                                        <tr>
                                            <th class="border-top-0">#</th>
                                            <th class="border-top-0">NAME</th>   
                                        </tr>
                                    </thead>
                                    <tbody>
                                    <?php
                                    if(DevicesStatus($connect, $xxid) == "Online"){
                                        for ($i = 0; $i <= count($Apps); $i++) {
                                            if($Apps[$i] != ""){
                                                echo "<tr><td>$i</td><td class='txt-oflo'>$Apps[$i]</td></tr>";
                                            }
                                        }
                                    }
                                    ?>      
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <footer class="footer text-center">Developed by Majdev</footer>
        </div>
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