namespace lab7
{
    #region 1 часть второй номер
    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Run100[] runs100 = { new Run100(100, 34), new Run100(100, 60), new Run100(100, 55), new Run100(100, 24),new Run100(100, 37) };
    //        Run500[] runs500 = { new Run500(500, 253), new Run500(500, 223), new Run500(500, 263), new Run500(500, 233), new Run500(100, 370) };
    //        Sort(runs100);
    //        Console.WriteLine($"Таблица для бегунов на дистанции 100 м :\n");
    //        for (int i = 0; i < runs100.Length; i++)
    //        {
    //            runs100[i].ShowResult();
    //        }
    //        Sort(runs500);
    //        Console.WriteLine("Таблица для бегунов на дистанции 500 м :\n");
    //        for (int i = 0; i < runs500.Length; i++)
    //        {
    //            runs500[i].ShowResult();
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
    //    private int _dist;
    //    private int _time;
    //    public Run(int dist, int time)
    //    {
    //        _dist = dist;
    //        _time = time;
    //    }

    //    public void ShowResult()
    //    {
    //        Console.WriteLine($"Дистанция {_dist} метров. Время забега составило {_time} cекунд");
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
    //    public Run100(int dist, int time) : base(100, time)
    //    {

    //    }
    //}
    //class Run500 : Run
    //{
    //    public Run500(int dist, int time) : base(500, time)
    //    {

    //    }
    //}
    #endregion 1
    #region 2 часть 4 номер 
    //abstract class Jump
    //{
    //    private int _metres;
    //    private double _points;
    //    private string _namedisc;
    //    public Jump(int metres, double points, string namedisc)
    //    {
    //        _metres = metres;
    //        _points = points;
    //        _namedisc = namedisc;
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
    //        Console.WriteLine($"Названия дисциплины {_namedisc}, очки {_points}");
    //    }

    //}
    //class Jump_3 : Jump
    //{
    //    public Jump_3(int metres, double points, string namedisc) : base(3, points, "прыжки с 3 м")
    //    {

    //    }

    //}
    //class Jump_5 : Jump
    //{
    //    public Jump_5(int metres, double points, string namedisc) : base(5, points, "прыжки с 5 м")
    //    {

    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Jump_3[] jump_3s = { new Jump_3(1, Point_Generator(),"2" ), new Jump_3(1, Point_Generator(), "2"),
    //            new Jump_3(1, Point_Generator(), "2") , new Jump_3(1, Point_Generator(), "2"), new Jump_3(1, Point_Generator(), "2") };
    //        Jump_5[] jump_5s = { new Jump_5(1, Point_Generator(),"2" ), new Jump_5(1, Point_Generator(),"2" ),
    //            new Jump_5(1, Point_Generator(),"2" ) ,new Jump_5(1, Point_Generator(),"2" ), new Jump_5(1, Point_Generator(),"2" ) };
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
    //class Sportsman
    //{
    //    private string _name;
    //    private double _result;
    //    private string _gender;


    //    public Sportsman(string name, double result, string gender)
    //    {
    //        _name = name;
    //        _result = result;
    //        _gender = gender;
    //    }
    //    public string Name { get { return _name; } }

    //    public double Result { get { return _result; } protected set { _result = value; } }

    //    public string Gender { get { return _gender; } }

    //    public virtual void Compete()
    //    {
    //        Random random = new Random();
    //        _result = random.Next(80, 100); // генерация случайного результата
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"пол {_gender},имя {_name}, результат {_result}");
    //    }
    //}

    //class WomanSkier : Sportsman
    //{

    //    public WomanSkier(string name, int result, string gender) : base(name, result, "Женщина")
    //    {

    //    }

    //    public override void Compete()
    //    {
    //        Random random = new Random();
    //        Result = random.Next(60, 100);
    //    }
    //}
    //class ManSkier : Sportsman
    //{

    //    public ManSkier(string name, int result, string gender) : base(name, result, "Мужчина")
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
    //        ManSkier[] Team1 = { new ManSkier("Vasya", 212343, "sdc"), new ManSkier("Vova", 53, "sdc"),
    //        new ManSkier("Nekitka", 23, "sdc") , new ManSkier("Slava", 23234, "sdc"), new ManSkier("Kerik", 123, "sdc") };
    //        ManSkier[] Team2 = { new ManSkier("Oleg", 213, "sdc"), new ManSkier("Danya", 253, "sdc"),
    //        new ManSkier("VAdim", 23, "sdc") , new ManSkier("Dima", 23, "sdc"), new ManSkier("Baha", 23, "sdc") };
    //        WomanSkier[] Team3 = {new WomanSkier("Svetka",2354,"24"), new WomanSkier("Luba", 2354, "24") ,
    //        new WomanSkier("Nastya", 2354, "24") , new WomanSkier("July", 2354, "24") , new WomanSkier("Tanya", 2354, "24") };
    //        WomanSkier[] Team4 = {new WomanSkier("Jane",2354,"24"), new WomanSkier("Alexa", 2354, "24") ,
    //        new WomanSkier("Alla", 2354, "24") , new WomanSkier("Steph", 2354, "24") , new WomanSkier("Liza", 2354, "24") };

    //        Sportsman[] Mans = new ManSkier[10];

    //        Sportsman[] Women = new WomanSkier[10];



    //        Mans = Fill(Team1, Team2);
    //        Women = Fill(Team3, Team4);

    //        for (int i = 0; i < Mans.Length; i++)
    //        {
    //            Mans[i].Compete();
    //            Women[i].Compete();
    //        }

    //        Console.WriteLine("МУЖИКИ!!!!\n");

    //        Sort(Mans);
    //        foreach (Sportsman man in Mans)
    //        {
    //            man.Display();
    //        }
    //        Console.WriteLine("ДЕВУШКИ!!!!!\n");

    //        Sort(Women);
    //        foreach (Sportsman girl in Women)
    //        {
    //            girl.Display();
    //        }


    //    }
    //    static Sportsman[] Fill(Sportsman[] skiers, Sportsman[] skiers2)
    //    {
    //        Sportsman[] hum = new Sportsman[skiers.Length + skiers2.Length];
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
    //    static Sportsman[] Sort(Sportsman[] skiers)
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