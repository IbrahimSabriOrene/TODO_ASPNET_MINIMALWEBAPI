CREATE PROCEDURE [dbo].[spTodo_Insert]
	@Title nvarchar(50),
	@Description nvarchar(200)
AS
Begin
	insert into dbo.[ToDo]([Title], [Description])
	values (@Title, @Description)
End

