using System;
using System.IO;

public class UserSettingsQuestion22
{
    public static void Main(string[] args)
    {
        string settings = "00000000";
        string fileName = "UserSettings.txt";
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        SaveUserSettingsToFile(filePath, fileName, settings);
        
        string filePathWithName = filePath + Path.PathSeparator + fileName;
        ReadUserSettingsFromFile(filePathWithName);
    }
    
    static void SaveUserSettingsToFile(string filePath, string fileName, string settings)
    {
        try
        {
            File.WriteAllText(Path.Combine(filePath, fileName), settings);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine("Exception occurred: " + uae.Message);
            Console.WriteLine("Please ensure you have access to path");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occurred: " + ex);
        }
    }
    
    static void ReadUserSettingsFromFile(string filePathWithName)
    {
        try
        {
            if (File.Exists(filePathWithName)) {
                string settings = File.ReadAllText(filePathWithName); 
                Console.WriteLine(settings); 
            }
            else 
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine("Exception occurred: " + uae.Message);
            Console.WriteLine("Please ensure you have access to path");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occurred: " + ex);
        }
    }
}