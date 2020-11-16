// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBConnection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookSystem_MultiThreading
{
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            /// Specifying the connectionString from the sql server connection.
            string connectiongString = @"Data Source=DESKTOP-4849HJR;Initial Catalog=AddressBook_System;Integrated Security=True;User ID=dheermeena;Password=Dheer@1998";
            SqlConnection connection = new SqlConnection(connectiongString);
            return connection;
        }
    }
}
