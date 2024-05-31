using System.Diagnostics.Metrics;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;
public struct Alphabet
{
    private char _letter;
    private int _count;
    public Alphabet(char letter, int count)
    {
        _letter = letter;
        _count = count;
    }

    public char Letter
    {
        get { return _letter; }
        private set { _letter = value; }
    }
    public int Count
    {
        get { return _count; }
        private set { _count = value; }
    }

    public void Counter()
    {
        _count++;
    }

}
namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. ";
            Console.WriteLine("Первое задание\n");
            string text1 = text;
            Task1 Task1 = new Task1(text1);
            Dictionary<char, double> dict = Task1.ParseText(text1);
            Task1.ShowResult(dict);

            Console.WriteLine("Третье задание\n");
            string text3 = text;
            Task3 task3 = new Task3(text3);
            task3.Splitter(text3);

            Console.WriteLine("Пятое задание\n");
            string text5 = text;
            Task5 task5 = new Task5(text5);
            Alphabet[] dict2 = task5.TextAnalizer(text5);
            task5.ShowSortedResult(dict2);

            Console.WriteLine("Седьмое задание\n");
            string text7 = text;
            Task7 task7 = new Task7(text7);
            task7.SameRootWords(text7);

            Console.WriteLine("Одиннадцатое задание\n");
            string text11 = "Иванов,Петров,Смирнов,Соколов,Кузнецов,Попов,Лебедев,Волков,Козлов,Новиков,Иванова,Петрова,Смирнова,Ivanov,Petrov,Smirnov,Sokolov,Kuznetsov,Popov,Lebedev,Volkov,Kozlov,Novikov,Ivanova,Petrova,Smirnova";
            Task11 task11 = new Task11(text11);
            string[] surnamesList = text11.Split(',');
            task11.SurnameSort(surnamesList);

            Console.WriteLine("Четырнадцатое задание\n");
            string text14 = text;
            Task14 task14 = new Task14(text14);
            string sum = task14.SummarizeNumbersInText(text14);

        }
    }
    abstract class Task
    {
        protected string text;

        public Task(string text)
        {
            this.text = text;
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

        public Dictionary<char, double> ParseText(string Text)
        {
            text = Text.ToLower();

            //добавил английский алфавит
            Dictionary<char, int> alphabet = new Dictionary<char, int>()
            {
                {'а', 0 },{ 'б',0 }, { 'в' ,0}, {'г' ,0}, { 'д' ,0},{'е',0},{ 'ё',0},{ 'ж' ,0},{ 'з' ,0},{'и' ,0},
                { 'й',0},{'к',0},{'л',0}, {'м',0}, {'н',0}, {'о',0}, {'п',0},{'р',0}, {'с',0}, {'т',0 },{'у', 0},
                {'ф',0},{'х',0},{'ц' ,0},{'ч',0},{'щ' ,0},{'ш' ,0},{'ъ',0},{'ы',0},{'ь', 0 }, {'э',0}, {'ю',0}, {'я',0 },
                { 'a', 0 },{ 'b', 0 },{ 'c', 0 },{ 'd', 0 },{ 'e', 0 }, { 'f', 0 }, { 'g', 0 },{ 'h', 0 }, { 'i', 0 },
                 { 'j', 0 }, { 'k', 0 }, { 'l', 0 },{ 'm', 0 },  { 'n', 0 }, { 'o', 0 }, { 'p', 0 },{ 'q', 0 },{ 'r', 0 },
                  { 's', 0 }, { 't', 0 }, { 'u', 0 },{ 'v', 0 },{ 'w', 0 },{ 'x', 0 }, { 'y', 0 }, { 'z', 0 }
            };
            for (int i = 0; i < text.Length; i++)
            {
                if (alphabet.ContainsKey(text[i]))
                {
                    alphabet[text[i]]++;
                }

            }
            int totalLetters = alphabet.Sum(x => x.Value);
            Dictionary<char, double> frequency = new Dictionary<char, double>();
            foreach (var smth in alphabet)
            {
                frequency[smth.Key] = (double)smth.Value / totalLetters;
            }
            return frequency;

        }
    }



    class Task1 : Task
    {
        public Task1(string text) : base(text)
        { }

        public override string ToString()
        {
            return text;
        }

        public void ShowResult(Dictionary<char, double> dict)
        {
            foreach (var smth in dict) { Console.WriteLine(smth); }
        }
    }
    class Task3 : Task
    {
        public Task3(string text) : base(text)
        { }

        public override string ToString()
        {
            Console.WriteLine(text);
            return text;

        }

        public void Splitter(string text)
        {
            int charCount = 0;
            string formattedText = "";

            foreach (char c in text)
            {
                if (charCount >= 50 && c == ' ')
                {
                    formattedText += "\n";
                    charCount = 0;
                }
                else
                {
                    formattedText += c;
                    if (c != '\n')
                    {
                        charCount++;
                    }
                }
            }
            Console.WriteLine(formattedText);
        }

    }
    class Task5 : Task
    {
        public Task5(string text) : base(text) { }

        public override string ToString() { return text; }
        public Alphabet[] TextAnalizer(string text)
        {
            //добавил английский алфавит
            Dictionary<char, int> alphabet = new Dictionary<char, int>()
                {
                    {'а', 0 },{ 'б',0 }, { 'в' ,0}, {'г' ,0}, { 'д' ,0},{'е',0},{ 'ё',0},{ 'ж' ,0},{ 'з' ,0},{'и' ,0},
                    { 'й',0},{'к',0},{'л',0}, {'м',0}, {'н',0}, {'о',0}, {'п',0},{'р',0}, {'с',0}, {'т',0 },{'у', 0},
                    {'ф',0},{'х',0},{'ц' ,0},{'ч',0},{'щ' ,0},{'ш' ,0},{'ъ',0},{'ы',0},{'ь', 0 }, {'э',0}, {'ю',0}, {'я',0 },
                    { 'a', 0 },{ 'b', 0 },{ 'c', 0 },{ 'd', 0 },{ 'e', 0 }, { 'f', 0 }, { 'g', 0 },{ 'h', 0 }, { 'i', 0 },
                    { 'j', 0 }, { 'k', 0 }, { 'l', 0 },{ 'm', 0 },  { 'n', 0 }, { 'o', 0 }, { 'p', 0 },{ 'q', 0 },{ 'r', 0 },
                    { 's', 0 }, { 't', 0 }, { 'u', 0 },{ 'v', 0 },{ 'w', 0 },{ 'x', 0 }, { 'y', 0 }, { 'z', 0 }
                };

            Alphabet[] Alphabet =
            {
                new Alphabet('а', 0), new Alphabet('б',0), new Alphabet('в' ,0), new Alphabet('г' ,0), new Alphabet('д' ,0), new Alphabet('е',0), new Alphabet('ё',0), new Alphabet('ж' ,0),
                new Alphabet('з' ,0), new Alphabet('и' ,0), new Alphabet('й',0), new Alphabet('к',0), new Alphabet('л',0), new Alphabet('м', 0), new Alphabet('н', 0), new Alphabet('о', 0),
                new Alphabet('п', 0), new Alphabet('р', 0), new Alphabet('с', 0), new Alphabet('т', 0), new Alphabet('у', 0), new Alphabet('ф', 0), new Alphabet('х', 0), new Alphabet('ц', 0),
                new Alphabet('ч', 0), new Alphabet('щ', 0), new Alphabet('ш', 0), new Alphabet('ъ', 0), new Alphabet('ы', 0), new Alphabet('ь', 0), new Alphabet('э', 0), new Alphabet('ю', 0),
                new Alphabet('я', 0), new Alphabet('a', 0), new Alphabet('b', 0), new Alphabet('c', 0), new Alphabet('d', 0), new Alphabet('e', 0), new Alphabet('f', 0), new Alphabet('g', 0),
                new Alphabet('h', 0), new Alphabet('i', 0),new Alphabet('j', 0),new Alphabet('k', 0),new Alphabet('l', 0),new Alphabet('n', 0),new Alphabet('o', 0),new Alphabet('p', 0),
                new Alphabet('q', 0),new Alphabet('r', 0),new Alphabet('s', 0),new Alphabet('t', 0),new Alphabet('u', 0),new Alphabet('v', 0),new Alphabet('w', 0),new Alphabet('x', 0),
                new Alphabet('y', 0),new Alphabet('z', 0)
            };

            if (text.Length <= 1000)
            {
                text.ToLower();
                string[] words = text.Split(' ');

                foreach (string s in words)
                {
                    if (s.Length != 0)
                    {
                        char firstLetter = s[0];


                        for (int i = 0; i < Alphabet.Length; i++)
                        {
                            if (Alphabet[i].Letter == firstLetter)
                            {
                                Alphabet[i].Counter();
                            }

                        }
                    }
                    
                }
                
            }
            else
            {
                Console.WriteLine("текст слишком большой");
            }
            return Alphabet;
        }

        public void ShowSortedResult(Alphabet[] alphabet)
        {


            for (int j = 0; j < alphabet.Length; j++)
            {
                for (int k = j + 1; k < alphabet.Length; k++)
                {
                    if (alphabet[k].Count > alphabet[j].Count)
                    {
                        var temp = alphabet[k];
                        alphabet[k] = alphabet[j];
                        alphabet[j] = temp;
                    }
                }
            }
            //добавил условие вывода только тех букв которые есть в тексте
            foreach (var kvp in alphabet)
            {
                if (kvp.Count != 0)
                {
                    Console.WriteLine($"{kvp.Letter}: {kvp.Count}");
                }
            }
        }

    }
    class Task7 : Task
    {
        public Task7(string text) : base(text)
        { }

        public override string ToString()
        {
            return text;
        }

        public string[] SameRootWords(string text)
        {
            text.ToLower();
            string[] words = text.Split(' ');
            if (text.Length <= 1000)
            {
                Console.WriteLine("Введите корень или набор букв для поиска");
                string root = Console.ReadLine().ToLower();

                char[] rootChars = new char[root.Length];
                for (int i = 0; i < root.Length; i++)
                {
                    rootChars[i] = root[i];
                }

                foreach (string word in words)
                {
                    if (!word.Contains(root))
                    {
                        continue;
                    }
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("Текст слишком большой");
            }
            return words;
        }
    }
    class Task11 : Task
    {
        public Task11(string text) : base(text)
        { }

        public override string ToString()
        {
            return text;
        }

        public string[] SurnameSort(string[] surnames)
        {

            for (int i = 0; i < surnames.Length; i++)
            {
                for (int j = i + 1; j < surnames.Length; j++)
                {
                    if (CompareSurnames(surnames[i], surnames[j]) > 0)
                    {
                        string temp = surnames[j];
                        surnames[j] = surnames[i];
                        surnames[i] = temp;
                    }
                }
            }
            foreach (string word in surnames)
            {
                Console.WriteLine(word);
            }
            return surnames;
        }

        static int CompareSurnames(string surname1, string surname2)
        {
            int minLength = Math.Min(surname1.Length, surname2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (GetCharIndex(surname1[i]) < GetCharIndex(surname2[i]))
                {
                    return -1;
                }
                else if (GetCharIndex(surname1[i]) > GetCharIndex(surname2[i]))
                {
                    return 1;
                }
            }
            return surname1.Length - surname2.Length;
        }

        static int GetCharIndex(char c)
        {
            string alphabet1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            char[] alphabet = new char[alphabet1.Length];
            int count = 0;
            //привели к char
            foreach (char letter in alphabet1)
            {
                alphabet[count] = letter;
                count++;
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == char.ToLower(c))
                {
                    return i;
                }
            }
            return -1; // Если символ не найден в алфавите
        }
    }
    class Task14 : Task
    {
        public Task14(string text) : base(text)
        { }

        public override string ToString()
        {
            return text;
        }

        public string SummarizeNumbersInText(string text)
        {
            int sum = 0;
            string currentNumber = "";
            bool numberFound = false;

            foreach (char c in text)
            {
                if (Char.IsDigit(c))
                {
                    currentNumber += c;
                    numberFound = true;
                }
                else
                {
                    if (numberFound)
                    {
                        sum += Int32.Parse(currentNumber);
                        currentNumber = "";
                        numberFound = false;
                    }
                }
            }

            if (numberFound)
            {
                sum += Int32.Parse(currentNumber);
            }
            Console.WriteLine("Сумма чисел в тексте: " + sum);
            return "Сумма чисел в тексте: " + sum;
        }
    }
}

