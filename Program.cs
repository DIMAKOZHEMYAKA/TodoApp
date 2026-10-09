using TodoApp.module;

TaskItem task1 = new TaskItem(1, "TestTitle1", "hahaha1");

System.Console.WriteLine(task1.ToString());
TaskItem task2 = new TaskItem(2, "TestTitle2", "hahaha2");
TaskItem task3 = new TaskItem(3, "TestTitle3", "hahaha3");
TaskItem task4 = new TaskItem(4, "TestTitle4", "hahaha4");
TaskItem task5 = new TaskItem(5, "TestTitle5", "hahaha5");

TaskManager taskManager = new([task1, task2, task3, task4, task5]);
System.Console.WriteLine(taskManager.ToString());

