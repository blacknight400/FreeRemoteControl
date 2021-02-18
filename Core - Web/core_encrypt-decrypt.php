<?php
function Encrypt($string){
    $encrypt_method = 'AES-256-CBC'; 
    $secret_key = '`+[%}3.$-&!]50.|%_078~{($7^"4{\(=~%1*!5_-;$3)';
    $secret_iv = '22-=**_'; 
    $key = hash('sha256', $secret_key);
    $iv = substr(hash('sha256', $secret_iv), 0, 16); 
    return openssl_encrypt($string,$encrypt_method, $key, false, $iv);
}

function Decrypt($string){
    $encrypt_method = 'AES-256-CBC'; 
    $secret_key = '`+[%}3.$-&!]50.|%_078~{($7^"4{\(=~%1*!5_-;$3)';
    $secret_iv = '22-=**_'; 
    $key = hash('sha256', $secret_key);
    $iv = substr(hash('sha256', $secret_iv), 0, 16); 
    return openssl_decrypt($string,$encrypt_method, $key, false, $iv);
}
?>