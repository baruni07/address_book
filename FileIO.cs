using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Address_book
{
    public class FileIO
    {
        public static void binarySerialization(addressBook ab)
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\Addres_ book\address_book_file.txt";
            
            FileStream file = File.OpenWrite(path);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, ab.address_book);

        }

        public static void binaryDeserialization()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\Addres_ book\address_book_file.txt";
            FileStream file = File.OpenRead(path);

            BinaryFormatter formatter = new BinaryFormatter();
            addressBook ab = (addressBook)formatter.Deserialize(file);
            Console.WriteLine("Address book detail: ");
            foreach(var person in ab.address_book)
            {
                Console.WriteLine("person : " + person.Key);
            }
            
        }
    }
}
