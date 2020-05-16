using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace KeyConcepts
{
    class Arrays
    {

        public void ArraysAreStronglyTyped()
        {
            int[] array = new int[2];
            array[0] = 1;
            //not allowed
            //array[1] = "string";
        }

        public void ArraysStoringManyDataTypes()
        {
            //object is base type of all types in c#
            //all types inherit from Object Type, 
            object[] array = new object[2];
            array[0] = 1;
            //allowed
            array[1] = "string";
        }

        public void ArraysStoringComplexTypes()
        {
            object[] array = new object[2];
            Customer c = new Customer();
            c.ID = 1;
            c.Name = "Joe Smith";
            //allowed
            array[2] = c;
        }

        public void ArrayListUseForStoringDifferentDataTypes()
        {
            Customer c = new Customer();
            c.ID = 1;
            c.Name = "Joe Smith";

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Jane Smith");
            arrayList.Add(c);

        }


        class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return this.Name;
            }

        }
    }
}
