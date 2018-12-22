select * from person;
insert into Person (first_name, last_name, national_id, age) values ('ali', 'dehnegar', '1010101010', 20), ('akbar', 'akbari', '1111111111', 21), ('naser', 'akbari', '1212121212', 23), ('ahmad', 'ahmadi', '1313131313', 21);
select last_name, COUNT(last_name) from Person group by last_name;
select city, count(*) from Person group by city;
--insert data by form in c#
select * from Person; 
-- view new record (amir mohammadi) in table
