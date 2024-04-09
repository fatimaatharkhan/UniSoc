
/*
USE master; -- Switch to the master database
GO

ALTER DATABASE UniSoc SET SINGLE_USER WITH ROLLBACK IMMEDIATE; -- Terminate all connections and rollback any transactions
GO

DROP DATABASE UniSoc; -- Drop the database
GO

*/
CREATE DATABASE UniSoc;
GO

USE UniSoc;
GO

CREATE TABLE Users (
    username VARCHAR(50) PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    password VARCHAR(50),
    role VARCHAR(20),
    roll_no INT NULL
);
GO



CREATE TABLE Society (
    society_id INT IDENTITY(1,1) PRIMARY KEY,
    society_name VARCHAR(100) UNIQUE,
    Capacity INT
);
GO

CREATE TABLE Admin (
    username VARCHAR(50) PRIMARY KEY REFERENCES Users(username) ON DELETE CASCADE
);
GO

CREATE TABLE Student (
    username VARCHAR(50) PRIMARY KEY REFERENCES Users(username) ON DELETE CASCADE
);
GO

CREATE TABLE Head (
    username VARCHAR(50),
    society_id INT,
    PRIMARY KEY (username, society_id),
    FOREIGN KEY (username) REFERENCES Users(username) ON DELETE CASCADE,
    FOREIGN KEY (society_id) REFERENCES Society(society_id) ON DELETE CASCADE
);
GO

CREATE TABLE Membership (
    membership_id INT IDENTITY(1,1) PRIMARY KEY,
    society_id INT,
    username VARCHAR(50),
    status BIT,
    FOREIGN KEY (society_id) REFERENCES Society(society_id) ON DELETE CASCADE,
    FOREIGN KEY (username) REFERENCES Student(username) ON DELETE CASCADE
);
GO

CREATE TABLE Event (
    event_id INT IDENTITY(1,1) PRIMARY KEY,
    society_id INT,
    event_name VARCHAR(100),
    event_description VARCHAR(255),
    FOREIGN KEY (society_id) REFERENCES Society(society_id) ON DELETE CASCADE,
    CONSTRAINT UQ_EventName UNIQUE (society_id, event_name) -- Unique constraint for event_name within each society
);
GO

CREATE TABLE Task (
    task_id INT IDENTITY(1,1) PRIMARY KEY,
    event_id INT,
    head_username VARCHAR(50),
	society_id INT,
    student_username VARCHAR(50),
    task_description VARCHAR(255),
    task_status BIT,
    FOREIGN KEY (event_id) REFERENCES Event(event_id) ON DELETE CASCADE,
    FOREIGN KEY (head_username, society_id) REFERENCES Head(username, society_id) ON DELETE NO ACTION ON UPDATE CASCADE,
    FOREIGN KEY (student_username) REFERENCES Student(username) ON DELETE CASCADE,
    CONSTRAINT UC_HeadSocietyStudentTaskDescription UNIQUE (head_username, event_id, student_username, task_description)
);
GO


CREATE TABLE Event_Student (
    event_id INT,
    username VARCHAR(50),
    PRIMARY KEY (event_id, username),
    FOREIGN KEY (event_id) REFERENCES Event(event_id) ON DELETE CASCADE,
    FOREIGN KEY (username) REFERENCES Student(username) ON DELETE CASCADE
);
GO



----------------------------------------------------------------------------------------------------------------------------------------------------------------
--							***************************************************TRIGGERS***************************************************						
USE UniSoc;
GO

CREATE TRIGGER trg_InsertAdmin ON Users
AFTER INSERT
AS
BEGIN
    INSERT INTO Admin(username)
    SELECT username FROM inserted WHERE role = 'admin'
END;
GO

CREATE TRIGGER trg_InsertStudent ON Users
AFTER INSERT
AS
BEGIN
    INSERT INTO Student(username)
    SELECT username FROM inserted WHERE role = 'student'
END;
GO

--CREATE TRIGGER InsertDefaultHead
--ON Society
--AFTER INSERT
--AS
--BEGIN
--    -- Insert a new record into the Head table with the default username 'tester'
--    INSERT INTO Head (username, society_id)
--    SELECT 'tester', inserted.society_id
--    FROM inserted;
--END;
--GO

--drop trigger InsertDefaultHead

CREATE TRIGGER DeleteHeadOnSocietyDelete
ON Society
AFTER DELETE
AS
BEGIN
    -- Delete the corresponding record from the Head table
    DELETE FROM Head
    WHERE society_id IN (SELECT deleted.society_id FROM deleted);
END;
GO

CREATE TRIGGER ChangeHeadRole
ON Head
AFTER INSERT, UPDATE 
AS
BEGIN
	--Update the role to head when the student is made the head
	UPDATE Users
	SET role = 'head'
	WHERE username = (Select  inserted.username
	FROM inserted);
END;
GO

drop trigger ChangeHeadRole
----------------------------------------------------------------------------------------------------------------------------------------------------------------


