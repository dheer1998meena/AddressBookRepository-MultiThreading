-- Using the address book services database
use AddressBook_System;
-- Adding the column to address book database table with null entries
ALTER TABLE Address_Book
ADD dateOfEntry date;
-- Inserting the entries in the newly added dateOfEntry colum with update query
update Address_Book set dateOfEntry = '2018-05-12' where FirstName = 'Navya';
update Address_Book set dateOfEntry = '2019-01-12' where FirstName = 'Radha';
update Address_Book set dateOfEntry = '2020-12-01' where FirstName = 'Shubham';
update Address_Book set dateOfEntry = '2019-03-12' where FirstName = 'Rajat';
---Getting the Data inserted between a date in the query
select * from Address_Book where dateOfEntry between '2018-01-01' and CAST(GETDATE() AS Date );