namespace ToDoMinimalApi.Api;

public static class Api
{
    public static void ConfigureApi(this WebApplication app )
    {
		app.MapGet( "/Todo" , GetToDo );
        app.MapPost( "/Todo" , InsertToDo );
        app.MapPut( "/Todo" , UpdateToDo );
        app.MapDelete( "/Todo" , DeleteTodo );
    }

    private static async Task<IResult> GetToDo( IToDoData data )
    {
		try
		{
			return Results.Ok( await data.GetToDo() );
		}
		catch ( Exception ex )
		{

			return Results.Problem(ex.Message);
		}
    }

	private static async Task<IResult> InsertToDo(ToDoModel todo, IToDoData data )
	{
        try
        {
            await data.InsertToDo( todo );
            return Results.Ok();
        }
        catch ( Exception ex )
        {

            return Results.Problem( ex.Message );
        }
    }

    private static async Task<IResult> UpdateToDo(ToDoModel todo, IToDoData data )
    {
        try
        {
            await data.UpdateToDo( todo );
            return Results.Ok();
        }
        catch ( Exception ex )
        {

            return Results.Problem( ex.Message );
        }
    }
	
    private static async Task<IResult> DeleteTodo(int id, IToDoData data )
    {
        try
        {
            await data.DeleteToDo( id );
            return Results.Ok();
        }
        catch ( Exception ex )
        {

            return Results.Problem( ex.Message );
        }
    }
}
