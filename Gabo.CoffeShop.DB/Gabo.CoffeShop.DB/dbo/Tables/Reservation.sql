﻿CREATE TABLE [dbo].[Reservation]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[Phone] VARCHAR(50) NOT NULL,
	[TotalPeople] INT NOT NULL,
	[Date] DateTime NOT NULL,
	[Time] varchar(max) NOT NULL,
	CONSTRAINT [PK_RESERVATION_ID] PRIMARY KEY CLUSTERED ([Id])
)
