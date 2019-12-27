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
-- Description:	Check Exists Value In Table
-- =============================================
ALTER PROCEDURE Pro_DELExistsValueInTable 
	-- Add the parameters for the stored procedure here
	@TableName Nvarchar(256) = 'DMKH', 
	@ColumnName Nvarchar(256) = 'ma_kh', 
	@Value Nvarchar(512) = 'BH12a3',
	@ToCsharp int  = 1 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @SQLStr NVARCHAR(MAX)
	SET @SQLStr = 'SELECT top 1 [' + @ColumnName + '] FROM [' + @TableName + '] WHERE [' + @columnName + '] = ' + char(39)+ @Value + char(39)		

	EXEC sp_executesql @SQLStr			
	IF(@@Rowcount >0)
		SET @ToCsharp=1
	ELSE
		SET @ToCsharp=0

	RETURN @ToCsharp
END
GO