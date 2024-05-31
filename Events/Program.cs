namespace Events
{
    class Program
    {
        public static void Main(string[] args)
        {
            Switcher sw = new Switcher();
            TvSet tv = new TvSet();
            Lamp lamp = new Lamp();

            sw.ElectricityOn += tv.TurnOnTv;
            sw.ElectricityOn += lamp.LightOn;

            sw.SwitchOn();
        }
    }
}