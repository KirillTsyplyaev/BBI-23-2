namespace lab7
{
    #region 1 часть второй номер
    //public struct Sportsmen
    //{
    //    private string _surname;
    //    private string _surnameT;
    //    private int _group;
    //    public Sportsmen(string surname, string surnameT, int group)
    //    {
    //        _surname = surname;
    //        _surnameT = surnameT;
    //        _group = group;
    //    }

    //    public string Surname
    //    { get { return _surname; } }

    //    public string SurnameT
    //    { get { return _surnameT; } }

    //    public int Group
    //    { get { return _group; } }

    //}
    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Sportsmen[] list_of_sportsmen = {
    //            new Sportsmen("Tsyplyaev", "Zakharov", 1), new Sportsmen("Mamedov", "Zakharov", 1),
    //            new Sportsmen("Pupkin", "Nasvayev", 1), new Sportsmen("Dobryi", "Kolya", 2),
    //            new Sportsmen("Gambarov", "Elshatov", 2),new Sportsmen("Russlih", "Eremin", 2)
    //        };
    //        Sportsmen[] list_of_sportsmen2 = {
    //            new Sportsmen("VAsin","Nikolaev", 3), new Sportsmen("Sirenko", "Nikolaev", 3),
    //            new Sportsmen("Gorin","RAaht", 4),new Sportsmen("Dobryak","NGitelman", 4)
    //        };

    //        Run100[] run100s = { new Run100(100, 23, list_of_sportsmen[0]), new Run100(100, 26, list_of_sportsmen[1]), new Run100(100, 25, list_of_sportsmen[2]), new Run100(100, 43, list_of_sportsmen[3]), new Run100(100, 29, list_of_sportsmen[4]), new Run100(100, 13, list_of_sportsmen[5]) };
    //        Run500[] run500s = { new Run500(500, 300, list_of_sportsmen2[0]), new Run500(500, 400, list_of_sportsmen2[1]), new Run500(500, 301, list_of_sportsmen2[2]), new Run500(500, 320, list_of_sportsmen2[3]), };
    //        Console.WriteLine("забеги на 100м \n");
    //        Sort(run100s);
    //        foreach (var runner in run100s)
    //        {
    //            runner.Sportsmeninfo();
    //        }
    //        Sort(run500s);
    //        Console.WriteLine("забеги на 500м \n");
    //        foreach (var runner in run500s)
    //        {
    //            runner.Sportsmeninfo();
    //        }
    //    }
    //    static Run[] Sort(Run[] run)
    //    {

    //        for (int i = 0; i < run.Length; i++)
    //        {
    //            for (int j = i + 1; j < run.Length; j++)
    //            {
    //                if (run[j].Time < run[i].Time)
    //                {
    //                    var temp = run[j];
    //                    run[j] = run[i];
    //                    run[i] = temp;
    //                }
    //            }
    //        }
    //        return run;
    //    }

    //}
    //abstract class Run
    //{
    //    private Sportsmen _sportsmen;
    //    private int _dist;
    //    private int _time;
    //    public Run(int dist, int time, Sportsmen sportsmen)
    //    {
    //        _dist = dist;
    //        _time = time;
    //        _sportsmen = sportsmen;
    //    }

    //    public void Sportsmeninfo()
    //    {
    //        Console.WriteLine($"Фамилия участницы {_sportsmen.Surname} фамилия учителя {_sportsmen.SurnameT} группа {_sportsmen.Group} Дистанция {_dist} метров. Время забега составило {_time} cекунд");
    //    }

    //    public int Dist
    //    {
    //        get { return _dist; }
    //        private set { }
    //    }
    //    public int Time
    //    {
    //        get { return _time; }
    //        private set { }
    //    }
    //}
    //class Run100 : Run
    //{
    //    public Run100(int dist, int time, Sportsmen sportsmen) : base(100, time, sportsmen)
    //    {

    //    }
    //}
    //class Run500 : Run
    //{
    //    public Run500(int dist, int time, Sportsmen sportsmen) : base(500, time, sportsmen)
    //    {

    //    }
    //}
    #endregion 1
    #region 2 часть 4 номер 
    //public struct Sportsmen
    //{
    //    private string _surname;
    //    public Sportsmen(string surname)
    //    {
    //        _surname = surname;
    //    }

    //    public string Surname
    //    { get { return _surname; } }
    //}

    //abstract class Jump
    //{
    //    private Sportsmen _sportsmen;
    //    private int _metres;
    //    private double _points;
    //    private string _namedisc;
    //    public Jump(int metres, double points, string namedisc, Sportsmen sportsmen)
    //    {
    //        _metres = metres;
    //        _points = points;
    //        _namedisc = namedisc;
    //        _sportsmen = sportsmen;
    //    }
    //    public int Metres { get { return _metres; } }

    //    public double Points { get { return _points; } }

    //    public string Namedisc
    //    {
    //        get
    //        {
    //            return _namedisc;
    //        }
    //    }
    //    public void ShowResult()
    //    {
    //        Console.WriteLine($"Фамилия {_sportsmen.Surname} Названия дисциплины {_namedisc}, очки {_points}");
    //    }

    //}
    //class Jump_3 : Jump
    //{
    //    public Jump_3(int metres, double points, string namedisc, Sportsmen sportsmen) : base(3, points, "прыжки с 3 м", sportsmen)
    //    {

    //    }

    //}
    //class Jump_5 : Jump
    //{
    //    public Jump_5(int metres, double points, string namedisc, Sportsmen sportsmen) : base(5, points, "прыжки с 5 м", sportsmen)
    //    {

    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Sportsmen[] list_of_sportmens = { new Sportsmen("Tsyplyaev"), new Sportsmen("Mamedov"), new Sportsmen("Fender"), new Sportsmen("Sigmochka"), new Sportsmen("Paul") };
    //        Sportsmen[] list_of_sportmens2 = { new Sportsmen("Gambarov"), new Sportsmen("Nurgulov"), new Sportsmen("Joestar"), new Sportsmen("Brando"), new Sportsmen("Butusov") };
    //        Jump_3[] jump_3s = {
    //            new Jump_3(1, Point_Generator(),"2" , list_of_sportmens[0]),
    //            new Jump_3(1, Point_Generator(), "2", list_of_sportmens[1]),
    //            new Jump_3(1, Point_Generator(), "2", list_of_sportmens[2]),
    //            new Jump_3(1, Point_Generator(), "2", list_of_sportmens[3]),
    //            new Jump_3(1, Point_Generator(), "2", list_of_sportmens[4]) };
    //        Jump_5[] jump_5s = {
    //            new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[0]),
    //            new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[1]),
    //            new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[2]),
    //            new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[3]),
    //            new Jump_5(1, Point_Generator(),"2", list_of_sportmens2[4]) };
    //        Sort(jump_3s);
    //        Sort(jump_5s);
    //        Console.WriteLine("прыжки с трех метров\n");
    //        for (int i = 0; i < jump_3s.Length; i++)
    //        {
    //            jump_3s[i].ShowResult();
    //        }
    //        Console.WriteLine("прыжки с пяти метров\n");
    //        for (int i = 0; i < jump_5s.Length; i++)
    //        {
    //            jump_5s[i].ShowResult();
    //        }

    //    }
    //    static double Point_Generator()
    //    {
    //        int[] points = new int[4]; double total_points = 0;
    //        Random point = new Random();
    //        for (int i = 0; i < 4; i++)
    //        {
    //            points[i] = point.Next(0, 42);
    //        }

    //        //поиск максимума
    //        int max = int.MinValue; int imax = 0;
    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (points[i] > max)
    //            {
    //                max = points[i]; imax = i;
    //            }
    //        }

    //        //поиск минимума 
    //        int min = int.MaxValue; int imin = 0;
    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (points[i] < min)
    //            {
    //                min = points[i]; imin = i;
    //            }
    //        }

    //        int sum = 0;
    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (i != imax && i != imin) sum += points[i];
    //        }

    //        //финальные очки
    //        total_points = sum * K();

    //        return total_points;
    //    }
    //    static double K()
    //    {
    //        double k = 2.5;
    //        double[] k_list = new double[6];
    //        for (int i = 0; i < 6; i++)
    //        {
    //            k_list[i] = k;
    //            k += 0.2;
    //        }
    //        Random random = new Random();
    //        int K = random.Next(0, 5);
    //        k = k_list[K];
    //        return k;
    //    }
    //    static Jump[] Sort(Jump[] Jumps)
    //    {

    //        for (int i = 0; i < Jumps.Length; i++)
    //        {
    //            for (int j = i + 1; j < Jumps.Length; j++)
    //            {
    //                if (Jumps[j].Points > Jumps[i].Points)
    //                {
    //                    var temp = Jumps[j];
    //                    Jumps[j] = Jumps[i];
    //                    Jumps[i] = temp;
    //                }
    //            }
    //        }
    //        return Jumps;
    //    }
    //}
    #endregion 2
    #region 3 часть 4 номер
    //public struct Sportsmen
    //{
    //    private string _name;

    //    public Sportsmen(string name)
    //    {
    //        _name = name;

    //    }

    //    public string Name { get { return _name; } }
    //}

    //class Skier
    //{
    //    private Sportsmen _sportsman;
    //    private double _result;
    //    private string _gender;

    //    public Skier(double result, Sportsmen sportsman, string gender)
    //    {
    //        _sportsman = sportsman;
    //        _result = result;
    //        _gender = gender;
    //    }

    //    public double Result { get { return _result; } protected set { _result = value; } }

    //    public string Gender { get { return _gender; } }

    //    public virtual void Compete()
    //    {
    //        Random random = new Random();
    //        _result = random.Next(80, 100); // генерация случайного результата
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"пол {_gender},имя {_sportsman.Name}, результат {_result}");
    //    }
    //}

    //class WomanSkier : Skier
    //{

    //    public WomanSkier(double result, Sportsmen sportsman, string gender) : base(result, sportsman, "женский")
    //    {

    //    }

    //    public override void Compete()
    //    {
    //        Random random = new Random();
    //        Result = random.Next(60, 100);
    //    }
    //}
    //class ManSkier : Skier
    //{

    //    public ManSkier(double result, Sportsmen sportsman, string gender) : base(result, sportsman, "мужской")
    //    {

    //    }

    //    public override void Compete()
    //    {
    //        Random random = new Random();
    //        Result = random.Next(80, 100);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Sportsmen[] list_of_men = {
    //            new Sportsmen("Tsyplyaev"), new Sportsmen("Mamedov"),
    //            new Sportsmen("Pupkin"), new Sportsmen("Dobryi"),
    //            new Sportsmen("Gambarov"),new Sportsmen("VAsin"),
    //            new Sportsmen("Sirenko"), new Sportsmen("Gorin"),
    //            new Sportsmen("Dobryak"),new Sportsmen("Kerik")
    //        };

    //        Sportsmen[] list_of_women = {
    //            new Sportsmen("Vasina"), new Sportsmen("Sirenkina"),
    //            new Sportsmen("Gorina"),new Sportsmen("Dobryakina"),
    //            new Sportsmen("Kerikina"), new Sportsmen("Tsyplyaeva"),
    //            new Sportsmen("Mamedova"), new Sportsmen("Pupkina"),
    //            new Sportsmen("Dobryia"), new Sportsmen("Gambarova")
    //        };

    //        ManSkier[] Team1 = {
    //            new ManSkier(1, list_of_men[0], "м"), new ManSkier(1, list_of_men[1], "м"),
    //            new ManSkier(1, list_of_men[2], "м"), new ManSkier(1, list_of_men[3], "м"),
    //            new ManSkier(1, list_of_men[4], "м")
    //        };
    //        ManSkier[] Team2 = {
    //            new ManSkier(1, list_of_men[5], "м"), new ManSkier(1, list_of_men[6], "м"),
    //            new ManSkier(1, list_of_men[7], "м"), new ManSkier(1, list_of_men[8], "м"),
    //            new ManSkier(1, list_of_men[9], "м")
    //        };

    //        WomanSkier[] Team3 = {
    //            new WomanSkier(1,list_of_women[0],"ж"), new WomanSkier(1,list_of_women[1],"ж"),
    //            new WomanSkier(1,list_of_women[2],"ж"),new WomanSkier(1,list_of_women[3],"ж"),
    //            new WomanSkier(1,list_of_women[4],"ж")
    //        };
    //        WomanSkier[] Team4 = {
    //            new WomanSkier(1,list_of_women[5],"ж"), new WomanSkier(1,list_of_women[6],"ж"),
    //            new WomanSkier(1,list_of_women[7],"ж"),new WomanSkier(1,list_of_women[8],"ж"),
    //            new WomanSkier(1,list_of_women[9],"ж")
    //        };
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Team1[i].Compete();
    //            Team2[i].Compete();
    //            Team3[i].Compete();
    //            Team4[i].Compete();
    //        }
    //        Sort(Team1);
    //        Sort(Team2);
    //        Sort(Team3);
    //        Sort(Team4);
    //        Console.WriteLine("Первая группа\n");
    //        foreach (var man in Team1) man.Display();
    //        Console.WriteLine("Вторая группа\n");
    //        foreach (var man in Team2) man.Display();
    //        Console.WriteLine("Третья группа\n");
    //        foreach (var girl in Team3) girl.Display();
    //        Console.WriteLine("Четвертая группа\n");
    //        foreach (var girl in Team4) girl.Display();

    //        Skier[] Mans = new Skier[10];
    //        Mans = Fill(Team1, Team2);
    //        Skier[] Women = new Skier[10];
    //        Women = Fill(Team3, Team4);
    //        Console.WriteLine("МУЖИКИ!!!!\n");
    //        Sort(Mans);
    //        foreach (Skier man in Mans)
    //        {
    //            man.Display();
    //        }
    //        Console.WriteLine("ДЕВУШКИ!!!!!\n");
    //        Sort(Women);
    //        foreach (Skier girl in Women)
    //        {
    //            girl.Display();
    //        }
    //        Skier[] all_runners = new Skier[20];
    //        all_runners = Fill(Mans, Women);
    //        Sort(all_runners);
    //        Console.WriteLine("Финальная таблица\n");
    //        foreach (Skier runner in all_runners)
    //        {
    //            runner.Display();
    //        }

    //    }
    //    static Skier[] Fill(Skier[] skiers, Skier[] skiers2)
    //    {
    //        Skier[] hum = new Skier[skiers.Length + skiers2.Length];
    //        for (int i = 0; i < skiers.Length; i++)
    //        {
    //            hum[i] = skiers[i];
    //        }
    //        for (int i = 0; i < skiers2.Length; i++)
    //        {
    //            hum[skiers.Length + i] = skiers2[i];
    //        }
    //        return hum;
    //    }
    //    static Skier[] Sort(Skier[] skiers)
    //    {
    //        for (int i = 0; i < skiers.Length; i++)
    //        {
    //            for (int j = i + 1; j < skiers.Length; j++)
    //            {
    //                if (skiers[i].Result < skiers[j].Result)
    //                {
    //                    var temp = skiers[i];
    //                    skiers[i] = skiers[j];
    //                    skiers[j] = temp;
    //                }
    //            }
    //        }
    //        return skiers;
    //    }
    //}
    #endregion 3
}