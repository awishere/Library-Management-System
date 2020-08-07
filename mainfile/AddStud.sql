create procedure [dbo].[AddStud]
@uname varchar(50),
@email varchar(50),
@password varchar(50),
@address varchar(50),
@semester smallint,
@name varchar(50)

As
Insert into Student (UserName,Email,Password,Address,Semester,Name)
values (@uname,@email,@password,@address,@semester,@name)
return