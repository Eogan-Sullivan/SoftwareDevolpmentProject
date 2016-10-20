-- Eogan Sullivan GD
-- TillSYS.sql
-- This Script Builds the database for a Till System.

DROP TABLE SALES;
DROP TABLE Staff;
DROP TABLE ITEMS;
DROP TABLE SALESITEMS;


CREATE TABLE Staff
(
 StaffID numeric(4),
 FirstName char(20) NOT NULL,
 LastName char(20) NOT NULL,
 CONSTRAINT pk_StaffID PRIMARY KEY (StaffID) 
);

CREATE TABLE ITEMS(
ITEMID numeric(3),
PRICE numeric(4,2),
QUANTITY numeric(3),
ITEMNAME char(40) NOT NULL,
DESCRIPTION char(40) NOT NULL,
CONSTRAINT pk_ITEMID PRIMARY KEY (ITEMID)
);

CREATE TABLE SALES(
SALEID numeric(4),
DATEOFPURCHASE char(40),
PRICE numeric(5,3),

CONSTRAINT pk_SALEID PRIMARY KEY(SALEID)
);

CREATE TABLE SALESITEMS(

SALEID numeric(4),
ITEMID numeric(3),
DESCRIPTION char(40),
QUANTITY numeric(3),
UNITPRICE numeric(4,2)

--FOREIGN KEY (SALEID) REFERENCES SALES,
--FOREIGN KEY (ITEMID) REFERENCES ITEMS,
--PRIMARY KEY (SALEID,ITEMID)

);



