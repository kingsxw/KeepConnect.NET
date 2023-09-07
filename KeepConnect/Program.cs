using System.Diagnostics;
using System.Net.Sockets;

namespace KeepConnect
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
            //EC.IsR = EasyConnect.IsRunning(EC.ClientName);
            //EC.IsI = EasyConnect.IsInstalled(EC.ClientName, out string loc);
            //EC.Location = loc;
            //EC.StatusCode = await EasyConnect.IsConnectedAsync();


            //MessageBox.Show("isRunning: " + isR.ToString());
            //MessageBox.Show("isInstalled: " + isI.ToString());
            //MessageBox.Show("path: "+ loc);
            //MessageBox.Show("status: " + status);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class EC
    {
        public static string ClientName { get; set; } = "EasyConnect";
        public static string? Location { get; set; }
        public static string Method { get; set; }
        public static string Url { get; set; }
        public static string Host { get; set; }
        public static int Port { get; set; }
        public static bool IsR { get; set; }
        public static bool IsI { get; set; }
        public static bool IsLoop { get; set; }
        public static int StatusCode { get; set; }
        public static int Cycle { get; set; }
        public static TcpClient Client { get; set; }
    }
}