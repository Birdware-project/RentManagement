CREATE TABLE Users (
    ID int identity(1,1),
    Name varchar(255),
    Sex varchar(255),
    Phone varchar(255),
    Password varchar(255)
);
create table Room(
	ID int identity(1,1),
	Price varchar(255),
	Name varchar(255)
);
create table Rent(
	ID int identity(1,1),
	RoomID int ,
	UserID int,
	isTrash varchar(255),
	isSpace varchar(255),
	Roomate varchar(255)
);
create table invoice (
	ID int identity(1,1),
	RoomID int ,
	UserID int ,
	edc_waterID int,
	edc_price varchar(255),
	water_price varchar(255),
	isSpace int,
	isTrash int,
	space_price varchar(255),
	trash_price varchar(255),
	Room_price varchar(255),
	Date date,
	Total varchar(255)
);
create table edc_water(
	ID int identity(1,1),
	RoomId int ,
	UserID int ,
	Date date ,
	edc_new varchar(255),
	edc_old varchar(255),
	water_new varchar(255),
	water_old varchar(255),
);
create table customer(
	ID int identity(1,1),
	Name varchar(255),
	Sex varchar(10),
	Age varchar(255),
	Phone varchar(255),
	Image image
);