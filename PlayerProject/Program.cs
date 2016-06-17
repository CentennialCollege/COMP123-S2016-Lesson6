using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Tom Tsiliopoulos
 * Date: June 17, 2016
 * StudentID: 300818557
 * Description: This Program tests the Player and Enemy Classes
 * Version: 0.01 - Initial Test version  - testing basic classes and methods
 */

namespace PlayerProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player greenPlayer = new PlayerProject.Player("green");

            greenPlayer.SetFacing(new Vector2().North(10));

            Console.WriteLine(greenPlayer.ToString());


            WaitForAnyKey();
        }

        /**
         * <summary>
         * Utility method to wait for a console key press from the user 
         * </summary>
         * 
         * @method WaitForAnyKey
         * @returns {void}
         */
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
