using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
        public class Shape    //BaseClass
        {

            public virtual double Area()
            {
                return 0;
            }
        }
        public class Square : Shape     //DerivedClass
        {
            public double Length { get; set; }

            public Square()
            {
                Length = 10;
            }
            public override double Area()
            {
                try
                {
                    return (Length * Length);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public class Circle : Shape     //Derivedclass
        {
            public double Radius { get; set; }
            public Circle()
            {
                Radius = 6.5;
            }
            public override double Area()
            {
                try
                {
                    return (3.14 * Radius * Radius);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public class Rectangle : Shape    //DerivedClass
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public Rectangle()
            {
                Height = 5;
                Width = 7;
            }
            public override double Area()
            {
                try
                {
                    return (Height * Width);
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    
}
