using System;
using Struct;

namespace Struct{
    class Program{
        static void Main(string[] args){
            ClientS c1 = new ClientS("Luan", "931231331", "20/10/2000", "luan@duck.com");
            System.Console.WriteLine(c1.show());
        }
    }
}