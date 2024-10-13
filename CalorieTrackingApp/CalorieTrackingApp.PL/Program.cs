using CalorieTrackingApp.DAL.Entities.Concrete;

namespace CalorieTrackingApp.PL
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
            Application.Run(new MealPanel());// þimdilik Meal Ekraný üzerine çalýþtýðýmdan ilk olarak bu sayfadan çalýþýr duruma getirdim
            // ama bizim ilk sayfamýz normal þartlarda Form1().
        }
    }
}