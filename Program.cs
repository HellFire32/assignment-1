// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System. Collections.Generic;

namespace ConsoleApp1
{
   
    class Student
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        
        public static int count = 0;
        public Student(string name, string email, int age)
        {
            this.Name = name;
            this.Email = email;
            this.Age = age;
        }

        public double[] grades= new double[5];
        //public double[] grades = Enumerable.Repeat(double.NaN, 5).ToArray();
        public bool areGradesAdded;

        public double GetAverage()
        {
            double avg = 0;
            foreach (double grade in grades)
            {
                avg += grade;
            }
      
            return avg / 5.0;
        }    
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int input1;
            bool areGradesAdded = false;
            Console.WriteLine("Welcome to Student Database.");
            List<Student> students = new List<Student>();

            goto1:
            try 
            {
                {
                    Console.Write("\nChoose an action:\n1. Add student\n2. Add grade\n3. Review student\n4. Quit\n\nResponse: ");
                    input1 = int.Parse(Console.ReadLine());
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.Write("\nChoose an action:\n1. Add student\n2. Add grade\n3. Review student\n\nResponse: ");
                input1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.Write("\nChoose an action:\n1. Add student\n2. Add grade\n3. Review student\n\nResponse: ");
                input1 = int.Parse(Console.ReadLine());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.Write("\nChoose an action:\n1. Add student\n2. Add grade\n3. Review student\n\nResponse: ");
                input1 = int.Parse(Console.ReadLine());
            }

            if (input1 == 1 || input1 == 2 || input1 == 3 || input1 == 4)
            {
                switch (input1)
                {

                    case 1:

                        string name, email;
                        int age;
                        
                        goto2:

                        try 
                        {
                            Console.Write("\nPlease enter the student's name: ");
                            name = Console.ReadLine();
                        } 
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto2;
                        }
                        catch (ArgumentNullException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto2;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto2;
                        }

                        goto3:

                        try
                        {
                            Console.Write("Please enter the student's email: ");
                            email = Console.ReadLine();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto3;
                        }
                        catch (ArgumentNullException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto3;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto3;
                        }

                    goto4:

                        try
                        {
                            Console.Write("Please enter the student's age: ");
                            age = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto4;
                        }
                        catch (ArgumentOutOfRangeException y)
                        {
                            Console.WriteLine(y.Message);
                            goto goto4;
                        }
                        catch (ArgumentNullException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto4;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto4;
                        }
                        catch (OverflowException ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto goto4;
                        }

                        Student newStudent = new Student(name, email, age);
                        students.Add(newStudent);      
                        students[Student.count].areGradesAdded = false;
                        Student.count++;
                        goto goto1;
                        //break;

                   case 2:

                        if (Student.count == 0)
                        {
                            Console.WriteLine("\nPlease add a student first!");
                            goto goto1;
                        }
                        
                        else
                        {
                            int input2;

                            try
                            {
                                Console.WriteLine("Please choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }

                            catch (NullReferenceException ex)
                            {
                                Console.WriteLine($"\n{ex.Message}");
                                Console.WriteLine("\nPlease choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input2 = int.Parse(Console.ReadLine());
                            }

                            catch (FormatException ex)
                            {
                                Console.WriteLine($"\n{ex.Message}");
                                Console.WriteLine("\nPlease choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input2 = int.Parse(Console.ReadLine());
                            }

                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("\nPlease enter the grade #{0}: ", i + 1);
                                students[input2 - 1].grades[i] = double.Parse(Console.ReadLine());
                            }

                            students[input2 - 1].areGradesAdded = true;
                            goto goto1;
                            //break;
                        }
                        

                   case 3:
  
                        int input3;

                        if (Student.count == 0)
                        {
                            Console.WriteLine("\nPlease add a student first!");
                            goto goto1;
                        }
                        else
                        {
                            try
                            {
                                Console.WriteLine("Please choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input3 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }

                            catch (NullReferenceException ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                Console.WriteLine("Please choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input3 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                Console.WriteLine("Please choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input3 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                Console.WriteLine("Please choose a student: ");
                                for (int i = 0; i < Student.count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {students[i].Name}");
                                }
                                Console.Write("\nResponse: ");
                                input3 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                            }

                            if (students[input3 - 1].areGradesAdded == true)
                            {
                                for (int i = 0; i < Student.count; i++)
                                {

                                    if (input3 == i + 1)
                                    {
                                        Console.WriteLine($"\nStudent's Profile:\nName: {students[i].Name}\nAge: {students[i].Age}\nEmail: {students[i].Email}\nAverage Grade: {students[i].GetAverage()}");
                                        if (students[i].GetAverage() < 2.0)
                                            Console.WriteLine("Warning: Student must be advised of a failing grade");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Grades for this student are not found. Please add grades beforehand.");
                                goto goto1;
                            }

                            goto goto1;
                            //break;
                        }

                    case 4:
                        Console.WriteLine("Thank you for using our database.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input!");
                goto goto1;
            }
                
        }
    }
}