-- Inserting data into Users
INSERT INTO Users (username, first_name, last_name, password, role, roll_no) VALUES
('tester', 'John', 'Doe', '123', 'admin', NULL),
('douglas70', 'Douglas', 'Fir', '456', 'student', 52604),
('linda35', 'Linda', 'Tree', '789', 'admin', NULL),
('ashleypeterson', 'Ashley', 'Peterson', 'ashley', 'admin', 42642),
('tyler83', 'Tyler', 'Swift', 'tyler', 'student', NULL),
('bowenmeredith', 'Bowen', 'Meredith', 'bowen', 'student', 57239),
('amycantrell', 'Amy', 'Cantrell', 'amy', 'admin', NULL),
('christopher90', 'Christopher', 'Nolan', 'chris', 'student', 86735),
('david58', 'David', 'Blaine', 'david', 'admin', NULL),
('seanlynch', 'Sean', 'Lynch', 'sean', 'student', 80575),
('stephanie03', 'Stephanie', 'Meyer', 'stephanie', 'student', NULL),
('sandra26', 'Sandra', 'Bullock', 'sandra', 'admin', 31223),
('sarahwilliams', 'Sarah', 'Williams', 'sarah', 'student', NULL),
('crystalsanders', 'Crystal', 'Sanders', 'crystal', 'admin', 37626),
('lchase', 'Chase', 'Logan', 'chase', 'admin', NULL),
('robertsmith', 'Robert', 'Smith', 'robert', 'admin', 50396),
('wrightbrianna', 'Brianna', 'Wright', 'wright', 'student', NULL),
('raymondhayden', 'Raymond', 'Hayden', 'raymond', 'student', 31338),
('cgonzalez', 'Carlos', 'Gonzalez', 'gonzalez', 'student', NULL),
('wodonnell', 'Will', 'O''Donnell', 'donell', 'student', 21584);
GO

-- Inserting data into Society
INSERT INTO Society ( society_name, Capacity) VALUES
( 'Decker-Bates',50),
('Bowman LLC',25),
('Hayes, Franklin and White',40),
('Howard LLC',35),
('Young Inc',25);
GO

-- Inserting data into Head
INSERT INTO Head (username, society_id) VALUES
('douglas70', 1)

INSERT INTO Head (username, society_id) VALUES
('stephanie03', 2)

INSERT INTO Head (username, society_id) VALUES
('sarahwilliams', 3)

INSERT INTO Head (username, society_id) VALUES
('seanlynch', 4)

INSERT INTO Head (username, society_id) VALUES
('douglas70', 5)


-- Inserting data into Membership
INSERT INTO Membership ( society_id, username, status) VALUES
(5,'bowenmeredith',0),
(5,'tyler83',1),
( 4, 'tyler83', 1),
( 1, 'bowenmeredith', 1),
( 3, 'christopher90', 1),
( 1, 'raymondhayden', 0),
( 5, 'cgonzalez', 1),
( 1, 'wodonnell', 1);
GO

---- Inserting data into Task
--INSERT INTO Task ( society_id, head_username, student_username, task_description, task_status) VALUES
--(5, 'douglas70', 'tyler83', 'Argue model reason exactly operation region blue.', 0),
----(1, 'wrightbrianna', 'bowenmeredith', 'Worker PM imagine case.'),
--(1, 'douglas70', 'christopher90', 'Although president deal.', 0),
--(2, 'stephanie03', 'raymondhayden', 'Risk natural anyone.', 0),
--(4, 'seanlynch', 'cgonzalez', 'Child kitchen cup.', 0),
--(3, 'sarahwilliams', 'wodonnell', 'Your scientist administration modern language.', 0);
--GO


-- Inserting data into Event
INSERT INTO Event (society_id, event_name, event_description) VALUES
( 1, 'Nascon', 'Nascon, the premier national level student convention, brings together brilliant minds for competitions, workshops, and seminars on current technological advancements and innovations in various fields.'),
( 2, 'Adventure Gala', 'Adventure Gala is an exhilarating event that offers a range of outdoor activities and challenges, from trekking and rock climbing to camping and survival skills workshops, promoting teamwork and personal growth.'),
( 3, 'Tech Expo', 'Tech Expo showcases cutting-edge technology from robotics to artificial intelligence, offering demonstrations, interactive sessions, and lectures by experts in the field, aiming to inspire innovation and creativity.'),
( 4, 'Cultural Fiesta', 'Cultural Fiesta celebrates diversity and heritage through performances, art displays, and culinary experiences from around the world, fostering a sense of community and global awareness.'),
( 5, 'Sports Week', 'Sports Week is an annual celebration of athleticism and spirit, featuring competitions in various sports, from football and cricket to track and field, encouraging healthy living and sportsmanship among students.');
GO

-- Inserting data into Event_Student
INSERT INTO Event_Student (event_id, username)
VALUES
(1, 'tyler83'), -- Nascon
(1, 'bowenmeredith'), -- Nascon
(2, 'raymondhayden'), -- Adventure Gala
(4, 'cgonzalez'), -- Cultural Fiesta
(5, 'wodonnell'); -- Sports Week

-- Inserting data into Task
INSERT INTO Task (society_id, event_id, head_username, student_username, task_description, task_status)
VALUES
(1, 1, 'douglas70', 'christopher90', 'Although president deal.', 0), -- Society: Decker-Bates, Event: Nascon
(3, 3, 'sarahwilliams', 'wodonnell', 'Your scientist administration modern language.', 0), -- Society: Howard LLC, Event: Tech Expo
(5, 5, 'douglas70', 'tyler83', 'Argue model reason exactly operation region blue.', 0); -- Society: Young Inc, Event: Sports Week


