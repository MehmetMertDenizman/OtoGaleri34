using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enesOgrenciUygulamasi
{
    public class Student
    {
        private int id ;
        private string name;
        private int age;
        private string sur;
        private int vize;
        private int vize2;
        private int final;
        private string school;
        //public Student(int _id, string _name, int _age, string _sur, int _vize, int _vize2, int _final, string _school)
        public Student()
        {
            Console.Write("ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Surname: ");
            sur = Console.ReadLine();
            Console.Write("Vize: ");
            vize = int.Parse(Console.ReadLine());
            Console.Write("Vize2: ");
            vize2 = int.Parse(Console.ReadLine());
            Console.Write("School: ");
            school = Console.ReadLine(); ;

        }
        public void stuInfo()
        {
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Surname: "+sur);
            Console.WriteLine("School: " + school);
            Console.WriteLine("Vize: " + vize + " Vize 2: " + vize2);
            Console.WriteLine("Final: " + stuAverage());
        }
        public int stuAverage()
        {
            return final = (vize + vize2) / 2;
        }
        public void stuSchool()
        {
            Console.WriteLine("School name is: ", school);
        }
        public int MyProperty {
            get
            {
                return MyProperty;

            }
            set 
            { 
                MyProperty = value;
            } }//PROP PROPERT
    }
    
   
}
