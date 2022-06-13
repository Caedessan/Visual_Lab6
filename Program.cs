namespace Visual_Lab6
{
    internal static class Program
    {
        public class Station
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int SignalPower { get; set; }
        }
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}