using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    class ClassVersusStructUDT
    {
    }

    public class SampleClass
    {
        //referenceType
        //stored on a heap
        //heaps are public
        //does support inheritance
        //does support Polymorphism
        //does support garbage collection
        //can be abstract
    }

    public struct SampleStruct
    {
        //valueType
        //stored on the stack
        //stacks are private
        //does NOT support inheritance
        //does NOT support Polymorphism
        //does NOT support garbage collection
        //can NOT be abstract
    }
}
