<?php 
    class Disciplina {
        private $name;
        private $professor;
        private $numeroAulas;
        private $turno;

        function __construct($name, $professor, $numeroAulas, $turno){
            $this->name = $name;
            $this->professor = $professor;
            $this->numeroAulas = $numeroAulas;
            $this->turno = $turno;
        }

        public function getName() {
            return $this->name;
          }
        
          public function setName($name) {
            $this->name = $name;
          }
        
          public function getProfessor() {
            return $this->professor;
          }
        
          public function setProfessor($professor) {
            $this->professor = $professor;
          }
        
          public function getNumeroAulas() {
            return $this->numeroAulas;
          }
        
          public function setNumeroAulas($numeroAulas) {
            $this->numeroAulas = $numeroAulas;
          }
        
          public function getTurno() {
            return $this->turno;
          }
        
          public function setTurno($turno) {
            $this->turno = $turno;
          }
       
        public function showProfessor(){
            echo "<div class='product'>";
            echo "nome: ".$this->name . "<br/>";
            echo "professor: ".$this->professor . "<br/>";
            echo "Número de aulas: ".$this->numeroAulas . "<br/>";
            echo "turno: ".$this->turno . "<br/>";
            echo "</div>";
        }
    }

?>