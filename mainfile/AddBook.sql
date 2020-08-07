create procedure [dbo].[AddBook]
@name varchar(50),
@author varchar(50),
@title varchar(50),
@publisher varchar(50),
@quantity int,
@entrydate smalldatetime,
@catname varchar(50),
@isbn  nchar(10)

AS
Insert into Book (Book_Name,Author,Title,Publisher,Quantity,Entry_Date,Category_Name,ISBN)
values (@name,@author,@title,@publisher,@quantity,@entrydate,@catname,@isbn)
return