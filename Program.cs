Todo todo1 = new Todo(4, "Wash the dishes", true);
Todo todo2 = new Todo(5, "Clean the house", false);
Todo todo3 = new Todo(6, "Mow the lawn", false);

TodoContext context = new TodoContext();

context.Todo.Add(todo1);
context.Todo.Add(todo2);
context.Todo.Add(todo3);
context.SaveChanges();