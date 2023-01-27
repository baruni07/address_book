using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.CompilerServices;

namespace FileOperations

{
    [Serializable]
    public class AddressBook
    {
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone_num { get; set; }

        public AddressBook() { }
    }
    public class FileIO
    {
        public static void binarySerialization()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\address_book_file.txt";
            
            FileStream file = File.OpenWrite(path);
            AddressBook ab = new AddressBook();
            ab.f_name = "Baruni";
            ab.l_name = "Karthika";
            ab.email = "abc@ge.com";
            ab.state = "tn";
            ab.zip = "123";
            ab.city = "chennai";
            ab.phone_num = "1234";
            ab.address = "abc123";

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, ab);
            file.Close();
        }

        public static void binaryDeserialization()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\address_book_file.txt";
            FileStream file = File.OpenRead(path);

            BinaryFormatter formatter = new BinaryFormatter();
            AddressBook ab = (AddressBook)formatter.Deserialize(file);
            Console.WriteLine("Address book detail: ");
            Console.WriteLine("Person : ");
            Console.WriteLine("f_name: " + ab.f_name);
            Console.WriteLine("l_name: " + ab.l_name);
            Console.WriteLine("email: " + ab.email);
            Console.WriteLine("city: " + ab.city);
            Console.WriteLine("state: " + ab.state);
            Console.WriteLine("address: " + ab.address);
            Console.WriteLine("zip: " + ab.zip);
            Console.WriteLine("phone num: " + ab.phone_num);
            file.Close();


        }
        
    }
}
