using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Address_book
{
    public class Contact{
        public string f_name;
        public string l_name;
        public string email;
        public string address;
        public string city;
        public string state;
        public int zip;
        public long phone_num;
        public Contact(string l_name, string email, string address, string city, string state, int zip, long phone_num)
        {
            this.l_name = l_name;   
            this.email = email;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone_num = phone_num;
        }
    }
    public class addressBook
    {
        public IDictionary<string, Contact> address_book = new Dictionary<string, Contact>();
        public void addContact()
        {
            Console.Write("Enter first name: ");
            string f_name = Console.ReadLine();
            Console.Write("Enter last name: ");
            string l_name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter adress: ");
            string address = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.Write("Enter zip: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone number: ");
            long phone_num = Convert.ToInt64(Console.ReadLine());

            if (checkContactExist(f_name) == false)
            {
                Contact new_contact = new Contact(l_name, email, address, city, state, zip, phone_num);
                this.address_book.Add(f_name, new_contact);
            }
            else
            {
                Console.WriteLine("Person already exists");
            }
            
        }

        bool checkContactExist(string f_name)
        {  
            if(this.address_book.ContainsKey(f_name))
            {
                return true;
            }
            return false;
        }


        public void editContact()
        {
            Console.WriteLine("Enter person f_name whom you want to edit: ");
            string f_name = Console.ReadLine();
            if (this.address_book.Count == 0)
            {
                Console.WriteLine("Address book empty");
            }
            else
            {
                foreach(var person in this.address_book)
                {
                    if (person.Key == f_name)
                    {
                        Console.WriteLine("enter num option to edit:");
                        Console.WriteLine("2:l_name, 3:email, 4:address, 5:city, 6:state, 7:zip, 8:phone_num");
                        int edit_option = Convert.ToInt32(Console.ReadLine());

                        switch(edit_option)
                        {
                            case 2:
                                Console.Write("Enter new l_name: ");
                                person.Value.l_name = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter new email: ");
                                person.Value.email = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter new address: ");
                                person.Value.address = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Enter new city: ");
                                person.Value.city = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter new state: ");
                                person.Value.state = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Enter new zip: ");
                                person.Value.zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                Console.Write("Enter new phone_num: ");
                                person.Value.phone_num = Convert.ToInt64(Console.ReadLine());
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        public void deleteContact()
        {
            Console.WriteLine("Enter person f_name whom you want to delete: ");
            string f_name = Console.ReadLine();
            if (this.address_book.Count == 0)
            {
                Console.WriteLine("Address book empty");
            }
            else
            {
                foreach(var person in this.address_book)
                {
                    if (person.Key == f_name)
                    {
                        this.address_book.Remove(person.Key);
                        break;
                    }
                }
            }
        }

        public void displayAddressBook()
        {
            Console.WriteLine("Address book: ");
            int i = 1;
            foreach(var person in this.address_book)
            {
                Console.WriteLine("Person " + i);
                Console.WriteLine("     f_name: " + person.Key);
                Console.WriteLine("     l_name :" + person.Value.l_name);
                Console.WriteLine("     email :" + person.Value.email);
                Console.WriteLine("     address :" + person.Value.address);
                Console.WriteLine("     city :" + person.Value.city);
                Console.WriteLine("     state :" + person.Value.state);
                Console.WriteLine("     zip :" + person.Value.zip);
                Console.WriteLine("     phone_num :" + person.Value.phone_num);

                Console.WriteLine("-----------------------------");
                i++;

            }
        }

    }

    public class addressSystem
    {
        public IDictionary<string, addressBook> address_system_dict = new Dictionary<string, addressBook>();

        public void addAddressBook(string addrss_book_name, addressBook addrss_book)
        {
            this.address_system_dict.Add(addrss_book_name, addrss_book);
        }

        public void searchPerson(string city_state)
        {
            Console.WriteLine("persons in given state/city " + city_state + " is: ");
            foreach(var adrs_book in this.address_system_dict)
            {
                foreach (var person in adrs_book.Value.address_book)
                {
                    if (person.Value.state == city_state || person.Value.city == city_state)
                    {
                        Console.WriteLine("Person: " + person.Key);
                    }
                }
            }
            
        }

        public void countPerson(string city, string state)
        {
            if (state != null)
            {
                int cnt_state = 0;
                
                foreach(var adrs_book in this.address_system_dict)
                {
                    cnt_state += adrs_book.Value.address_book.Values.Count(x => x.state == state);
                }
                
                Console.WriteLine("Number of persons in given state: "+ state+" is: " + cnt_state);
            }
            if (city != null)
            {
                int cnt_city = 0;
                foreach(var adrs_book in this.address_system_dict)
                {
                    cnt_city += adrs_book.Value.address_book.Values.Count(x => x.city == city);
                }
                
                Console.WriteLine("Number of persons in given state: " + city + " is: " + + cnt_city);
            }

        }

        public void displayAddressSystem()
        {
            foreach(var adrs_book in this.address_system_dict)
            {
                Console.WriteLine("Address book name: " + adrs_book.Key);
                Console.WriteLine("Address book: ");
                int i = 1;
                foreach (var person in adrs_book.Value.address_book)
                {
                    Console.WriteLine("Person " + i);
                    Console.WriteLine("     f_name: " + person.Key);
                    Console.WriteLine("     l_name :" + person.Value.l_name);
                    Console.WriteLine("     email :" + person.Value.email);
                    Console.WriteLine("     address :" + person.Value.address);
                    Console.WriteLine("     city :" + person.Value.city);
                    Console.WriteLine("     state :" + person.Value.state);
                    Console.WriteLine("     zip :" + person.Value.zip);
                    Console.WriteLine("     phone_num :" + person.Value.phone_num);

                    Console.WriteLine("-----------------------------");
                    i++;

                }

            }
        }
    }
}
