<?php 
    class Car{
        private $model;
        private $color;
        private $licensePlate;
        private $numbersDoors;

        function __construct($model, $color, $plate, $numbers){
            $this->model = $model;
            $this->color = $color;
            $this->licensePlate = $plate;
            $this->numbersDoors = $numbers;
        }

        function set_model($model){
            $this->model = $model;
        }

        function set_licensePlate($licensePlate){
            $this->licensePlate = $licensePlate;
        }

        function set_color($color){
            $this->color = $color;
        }

        function set_numbersDoors($numbers){
            $this->numbersDoors = $numbers;
        }

        function get_model(){
            return $this->model;
        }

        function get_licensePlate(){
            return $this->licensePlate;
        }

        function get_color(){
            return $this->color;
        }

        function get_numbersDoors(){
            return $this->numbersDoors;
        }

        public function show(){
            echo "<div class='car'>";
            echo "Model: ".$this->model . "<br/>";
            echo "Color: ".$this->color . "<br/>";
            echo "License Plate: ".$this->licensePlate . "<br/>";
            echo "Numbers Doors: ".$this->numbersDoors . "<br/>";
            echo "</div>";
        }

    }
?>