using ManBoyInheritanceApp.Domain;
using System;

namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            //  CaseStudy2();

            //CaseStudy3();

            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Infant());
            AtThePark(new Toddler());
            AtThePark(new Boy());

        }

        private static void AtThePark(Man x)//Polymorphic method (ISA)
        
        {
            Console.WriteLine("At the park..");
            x.Play();
        
        }

        private static void CaseStudy3()
        {
            Man x; // IS a man or subclasses of man
            x = new Boy();

            x.Play();
            x.Read();

            //Boy temp = x as Boy;
            //temp.Eat();
           


        }

        private static void CaseStudy2()
        {
            Boy y;//(ISA) y expects boy object

            y = new Boy();
            y.Play();
            y.Eat();
            y.Read();
           


        }

        private static void CaseStudy1()
        {
            Man x;// (ISA) x expects a Man object
            x = new Man();
            x.Play();
            x.Read();
        }
    }
}
