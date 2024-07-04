namespace Assignment_6
{
    internal class Program
    {

        #region P1
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        #region P2
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

           
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        #endregion

        #region P3
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region P5
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion

        #region P6
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }


            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }


            public double DistanceTo(Point other)
            {
                double deltaX = X - other.X;
                double deltaY = Y - other.Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }
        #endregion

        #region P7
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        } 
        #endregion

        static void Main(string[] args)
        {

            /** #region P1
             Array weekDaysValues = Enum.GetValues(typeof(WeekDays));


             for (int i = 0; i < weekDaysValues.Length; i++)
             {

                 Console.WriteLine(weekDaysValues.GetValue(i));
             }

             #endregion


            #region P2
            Person[] persons = new Person[3];


            persons[0] = new Person("Alice", 30);
            persons[1] = new Person("Bob", 25);
            persons[2] = new Person("Charlie", 35);


            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Name: {persons[i].Name}, Age: {persons[i].Age}");
            } 
            #endregion

             #region P3
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();


            bool success = Enum.TryParse(input, true, out Season season);

            if (success)
            {

                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid season name.");
            } 
            #endregion

            #region P5
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string input = Console.ReadLine();


            bool success = Enum.TryParse(input, true, out Colors color);

            if (success)
            {

                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {

                Console.WriteLine($"{input} is not a primary color.");
            } 
            #endregion

               #region P6



            Console.WriteLine("Enter the coordinates of the first point (X Y):");
            string[] input1 = Console.ReadLine().Split();
            double x1 = double.Parse(input1[0]);
            double y1 = double.Parse(input1[1]);


            Point point1 = new Point(x1, y1);

            Console.WriteLine("Enter the coordinates of the second point (X Y):");
            string[] input2 = Console.ReadLine().Split();
            double x2 = double.Parse(input2[0]);
            double y2 = double.Parse(input2[1]);

            Point point2 = new Point(x2, y2);

            double distance = point1.DistanceTo(point2);

            Console.WriteLine($"The distance between the points is: {distance}"); 
            #endregion

            #region P7
            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the details of person {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                persons[i] = new Person(name, age);
            }

            Person oldestPerson = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldestPerson.Age)
                {
                    oldestPerson = persons[i];
                }
            }

            Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}."); 
            #endregion
             */



        }
    }

}