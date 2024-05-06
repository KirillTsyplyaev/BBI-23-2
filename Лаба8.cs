namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание\n");
            string text1 = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. ";
            Task1 Task1 = new Task1(text1);
            Dictionary<char, double> dict = Task1.ParseText(text1);
            Task1.ShowResult(dict);

            Console.WriteLine("Третье задание\n");
            string text3 = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
            Task3 task3 = new Task3(text3);
            task3.Splitter(text3);

            Console.WriteLine("Пятое задание\n");
            string text5 = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.";
            Task5 task5 = new Task5(text5);
            Dictionary<char, int> dict2 = task5.TextAnalizer(text5);
            task5.ShowSortedResult(dict2);

            Console.WriteLine("Седьмое задание\n");
            string text7 = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            Task7 task7 = new Task7(text7);
            task7.SameRootWords(text7);

            Console.WriteLine("Одиннадцатое задание\n");
            string text11 = "Иванов,Петров,Смирнов,Соколов,Кузнецов,Попов,Лебедев,Волков,Козлов,Новиков,Иванова,Петрова,Смирнова,Ivanov,Petrov,Smirnov,Sokolov,Kuznetsov,Popov,Lebedev,Volkov,Kozlov,Novikov,Ivanova,Petrova,Smirnova"; 
            Task11 task11 = new Task11(text11);
            string[] surnamesList = text11.Split(',');
            task11.SurnameSort(surnamesList);

            Console.WriteLine("Четырнадцатое задание\n");
            string text14 = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
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

            Dictionary<char, int> alphabet = new Dictionary<char, int>()
            {
            {'а', 0 },{ 'б',0 }, { 'в' ,0}, {'г' ,0}, { 'д' ,0},{'е',0},{ 'ё',0},{ 'ж' ,0},{ 'з' ,0},{'и' ,0},
            { 'й',0},{'к',0},{'л',0}, {'м',0}, {'н',0}, {'о',0}, {'п',0},{'р',0}, {'с',0}, {'т',0 },{'у', 0},
            {'ф',0},{'х',0},{'ц' ,0},{'ч',0},{'щ' ,0},{'ш' ,0},{'ъ',0},{'ы',0},{'ь', 0 }, {'э',0}, {'ю',0}, {'я',0 }
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

        public Dictionary<char, int> TextAnalizer(string text)
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>()
                {
                {'а', 0 },{ 'б',0 }, { 'в' ,0}, {'г' ,0}, { 'д' ,0},{'е',0},{ 'ё',0},{ 'ж' ,0},{ 'з' ,0},{'и' ,0},
                { 'й',0},{'к',0},{'л',0}, {'м',0}, {'н',0}, {'о',0}, {'п',0},{'р',0}, {'с',0}, {'т',0 },{'у', 0},
                {'ф',0},{'х',0},{'ц' ,0},{'ч',0},{'щ' ,0},{'ш' ,0},{'ъ',0},{'ы',0},{'ь', 0 }, {'э',0}, {'ю',0}, {'я',0 }
                };

            if (text.Length <= 1000)
            {
                text.ToLower();
                string[] words = text.Split(' ');
                foreach (string s in words)
                {
                    char firstLetter = s[0];
                    if (alphabet.ContainsKey(firstLetter))
                    {
                        alphabet[firstLetter]++;
                    }
                }
            }
            else
            {
                Console.WriteLine("текст слишком большой");
            }
            return alphabet;
        }

        public void ShowSortedResult(Dictionary<char, int> dict)
        {
            KeyValuePair<char, int>[] kvpArray = new KeyValuePair<char, int>[dict.Count];
            int i = 0;
            foreach (var kvp in dict)
            {
                kvpArray[i++] = kvp;
            }

            for (int j = 0; j < kvpArray.Length; j++)
            {
                for (int k = j + 1; k < kvpArray.Length; k++)
                {
                    if (kvpArray[k].Value > kvpArray[j].Value)
                    {
                        var temp = kvpArray[k];
                        kvpArray[k] = kvpArray[j];
                        kvpArray[j] = temp;
                    }
                }
            }
            foreach (var kvp in kvpArray)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
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
                for(int i = 0;i < root.Length; i++)
                {
                    rootChars[i] = root[i];
                }
 
                foreach(string word in words)
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
    class Task11: Task
    {
        public Task11(string text) : base(text) 
        { }

        public override string ToString()
        {
            return text;
        }

        public string[] SurnameSort(string[] surnames)
        {
            
            for(int i = 0; i < surnames.Length ; i++)
            {
                for(int j = i + 1;j < surnames.Length ; j++)
                {
                    if (CompareSurnames(surnames[i], surnames[j]) > 0)
                    {
                        string temp = surnames[j];
                        surnames[j] = surnames[i];
                        surnames[i] = temp;
                    }
                }
            }
            foreach(string word in surnames)
            {
                Console.WriteLine(word); 
            }
            return surnames;
        }
        
        static int CompareSurnames(string surname1, string surname2)
        {
            int minLength = Math.Min(surname1.Length, surname2.Length);
            for(int i = 0; i < minLength; i++)
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
            char[] alphabet = new char [alphabet1.Length];
            int count = 0;
            //привели к char
            foreach(char letter in alphabet1)
            {
                alphabet[count] = letter;
                count++;
            }
            
            for ( int i = 0; i < alphabet.Length; i++)
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


