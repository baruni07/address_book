using System;

namespace Address_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address system management");          
            addressBook adrs_book_1 = new addressBook();

            adrs_book_1.addContact();
            Console.WriteLine("-----------------------------");
            adrs_book_1.addContact();
            adrs_book_1.displayAddressBook();

            addressBook adrs_book_2 = new addressBook();

            adrs_book_2.addContact();
            Console.WriteLine("-----------------------------");
            adrs_book_2.addContact();
            adrs_book_2.displayAddressBook();

            addressSystem adrs_system = new addressSystem();
            adrs_system.addAddressBook("address_book1", adrs_book_1);
            adrs_system.addAddressBook("address_book2", adrs_book_2);

            adrs_system.displayAddressSystem();

            adrs_system.searchPerson("chennai");
            adrs_system.countPerson("chennai", null);
            adrs_system.countPerson("", "tn");

        }
    }
}