using System;

namespace Address_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book management");          
            addressBook adrs_book = new addressBook();

            adrs_book.addContact();
            Console.WriteLine("-----------------------------");
            adrs_book.addContact();
            adrs_book.displayAddressBook();
           
            adrs_book.editContact();
            adrs_book.displayAddressBook();

            adrs_book.deleteContact();
            adrs_book.displayAddressBook();

        }
    }
}