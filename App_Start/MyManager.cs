using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class MySettings
{
    public string DefaultPageText1 { get; set; }
    public string DefaultPageText2 { get; set; }
    public string DefaultPageHeaderText { get; set; }
    public string DefaultPageFooterText { get; set; }
}

   
    public class MyManager
    {
        public static MySettings LoadSettings(string FilePath)
        {
            MySettings Settings = new MySettings();
            try
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(MySettings));
                System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
                Settings = (MySettings)reader.Deserialize(file);
                file.Close();
                return Settings;
            }
            catch(Exception)
            {
                return Settings;
            }
        }
        public static void SaveSettings(string FilePath,MySettings SettingsObj)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(MySettings));

            var FileName = "MySettings.xml";
            System.IO.FileStream file = System.IO.File.Create(FilePath);

            writer.Serialize(file, SettingsObj);
            file.Close();
        }
    
   
        
    }
