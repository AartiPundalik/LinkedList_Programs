using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter an number");
              
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedlist.Add(45);
                        linkedlist.Add(55);
                        linkedlist.Add(65);
                        break;
                    case 2:
                        linkedlist.AddReverse(65);
                        linkedlist.AddReverse(55);
                        linkedlist.AddReverse(45);
                        break;
                    case 3:
                        linkedlist.Display();
                        break;
                    
                }
            }
        }
    }
}
        
    

