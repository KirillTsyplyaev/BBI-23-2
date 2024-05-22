using System.Text.Json.Serialization;
using MyJsonSerializer_;

namespace _1е_задание
{
    public struct Sportsmen
    {
        private string _surname;
        private string _surnameT;
        private int _group;


        public Sportsmen(string surname, string surnameT, int group)
        {
            _surname = surname;
            _surnameT = surnameT;
            _group = group;
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string SurnameT
        {
            get { return _surnameT; }
            set { _surnameT = value; }
        }

        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }

    }

    internal class Program
    {
        static void Main()
        {
            Sportsmen[] list_of_sportsmen =
            {
                new Sportsmen("Mamedov", "Zakharov", 1),
                new Sportsmen("Pupkin", "Nasvayev", 1),
                new Sportsmen("Dobryi", "Kolya", 2),
                new Sportsmen("Gambarov", "Elshatov", 2),
                new Sportsmen("Russlih", "Eremin", 2)
            };

            Sportsmen[] list_of_sportsmen2 =
            {
                new Sportsmen("VAsin","Nikolaev", 3),
                new Sportsmen("Sirenko", "Nikolaev", 3),
                new Sportsmen("Gorin","RAaht", 4),
                new Sportsmen("Dobryak","NGitelman", 4),
                new Sportsmen("Tsyplyaev", "Zakharov", 1)
            };

            Run100[] run100s =
            {

                new Run100(100, 26, list_of_sportsmen[0]),
                new Run100(100, 25, list_of_sportsmen[1]),
                new Run100(100, 43, list_of_sportsmen[2]),
                new Run100(100, 29, list_of_sportsmen[3]),
                new Run100(100, 13, list_of_sportsmen[4])
            };

            Run500[] run500s =
            {
                new Run500(500, 300, list_of_sportsmen2[0]),
                new Run500(500, 400, list_of_sportsmen2[1]),
                new Run500(500, 301, list_of_sportsmen2[2]),
                new Run500(500, 320, list_of_sportsmen2[3]),
                new Run500(500, 232, list_of_sportsmen2[4]),
            };

            Sort(run100s);
            Sort(run500s);

            string filePath = @"C:\\Users\\Кириешка\\Desktop\\runs";
            string filePath2 = filePath;

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            else
            {
                Console.WriteLine("Папка существует");
            }

            string fileName = "run100.json";
            string fileName2 = "run500.json";

            filePath = Path.Combine(filePath, fileName);
            filePath2 = Path.Combine(filePath2, fileName2);

            if (!File.Exists(filePath))
            {
                var createdFile = File.Create(filePath);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Run100[]>(run100s, filePath);
            }
            MyJsonSerializer.Write<Run100[]>(run100s, filePath);

            if (!File.Exists(filePath2))
            {
                var createdFile = File.Create(filePath2);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Run500[]>(run500s, filePath2);
            }
            MyJsonSerializer.Write<Run500[]>(run500s, filePath2);

            if (File.Exists(filePath) && File.Exists(filePath2))
            {
                var deserializedData = MyJsonSerializer.Read<Run100[]>(filePath);
                var deserializedData2 = MyJsonSerializer.Read<Run500[]>(filePath2);
                Console.WriteLine("\nЗабеги на 100м");
                foreach (Run s in deserializedData)
                {
                    Console.WriteLine($"Фамилия {s.Sportsmen.Surname}, Имя преподавателя {s.Sportsmen.SurnameT}, Время {s.Time} , Дистанция {s.Dist}");
                }
                Console.WriteLine("\nЗабеги на 500м");
                foreach (Run s in deserializedData2)
                {
                    Console.WriteLine($"Фамилия {s.Sportsmen.Surname}, Имя преподавателя {s.Sportsmen.SurnameT}, Время {s.Time} , Дистанция {s.Dist}");
                }
            }

        }

        static Run[] Sort(Run[] run)
        {
            for (int i = 0; i < run.Length; i++)
            {
                for (int j = i + 1; j < run.Length; j++)
                {
                    if (run[j].Time < run[i].Time)
                    {
                        var temp = run[j];
                        run[j] = run[i];
                        run[i] = temp;
                    }
                }
            }
            return run;
        }

    }

    abstract class Run
    {
        private Sportsmen _sportsmen;
        private int _dist;
        private int _time;

        public Run(int dist, int time, Sportsmen sportsmen)
        {
            _dist = dist;
            _time = time;
            _sportsmen = sportsmen;
        }
        public Sportsmen Sportsmen
        {
            get { return _sportsmen; }
            set { _sportsmen = value; }
        }

        public void Sportsmeninfo()
        {
            Console.WriteLine($"Фамилия участницы {_sportsmen.Surname} фамилия учителя {_sportsmen.SurnameT} группа {_sportsmen.Group} Дистанция {_dist} метров. Время забега составило {_time} cекунд");
        }

        public int Dist
        {
            get { return _dist; }
            set { _dist = value; }
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }

    class Run100 : Run
    {
        [JsonConstructor]
        public Run100(int dist, int time, Sportsmen sportsmen) : base(100, time, sportsmen)
        {

        }
    }

    class Run500 : Run
    {
        [JsonConstructor]
        public Run500(int dist, int time, Sportsmen sportsmen) : base(500, time, sportsmen)
        {

        }
    }
}
