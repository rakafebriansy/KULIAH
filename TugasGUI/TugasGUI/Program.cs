namespace TugasGUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            Application.Run(new TugasGUI.Form4());
        }
    }
    
}