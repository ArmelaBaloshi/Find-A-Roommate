﻿// See https://aka.ms/new-console-template for more information
using FindMeARoomate.BusinessLayer;
using FindMeARoomate.DataLayer.DatabaseContext;
using FindMeARoomate.DataLayer.Entities;
Console.WriteLine("Welcome to Find Roommate Application!");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Menu");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("1 - Register");
Console.WriteLine("2 - Get All students");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        {
            //Register
            StudentService studentService = new StudentService();
            studentService.RegisterStudent();
            break;
        }

        case 2: 
        {
            //Get all students

            var studentService = new StudentService();
            var students = new List<Student>();
         
          students= studentService.GetStudents();

            foreach (var s in students)
            {

                Console.WriteLine(s.Name + "         " + s.Surname + "        " + s.Address);
            }
        }
            break; 
        }
