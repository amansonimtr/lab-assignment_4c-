using System;

class Program
{
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    static void Main()
    {
        Season currentSeason;

        int currentMonth = DateTime.Now.Month;
        switch (currentMonth)
        {
            case 12:
            case 1:
            case 2:
                currentSeason = Season.Winter;
                break;
            case 3:
            case 4:
            case 5:
                currentSeason = Season.Spring;
                break;
            case 6:
            case 7:
            case 8:
                currentSeason = Season.Summer;
                break;
            case 9:
            case 10:
            case 11:
                currentSeason = Season.Autumn;
                break;
            default:
                currentSeason = Season.Spring; 
                break;
        }

        switch (currentSeason)
        {
            case Season.Spring:
                Console.WriteLine("It's Spring!");
                break;
            case Season.Summer:
                Console.WriteLine("It's Summer!");
                break;
            case Season.Autumn:
                Console.WriteLine("It's Autumn!");
                break;
            case Season.Winter:
                Console.WriteLine("It's Winter!");
                break;
        }

        Console.ReadLine();
    }
}
