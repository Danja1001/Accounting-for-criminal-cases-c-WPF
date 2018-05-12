CREATE TABLE [dbo].[Lawyer]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[FirstName] NVARCHAR(255) NOT NULL,
	[LastName] NVARCHAR(255) NOT NULL,
	[Email] NVARCHAR(255) NOT NULL,
	[Password] NVARCHAR(255) NOT NULL,
	[DateOfBirth] DATETIME NOT NULL
);



CREATE TABLE [dbo].[Case]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Title] NVARCHAR(400) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[StartDate] DATETIME NOT NULL,
	[EndDate] DATETIME NULL
);



CREATE TABLE [dbo].[LawyerToCase]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[LawyerId] INT NOT NULL ,
	[CaseId] INT NOT NULL
);

ALTER TABLE [dbo].[LawyerToCase]
ADD CONSTRAINT [FK_LawyerToCase_Lawyer]
	FOREIGN KEY ([LawyerId])
	REFERENCES [Lawyer]([Id]);

ALTER TABLE [dbo].[LawyerToCase]
ADD CONSTRAINT [FK_LawyerToCase_Case]
	FOREIGN KEY ([CaseId])
	REFERENCES [Case]([Id]);



CREATE TABLE [dbo].[Document]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[CaseId] INT NOT NULL,
	[Date] DATETIME NOT NULL,
	[PathToImage] NVARCHAR(400) NOT NULL
);

ALTER TABLE [dbo].[Document]
ADD CONSTRAINT [FK_Document_Case]
	FOREIGN KEY ([CaseId])
	REFERENCES [Case]([Id]);



CREATE TABLE [dbo].[Comment]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[DocumentId] INT NOT NULL,
	[LawyerId] INT NOT NULL,	
	[Description] NVARCHAR(MAX) NOT NULL,
	[Date] DATETIME NOT NULL,
);

ALTER TABLE [dbo].[Comment]
ADD CONSTRAINT [FK_Comment_Document]
	FOREIGN KEY ([DocumentId])
	REFERENCES [Document]([Id]);

ALTER TABLE [dbo].[Comment]
ADD CONSTRAINT [FK_Comment_Lawyer]
	FOREIGN KEY ([LawyerId])
	REFERENCES [Lawyer]([Id]);