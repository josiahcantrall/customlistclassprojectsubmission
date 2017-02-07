using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlistclassproject
{


    public class CustomList<T>
    {


        public T[] myFirstArray = new T[5];
        public int Count = 0;
        public int Capacity = 5;

        //public void Add(T addcows)
        //{
        //    Console.WriteLine("How many cowss do you want to add?");
        //    int cowCount = Int32.Parse(Console.ReadLine());

        //}

        public void Add(T value)
        {

            if (myFirstArray.Length < 0)
            {

            }

            else
            {

                //if (myFirstArray[0] = 0)
                //{
                //    Count++;
                //}
                //check if there are empty spaces in the array.  If there aren't we add more space
                T[] TempArray = new T[myFirstArray.Length];
                for (int i = 0; i < myFirstArray.Length; i++)
                {
                    //add logic to copy from old array into temp array
                }
                myFirstArray = TempArray;
                myFirstArray[Count] = value;
                Count++;
            }

            //public int BuySugar()
            //{
            //    Console.WriteLine("Sugar cubes cost $5 per cube.");
            //    Console.WriteLine("How many sugar cubes do you want?");
            //    int sugarCubes = Int32.Parse(Console.ReadLine());
            //    return sugarCubes;
            //}
            //public void AddSugarCubes(int sugarCubes)
            //{
            //    for (int i = 0; i < sugarCubes; i++)
            //    {
            //        Sugar sugar = new Sugar();
            //        inventory.sugars.Add(sugar);
            //    }
            //}
            //public int Remove(T variable)
            //{
            //    T[] customlist = new T[1];
            //    {

            //    }
            //}
        }
    }
}
