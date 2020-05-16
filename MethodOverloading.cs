using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    //This method is also known as 
    //Method Overloading, 
    //Early Binding, 
    //Compile Time Polymorphism or 
    //Static Binding.
    public class MethodOverloading
    {
        public int add(int a, int b)  //two int type Parameters method  
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public float add(float a, float b, float c)
        {
            return a + b + c ;
        }
        public float add(float a, float b, float c, float d)
        {
            return a + b + c + d;
        }

    }
}
