// к первому номеру
//public struct Girls
//{
//    private string _name;
//    private string _surname_teacher;
//    private int _group;
//    private int _result;
//    public Girls(string name, string surname_teacher, int group, int result)
//    {
//        _name = name;
//        _surname_teacher = surname_teacher;
//        _group = group;
//        _result = result;
//    }
//    public int Result
//    {
//        get { return _result; }
//    }
//    public string Name
//    {
//        get { return _name; }
//    }
//    public string Surname_Teacher
//    {
//        get { return _surname_teacher; }
//    }
//    public int Group
//    {
//        get { return _group; }
//    }
//}
//internal class Program
//{ 
//первый номер
//static void Main(string[] args)
//{
//    Girls[] girls = new Girls[4] {new Girls("Юля", "Грантова", 1 , 2 ),
//    new Girls("Таня", " Собчак", 3, 5),
//    new Girls("Александра", "Мармеладова", 3 , 4 ), new Girls("Лена", " Герберт", 6, int.MaxValue)};
//    Sort(girls);
//    for (int i = 0; i < girls.Length; i++)
//    {
//        string j;
//        if (girls[i].Result == int.MaxValue)
//        {
//            j = Convert.ToString(girls[i].Result);
//            j = "не пробежала";
//        }
//        else
//        {
//            j = Convert.ToString(girls[i].Result);
//        }
//        Console.WriteLine($"имя:{girls[i].Name}, группа:{girls[i].Group}, фамилия учителя:{girls[i].Surname_Teacher}, результат:{j}  \n");
//    }
//    int count = Counter(girls);
//    Console.WriteLine($"число девушек пробежавших забег: {count}");

//}

//static int Counter(Girls[] girls)
//{
//    int count = 0;
//    for (int i = 0; i < girls.Length; i++)
//    {
//        if (girls[i].Result != int.MaxValue) count++;
//    }
//    return count;
//}
//static Girls[] Sort(Girls[] girls)
//{

//    for (int i = 1; i < girls.Length;i++) //i текущий элемент
//    {
//        int j = i ; 

//        while (j > 0 && girls[j - 1].Result > girls[j].Result) // j-1 предыдущий
//        {
//            Girls temp = girls[j];
//            girls[j] = girls[j - 1];
//            girls[j - 1] = temp;
//            j--; //проверяем текущий элемент со следующим
//        }

//    }
//    return girls;
//}

//}

//Часть 3 Задание 4
public struct Sportmen
{
    private string _name;
    private int _points;
    public Sportmen(string name, int points)
    {
        _name = name;
        _points = points;
    }
    public string Name { get { return _name; } }
    public int Points { get { return _points; } }

}
internal class Program
{
    static void Main(string[] args)
    {
        
        Sportmen[] s1 = new Sportmen[3];
        Sportmen[] s2 = new Sportmen[3];
        Sportmen[] allSportmens = new Sportmen[s1.Length + s2.Length];

        for(int i = 0; i < s1.Length;i++ )
        {
            s1[i] = FirstGroup()[i];
        }

        for (int i = 0; i < s2.Length; i++)
        {
            s2[i] = SecondGroup()[i];
        }

        Sort(s1);
        Sort(s2);


        allSportmens = Fill(s1, s2);

        Sort(allSportmens);

        Console.WriteLine("отсортированный список");
        for (int i = 0; i < allSportmens.Length; i++)
        {
            Console.WriteLine($"фамилия:{allSportmens[i].Name} , очки: {allSportmens[i].Points}");
        }

    }
    static Sportmen[] FirstGroup()
    {
        Sportmen[] list_of_sportsmens1 = new Sportmen[3] {
        new Sportmen("Jordan", 44),
        new Sportmen("Bryant", 55),
        new Sportmen("Lebron", 66)};
        Sort(list_of_sportsmens1);
        return list_of_sportsmens1;
    }
    static Sportmen[] SecondGroup()
    {
        Sportmen[] list_of_sportsmens2 = new Sportmen[3] {
        new Sportmen("Curry", 22),
        new Sportmen("Garnett", 54),
        new Sportmen("Iverson", 98)};
        Sort(list_of_sportsmens2);
        return list_of_sportsmens2;
    }
    static Sportmen[] Sort(Sportmen[] list)
    {
        Sportmen temp;
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = i + 1; j < list.Length; j++)
            {
                if (list[j].Points > list[i].Points)
                {
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        return list;
    }
    static Sportmen[] Fill(Sportmen[] s1, Sportmen[] s2)
    {
        Sportmen[] allSportsmens = new Sportmen[s1.Length + s2.Length];

        for (int i = 0; i < s1.Length; i++)
        {
            allSportsmens[i] = s1[i];
        }

        int j = s1.Length;
        for (int i = 0; i < s2.Length; i++)
        {
            allSportsmens[j + i] = s2[i];
            
        }
        return allSportsmens;
    }
}