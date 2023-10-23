// Todo todo1 = new Todo(4, "Wash the dishes", true);
// Todo todo2 = new Todo(5, "Clean the house", false);
// Todo todo3 = new Todo(6, "Mow the lawn", false);

TodoContext context = new TodoContext();

// context.Todo.Add(todo1);
// context.Todo.Add(todo2);
// context.Todo.Add(todo3);
// context.SaveChanges();

Console.WriteLine("==== Tous les Todos ====");
foreach (var todo in context.Todo)
{
    Console.WriteLine($"Todo {todo.Id}, task: {todo.Task}, completed: {todo.Completed}");
}

Console.WriteLine("==== Tous les Todos non terminés ====");
var notCompletedTodo = context.Todo.Where(x => x.Completed == false);
foreach (var todo in notCompletedTodo)
{
    if (!todo.Completed)
        Console.WriteLine($"Todo {todo.Id}, task: {todo.Task}, completed: {todo.Completed}");
}

