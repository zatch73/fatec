<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css" type="text/css">
    <title>Document</title>
</head>
<body>
    <?php
        require "Car.php";

        $car1 = new Car("default", "blue", "31F-313", 4);
        $car1->show();
        $car2 = new Car("default", "blue", "31F-313", 4);
        $car2->show();
        $car3 = new Car("default", "blue", "31F-313", 4);
        $car3->show();
        $car4 = new Car("default", "blue", "31F-313", 4);
        $car4->show();
    ?>
</body>
</html>
