using MyJsonSerializer_;
using System.Text.Json.Serialization;

namespace _3е_задание
{
    public struct Sportsmen
    {
        private string _name;

        public Sportsmen(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }

    class Skier
    {
        protected Sportsmen _sportsmen;
        protected double _result;
        protected string _gender;

        public Skier(double result, Sportsmen sportsmen, string gender)
        {
            _sportsmen = sportsmen;
            _result = result;
            _gender = gender;
        }

        public Sportsmen Sportsmen
        {
            get { return _sportsmen; }
            set { _sportsmen = value; }
        }

        public double Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public virtual void Compete()
        {
            Random random = new Random();
            _result = random.Next(80, 100); // генерация случайного результата
        }

        public void Display()
        {
            Console.WriteLine($"пол {_gender},имя {_sportsmen.Name}, результат {_result}");
        }

    }

    class WomanSkier : Skier
    {
        [JsonConstructor]
        public WomanSkier(double result, Sportsmen sportsmen, string gender) : base(result, sportsmen, "woman")
        {

        }

        public override void Compete()
        {
            Random random = new Random();
            Result = random.Next(60, 100);
        }
    }

    class ManSkier : Skier
    {
        [JsonConstructor]
        public ManSkier(double result, Sportsmen sportsmen, string gender) : base(result, sportsmen, "man")
        {

        }

        public override void Compete()
        {
            Random random = new Random();
            Result = random.Next(80, 100);
        }
    }

    class Program
    {
        static void Main()
        {
            Sportsmen[] list_of_men = {
                new Sportsmen("Tsyplyaev"), new Sportsmen("Mamedov"),
                new Sportsmen("Pupkin"), new Sportsmen("Dobryi"),
                new Sportsmen("Gambarov"),new Sportsmen("VAsin"),
                new Sportsmen("Sirenko"), new Sportsmen("Gorin"),
                new Sportsmen("Dobryak"),new Sportsmen("Kerik")
            };

            Sportsmen[] list_of_women = {
                new Sportsmen("Vasina"), new Sportsmen("Sirenkina"),
                new Sportsmen("Gorina"),new Sportsmen("Dobryakina"),
                new Sportsmen("Kerikina"), new Sportsmen("Tsyplyaeva"),
                new Sportsmen("Mamedova"), new Sportsmen("Pupkina"),
                new Sportsmen("Dobryia"), new Sportsmen("Gambarova")
            };

            ManSkier[] Team1 = {
                new ManSkier(1, list_of_men[0], "м"), new ManSkier(1, list_of_men[1], "м"),
                new ManSkier(1, list_of_men[2], "м"), new ManSkier(1, list_of_men[3], "м"),
                new ManSkier(1, list_of_men[4], "м")
            };
            ManSkier[] Team2 = {
                new ManSkier(1, list_of_men[5], "м"), new ManSkier(1, list_of_men[6], "м"),
                new ManSkier(1, list_of_men[7], "м"), new ManSkier(1, list_of_men[8], "м"),
                new ManSkier(1, list_of_men[9], "м")
            };

            WomanSkier[] Team3 = {
                new WomanSkier(1,list_of_women[0],"ж"), new WomanSkier(1,list_of_women[1],"ж"),
                new WomanSkier(1,list_of_women[2],"ж"), new WomanSkier(1,list_of_women[3],"ж"),
                new WomanSkier(1,list_of_women[4],"ж")
            };
            WomanSkier[] Team4 = {
                new WomanSkier(1,list_of_women[5],"ж"), new WomanSkier(1,list_of_women[6],"ж"),
                new WomanSkier(1,list_of_women[7],"ж"), new WomanSkier(1,list_of_women[8],"ж"),
                new WomanSkier(1,list_of_women[9],"ж")
            };
            for (int i = 0; i < 5; i++)
            {
                Team1[i].Compete();
                Team2[i].Compete();
                Team3[i].Compete();
                Team4[i].Compete();
            }

            Skier[] Mans = new Skier[10];
            Mans = Fill(Team1, Team2);
            Skier[] Women = new Skier[10];
            Women = Fill(Team3, Team4);

            Skier[] all_runners = new Skier[20];
            all_runners = Fill(Mans, Women);
            Sort(all_runners);

            Sort(Mans);
            Sort(Women);

            string filePath = @"C:\\Users\\Кириешка\\Desktop\\skiers";
            string filePath2 = filePath;
            string filePath3 = filePath2;

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            else
            {
                Console.WriteLine("Директория существует");
            }

            string fileName = "woman_skiers.json";
            string fileName2 = "man_skiers.json";
            string fileName3 = "all_runners.json";

            filePath = Path.Combine(filePath, fileName);
            filePath2 = Path.Combine(filePath2, fileName2);
            filePath3 = Path.Combine(filePath3, fileName3);

            if (!File.Exists(filePath))
            {
                var createdFile = File.Create(filePath);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Skier[]>(Women, filePath);
            }
            MyJsonSerializer.Write<Skier[]>(Women, filePath);

            if (!File.Exists(filePath2))
            {
                var createdFile = File.Create(filePath2);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Skier[]>(Mans, filePath2);
            }
            MyJsonSerializer.Write<Skier[]>(Mans, filePath2);

            if (!File.Exists(filePath3))
            {
                var createdFile = File.Create(filePath3);
                createdFile.Close();
            }
            else
            {
                MyJsonSerializer.Write<Skier[]>(all_runners, filePath3);
            }
            MyJsonSerializer.Write<Skier[]>(all_runners, filePath3);

            if (File.Exists(filePath2) && File.Exists(filePath) && File.Exists(filePath3))
            {
                var deserializedData = MyJsonSerializer.Read<WomanSkier[]>(filePath);
                var deserializedData2 = MyJsonSerializer.Read<ManSkier[]>(filePath2);
                var deserializedData3 = MyJsonSerializer.Read<Skier[]>(filePath3);

                Console.WriteLine("ДЕВУШКИ!!!!!\n");
                foreach (WomanSkier skier in deserializedData)
                {
                    skier.Display();
                }

                Console.WriteLine("МУЖИКИ!!!!\n");
                foreach (ManSkier skier in deserializedData2)
                {
                    skier.Display();
                }

                Console.WriteLine("Финальная таблица\n");
                foreach (Skier skier in deserializedData3)
                {
                    skier.Display();
                }
            }

        }

        static Skier[] Fill(Skier[] skiers, Skier[] skiers2)
        {
            Skier[] hum = new Skier[skiers.Length + skiers2.Length];
            for (int i = 0; i < skiers.Length; i++)
            {
                hum[i] = skiers[i];
            }
            for (int i = 0; i < skiers2.Length; i++)
            {
                hum[skiers.Length + i] = skiers2[i];
            }
            return hum;
        }

        static Skier[] Sort(Skier[] skiers)
        {
            for (int i = 0; i < skiers.Length; i++)
            {
                for (int j = i + 1; j < skiers.Length; j++)
                {
                    if (skiers[i].Result < skiers[j].Result)
                    {
                        var temp = skiers[i];
                        skiers[i] = skiers[j];
                        skiers[j] = temp;
                    }
                }
            }
            return skiers;
        }

    }
}
