using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    //Process of creating a method in the derived class with the same signature and name in the base class
    //Method Overriding 
    //Run Time Polymorphism
    //Dynamic Polymorphism 
    //Late binding 
    public class MethodOverriding : BaseMethodOverriding
    {
        public override int PrintJob()
        {
            return 1;
        }

        //cannot new up the abstract class 
        //BaseAbstractMethodOverriding bs = new BaseAbstractMethodOverriding();
        BaseMethodOverriding bmo = new BaseMethodOverriding();

    }

    public class BaseMethodOverriding
    {
        //common Properties
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual int PrintJob()
        {
            //With Virtual Keyword we tell the derived classes that they can override this method 
            throw new NotImplementedException();
            //NEEDS default implementation
        }
    }

    //This class cannot be instantiated. 
    //Stops the direct usage of new-ing like BaseMethodOverriding class
    public abstract class BaseAbstractMethodOverriding
    {
        public abstract int ScanJob();
        //no implmentation needed. 
    }

}
