CREATE PROCEDURE [dbo].[GetAllData]
AS
BEGIN
	select [Id],[Title], [Description] 
	from dbo.[ToDo];
END
