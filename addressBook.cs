using System;

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
        public Contact(string f_name, string l_name, string email, string address, string city, string state, int zip, long phone_num)
        {
            this.f_name = f_name;
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
        public List<Contact> address_book = new List<Contact>();
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

            Contact new_contact = new Contact(f_name, l_name, email, address, city, state, zip, phone_num);

            this.address_book.Add(new_contact);
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
                foreach(Contact person in this.address_book)
                {
                    if (person.f_name== f_name)
                    {
                        Console.WriteLine("enter num option to edit:");
                        Console.WriteLine("1:f_name, 2:l_name, 3:email, 4:address, 5:city, 6:state, 7:zip, 8:phone_num");
                        int edit_option = Convert.ToInt32(Console.ReadLine());

                        switch(edit_option)
                        {
                            case 1:
                                Console.Write("Enter new f_name: ");
                                person.f_name = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Enter new l_name: ");
                                person.l_name = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter new email: ");
                                person.email = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter new address: ");
                                person.address = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Enter new city: ");
                                person.city = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter new state: ");
                                person.state = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Enter new zip: ");
                                person.zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                Console.Write("Enter new phone_num: ");
                                person.phone_num = Convert.ToInt64(Console.ReadLine());
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
                foreach(Contact person in this.address_book)
                {
                    if (person.f_name == f_name)
                    {
                        this.address_book.Remove(person);
                        break;
                    }
                }
            }
        }

        public void displayAddressBook()
        {
            Console.WriteLine("Address book: ")
            int i = 1;
            foreach(Contact person in this.address_book)
            {
                Console.WriteLine("Person " + i);
                Console.WriteLine("     f_name: " + person.f_name);
                Console.WriteLine("     l_name :" + person.l_name);
                Console.WriteLine("     email :" + person.email);
                Console.WriteLine("     address :" + person.address);
                Console.WriteLine("     city :" + person.city);
                Console.WriteLine("     state :" + person.state);
                Console.WriteLine("     zip :" + person.zip);
                Console.WriteLine("     phone_num :" + person.phone_num);

                Console.WriteLine("-----------------------------");
                i++;

            }
        }

    }
}
