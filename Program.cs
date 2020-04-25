using System;
using System.IO;

namespace lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines(@"C:\Users\Lenovo X1 Carbon\source\repos\lab3.3\111.txt");
            int sum; 
            string[] numbers;

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo X1 Carbon\source\repos\lab3.3\111.txt"))
            {
                for (int i = 0; i < file.Length; i++)
                {
                    sum = 0;
                    numbers = file[i].Split(',');
                    for (int j = 0; j < numbers.Length; j++)
                        sum += Int32.Parse(numbers[j]);
                    sw.WriteLine(file[i] + " = " + sum);

                }
                sw.Close();
            }

        }
       
    }
   
}


