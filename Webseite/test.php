<?PHP
$version = file_get_contents('https://auxilium.cc/auxilium.cc/mogelmodul/version.txt');
$check = file_get_contents('http://api.steampowered.com/ISteamApps/UpToDateCheck/v1?appid=730&version='.$version);

if (strpos($check,'"up_to_date": true') == true) {
    echo 'The hack is up2date.';
}

if (strpos($check,'"up_to_date": false') == true) {
    echo 'The hack is outdated.';
}

?>