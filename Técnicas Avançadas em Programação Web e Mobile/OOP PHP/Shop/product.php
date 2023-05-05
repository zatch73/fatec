<?php 
    class Product {
        private $name;
        private $brand;
        private $description;
        private $value;

        function __construct($name, $brand, $description, $value){
            $this->name = $name;
            $this->brand = $brand;
            $this->description = $description;
            $this->value = $value;
        }

        public function getName()
        {
            return $this->name;
        }

        public function setName($name)
        {
            $this->name = $name;
            return $this;
        }

        public function getBrand()
        {
            return $this->brand;
        }

        public function setBrand($brand)
        {
            $this->brand = $brand;
            return $this;
        }

        public function getDescription()
        {
            return $this->description;
        }

        public function setDescription($description)
        {
            $this->description = $description;
            return $this;
        }

        public function getValue()
        {
            return $this->value;
        }

        public function setValue($value)
        {
            $this->value = $value;
            return $this;
        }
        
        public function updateValue($porcent){
            $porcent /= 100;
            $this->setValue($this->value + ($this->value * $porcent));
        }

        public function showProduct(){
            echo "<div class='product'>";
            echo "Name: ".$this->name . "<br/>";
            echo "Brand: ".$this->brand . "<br/>";
            echo "Description: ".$this->description . "<br/>";
            echo "Value: ".$this->value . "<br/>";
            echo "</div>";
        }
    }

?>