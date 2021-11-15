<?php 
$url = ".\\NUnitAllureProject\\allure-report\\widgets\\summary.json";
$title = "A1QA Allure Report";
$strings = file_get_contents($url, FILE_USE_INCLUDE_PATH);

$stringsreplace = str_replace("Allure Report", $title, $strings);

file_put_contents($url, $stringsreplace);

?>