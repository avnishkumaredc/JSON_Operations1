using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Operations1
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonHandler jsonHandler = new JsonHandler();
            string pathOfFile = "C:\\Ecolab-Training\\cs-projects\\JSON_Operations1\\JSON_Operations1\\dummyData.json";
            List<Student> students = jsonHandler.DeserializeFromJson(pathOfFile);
            Console.WriteLine("below are the before results");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.name} having id = {student.id} pays fess = {student.fees} and gender = {student.gender}");
            }
            students[0].name = "editedname1";
            students[1].name = "editedname2";
            students[2].fees = -10.11122;
            jsonHandler.SerializeToJson(students, pathOfFile);
            Console.WriteLine("below are the after results");
            students = jsonHandler.DeserializeFromJson(pathOfFile);
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.name} having id = {student.id} pays fess = {student.fees} and gender = {student.gender}");
            }
        }
    }
}
