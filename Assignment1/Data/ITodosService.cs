using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
        void RemoveTodo(int todoId);
        void Update(Todo todo);
    }
}