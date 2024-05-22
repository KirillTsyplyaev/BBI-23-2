using System.Text.Json.Serialization;
using MyJsonSerializer_;

namespace _2е_задание
{
    public struct Sportsmen
    {
        private string _surname;

        public Sportsmen(string surname)
        {
            _surname = surname;
        }

        public string Surname
        {
            set { _surname = value; }
            get { return _surname; }
        }

    }

    abstract class Jump
    {
        protected Sportsmen _sportsmen;
        protected int _metres;
        protected double _points;
        protected string _namedisc;

        public Jump(int metres, double points, string namedisc, Sportsmen sportsmen)
        {
            _metres = metres;
            _points = points;
            _namedisc = namedisc;
            _sportsmen = sportsmen;
        }

        public int Metres
        {
            get { return _metres; }
            set { _metres = value; }
        }

        public double Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public string Namedisc
        {
            get { return _namedisc; }
            set { _namedisc = value; }
        }

        public Sportsmen Sportsmen
        {
            get { return _sportsmen; }
            set { _sportsmen = value; }
        }

        public void ShowResult()
        {
            Console.WriteLine($"Фамилия {_sportsmen.Surname} Названия дисциплины {_namedisc}, очки {_points}");
        }

    }
    class Jump_3 : Jump
    {
        [JsonConstructor]
        public Jump_3(int metres, double points, string namedisc, Sportsmen sportsmen) : base(3, points, "3 m", sportsmen)
        {

        }

    }
    class Jump_5 : Jump
    {
        [JsonConstructor]
        public Jump_5(int metres, double points, string namedisc, Sportsmen sportsmen) : base(5, points, "5 m", sportsmen)
        {

        }

    }

    class Program
    {
        static void Main()
        {
            Sportsmen[] list_of_sportmens =
            {
               new Sportsmen("Tsyplyaev"),
               new Sportsmen("Mamedov"),
               new Sportsmen("Fender"),
               new Sportsmen("Sigmochka"),
               new Sportsmen("Paul")
            };

            Sportsmen[] list_of_sportmens2 =
            {
               new Sportsmen("Gambarov"),
               new Sportsmen("Nurgulov"),
               new Sportsmen("Joestar"),
               new Sportsmen("Brando"),
               new Sportsmen("Butusov")
            };

            Jump_3[] jump_3s =
            {
               new Jump_3(1, Point_Generator(),"2" , list_of_sportmens[0]),
               new Jump_3(1, Point_Generator(), "2", list_of_sportmens[1]),
               new Jump_3(1, Point_Generator(), "2", list_of_sportmens[2]),
               new Jump_3(1, Point_Generator(), "2", list_of_sportmens[3]),
               new Jump_3(1, Point_Generator(), "2", list_of_sportmens[4])
            };

            Jump_5[] jump_5s =
            {
                new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[0]),
                new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[1]),
                new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[2]),
                new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[3]),
                new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[4])
            };

            Sort(jump_3s);
            Sort(jump_5s);

            string filePath = @"C:\\Users\\Кириешка\\Desktop\\jumps";
            string filePath2 = filePath;

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            else
            {
                Console.WriteLine("Папка существует");
            }

            string fileName = "jumps3.json";
            string fileName2 = "jumps5.json";

            filePath = Path.Combine(filePath, fileName);
            filePath2 = Path.Combine(filePath2, fileName2);

            if (!File.Exists(filePath))
            {
                var createdFile = File.Create(filePath);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Jump_3[]>(jump_3s, filePath);
            }

            MyJsonSerializer.Write<Jump_3[]>(jump_3s, filePath);

            if (!File.Exists(filePath2))
            {
                var createdFile = File.Create(filePath2);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Jump_5[]>(jump_5s, filePath2);
            }

            MyJsonSerializer.Write<Jump_5[]>(jump_5s, filePath2);

            if (File.Exists(filePath) && File.Exists(filePath2))
            {
                var deserializedData = MyJsonSerializer.Read<Jump_3[]>(filePath);
                var deserializedData2 = MyJsonSerializer.Read<Jump_5[]>(filePath2);

                Console.WriteLine("\nпрыжки с 3 метров");
                foreach (Jump_3 j in deserializedData)
                {
                    Console.WriteLine($"Фамилия {j.Sportsmen.Surname}, количество очков {j.Points},  {j.Namedisc} , высота {j.Metres} м");
                }
                Console.WriteLine("\nпрыжки с 5 метров");
                foreach (Jump_5 j in deserializedData2)
                {
                    Console.WriteLine($"Фамилия {j.Sportsmen.Surname}, количество очков {j.Points},  {j.Namedisc} , высота {j.Metres} м");
                }

            }


        }

        static double Point_Generator()
        {

            int[] points = new int[4]; double total_points = 0;
            Random point = new Random();

            for (int i = 0; i < 4; i++)
            {
                points[i] = point.Next(0, 42);
            }

            //поиск максимума
            int max = int.MinValue; int imax = 0;
            for (int i = 0; i < 4; i++)
            {
                if (points[i] > max)
                {
                    max = points[i]; imax = i;
                }
            }

            //поиск минимума 
            int min = int.MaxValue; int imin = 0;
            for (int i = 0; i < 4; i++)
            {
                if (points[i] < min)
                {
                    min = points[i]; imin = i;
                }
            }

            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i != imax && i != imin) sum += points[i];
            }
            //финальные очки
            total_points = sum * K();

            return Math.Round(total_points, 0);
        }

        static double K()
        {
            double k = 2.5;
            double[] k_list = new double[6];

            for (int i = 0; i < 6; i++)
            {
                k_list[i] = k;
                k += 0.2;
            }

            Random random = new Random();
            int K = random.Next(0, 5);
            k = k_list[K];
            return k;
        }

        static Jump[] Sort(Jump[] Jumps)
        {

            for (int i = 0; i < Jumps.Length; i++)
            {
                for (int j = i + 1; j < Jumps.Length; j++)
                {
                    if (Jumps[j].Points > Jumps[i].Points)
                    {
                        var temp = Jumps[j];
                        Jumps[j] = Jumps[i];
                        Jumps[i] = temp;
                    }
                }
            }
            return Jumps;
        }

    }
}
