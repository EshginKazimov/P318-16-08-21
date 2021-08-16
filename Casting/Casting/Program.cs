using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting

            #region Upcasting, boxing, implicit

            //Shark shark1 = new Shark();
            //shark1.TeethCount = 10;
            //Console.WriteLine(shark1.TeethCount);
            //shark1.Eat();
            //shark1.Swim();

            //Eagle eagle1 = new Eagle();
            //eagle1.Fly();

            //Animal a1 = new Animal();

            //Print(shark1);
            //Print(eagle1);

            //Animal shark2 = new Shark();
            //shark2.TeethCount = 10;
            //shark2.Eat();
            //shark2.Swim();
            //Print(shark2);
            //Console.WriteLine(shark2);

            //Animal eagle2 = new Eagle();
            //eagle2.Eat();

            //Animal a1 = eagle2;

            //object[] arr = { shark2, eagle2, "Salam", 10, true };
            //foreach (object item in arr)
            //{
            //    Console.WriteLine(item);
            //    //Console.WriteLine(item.ToString());
            //}

            //Animal[] arr = { eagle2, shark2 };
            //foreach (Animal item in arr)
            //{
            //    item.Eat();
            //}

            #endregion

            #region Downcasting, unboxing, explicit

            //Animal animal1 = new Shark();
            //Animal animal2 = new Eagle();

            //Shark fish = (Shark)animal1;

            //if (animal1 is Shark)
            //{
            //    Shark shark1 = (Shark)animal1;
            //    Console.WriteLine("Ok");
            //}
            //if (animal1 is Shark shark1)
            //{
            //    shark1.Swim();
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid cast");
            //}

            //Shark fish = animal1 as Shark;
            //if (fish != null)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid cast");
            //}

            //object[] arr = { animal1, animal2, 10, "Salam", true };

            //foreach (var item in arr)
            //{
            //    if (item is Animal animal)
            //    {
            //        animal.Eat();
            //    }
            //}

            #endregion

            //int a = 10;
            //long l = a;
            //Console.WriteLine(l);

            //long l = 100000000000000000;
            //int a = (int)l;
            //Console.WriteLine(a);

            //double d = 10.5;
            //int b = (int)d;
            //Console.WriteLine(b);

            #endregion

            #region Implicit, explicit

            Manat m1 = new Manat(340);

            //Dollar d1 = new Dollar(m1.Value / 1.7);
            Dollar d1 = (Dollar)m1;
            //Dollar d1 = (Dollar)m1;
            //Console.WriteLine(d1.Value);

            #endregion

            #region Custom operators

            //Person p1 = new Person("Elnur", "Suleymanzade", 31);
            //Person p2 = new Person("Sarkhan", "Asgarov", 26);
            //Console.WriteLine(p1 + p2);
            //Console.WriteLine(p1 < p2);

            #endregion
        }

        #region Upcasting

        static void Print(Animal animal)
        {
            Console.WriteLine("Hello");
            animal.Eat();
            Console.WriteLine("Bye");
        }

        static void Print(Fish fish)
        {
            fish.Swim();
            fish.Eat();
        }

        //static void Print(Shark s1)
        //{
        //    Console.WriteLine("Hello");
        //    s1.Eat();
        //    Console.WriteLine("Bye");
        //}

        //static void Print(Eagle e1)
        //{
        //    Console.WriteLine("Hello");
        //    e1.Eat();
        //    Console.WriteLine("Bye");
        //}

        #endregion
    }

    #region Casting

    abstract class Animal : Object
    {
        public abstract void Eat();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }

        public override string ToString()
        {
            return TeethCount.ToString();
        }
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    #endregion

    #region Implicit, explicit

    //1.Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var ve
    //Degree adli property-leri var. 
    //Celcius uchun implicit operatorunu yazmaginizi isteyirem.(0C= 273K)

    class Manat
    {
        public double Value { get; set; }

        public Manat(double value)
        {
            Value = value;
        }

        public static implicit operator Dollar(Manat manat)
        {
            //Dollar d1 = new Dollar(manat.Value / 1.7);
            //return d1;
            return new Dollar(manat.Value / 1.7);
        }

        //public static explicit operator Dollar(Manat manat)
        //{
        //    //Dollar d1 = new Dollar(manat.Value / 1.7);
        //    //return d1;
        //    return new Dollar(manat.Value / 1.7);
        //}
    }

    class Dollar
    {
        public double Value { get; set; }

        public Dollar(double value)
        {
            Value = value;
        }
    }

    #endregion

    #region Custom operators

    class Person
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }

        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }

    #endregion
}
