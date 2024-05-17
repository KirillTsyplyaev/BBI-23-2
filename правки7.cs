public struct Sportsmen
{
    private string _name;

    public Sportsmen(string name)
    {
        _name = name;
    }

    public string Name { get { return _name; } }
}

class Skier
{
    private Sportsmen _sportsman;
    private double _result;
    private string _gender;

    public Skier(double result, Sportsmen sportsman, string gender)
    {
        _sportsman = sportsman;
        _result = result;
        _gender = gender;
    }

    public double Result { get { return _result; } protected set { _result = value; } }

    public string Gender { get { return _gender; } }

    public virtual void Compete()
    {
        Random random = new Random();
        _result = random.Next(80, 100); // генерация случайного результата
    }
    public void Display()
    {
        Console.WriteLine($"пол {_gender},имя {_sportsman.Name}, результат {_result}");
    }

    public static Skier[] MergeSort(Skier[] skiers)
    {

        if(skiers.Length <= 1)
        {
            return skiers;
        }
        int n = skiers.Length;
        Skier[] left = new Skier[n/2];
        Skier[] right = new Skier[skiers.Length - n/2];

        //деление массива
        for(int i1 = 0; i1 < n/2; i1++)
        {
            left[i1] = skiers[i1];
        }

        for(int i1 = n/2; i1 < skiers.Length;i1++)
        {
            right[i1 - n / 2] = skiers[i1];
        }

        MergeSort(left);
        MergeSort(right);

        int i = 0;
        int j = 0;
        int k = 0;

        //слияние элементов
        while (i < left.Length && j < right.Length)
        {
            if (left[i].Result <= right[j].Result)
            {
                skiers[k++] = left[i++];
            }
            else
            {
                skiers[k++] = right[j++];
            }
        }

        //добавление оставшихся элементов левого массива
        while (i < left.Length)
        {
            skiers[k++] = left[i++];
        }

        //добавление оставшихся элементов правого массива
        while (j < right.Length)
        {
            skiers[k++] = right[j++];
        }

        return skiers;
    }
    
}

class WomanSkier : Skier
{
    public WomanSkier(double result, Sportsmen sportsman, string gender) : base(result, sportsman, "женский")
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

    public ManSkier(double result, Sportsmen sportsman, string gender) : base(result, sportsman, "мужской")
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
            new WomanSkier(1,list_of_women[2],"ж"),new WomanSkier(1,list_of_women[3],"ж"),
            new WomanSkier(1,list_of_women[4],"ж")
        };
        WomanSkier[] Team4 = {
            new WomanSkier(1,list_of_women[5],"ж"), new WomanSkier(1,list_of_women[6],"ж"),
            new WomanSkier(1,list_of_women[7],"ж"),new WomanSkier(1,list_of_women[8],"ж"),
            new WomanSkier(1,list_of_women[9],"ж")
        };
        for (int i = 0; i < 5; i++)
        {
            Team1[i].Compete();
            Team2[i].Compete();
            Team3[i].Compete();
            Team4[i].Compete();
        }

        Skier.MergeSort(Team1);
        Skier.MergeSort(Team2);
        Skier.MergeSort(Team3);
        Skier.MergeSort(Team4);
        

        Console.WriteLine("Первая группа\n");
        foreach (var man in Team1) man.Display();
        Console.WriteLine("Вторая группа\n");
        foreach (var man in Team2) man.Display();
        Console.WriteLine("Третья группа\n");
        foreach (var girl in Team3) girl.Display();
        Console.WriteLine("Четвертая группа\n");
        foreach (var girl in Team4) girl.Display();

        Skier[] Mans = new Skier[10];
        Mans = Fill(Team1, Team2);
        Skier[] Women = new Skier[10];
        Women = Fill(Team3, Team4);
        Console.WriteLine("МУЖИКИ!!!!\n");
        Sort(Mans);
        foreach (Skier man in Mans)
        {
            man.Display();
        }
        Console.WriteLine("ДЕВУШКИ!!!!!\n");
        Sort(Women);
        foreach (Skier girl in Women)
        {
            girl.Display();
        }
        Skier[] all_runners = new Skier[20];
        all_runners = Fill(Mans, Women);
        Sort(all_runners);
        Console.WriteLine("Финальная таблица\n");
        foreach (Skier runner in all_runners)
        {
            runner.Display();
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