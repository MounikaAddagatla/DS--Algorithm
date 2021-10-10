using System;
using System.IO;

namespace DS_AlgorithemProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Data structure Practise Problems");
            string filePath = @"E:\DS--Algorithm\DS-AlgorithemProblems\List\List.txt";
            string text = File.ReadAllText(filePath);
            string[] stringArray = text.Split(" ");

            Console.WriteLine("1.Unordered List");
            Console.WriteLine("Enter Your Option");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            switch (choice)
            {

                case 1:
                    UnOrderList<string> unOrdered = new UnOrderList<string>();
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        unOrdered.AddLast(stringArray[i]);
                    }
                    //Get the input from user
                    Console.WriteLine("Enter the word to searched:");
                    string word = Console.ReadLine();
                    int found = unOrdered.SearchNode(word);
                    if (found == 1)
                    {
                        unOrdered.DeleteNode(word);
                    }
                    else
                    {
                        unOrdered.AddLast(word);
                    }
                    string data = unOrdered.Display();
                    File.WriteAllText(filePath, data);
                    break;
            }
            Console.ReadLine();
        }
    }
    
}
