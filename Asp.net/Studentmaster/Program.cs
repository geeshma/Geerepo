using System;
using Studentmaster.Entities;
using System.Linq;
using System.Collections.Generic;
namespace Studentmaster
{
    class Program
    {
        public static void GetAllStudents()
        {
            TrainingContext db = new TrainingContext();
            List<StudentMaster> list = db.StudentMasters.ToList();
            foreach(var item in list)
            {
                Console.WriteLine($"StudCode:{item.StudCode}"+
                                    $"StudName:{item.StudName}"+
                                    $"DeptCode:{item.DeptCode}"+
                                    $"StudDob:{item.StudDob}"+
                                    $"Address:{ item.Address}");
            }
        }
        public static void GetStudentsbycode(decimal Stud_Code)
        {
            TrainingContext db = new TrainingContext();
            StudentMaster details = db.StudentMasters.SingleOrDefault(b => b.StudCode == Stud_Code);
            Console.WriteLine(      $"StudName:{details.StudName}" +
                                    $"DeptCode:{details.DeptCode}" +
                                    $"StudDob:{details.StudDob}" +
                                    $"Address:{details.Address}");
        }
        public static void AddStudent(StudentMaster studentmaster)
        {
            TrainingContext db = new TrainingContext();           
                db.StudentMasters.Add(studentmaster); //adds record to Studentmaster table
         

        }
        static void Main(string[] args)
        {
           /*GetAllStudents();
            Console.WriteLine("Enter student code");
            decimal Stud_code = decimal.Parse(Console.ReadLine());
            GetStudentsbycode(Stud_code);*/
            
            StudentMaster studentmaster = new StudentMaster()
            {
                StudCode = 100166,
                StudName="Geeshma",
                DeptCode=133,
                
                Address="G"
            };
            AddStudent(studentmaster);
            GetAllStudents();
        }
    }
}
