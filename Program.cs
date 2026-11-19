namespace Examen_RentaCar_JohanAlexander;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmAlquiler());
    }
}
