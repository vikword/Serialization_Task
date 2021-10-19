using Newtonsoft.Json;
using System;
using System.IO;

namespace Serialization_Task
{
    class Program
    {
        static void Main()
        {
            Mersedes[] auto = new Mersedes[] 
            {
                new Mersedes("CLK 500", 250, Mode.Lux,
                new Person[]
                {
                    new Person("Василий", "Петров", 20),
                    new Person("Иван", "Сидоров", 30),
                    new Person("Пётр", "Васильев", 40)
                }),
                new Mersedes("SLK 200", 200, Mode.Mid,
                new Person[]
                {
                    new Person("Сергей", "Иванов", 40)
                }),
                new Mersedes("SL 600", 300, Mode.Sport,
                new Person[]
                {
                    new Person("Владимир", "Сидоров", 20),
                    new Person("Дмитрий", "Сомов", 40)
                }),
            };

            //Сериализация
            string jsonSerialize = JsonConvert.SerializeObject(auto);
            File.WriteAllText("json.json", jsonSerialize);

            //Десериализация
            string jsonDeserialize = File.ReadAllText("json.json");
            Mersedes[] mersedes = JsonConvert.DeserializeObject<Mersedes[]>(jsonDeserialize);

            //Вывод
            foreach (var mers in mersedes)
            {
                Console.WriteLine($"Имя      : {mers.Name}");
                Console.WriteLine($"Скорость : {mers.Speed}");
                Console.WriteLine($"Режим    : {mers.Mode}");
                foreach (var person in mers.Person)
                {
                    Console.WriteLine($"Владельцы: {person.Name}, {person.Surname}, {person.Age}");
                }
                Console.WriteLine();
            }
        }
    }
}
