DROP TABLE IF EXISTS Shelter;
DROP TABLE IF EXISTS Userss;
DROP TABLE IF EXISTS Animal;


CREATE TABLE Shelter (
    Shelter_ID SERIAL PRIMARY KEY,
    Shelter_Name VARCHAR(100),
    Shelter_Location VARCHAR(255),
    Shelter_Number VARCHAR(20) UNIQUE,
    Shelter_Email VARCHAR(100) UNIQUE
);

CREATE TABLE Userss (
    User_ID SERIAL PRIMARY KEY,
    ID VARCHAR(50),
    User_Name VARCHAR(100),
    User_Age INT NOT NULL,
    User_Location VARCHAR(255) NOT NULL,
    Prefer VARCHAR(100) NOT NULL,
    FieldOfActivity VARCHAR(100) NOT NULL,
    User_Email VARCHAR(100) UNIQUE,
    Password VARCHAR(255) NOT NULL,
	CONSTRAINT Password_Check CHECK (LENGTH(Password) >= 8)
);

CREATE TABLE Animal (
    AnimalID SERIAL PRIMARY KEY,
    Animal_Name VARCHAR(100),
    Species VARCHAR(50) NOT NULL,
    Breed VARCHAR(50),
    Animal_Age INT NOT NULL,
    Infection VARCHAR(100) NOT NULL,
    Vaccine VARCHAR(100) NOT NULL,
    Parasite VARCHAR(100) NOT NULL,
	User_ID INT NOT NULL,
    FOREIGN KEY (User_ID) REFERENCES Userss(User_ID)
);