using System.Buffers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// Write a program and ask the user to enter 5 numbers. 
// If a number has been previously entered, 
// display an error message and ask the user to re-try. 
// Once the user successfully enters 5 unique numbers, 
// sort them and display the result on the console.

namespace WhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Buffer= new int[5];
            int flag=1;
            int count=0;
            do
            {
                for(var i=0;i<5;i++)
                {   
                    Console.Write($"Enter element #{i+1}:");
                    int input=int.Parse(Console.ReadLine());
                    if(Array.IndexOf(Buffer,input)==-1)
                    {
                        Buffer[i]=input;
                        flag=0;
                    }
                    else
                    {
                        flag=1;
                        break;
                    }
                    
                }
            }while(flag==1);
            Array.Sort(Buffer);
            foreach (var item in Buffer)
            {
                Console.WriteLine(item);
            }  
        }   
        
    }
}