CREATE PROCEDURE [dbo].[spTodo_Delete]
	@Id int
AS
begin
	delete 
	from dbo.[ToDo]
	where Id = @Id
end 