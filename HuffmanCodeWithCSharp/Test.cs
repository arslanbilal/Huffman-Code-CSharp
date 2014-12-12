using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCodeWithCSharp
{
    class Test
    {
        // Test class provide us to test our program.
        static void Main(string[] args)
        {
            Console.Title = "Huffman Code with File, by bilalarslan"; // Setting the Console name.
            List<HuffmanNode> nodeList; // store nodes on List.
            
            ProcessMethods pMethods = new ProcessMethods();


            while (true)
            {
                Console.Clear();
                nodeList = pMethods.getListFromFile();
                Console.Clear();
                if (nodeList == null)
                {
                    setColor();
                    Console.WriteLine("File cannot be read!");
                    Console.WriteLine("Pressthe any key to continue or Enter \"E\" to exit the program.");
                    setColorDefault();
                    string choise = Console.ReadLine();
                    if (choise.ToLower() == "e")
                        break;
                    else
                        continue;
                }
                else
                {
                    Console.Clear();
                    setColor();
                    Console.WriteLine("#Symbols   -   #Frequency");
                    setColorDefault();
                    pMethods.PrintInformation(nodeList);
                    pMethods.getTreeFromList(nodeList);
                    pMethods.setCodeToTheTree("",nodeList[0]);
                    Console.WriteLine("\n\n");
                    setColor();
                    Console.WriteLine(" #   Huffman Code Tree   # \n");
                    setColorDefault();
                    pMethods.PrintTree(0, nodeList[0]);
                    setColor();
                    Console.WriteLine("\n\n#Symbols    -    #Codes\n");
                    setColorDefault();
                    pMethods.PrintfLeafAndCodes(nodeList[0]);
                    Console.WriteLine("\n\n");
                    setColor();
                    Console.WriteLine("Press the any key to contunie");
                    Console.WriteLine("Enter the\"E\" to exit the program.");
                    setColorDefault();
                    string choise = Console.ReadLine();
                    if (choise.ToLower() == "e")
                        break;
                    else
                        continue;

                }
            }
        }


        // These are methods that to change the color of the console secren. These are public because they must be accessible from ProcessMethods class. Instant method.
        public static void setColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void setColorDefault()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
