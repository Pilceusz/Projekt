USE [Baza]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[People_GetByLastName]
	@LastName nvarchar (50)
AS
BEGIN 
	SET NOCOUNT ON;

	select *
	from dbo.People
	where LastName = @LastName;
END