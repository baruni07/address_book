// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //fileIO.fileExist();
            //BinaryOprtn.binarySerialization();
            //BinaryOprtn.binaryDeserialization();
            //BinaryOprtn.JSONserialization();
            //BinaryOprtn.JSONdeserialization();
            FileIO.binarySerialization();
            FileIO.binaryDeserialization();
        }
    }

    class fileIO
    {
        public static bool fileExist()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\sample1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                return true;
            }
            else
            {
                Console.WriteLine("File doesnt exist");
                return false;
            }
        }
        public static void readLines()
        {
            string path = @"C:\Users\223090003\Desktop\C#_bridgelabz\Trial1\FileOperations\sample1.txt";
            if(File.Exists(path))
            {
                string res = File.ReadAllText(path);
                Console.WriteLine(res);
            }
        }
    }
}
