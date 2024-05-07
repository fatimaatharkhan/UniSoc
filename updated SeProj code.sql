
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



-- Create the Reserved_Resources table
CREATE TABLE Reserved_Resources (
    resource_id INT IDENTITY(1,1) PRIMARY KEY,
    start_time TIME,
    stop_time TIME,
    resource_date DATE,
    resource_type VARCHAR(100),
    head_username VARCHAR(50),
    society_id INT,
    FOREIGN KEY (head_username) REFERENCES Users(username) ON DELETE CASCADE,
    FOREIGN KEY (society_id) REFERENCES Society(society_id) ON DELETE CASCADE
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

--drop trigger ChangeHeadRole
----------------------------------------------------------------------------------------------------------------------------------------------------------------


-- Inserting data into Users
INSERT INTO Users (username, first_name, last_name, password, role) VALUES
('tester', 'John', 'Doe', 'T3stP@ssw0rd', 'admin'),
('douglas70', 'Douglas', 'Fir', 'D0ugl@$70', 'student'),
('linda35', 'Linda', 'Tree', 'L1nd@#35', 'admin'),
('ashleypeterson', 'Ashley', 'Peterson', 'A$h13ypet3rson', 'admin'),
('tyler83', 'Tyler', 'Swift', 'Ty13r!Sw1ft', 'student'),
('bowenmeredith', 'Bowen', 'Meredith', 'B0w3nM3r3dith', 'student'),
('amycantrell', 'Amy', 'Cantrell', '4mYc@ntr3ll', 'admin'),
('christopher90', 'Christopher', 'Nolan', 'Chr15t0ph3r90!', 'student'),
('david58', 'David', 'Blaine', 'Dav1dBl@1n3', 'admin'),
('seanlynch', 'Sean', 'Lynch', 'S34n!Lynch', 'student'),
('stephanie03', 'Stephanie', 'Meyer', 'St3ph@ni3M3y3r', 'student'),
('sandra26', 'Sandra', 'Bullock', 'S@ndr@26', 'admin'),
('sarahwilliams', 'Sarah', 'Williams', 'S@r@hW1ll14m$', 'student'),
('crystalsanders', 'Crystal', 'Sanders', 'Cryst@l$@nd3r$', 'admin'),
('lchase', 'Chase', 'Logan', 'Lch@$3', 'admin'),
('robertsmith', 'Robert', 'Smith', 'R0b3rt$mith', 'admin'),
('wrightbrianna', 'Brianna', 'Wright', 'WrightBr14nn@', 'student'),
('raymondhayden', 'Raymond', 'Hayden', 'R@ym0ndH@yd3n', 'student'),
('cgonzalez', 'Carlos', 'Gonzalez', 'C@rl0$G0nz@l3z', 'student'),
('wodonnell', 'Will', 'O''Donnell', 'W!ll0d0nn3ll', 'student');
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

select * from Reserved_Resources
