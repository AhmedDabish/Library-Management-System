/*create database lib_sys;*/


create table Books(
ID int not null,
Title varchar(250) not null,
Author varchar(250) not null,
section varchar(50) not null,
Edition varchar(70),
Quantity int not null,
Price int not null
unique(Title),
primary key(ID)
);

create table Users(
UserID int identity(1,1),
Username varchar(200) not null,
password varchar(200) not null,
Email varchar(250) not null,
phone varchar(200) not null,
address varchar(250) not null,
type varchar(50) not null
unique(Email),
primary key(UserID)
);
drop table Users;

 create table bowrrowed_books(
 BookID_borrow int not null ,
 ID int not null,
 UserID_borrow int not null,
 first_date datetime not null,
 end_date datetime not null,
 status varchar(60) not null
 Foreign key(UserID_borrow) REFERENCES Users(UserID),
 foreign key(ID) REFERENCES Books(ID)
 );
 drop table bowrrowed_books;
 /*delete from Users
 where UserID = and type = 'Librarian';

 select UserID , type from dbo.Users
 where UserID =39 and type ='Librarian';*/

insert into Books(ID,Title,Author,section,Edition,Quantity,Price) values(20 , 'Cleaan Code' ,'Robert Martin','Programming','2017',5,15);


insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(23, 'Code Complete', 'Steve McConnell', 'Programming', '2004', 4, 25),
(24, 'The Mythical Man-Month', 'Frederick Brooks', 'Software Engineering', '1995', 6, 15),
(25, 'Design Patterns', 'Erich Gamma et al.', 'Programming', '1994', 5, 30),
(26, 'Refactoring', 'Martin Fowler', 'Programming', '1999', 3, 20),
(27, 'The C Programming Language', 'Brian Kernighan and Dennis Ritchie', 'Programming', '1988', 7, 10),
(28, 'Introduction to Algorithms', 'Thomas Cormen et al.', 'Computer Science', '2009', 2, 50),
(29, 'Structure and Interpretation of Computer Programs', 'Harold Abelson et al.', 'Computer Science', '1996', 4, 40),
(30, 'The Elements of Style', 'William Strunk and E.B. White', 'Writing', '2000', 8, 5),
(31, 'The Hitchhiker s Guide to the Galaxy', 'Douglas Adams', 'Science Fiction', '1979', 10, 10),
(32, 'Nineteen Eighty-Four', 'George Orwell', 'Dystopian Fiction', '1949', 9, 12);



insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(33, 'The Lord of the Rings', 'J.R.R. Tolkien', 'Fantasy', '1954', 5, 20),
(34, 'Harry Potter and the Philosophers Stone', 'J.K. Rowling', 'Fantasy', '1997', 8, 15),
(35, 'The Da Vinci Code', 'Dan Brown', 'Thriller', '2003', 6, 12),
(36, 'The Catcher in the Rye', 'J.D. Salinger', 'Novel', '1951', 7, 10),
(37, 'To Kill a Mockingbird', 'Harper Lee', 'Novel', '1960', 9, 8),
(38, 'The Little Prince', 'Antoine de Saint-Exupéry', 'Children s Literature', '1943', 10, 5),
(39, 'The Alchemist', 'Paulo Coelho', 'Novel', '1988', 4, 10),
(40, 'Think and Grow Rich', 'Napoleon Hill', 'Self-Help', '1937', 3, 15),
(41, 'The 7 Habits of Highly Effective People', 'Stephen Covey', 'Self-Help', '1989', 5, 18),
(42, 'How to Win Friends and Influence People', 'Dale Carnegie', 'Self-Help', '1936', 6, 12);



insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(43, 'The Hunger Games', 'Suzanne Collins', 'Dystopian Fiction', '2008', 7, 12),
(44, 'The Girl with the Dragon Tattoo', 'Stieg Larsson', 'Crime Fiction', '2005', 6, 15),
(45, 'The Kite Runner', 'Khaled Hosseini', 'Novel', '2003', 8, 10),
(46, 'The Chronicles of Narnia', 'C.S. Lewis', 'Fantasy', '1950', 5, 20),
(48, 'The Fault in Our Stars', 'John Green', 'Young Adult Fiction', '2012', 9, 12),
(49, 'The Diary of a Young Girl', 'Anne Frank', 'Autobiography', '1947', 4, 8),
(50, 'Animal Farm', 'George Orwell', 'Political Satire', '1945', 3, 10),
(51, 'The Hobbit', 'J.R.R. Tolkien', 'Fantasy', '1937', 5, 15),
(52, 'Frankenstein', 'Mary Shelley', 'Gothic Fiction', '1818', 2, 12);



insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(53, 'The Lion, the Witch and the Wardrobe', 'C.S. Lewis', 'Fantasy', '1950', 5, 10)



insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(73, 'The Picture of Dorian Gray', 'Oscar Wilde', 'Novel', '1890', 4, 10),
(74, 'Dracula', 'Bram Stoker', 'Gothic Fiction', '1897', 3, 12),
(75, 'Pride and Prejudice', 'Jane Austen', 'Novel', '1813', 6, 8),
(76, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Novel', '1925', 5, 10),
(77, 'The Adventures of Sherlock Holmes', 'Arthur Conan Doyle', 'Detective Fiction', '1892', 7, 15),
(78, 'Alice "s Adventures in Wonderland', 'Lewis Carroll', 'Fantasy', '1865', 8, 5),
(79, 'The Three Musketeers', 'Alexandre Dumas', 'Historical Fiction', '1844', 5, 12),
(80, 'War and Peace', 'Leo Tolstoy', 'Historical Fiction', '1869', 2, 20),
(81, 'Don Quixote', 'Miguel de Cervantes', 'Novel', '1605', 3, 15),
(82, 'The Divine Comedy', 'Dante Alighieri', 'Epic Poem', '1320', 4, 18);



insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(83, 'The Catch-22', 'Joseph Heller', 'Novel', '1961', 4, 12),
(84, 'The Metamorphosis', 'Franz Kafka', 'Novella', '1915', 3, 10),
(85, 'One Hundred Years of Solitude', 'Gabriel García Márquez', 'Novel', '1967', 6, 15),
(86, 'Brave New World', 'Aldous Huxley', 'Dystopian Fiction', '1932', 5, 12),
(87, 'Fahrenheit 451', 'Ray Bradbury', 'Dystopian Fiction', '1953', 7, 10),
(88, 'The Grapes of Wrath', 'John Steinbeck', 'Novel', '1939', 8, 15),
(89, 'Moby-Dick', 'Herman Melville', 'Novel', '1851', 5, 18),
(90, 'Crime and Punishment', 'Fyodor Dostoyevsky', 'Novel', '1866', 2, 20),
(91, 'Les Misérables', 'Victor Hugo', 'Historical Fiction', '1862', 3, 25),
(92, 'The Iliad and the Odyssey', 'Homer', 'Epic Poem', '8th century BC', 4, 30);

insert into Books(ID,Title,Author,Section,Edition,Quantity,Price) values
(93, 'The Count of Monte Cristo', 'Alexandre Dumas', 'Historical Fiction', '1844', 4, 15),
(94, 'The Brothers Karamazov', 'Fyodor Dostoyevsky', 'Novel', '1880', 3, 20),
(95, 'Ulysses', 'James Joyce', 'Novel', '1922', 6, 25),
(96, 'Lolita', 'Vladimir Nabokov', 'Novel', '1955', 5, 12),
(97, 'The Handmaid"s Tale', 'Margaret Atwood', 'Dystopian Fiction', '1985', 7, 15),
(98, 'Slaughterhouse-Five', 'Kurt Vonnegut', 'Science Fiction', '1969', 8, 10),
(99, 'The Lord of the Flies', 'William Golding', 'Novel', '1954', 5, 8),
(100, 'Wuthering Heights', 'Emily Brontë', 'Novel', '1847', 2, 10),
(101, 'Jane Eyre', 'Charlotte Brontë', 'Novel', '1847', 3, 10),
(102, 'A Tale of Two Cities', 'Charles Dickens', 'Historical Fiction', '1859', 4, 12);

select * from Books
where Title like 'tale%' or title like '%Tale' or title like '%Tale%' ;


select Users.UserID ,Books.ID  , Users.Username , bowrrowed_books.first_date , bowrrowed_books.end_date,Books.Price from bowrrowed_books join Users
on Users.UserID = bowrrowed_books.UserID_borrow join Books
on Books.ID = bowrrowed_books.BookID_borrow
where BookID_borrow =4 and Users.UserID = 1;

update Books
set Quantity +=1
where ID = 4; 

select * from bowrrowed_books;



select Books.Quantity
from Books  
where ID = 100;

