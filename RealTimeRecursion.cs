using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyConcepts
{
    public static class RealTimeRecursion
    {

        public static void FindFiles(string path)
        {
            //print all files in folder
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            //get all directories within folder
            foreach (string directory in Directory.GetDirectories(path))
            {
                //recursive call to itself
                FindFiles(directory);
            }
        }



    }
}
