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
ALTER PROCEDURE Pro_DELExistsValue
	-- Add the parameters for the stored procedure here
	@ColumnName Nvarchar(256) = 'ma_kh', 
	@Value Nvarchar(512) = 'BH12a3',
	@ToCsharp int  = 1 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @SQLStr NVARCHAR(MAX),@TableName Nvarchar(256)
	DECLARE curDEL CURSOR FOR SELECT name FROM sysobjects WHERE [xtype] = 'U'  and [id] IN (SELECT [id] FROM syscolumns WHERE [name] = @ColumnName)	
	OPEN curDEL               
	FETCH NEXT FROM curDEL INTO @TableName
	WHILE @@FETCH_STATUS = 0         
	BEGIN
		SET @ToCsharp = 0
		Exec Pro_DELExistsObject @TableName,'U',@ToCsharp
		IF(@ToCsharp = 1)
		BEGIN
			SET @ToCsharp = 0
			Exec Pro_DELExistsColumnInTable @TableName,'U',@ColumnName,@ToCsharp
			IF(@ToCsharp = 1)
			BEGIN
				SET @ToCsharp = 0
				Exec  Pro_DELExistsValueInTable @TableName,@ColumnName,@Value,@ToCsharp
				IF(@ToCsharp = 1)
				BEGIN
					RETURN @ToCsharp
				END

			END
		END
		FETCH NEXT FROM curDEL INTO @TableName
	END
	CLOSE curDEL              
	DEALLOCATE curDEL 
		
	RETURN @ToCsharp
	
END
GO
