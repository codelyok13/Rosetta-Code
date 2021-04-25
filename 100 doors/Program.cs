using System;

namespace Rosetta_Code
{
    /*
     * Website: http://rosettacode.org/wiki/100_doors
     * 
    There are 100 doors in a row that are all initially closed.
    You make 100 passes by the doors.
    
    The first time through, visit every door and  toggle  the door  
    (if the door is closed,  open it;   
    if it is open,  close it).

    The second time, only visit every 2nd door   
    (door #2, #4, #6, ...),   and toggle it.
    
    The third time, visit every 3rd door   
    (door #3, #6, #9, ...), etc,   
    until you only visit the 100th door.
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create an array of one hundred booleans
             * An array of booleans make sense since the state of 
             * the doors can only be open or closed which maps to
             * the properties of a boolean type cleanly.
             * A boolean is a variable that can only one of two values: true or false
             * In this case, false means the door is closed
             * and true means the doors is open
             */
            bool[] doors = new bool[100];
            Array.Fill(doors, false); //initialize every boolean varaible in the array to false

            for (int skip = 1; skip <= 100; skip++)
            {
                //door must be skip-1 because arrays start at 0
                for(int door = skip-1; door < 100; door += skip)
                {
                    /*
                     * The code below is accessing one of the booleans
                     * in the array and then flipping that varaible's value.
                     * 
                     * Ex.
                     * Doors:   0   1   2   3   4
                     * Content: F   F   F   T   F
                     * 
                     * Door 3 Content: True
                     * 
                     * Booleans are able to use a special
                     * single operand operation called "Logical NOT"
                     * This is represented by using a "!" to tell 
                     * the door that it is NOT its content.
                     * 
                     * Ex.
                     * !Door 3 Content = NOT True = False
                     */
                    doors[door] = !doors[door];
                }
            }

            //This code just prints out the array in a way that is easy to see
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    char output = doors[i * 10 + j] ? 'T' : 'F';
                    Console.Write(output + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
