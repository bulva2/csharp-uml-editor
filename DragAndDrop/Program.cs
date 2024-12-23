namespace DragAndDrop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            FormMain main = new FormMain();

#if DEBUG
            FormDebug debug = new FormDebug();
            Thread debugThread = new Thread(() => Application.Run(debug));
            debugThread.Start();

            Console.SetOut(debug.DebugWriter);
#endif

            Application.Run(new FormMain());
        }
    }
}