create database dbtest;
use dbtest;
create table tblStudent(
	sid INT auto_increment primary key,
    name varchar(100),
    address varchar(100)
);

create user 'testuser'@'localhost' identified by '1234';
grant all privileges on dbtest.* TO 'testuser'@'localhost';
flush privileges;