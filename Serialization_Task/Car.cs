
namespace Serialization_Task
{
    class Car
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
