using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////qn1
            //Console.Write("Enter number: ");
            //int num =int.Parse(Console.ReadLine());
            //if(num%2==0)
            //{
            //    Console.WriteLine("It is an even number");
            //}
            //else
            //{
            //    Console.WriteLine("It is an odd number");
            //}

            ////qn2
            //Console.Write("Enter number: ");
            //int num =int.Parse(Console.ReadLine());
            //int absnum;
            //if(num<0)
            //{
            //    absnum = -1 * num;
            //}
            //else
            //{
            //    absnum = num;
            //}
            //Console.WriteLine("The absolute value of {0} is {1}", num, absnum);

            ////qn3
            //bool anotherItem = true;
            //double total = 0;
            //while (anotherItem)
            //{
            //    Console.Write("Enter item quantity: ");
            //    int quantity = int.Parse(Console.ReadLine());
            //    Console.Write("Enter item price: ");
            //    int price = int.Parse(Console.ReadLine());
            //    total += (quantity * price);
            //    Console.WriteLine("Add another item?(y/n)");
            //    char yn = char.Parse(Console.ReadLine());
            //    if (yn == 'y')
            //    {
            //        anotherItem = true;

            //    }
            //    else
            //    {
            //        anotherItem = false;
            //    }
            //}
            //if (total > 5000)
            //{
            //    total = total - (0.1 * total);

            //}
            //Console.WriteLine("The total expenses: {0}", total);

            ////qn 4
            //Console.Write("Enter cost price: ");
            //int cp = int.Parse(Console.ReadLine());
            //Console.Write("Enter selling price: ");
            //int sp = int.Parse(Console.ReadLine());
            //float profitLoss = (float)(((sp - cp) * 100) / cp);
            //if(profitLoss>0)
            //{
            //    Console.WriteLine("It is profit. Profit percentage is {0}%", profitLoss);

            //}
            //else if(profitLoss<0)
            //{
            //    Console.WriteLine("It is loss. loss percentage is {0}%", profitLoss);
            //}
            //else
            //{
            //    Console.WriteLine("No profit No Loss");
            //}

            ////qn5
            //Console.Write("Enter Ram age: ");
            //int ram = int.Parse(Console.ReadLine());
            //Console.Write("Enter sulabh age: ");
            //int sulabh = int.Parse(Console.ReadLine());
            //Console.Write("Enter ajay age: ");
            //int ajay = int.Parse(Console.ReadLine());
            //if(ram<sulabh)
            //{
            //    if(ram<ajay)
            //    {
            //        Console.WriteLine("ram is youngest");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ajay is youngest");
            //    }
            //}
            //else
            //{
            //    if(sulabh<ajay)
            //    {
            //        Console.WriteLine("sulabh is youngest");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ajay is youngest");
            //    }
            //}

            ////qn 6
            //Console.Write("Enter angle 1 ");
            //float ang1 = float.Parse(Console.ReadLine());
            //Console.Write("Enter angle 2 ");
            //float ang2 = float.Parse(Console.ReadLine());
            //Console.Write("Enter angle 3 ");
            //float ang3 = float.Parse(Console.ReadLine());
            //if((ang1+ang2+ang3)==180)
            //{
            //    Console.WriteLine("It is a valid triangle");
            //}
            //else
            //{
            //    Console.WriteLine("It is not a valid triangle");
            //}

            ////qn 7
            //Console.Write("Enter year: ");
            //int year = int.Parse(Console.ReadLine());
            //if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            //{
            //    Console.WriteLine("{0} is a leap year\n", year);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a leap year\n", year);
            //}

            ////qn 8
            //Console.Write("Basic salary: ");
            //int basic = int.Parse(Console.ReadLine());
            //double hra, da;
            //if(basic<1500)
            //{
            //    hra = 0.1 * basic;
            //    da = 0.9 * basic;

            //}
            //else
            //{
            //    hra = 500;
            //    da = 0.98 * basic;

            //}
            //double gross = basic + hra + da;
            //Console.WriteLine("The gross salary is :{0}", gross);

            ////qn 9
            //Console.Write("subject 1 score: ");
            //int sub1 = int.Parse(Console.ReadLine());
            //Console.Write("subject 2 score: ");
            //int sub2 = int.Parse(Console.ReadLine());
            //Console.Write("subject 3 score: ");
            //int sub3 = int.Parse(Console.ReadLine());
            //Console.Write("subject 4 score: ");
            //int sub4 = int.Parse(Console.ReadLine());
            //Console.Write("subject 5 score: ");
            //int sub5 = int.Parse(Console.ReadLine());
            //float percentage = ((float)(sub1 + sub2 + sub3 + sub4 + sub5) / 500)*100;
            //Console.WriteLine("percentage is {0}%",percentage);
            //if(percentage>=60)
            //{
            //    Console.WriteLine("first division!");
            //}
            //else if(percentage>=50&&percentage<=59)
            //{
            //    Console.WriteLine("second division!");
            //}
            //else if (percentage >= 40 && percentage <= 49)
            //{
            //    Console.WriteLine("third division!");
            //}
            //else if(percentage<40)
            //{
            //    Console.WriteLine("Fail");
            //}

            ////qn 10
            //float a, b, c;
            //double root1, root2, imaginary, discriminant;

            //Console.WriteLine("\nEnter values of a, b, c of Quadratic Equation :  ");
            //a=float.Parse(Console.ReadLine());
            //b = float.Parse(Console.ReadLine());
            //c = float.Parse(Console.ReadLine());

            //discriminant = (b * b) - (4 * a * c);

            //if (discriminant > 0)
            //{
            //    root1 = (-b + Math.Sqrt(discriminant) / (2 * a));
            //    root2 = (-b - Math.Sqrt(discriminant) / (2 * a));
            //    Console.WriteLine("\nTwo Distinct Real Roots Exists: root1 = {0} and root2 ={1}", root1, root2);
            //}
            //else if (discriminant == 0)
            //{
            //    root1 = root2 = -b / (2 * a);
            //    Console.WriteLine("\nTwo Equal and Real Roots Exists: root1 ={0} and root2 ={1}", root1, root2);
            //}
            //else if (discriminant < 0)
            //{
            //    root1 = root2 = -b / (2 * a);
            //    imaginary = Math.Sqrt(-discriminant) / (2 * a);
            //    Console.WriteLine("\nTwo Distinct Complex Roots Exists: root1 = {0}+{1} i and root2 ={0}-{1} i", root1, imaginary);
            //}






        }
    }
}
