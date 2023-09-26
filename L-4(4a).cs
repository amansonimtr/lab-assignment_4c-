public class Temperature
{
    private double celsius;

    
    public Temperature(double celsius)
    {
        this.celsius = celsius;
    }

    
    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }

    
    public double Fahrenheit
    {
        get { return (celsius * 9 / 5) + 32; }
    }
}
