using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Operations1
{
    public class JsonHandler
    {
        public void SerializeToJson(List<Student> students, string pathOfFile)
        {
            string json = JsonConvert.SerializeObject(students);
            File.WriteAllText(pathOfFile, json);
        }
        public List<Student> DeserializeFromJson(string pathOfFile)
        {
            string json = File.ReadAllText(pathOfFile);
            List<Student> newStudents = JsonConvert.DeserializeObject<List<Student>>(json);
            return newStudents;
        }
    }
}
