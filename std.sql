CREATE DATABASE STUDENT

CREATE TABLE Students
(
StudentId int primary key,
StudentName varchar(100) NOT NULL,
CGPA float NOT NULL,
Semester float NOT NULL
);
select *from Students
update Students set StudentName='kittt',CGPA=2.8,Semester=4.2 where StudentId=3;
insert into Students (StudentId,StudentName,CGPA,Semester) VALUES(3,'ka',3.4,4.2);
delete from Students where StudentId=0;