using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<Todoitem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem 
            {
                Title = "learn ASP.NET Core",
                DueAt = DateTimeOffSet.Now.AddDays(1)
            };

            var item2 = new TodoItem 
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffSet.Now.AddDays(2)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}