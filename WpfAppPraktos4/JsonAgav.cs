using Newtonsoft.Json;
using System;
using System.IO;

namespace WpfAppPraktos4
{
    internal class JsonHelper
    {
        public static void Serialize<T>(T zametkis, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                filePath = desktop + "\\agavtop.json";
            }

            string json = JsonConvert.SerializeObject(zametkis);
            File.WriteAllText(filePath, json);
        }

        public static T Deserialize<T>(string filePath = null)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                filePath = desktop + "\\agavtop.json";
            }

            if (!File.Exists(filePath))
            {
                var emptyData = default(T);
                Serialize(emptyData, filePath);
            }

            string json = File.ReadAllText(filePath);
            T deserializedData = JsonConvert.DeserializeObject<T>(json);
            return deserializedData;
        }
    }
}
