use estacionamento_dapper;

create table PARKING_SPOT(
	ID 				BIGINT 	NOT NULL AUTO_INCREMENT,
	Location 		VARCHAR(100) NOT NULL,
	Occuped			BOOLEAN default false,
	constraint PK_PARKINGSPOT primary key (ID)
);

create table VALUE(
	ID 				BIGINT 	NOT NULL AUTO_INCREMENT,
	Name			VARCHAR(20)	NOT NULL,
	Value_Hour		DECIMAL(4,2)  NOT NULL,
	constraint PK_VALUE primary key (ID)	
);

create table OWNER(
	ID 				BIGINT 	NOT NULL AUTO_INCREMENT,
	Name 			VARCHAR(100),
	TelNumber		VARCHAR(14) NOT NULL,
	constraint PK_OWNER primary key (ID)
);

create table VEHICLE (
	ID 				BIGINT 	NOT NULL AUTO_INCREMENT,
	OwnerId 		BIGINT NOT NULL,
	Model 			VARCHAR(50) NOT NULL,
	Make 			VARCHAR(50) NOT NULL,
	LicensePlate 	INT,
	constraint PK_VEHICLE primary key (ID),
	constraint FK_OWNERID foreign key (OwnerId) references OWNER(ID)
);

create table Ticket(
	ID 				BIGINT 	NOT NULL AUTO_INCREMENT,
	ParkingSpotId	BIGINT NOT NULL,
	VehicleId		BIGINT NOT NULL,
	InDate			DATETIME NOT NULL,
	OutDate 		DATETIME NOT NULL,
	PriceAmount		DECIMAL(10,2)  NOT NULL,
	constraint PK_TICKET primary key (ID),
	constraint FK_PARKINGSPOTID foreign key (ParkingSpotId) references PARKING_SPOT(ID),
	constraint FK_VEHICLEID foreign key (VehicleId) references VEHICLE(ID)
);
