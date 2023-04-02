namespace LinqExp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool Teste = true;
            List<Task> ToDo = new List<Task>
            {
                new Task{Id=Guid.NewGuid().ToString(), Title="Study C#", Done=false},
                new Task{Id=Guid.NewGuid().ToString(), Title="Study Delphi", Done=false},
                new Task{Id=Guid.NewGuid().ToString(), Title="Call Mr. Crane", Done=true},
                new Task{Id=Guid.NewGuid().ToString(), Title="Help Mrs. Wilson", Done=false}
            };

            var UndoneToDos = from todo in ToDo
                              where todo.Done == Teste
                              orderby todo.Title
                              select todo;

            foreach (var task in UndoneToDos)
            {
                Console.WriteLine("{0} - {1}", task.Id, task.Title);
            }                  
            Console.ReadKey();

        }
    }

    class Task
    {
        public string? Id { get; set; }
        public string? Title {get; set;}
        public bool Done { get; set; }
    }
    
}