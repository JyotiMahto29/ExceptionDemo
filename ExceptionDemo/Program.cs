using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionDemo.StaticPolymorphism;

namespace ExceptionDemo
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                //Inheritance
                Peacock obj = new Peacock();
                obj.show1();
                obj.show2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                // Static Polymorphism
                StaticPolymorphism staticpolymorphism = new StaticPolymorphism();
                staticpolymorphism.Print("JYOTI", "MAHTO");
                staticpolymorphism.Print("Vadodara");
                staticpolymorphism.Print(012345678, "jyoti@gmail.com");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            { 
                //Abstraction
                Vehicle myVehicle = new Vehicle();             // Create a Vehicle object
                myVehicle.VehicleDetails("Car", "Red", 4, 50);  
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                //Encapsulation
                Encapsulation encapsulate = new Encapsulation();
                encapsulate.AccountNumber = 12345678;
                encapsulate.Name = "Bank";
                encapsulate.GetBalance();
                encapsulate.Deposit();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                //DynamicPolymorphism
                Shape square = new Square();
                Console.WriteLine("Area Of Square is : " + square.Area());
                Shape circle = new Circle();
                Console.WriteLine("Area Of Circle is : " + circle.Area());
                Shape rectangle = new Rectangle();
                Console.WriteLine("Area Of Rectangle is: " + rectangle.Area());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}