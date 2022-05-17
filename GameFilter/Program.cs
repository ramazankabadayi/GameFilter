namespace GameFilter
{
    internal static class Program
    {
        
                /// <summary>
                ///  The main entry point for the application.
                /// </summary>
                [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        
    }
    [Flags]
    public enum MasaTipi // Her masa tipinin ve kombinasyonunun tek degerde saklanmasi
    {
        None = 0,
        Hizli = 1,
        TekeTek = 2,
        Rovans = 4,
    }



    public class Masa // Masa ozellilerini iceren Class
    {
        public int ID { get; set; }
        public int Bahis { get; set; }
        public int MasaTipi { get; set; }
        public Masa(int id ,int bahis, int masatipi) {
            Bahis = bahis;
            MasaTipi = masatipi;
            ID = id;
        }
    }

    
}