<?php
include($_SERVER['DOCUMENT_ROOT']."/core_config.php");



if(isset($_POST['core_loginbutton'])) { 
  $id = $_POST['core_id'];
  $password = sha1(md5($_POST['core_password']));
  if($password == FindDevices($connect, $id)["password"]){     
    header("Location: /dashboard/index.php?type=watch&core_id=$id&core_password=$password");
  }
  else{
      echo base64_decode("PGRpdiBjbGFzcz0icC1hbGVydCI+PHNwYW4gY2xhc3M9InAtY2xvc2VidG4iIG9uY2xpY2s9InRoaXMucGFyZW50RWxlbWVudC5zdHlsZS5kaXNwbGF5PSdub25lJzsiPiZ0aW1lczs8L3NwYW4+IDxzdHJvbmc+V2FybmluZyE8L3N0cm9uZz4gSUQgb3IgUGFzc3dvcmQgaXMgaW5jb3JyZWN0LiBQbGVhc2UgcmUtZW50ZXI8L2Rpdj4=");

  }
} 
?>

<html class="no-js"><head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>mCore | Login Page</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" type="image/x-icon" href="login/img/favicon.png">
    <link rel="stylesheet" href="login/css/bootstrap.min.css">
    <link rel="stylesheet" href="login/css/fontawesome-all.min.css">
    <link rel="stylesheet" href="login/font/flaticon.css">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&amp;display=swap" rel="stylesheet">
    <link rel="stylesheet" href="login/style.css">
</head>
<body> 
    <section class="fxt-template-animation fxt-template-layout10 loaded">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-6 col-12 fxt-bg-img" data-bg-image="login/img/figure/bg10-l.jpg" style="background-image: url(&quot;login/img/figure/bg10-l.jpg&quot;);">
                    <div class="fxt-header">
                        <a href="https://core.majdev.net/" class="fxt-logo"><img src="dashboard/dashboard-all/plugins/images/light.png"></a>
                        <a href="https://github.com/inc-Majdev/mCore/releases/download/v1.0.0/Client.exe" class="fxt-btn-ghost">Download</a>
                    </div>
                </div>
                <div class="col-md-6 col-12 fxt-bg-color">
                    <div class="fxt-content">                        
                        <div class="fxt-form">
                            <h2>Sign in to mCore</h2>
                            <form method="POST">
                                <div class="form-group">                                                
                                    <div class="fxt-transformY-50 fxt-transition-delay-3">                                                
                                        <input type="text" id="core_id" name="core_id" class="form-control" placeholder="ID" required="required">
                                    </div>
                                </div>
                                <div class="form-group">                                                
                                    <div class="fxt-transformY-50 fxt-transition-delay-4">                                                
                                        <input id="core_password" name="core_password" type="password" class="form-control" placeholder="Password" required="required">
                                        <i toggle="#password" class="fa fa-fw toggle-password field-icon fa-eye"></i>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="fxt-transformY-50 fxt-transition-delay-3">  
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="fxt-transformY-50 fxt-transition-delay-5">
                                        <div class="text-center">
											<input type="submit" id="core_loginbutton" name="core_loginbutton" class="fxt-btn-fill" value="Log in"/> 
                                        </div>
                                    </div>
                                </div>
                            </form>                            
                        </div> 
                        
                    </div>
                </div>                
            </div>
        </div>
    </section>
    <script src="login/js/jquery-3.5.0.min.js"></script>
    <script src="login/js/popper.min.js"></script>
    <script src="login/js/bootstrap.min.js"></script>
    <script src="login/js/imagesloaded.pkgd.min.js"></script>    
    <script src="login/js/validator.min.js"></script>
    <script src="login/js/main.js"></script>
</body>
</html>