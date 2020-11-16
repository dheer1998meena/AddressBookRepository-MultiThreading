using System;

namespace AddressBookSystem_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System using MultiThreading");
            ///Creating instance class of AddressBookRepository class.
            AddressBookRepository repository = new AddressBookRepository();
            ///UC16 Retrieve all the contact details from the DB
            repository.RetrieveAllContactDetails();
        }
    }
}
