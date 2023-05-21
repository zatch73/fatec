using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructorStaticEmployee.entities
{
    public class Employee
    {
        public static int numberEmployees = 0;
        public string Name { get; set; }
        public static int Code { get; set; }
        public float Salary { get; set; }


        static Employee(){
            Code = 100;
        }
        public Employee(string name, float salary){
            this.Name = name;
            this.Salary = salary;
            Code++;
            numberEmployees++; 
        }
        
        // Reajuste salárial
        public float SalaryReadjustment(float value){
            this.Salary += value;
            return this.Salary;
        }
        
        public override string ToString(){
            return this.Name + " " + Code + " " + this.Salary;
        }


    }
}