using System;

namespace AddressBookUsingADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book using ADO.NET");

            AddressBook addressbook = new AddressBook();
            AddressBookModel contact = new AddressBookModel();
            AddressBookModel contact1 = new AddressBookModel();


            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1.AddContact \n2.EditContact \n3.DeleteContact \n4.RetriveStateorCity" +
                                  "\n5.SizeofBook\n6.SortPersonNameByCity\n7.identifyEachAddressbook\n8.CountByBookType\n9.Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());

                 switch (choice)
                    {
                        case 1:
                            #region add Contact
                            contact.First_Name = "Varun";
                            contact.Last_Name = "Brahmane";
                            contact.Address = "Loni kd";
                            contact.City = "Ahmadnagar";
                            contact.State = "Maharastra";
                            contact.Zip = "413713";
                            contact.Phone_Number = "7040391139";
                            contact.Email = "b@gmail.com";
                            contact.BookName = "one";
                            contact.AddressbookType = "Family";

                            #endregion
                            bool result = addressbook.AddContact(contact);
                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                        case 2:

                            #region new Contact (Editing)
                            contact.First_Name = "Saurabh";
                            contact.Last_Name = "Narhe";
                            contact1.Address = "Pune";
                            contact1.City = "Kothrud";
                            contact1.State = "Maharastra";
                            contact1.Zip = "123456";
                            contact1.Phone_Number = "8623000000";
                            contact1.Email = "sn@gmail.com";
                            contact.BookName = "Two";
                            contact.AddressbookType = "Friend";
                            #endregion
                            addressbook.EditContact(contact1);
                            Console.ReadKey();
                            break;

                        case 3:

                            contact.First_Name = "Vikram";
                            addressbook.DeleteContact(contact);
                            Console.ReadKey();
                            break;

                        case 4:
                            addressbook.RetrieveContact();
                            Console.ReadKey();
                            break;
                        case 5:
                            addressbook.AddressBookSize();
                            Console.ReadKey();
                            break;
                        case 6:
                            addressbook.SortPersonName();
                            Console.ReadKey();
                            break;
                        case 7:
                            addressbook.GetAddressBookType();
                            Console.ReadKey();
                            break;
                        case 8:
                            addressbook.GetNumberOfContacts();
                            Console.ReadKey();
                            break;

                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You Entred Wrong Choice, Try again.");
                            break;
                 }
            }
        }
    }
}
