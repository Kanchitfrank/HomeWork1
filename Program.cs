using System;

namespace Homework1{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Password : "); int password = int.Parse(Console.ReadLine());
            Console.Write("Agency : "); string agency = (Console.ReadLine());
            if(agency == "CIA"){
                Console.WriteLine("Hello");
            }else{
                Console.WriteLine("False");
            }
        }
    }
}