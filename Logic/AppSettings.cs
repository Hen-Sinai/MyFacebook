using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    public sealed class AppSettings
    {
        public bool RememberMeUser { get; set; }
        public string LastAccessToken { get; set; }
        public List<string> BDCards { get; set; }

        private AppSettings()
        {
            RememberMeUser = false;
            LastAccessToken = null;
            BDCards = new List<string>();
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"C:\Temp\FileAppSetting.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            XmlSerializer serializer;
            AppSettings obj = new AppSettings();

            if (File.Exists(@"C:\Temp\FileAppSetting.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Temp\FileAppSetting.xml", FileMode.Open))
                {
                    serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }
    }
}
