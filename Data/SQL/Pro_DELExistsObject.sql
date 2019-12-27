-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sherwin
-- Create date: 27/12/2019
-- Description:	Check Exists Table
-- =============================================
ALTER PROCEDURE Pro_DELExistsObject
	-- Add the parameters for the stored procedure here
	(@ObjectName Nvarchar(256) = 'DMKH', 
	@TypeObject Nvarchar(256) = 'U', 
	@ToCsharp int = 0 output)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @SQLStr NVARCHAR(MAX)
	SET @SQLStr = 'SELECT id FROM sysobjects WHERE [xtype] = '+char(39)+ @TypeObject + char(39)+'  and  [name] = ' + char(39)+@ObjectName + char(39)			
	EXEC sp_executesql @SQLStr			
	IF(@@Rowcount >0)
		SET @ToCsharp=1
	ELSE
		SET @ToCsharp=0

	Return @ToCsharp
END
GO

		