﻿CREATE TABLE `CUSTOMERS` ( 
	`CUSTOMER_ID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
	`FIRST_NAME` TEXT NOT NULL,
	`LAST_NAME` TEXT NOT NULL,
	`CNP` INTEGER NOT NULL UNIQUE,
	`BIRTHDATE` TEXT NOT NULL);

CREATE TABLE `CUST_ACCOUNT` ( 
	`ID_ACCOUNT` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
	`CUSTOMER_ID` INTEGER NOT NULL, 
	`ACCOUNT_NUMBER` INTEGER NOT NULL UNIQUE, 
	`ACCOUNT_TYPE` INTEGER NOT NULL, 
	`CURRENCY` TEXT NOT NULL, 
	`AMOUNT` NUMERIC NOT NULL,
	`OPEN_DATE` TEXT NOT NULL );

CREATE TABLE `CUST_DETAILS` ( 
	`ID_DETAIL` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
	`CUSTOMER_ID` INTEGER NOT NULL, 
	`PHONE` TEXT NOT NULL, 
	`EMAIL` TEXT NOT NULL, 
	`COUNTRY` TEXT NOT NULL, 
	`COUNTY` TEXT NOT NULL, 
	`CITY` TEXT, 
	`LOCALITY` TEXT,
	`STREET` TEXT,
	`STREET_NO` INTEGER );

CREATE TABLE `USERS` ( 
	`ID_USER` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
	`USERNAME` TEXT NOT NULL UNIQUE, 
	`PASSWORD` TEXT NOT NULL );

INSERT INTO USERS (username, password) VALUES ('c026dinab', 'parola');