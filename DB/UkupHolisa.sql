Create DATABASE UkupholisaHealthcare
GO
WAITFOR DElAY '00:00:02'
Use UkupholisaHealthcare
GO

CREATE TABLE Client
(
ClientID int PRIMARY key,
ClientName VARCHAR(50) NOT NULL,
ClientAddress VARCHAR(50) NOT NULL,
clientEmail VARCHAR(50)

);
WAITFOR DElAY '00:00:02'
CREATE table FamilyMember
(
    FamilyMemberID  int PRIMARY key not NULL,
    FamilyMemberName varchar(50) NOT NULL,
    FamilyMemberSurname varchar(50) NOT NULL,
    FamilyMemberEmail varchar(50) NOT NULL,
    FamilyMemberAddress varchar(50) NOT NULL,
    FamilyMemberPhone varchar(10) Not NULL,
    ClientID int FOREIGN KEY REFERENCES Client(ClientID)
)

CREATE table tbPolicy
(
    POlicyID  int PRIMARY key not NULL,
    POlicyName varchar(50) NOT NULL,
    startTime DATETIME NOT NULL,
    endTime DATETIME NOT NULL

)
WAITFOR DElAY '00:00:02'
CREATE table tbPOlicyStatus
(
    POlicyStatusID  int PRIMARY key not NULL,
    startTime DATETIME NOT NULL,
    endTime DATETIME NOT NULL,
    POlicyStatusstate VARCHAR(50) NOT NULL,
    POlicyID int FOREIGN KEY REFERENCES tbPOlicy(POlicyID)

)
WAITFOR DElAY '00:00:02'
CREATE table ClientPolicy
(
    POlicyID int FOREIGN KEY REFERENCES tbPOlicy(POlicyID),
    ClientID int FOREIGN KEY REFERENCES Client(ClientID)
)
CREATE TABLE Coverage(
    CoverageID  int PRIMARY key not NULL,
    CoverageLevel VARCHAR(50) NOT NUlL,
    CoverageDESCRIPTION VARCHAR(50) NOT NUll
);
create TABLE MedicalServiceProvidor(
    MedicalServiceProvidorID int NOT NULL PRIMARY KEY,
    MedicalServiceProvidorName varchar(50) NOT NULL,
    MedicalServiceProvidorAddress varchar(200) NOT NULL,
    MedicalServiceProvidorEmail varchar(50) NOT NULL,
    MedicalServiceProvidorPhone varchar(50) NOT NULL
);
create TABLE Treatment(
    TreatmentID int NOT NULL PRIMARY KEY,
    TreatmentName varchar(50) NOT NULL,
    TreatmentDescription varchar(200) NOT NULL
);
WAITFOR DElAY '00:00:02'
create TABLE MedicalServiceProvidorTreatment(
    MSPTID int NOT NULL PRIMARY KEY,
    ProvidorStatus varchar(50) NOT NULL,
    MedicalServiceProvidorID  int FOREIGN KEY REFERENCES MedicalServiceProvidor(MedicalServiceProvidorID),
    TreatmentID  int FOREIGN KEY REFERENCES Treatment(TreatmentID)
);
WAITFOR DElAY '00:00:02'
CREATE TABLE PolicyTreatmentCoverage(
    PolicyTypeID int NOT NULL PRIMARY KEY,
    TreatmentID  int FOREIGN KEY REFERENCES Treatment(TreatmentID),
    PolicyID  int FOREIGN KEY REFERENCES tbPolicy(POlicyID),
    CoverageID  int FOREIGN KEY REFERENCES Coverage(CoverageID)
);
CREATE TABLE MedicalCondition(
    MedicalConditionID int NOT NULL PRIMARY KEY,
    MedicalConditionName varchar(100) NOT NULL,
    MedicalConditionDescription varchar(200) NOT NULL

);
WAITFOR DElAY '00:00:02'
CREATE TABLE MedicalConditionTreatment(
    MCTID  int NOT NULL PRIMARY KEY,
    MedicalConditionID  int FOREIGN KEY REFERENCES MedicalCondition(MedicalConditionID),
    TreatmentID  int FOREIGN KEY REFERENCES Treatment(TreatmentID),

);
CREATE TABLE CallDetails(
    CALLID int NOT NULL PRIMARY KEY,
    startTime DateTime NOT NULL,
    endTime DateTime NOT NULL,
);
CREATE TABLE Claim(
    CLAIMID int NOT NULL PRIMARY KEY,
    ClaimeStatus varchar(50) NOT NULL,
    placeOfTreatment varchar(50),
    CallID  int FOREIGN KEY REFERENCES CallDetails(CALLID),
    ClientID  int FOREIGN KEY REFERENCES Client(ClientID)
);

CREATE TABLE ClaimMedicalConditionTreatment(
    CLAIMID  int FOREIGN KEY REFERENCES Claim(CLAIMID),
    MCTID  int FOREIGN KEY REFERENCES MedicalConditionTreatment(MCTID)

);
