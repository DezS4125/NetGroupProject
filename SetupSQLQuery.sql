create database groupProject
use groupProject

sp_changedbowner mylogin;

create table users(
	user_id int primary key auto increment,
	user_name nvarchar(30) unique,
	user_address nvarchar(200), 
	phone_number varchar(20), 
	email varchar(60), 
	password varchar(50),
	salary money, 
	position_id int
)