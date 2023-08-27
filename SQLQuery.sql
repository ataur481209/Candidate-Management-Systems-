CREATE DATABASE R53_CandidateDb
GO
USE R53_CandidateDb
GO
CREATE TABLE Skills
(
	SkillId INT IDENTITY PRIMARY KEY,
	SkillName NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE Candidates
(
	CandidateId INT IDENTITY PRIMARY KEY,
	CandidateName NVARCHAR(50) NOT NULL,
	DateOfBirth DATE NOT NULL,
	Phone VARCHAR(20) NOT NULL,
	Image NVARCHAR(MAX) NULL,
	Fresher BIT NULL
)
GO
CREATE TABLE CandidateSkills
(
	CandidateSkillId INT IDENTITY PRIMARY KEY,
	CandidateId INT REFERENCES Candidates(CandidateId),
	SkillId INT REFERENCES Skills(SkillId),
)
GO
SELECT * FROM CandidateSkills
GO