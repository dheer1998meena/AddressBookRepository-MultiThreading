// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
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
            /// UC17 Updates the column specified of the existing contact using name.
            repository.UpdateExistingContactUsingByName("Navya", "Upadhyay", "navya869@gmail.com");
            repository.RetrieveAllContactDetails();
        }
    }
}
