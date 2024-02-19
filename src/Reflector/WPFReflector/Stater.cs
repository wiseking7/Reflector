namespace WPFReflector
{
    internal class Stater
    {
        [STAThread]
        private static void Main(string[] args)
        {
            App app = new App();
            app.Run();
        }
    }
}
