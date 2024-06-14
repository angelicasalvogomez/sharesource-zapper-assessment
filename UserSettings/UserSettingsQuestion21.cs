using System;

public class UserSettingsQuestion21
{
    public static void Main(string[] args)
    {
        string settings = "00000000";
        int setting = 7;
        
        if (setting > 0 && setting < 9)
        {
            int index = setting -1;
            bool isEnabled = settings[index].Equals('0') ? false : true;
            Console.WriteLine (isEnabled);
        }
        else
        {
           Console.WriteLine ("Not a valid setting"); 
        }
    }
}