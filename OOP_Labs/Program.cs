using Lab1;
using System.Text;


Console.OutputEncoding = UTF8Encoding.UTF8;//підключаємо кодування для коректного виведення на консоль
List<ComponentsInfo> list = new();//створюємо список елементів типу нашого класу

//створюємо екземпляри класу
ComponentsInfo flange = new ("Фланець", "З", 3, 450);
ComponentsInfo adapter = new ("Перехідник", "К", 8, 74);
ComponentsInfo frame = new ("Станина", "Про", 1, 117050);

//додаємо їх до списку
list.Add(flange);
list.Add(adapter);
list.Add(frame);

//за допомогою циклу перебираємо елементи у списку і виводимо їх на консоль методом прінт
foreach (var item in list) item.Print();