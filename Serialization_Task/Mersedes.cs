
namespace Serialization_Task
{
    class Mersedes : Car
    {
        public Mode Mode { get; set; }
        public Person[] Person { get; set; }

        public Mersedes(string name, int speed, Mode mode, Person[] person) : base(name, speed)
        {
            Mode = mode;
            Person = person;
        }
    }
}
