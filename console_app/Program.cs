using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            //Commit from home_pc
            //Commit from place2

            //commit from place1 2019-03-21 4:10
            //commit from place1 2019-03-21 5:27
            //commit from place1 2019-03-21 5:28

            //commit from place2  2019-03-21 4:10
            //commit from place2  2019-03-21 5:17
            //commit from place2  2019-03-21 5:28
            //commit from place2 2019-04-10 3:02
            try
            {
                CFoo.Do();
                CScubbyDo.IveSomeClue();


                Method2();

                CScubbyDo.IveSomeClue();

                Method1();
            }
            catch (Exception e)
            {
                Console.WriteLine("excrption found");

            }

            CScubbyDo.IveSomeClue();
            CUtil.RoutineMethod1();
            Method1();
                  
        }

        static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        //commit from place2  2019-10-04 3:04
        //commit from place2  2019-10-04 3:15



    }
}
