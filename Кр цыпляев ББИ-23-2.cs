namespace Kr
{
    abstract class Task
    {
        private string text;
        public Task(string text)
        {
            this.text = text;
        }
    }
    class Task1 : Task
    {
        public Task1(string text) : base(text)
        {

        }
        public int FindMaxWords(string text)
        {
            int max = 0;
            string[] arr = text.Split(".");
            int[] maxword = new int[arr.Length];
            foreach (string sentence in arr)
            {
                sentence.Split(" ");
                Console.WriteLine(sentence.Length);
            }
            for(int i = 0; i < maxword.Length; i++)
            {
                for(int j = 1; j< maxword.Length;j++)
                {
                    if (maxword[j] > maxword[i])
                    {
                        max = maxword[j];
                        maxword[i] = maxword[j];

                    }
                }
            }
            return max;
        }
    }
    class Task2 : Task
    {
        public Task2(string text) : base(text)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            

        }
    }
}
