using System;

namespace Stacks
{
    class Program
    {
        public static int[] stk = new int[5];
        public static int top = -1;
        static void Main(string[] args)
        {
            
            int ch;
            bool check = false;
            int el;
            Console.WriteLine("Welcome");
            do
            {
                Console.WriteLine("\n1.push 2.pop 3.display 4.exit\nEnter ur choice: ");
                ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the element you want to add to the stack");
                        el = Int32.Parse(Console.ReadLine());
                        push(el);
                        break;
                    case 2:
                        pop();
                        break;
                    case 3:
                        display();
                        break;
                    case 4:
                        check = true;
                        break;
                }
            }
            while (!check);
        }
        
        public static void push(int el)
        {
            if (top > 4)
                Console.WriteLine("There's a stack overflow");
            stk[++top] = el;
            Console.WriteLine("Element successfully added");
        }
        public static void pop()
        {
            if(top < 0)
            {
                Console.WriteLine("There's nothing to be removed");
            }
            _ = stk[top--];
            Console.WriteLine("Element removed from the stack");
        }
        public static void display()
        {
            if (top < 0)
            {
                Console.WriteLine("There's nothing to be displayed");
            }
            else
            {
                foreach (var i in stk)
                {
                    Console.WriteLine("The elements in the stack are:");
                    Console.WriteLine($"The item is {i}");
                }
            }
        }

    }
}
