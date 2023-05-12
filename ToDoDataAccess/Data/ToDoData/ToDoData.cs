

using ToDoDataAccess.DbAccess;
using ToDoDataAccess.Models;

namespace ToDoDataAccess.Data.ToDoData;
public class ToDoData : IToDoData
{
    private readonly ISqlDataAccess _db;

    public ToDoData( ISqlDataAccess db )
    {
        _db = db;
    }

    public Task<IEnumerable<ToDoModel>> GetToDo() =>
        _db.LoadData<ToDoModel , dynamic>( "GetAllData" , new { } );

    public Task InsertToDo( ToDoModel todo ) =>
         _db.SaveData( "spTodo_Insert" , new { todo.Title , todo.Description } );

    public Task UpdateToDo( ToDoModel todo ) =>
        _db.SaveData( "spTodo_Update" , todo );

    public Task DeleteToDo( int id ) =>
        _db.SaveData( "spTodo_Delete" , new { Id = id } );
}
