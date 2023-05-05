<?php 
require "product.php";

$p1 = new Product("Phone", "PHONES100", "PHONE BLACK 64GB", 1000);
$p1->showProduct();
$p1->updateValue(20);
$p1->showProduct();
?>
