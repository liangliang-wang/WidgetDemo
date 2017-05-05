
namespace ConsoleApplication1
{
    public class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Sex { set; get; }

        public Person( )
        {
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public void Eat()
        {

        }

        public void Foot()
        {

        }
        public void Hit()
        {

        }


    }

    public class Car
    {
        public string Color { set; get; }
        public string Brand { set; get; }

        public Car(string color, string brand)
        {
            Color = color;
            Brand = brand;

        }

        public string Qidong(Person p)
        {
            return p.Name+"Success 驾驶"+Color+Brand+"的车";
        }
    }

    public class Oldpeople:Person
    {
        public string Foot(Person p)
        {
            return p.Name;
        }

    }
}


