using System;

namespace classMembers
{
    class Vehicle
    {
        // Fields are variables that are declared within a class.  They may be of any type, for example, a Vehicle class may have MaxNumPassengers, Color, and MaxSpeed, each represented by a int, string, and double, respectively.
        public int MaxNumPassengers;
        public string Color;
        public double MaxSpeed;


        // Methods
        // Methods are functions that are declared within a class.  You must declare their return type, as well as the types of any input arguments.  Methods may be overloaded, meaning you may provide more than one method of the same name - provided each has different input arguments.  Invocation of an overloaded method is determined by the argument(s) you pass to the method call.
        public void MakeNoise()
        {
            System.Console.WriteLine("Beep!");
        }
        // Properties are a bit of a hybrid between a field and a method.  They appear as if they are a field, but behave more like a method.  They work by using two keywords, known as property accessors: get and set - each with separate code blocks that will either return or assign a value.  Typically properties are used to provide safety controls over your fields.  get  accessors (commonly referred to as getters) must return a value of the type declared by the property.  set accessors (or setters) make use of the value keyword which is determined by the right-hand value of a property assignment.  You may provide logic within your property's code blocks to control how values are returned/assigned.
        public string ColorProp
        {
            get{
                return $"This thing is {Color}";
            }
            set{
                Color = value;
            }
        }
        //         Auto-Implemented Properties
        // You may also use properties to generate fields, by just providing the get  and set keywords without any code blocks.  This will create a so-called "backing field" for your class, which is known to the compiler but hidden from your source code. Auto-implemented properties are used throughout the ASP web-framework - so it will be good to be aware of them.  The syntax for auto-implemented properties is quite simple:
        public string Name{get;set;}
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
