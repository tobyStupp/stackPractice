using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace stackPractice
{
    class Program
    {
        static Stack<int> Copy(Stack<int> s)
        {
            throw new NotImplementedException();
        }
        static void Spill(Stack<int> destination, Stack<int> source)
        {
            // take all elements in source and transfering to destination
        }
        static void Print (Stack<int> s)
        {
            // prints the stack without changing its build
        }
        static bool Exists(Stack<int> stack, int x)
        {
            throw new NotImplementedException();
        }
        static int CountAndRemove (Stack<int> stack, int x)
        {
            //input => a stack and a number
            //output=> counts how many time x appears in stack  and removes them
            throw new NotImplementedException();
        }
        static int Count (Stack<int> stack, int x)
        {
            //input => a stack and a number
            //output => counts how many times x exists in the stack
            throw new NotImplementedException();
        }
        static void AddSorted (Stack<int> s, int x)
        {
            // Add individual number to stack
        }
       
        static Stack<int> SortAll (Stack<int> s)
        {
            throw new NotImplementedException();
        }
        static bool aXbXa (string s)
        {
            // check whether the string is arranged as string until X from then on b is the oposite order than a, and the last thrird is the same as the original
            // stack/
            throw new NotImplementedException();
        }
        static int RemoveBiggest (Stack<int> s)
        {
            throw new NotImplementedException();
        }
      
        static bool AllDifferent(Stack<int> s)
        {
            // checks and returns true if all the numbers are different
            throw new NotImplementedException();
        }
        static Stack<int> Merge(Stack<int> s1, Stack<int> s2)
        {
            // merge two ordered stacks 
            throw new NotImplementedException();
        }
        static Stack<int> Gather(Stack<int> s)
        {
            //gathers same numbers and adds them and saves in new stack. if has only one, doesn't add the value to stack
            // example [3,3,3,4,5,5,1,1,1,1] => [9, 10,4]
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
        }
    }
}
