using System.Text.Json;

namespace MyJsonSerializer_
{
        public class MyJsonSerializer
        {
            public static void Write<T>(T obj, string filePath)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    JsonSerializer.Serialize<T>(fs, obj);
                }
            }

            public static T Read<T>(string filePath)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    return (T)JsonSerializer.Deserialize<T>(fs);
                }
                return default(T);
            }

        }

    
}
