using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class test
    {
        static void Main()
        {
            int dash=4;
            string longest;
            int length;
            string[] titles = new string[] {"mark1", "mark2", "mark3", "mark4", "mark5", "Total", "Average" };
            string[] student = new string[5];
            int[,] marks = new int[5,5];
            int[] total = new int[5];
            float[] average = new float[5];
            for(int i=0;i<student.Length;i++)
            {
                total[i] = 0;
                Console.WriteLine("Enter the name of the student");
                student[i] = Console.ReadLine();
                Console.WriteLine("Enter the five subject marks of the student:");
                for (int j=0;j<5;j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                    total[i] = total[i] + marks[i, j];
                }
                average[i] = total[i] / 5;
            }

            longest = student.OrderByDescending(s => s.Length).First();
            length = longest.Length <= 4 ? 4 : longest.Length;
            dash = dash + length;
            Console.WriteLine("Marklist of the Students:");
            Console.Write("\n");
            Console.Write("Name"+new string(' ',length));
            foreach (var item in titles)
            {
                Console.Write("{0,2}" + "  ", item);
                dash = dash + 2 + item.Length;
            }
            Console.Write("\n");
            for (int i = 0; i < dash-2; i++)
                Console.Write("-");
            Console.Write("\n");

            for (int i = 0; i < 5; i++)
            {
                int str;
                str = student[i].Length <= 4 ? length + 4 - student[i].Length : length-(student[i].Length-4);
                Console.Write(student[i]+new string(' ',str));
                for (int j = 0; j < 5; j++)
                {
                    int l = marks[i, j].ToString().Length == 1 ? 6 : marks[i, j].ToString().Length == 2 ? 5 : 4; 
                    Console.Write(marks[i, j]+new string(' ', l));
                }
                Console.Write(total[i]+ new string(' ', total[i].ToString().Length == 1 ? 6 : total[i].ToString().Length == 2 ? 5 : 4));
                Console.Write(average[i]+"\n");
            }
            Console.ReadLine();
        }
    }
}
