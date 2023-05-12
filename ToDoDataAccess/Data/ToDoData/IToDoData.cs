using ToDoDataAccess.Models;

namespace ToDoDataAccess.Data.ToDoData;
public interface IToDoData
{
    Task DeleteToDo( int id );
    Task<IEnumerable<ToDoModel>> GetToDo();
    Task InsertToDo( ToDoModel todo );
    Task UpdateToDo( ToDoModel todo );
}