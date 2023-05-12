CREATE PROCEDURE [dbo].[spTodo_Update]
	@Id int,
	@Title nvarchar(50),
	@Description nvarchar(200)
AS
begin
	update dbo.[ToDo]
	set [Title] = @Title, [Description] = @Description
	where Id = @Id;
end