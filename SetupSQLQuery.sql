create database groupProject
use groupProject

create login mylogin with password = 'mylogin'
sp_changedbowner mylogin;

create table positions(
	position_id int identity(1,1) primary key,
	position_name nvarchar(50)
)

create table users(
	user_id int identity(1,1) primary key,
	user_name nvarchar(30) not null,
	user_address nvarchar(200), 
	phone_number varchar(20), 
	email varchar(60), 
	password varchar(50) not null,
	salary money check (salary>0), 
	position_id int references positions(position_id)
)

create table food_categories(
	category_id int identity(1,1) primary key,
	category_name nvarchar(100) not null
)

create table foods(
	food_id int identity(1,1) primary key, 
	food_name nvarchar(100) not null, 
	category_id int references food_categories(category_id)
)

create table food_prices(
	food_price_id int identity(1,1) primary key, 
	food_id int, 
	price_date date not null, 
	price money check (price>0),
	foreign key(food_id) references foods(food_id)
)

create table dining_tables(
	 table_id int identity(1,1) primary key, 
	 table_name varchar(30), 
	 table_status varchar(10) check (table_status in ('empty', 'reserved', 'in use')) not null default 'empty'
)

create table invoices(
	invoice_id int identity(1,1) primary key, 
	invoice_date smalldatetime not null default getdate(),
	user_id int, 
	table_id int, 
	total_money money check (total_money >0),
	foreign key(user_id) references users(user_id),
	foreign key(table_id) references dining_tables(table_id),
)

create table invoice_details(
	invoice_id int,  
	food_id int, 
	quantity int check(quantity>=1),
	primary key(invoice_id,food_id),
	foreign key(invoice_id) references invoices(invoice_id),
	foreign key(food_id) references foods(food_id)
)

drop table table_reservation;
create table table_reservation(
	reservation_id int identity(1,1) primary key,
	user_id int references users(user_id),
	table_id int references dining_tables(table_id),
	reservation_date datetime not null,
	reservation_duration int check (reservation_duration > 0)
)

-- Inserting data into the positions table
INSERT INTO positions (position_name) VALUES ('Manager');
INSERT INTO positions (position_name) VALUES ('Waiter');
INSERT INTO positions (position_name) VALUES ('Chef');

-- Inserting data into the users table
INSERT INTO users (user_name, user_address, phone_number, email, password, salary, position_id) VALUES ('John Doe', '123 Main St', '123-456-7890', 'john.doe@example.com', 'password', 50000, 1);
INSERT INTO users (user_name, user_address, phone_number, email, password, salary, position_id) VALUES ('Jane Smith', '456 Elm St', '987-654-3210', 'jane.smith@example.com', 'password', 30000, 2);

-- Inserting data into the food_categories table
INSERT INTO food_categories (category_name) VALUES ('Appetizer');
INSERT INTO food_categories (category_name) VALUES ('Main Course');
INSERT INTO food_categories (category_name) VALUES ('Dessert');

-- Inserting data into the foods table
INSERT INTO foods (food_name, category_id) VALUES ('Spring Rolls', 1);
INSERT INTO foods (food_name, category_id) VALUES ('Pho', 2);
INSERT INTO foods (food_name, category_id) VALUES ('Cheesecake', 3);

-- Inserting data into the food_prices table
INSERT INTO food_prices (food_id, price_date, price) VALUES (1, '2024-01-01', 5.00);
INSERT INTO food_prices (food_id, price_date, price) VALUES (2, '2024-01-01', 10.00);
INSERT INTO food_prices (food_id, price_date, price) VALUES (3, '2024-01-01', 7.50);

-- Inserting data into the dining_tables table
INSERT INTO dining_tables (table_name, table_status) VALUES ('Table 1', 'empty');
INSERT INTO dining_tables (table_name, table_status) VALUES ('Table 2', 'reserved');
INSERT INTO dining_tables (table_name, table_status) VALUES ('Table 3', 'in use');

-- Inserting data into the invoices table
INSERT INTO invoices (user_id, table_id, total_money) VALUES (1, 1, 15.00);
INSERT INTO invoices (user_id, table_id, total_money) VALUES (2, 2, 22.50);

-- Inserting data into the invoice_details table
INSERT INTO invoice_details (invoice_id, food_id, quantity) VALUES (1, 1, 2);
INSERT INTO invoice_details (invoice_id, food_id, quantity) VALUES (1, 2, 1);
INSERT INTO invoice_details (invoice_id, food_id, quantity) VALUES (2, 3, 3);

select * from dining_tables
select * from users
select invoice_id,user_name, invoice_date,table_name,total_money from invoices as i
	join users as u on i.user_id = u.user_id
	join dining_tables as d on i.table_id = d.table_id

insert into table_reservation(user_id, table_id, reservation_date, reservation_duration) values	(1, 1, '2024-04-12T18:30:00', 2),
																								(1, 2, '2024-04-13T19:00:00', 3),
																								(1, 1, '2024-04-14T20:00:00', 2),
																								(2, 2, '2024-04-15T18:00:00', 2),
																								(2, 2, '2024-04-16T19:30:00', 3);

select * from table_reservation
select * from dining_tables
select user_id, user_name from users

select table_id, table_name from dining_tables

SELECT max(invoice_id) from invoices
select * from invoices
insert into invoices(invoice_date, user_id, table_id, total_money) values ('2024-04-07 00:06:00',2,3,300);

select * from invoice_details;