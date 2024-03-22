create database groupProject
use groupProject

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
