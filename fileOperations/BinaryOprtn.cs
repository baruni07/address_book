using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace FileOperations
{
    internal class BinaryOprtn
    {
        public static void binarySerialization()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\binaryFile.txt";
            PersonData person = new PersonData();
            person.name = "bk";
            person.age = 20;
            FileStream file = File.OpenWrite(path);
            
            BinaryFormatter formatter= new BinaryFormatter();
            formatter.Serialize(file, person);
        
        }

        public static void binaryDeserialization() 
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\binaryFile.txt";
            FileStream file = File.OpenRead(path);
            
            BinaryFormatter formatter= new BinaryFormatter();
            PersonData person = (PersonData)formatter.Deserialize(file);
            Console.WriteLine("Person detail: ");
            Console.WriteLine("Name : " + person.name + " age: " + person.age);
        }

        public static void JSONserialization()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\jsonFile.json";
            PersonData person = new PersonData() { name = "bk", age = 20 };
            string res = JsonConvert.SerializeObject(person);
            File.WriteAllText(path, res);
        }

        public static void JSONdeserialization()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\jsonFile.json";
            string res = File.ReadAllText(path);
            PersonData person = JsonConvert.DeserializeObject<PersonData>(res);
            Console.WriteLine("detail: name: " + person.name + " age: " + person.age);
        }
    }
}
