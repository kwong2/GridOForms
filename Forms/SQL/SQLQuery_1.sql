/* Create database */
CREATE DATABASE FormDB;
GO

/* Create tables */
CREATE TABLE Form (
    FormId INT,
    Name VARCHAR(20), 
    Description VARCHAR(100),
    Date DATE, 
);

INSERT INTO Form (FormId, Name, Description, Date) 
VALUES ('1', 'Game', 'Red Dead Redemption II', '02-11-2019'),
       ('2', 'Movie', 'Mad Max: Fury Road', '05-10-2014'),
       ('3', 'Show', 'Game of Thrones', '04-17-2019');

GO