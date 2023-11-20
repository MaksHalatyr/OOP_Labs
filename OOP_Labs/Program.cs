using Lab_3.Third_Task;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//First Task

//створюємо новий екземпляр класу персон
Lab_3.First_Task.Person Bob = new("Bob", "Lancer", 21); 
Bob.Greet();
//створюємо новий екземпляр класу студент
Lab_3.First_Task.Student Dima = new("Dima", "Kerpov", 1);
Dima.SetAge(19);
Dima.Greet();
Dima.ShowAge();
//створюємо новий екземпляр класу професор
Lab_3.First_Task.Professor Oleh = new("Oleh", "Somer", 42, "Math");
Oleh.Explain();

//Second Task
Console.WriteLine();
//створюємо нові екземпляри класу воркер
Lab_3.Second_Task.Worker Ivan = new("Ivan", 25, 1000);
Lab_3.Second_Task.Worker Vasya = new("Vasya", 26, 2000);
Ivan.Print();
Vasya.Print();
Console.WriteLine("Sum salary = " + (Ivan.Salary + Vasya.Salary));

//Third Task
//створюємо новий екземпляр класу депо
TrainDepartment train = new TrainDepartment(747,"Kyiv", 23, 50, 10);
train.Print();
train.TimeToDep();