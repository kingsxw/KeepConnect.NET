using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text.Json.Nodes;
using Microsoft.VisualBasic.Logging;
using System.Security.Policy;
using Flurl;
using Flurl.Http;

namespace KeepConnect
{
    internal class EasyConnect
    {
        public static bool IsRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0 ? true : false;
        }
        public static bool IsInstalled(string softwareName, out string installLocation)
        {
            string[] uninstallKeys =
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
            @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall",
        };
            installLocation = null;

            foreach (string uninstallKey in uninstallKeys)
            {
                RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                using (RegistryKey key = hklm.OpenSubKey(uninstallKey))
                {
                    if (key != null)
                    {
                        foreach (string subKeyName in key.GetSubKeyNames())
                        {
                            using (RegistryKey subKey = key.OpenSubKey(subKeyName))
                            {
                                string name = subKey.GetValue("DisplayName") as string;
                                string location = subKey.GetValue("DisplayIcon") as string;

                                if (name != null && name.Equals(softwareName, StringComparison.OrdinalIgnoreCase))
                                {
                                    installLocation = location;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static async Task<int> IsConnectedAsync()
        {
            //0 - 未连接
            //1 - 已连接
            //2 - 连接中
            //3 - 未运行
            //if (!EC.IsR)
            //{
            //    StartClient(EC.Location);
            //}
            var url = "https://127.0.0.1:54530/ECAgent";
            var response = await url
                .SetQueryParams(new
                {
                    op = "DoQueryService",
                    arg1 = "QUERY LOGINSTATUS"
                })
                .GetAsync();
            var result = response.ResponseMessage.Content.ReadAsStringAsync().Result.Trim(';').Trim(')').Trim('(');
            var json = JsonObject.Parse(result);
            return (int)json["data"]["status"];
        }

        public static void TcpKeep(string host,int port)
        {
            //// Create a TCP client socket
            //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //// Set the keepalive option
            //socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

            //// Connect to the remote server
            //socket.Connect(host, port);

            //// Check if the socket is still connected
            //// bool isConnected = socket.Connected;
            //// MessageBox.Show("Is Connected: " + isConnected);

            //// Close the socket
            //Thread.Sleep(10000);
            //socket.Close();
            EC.Client = new TcpClient();
            try
            {
                // Connect to the server
                EC.Client.Connect(EC.Host, EC.Port);

                // Set the KeepAlive option to make the connection persistent
                EC.Client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                EC.Client.Client.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveInterval, 3);
                EC.Client.Client.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveRetryCount, 5);
                EC.Client.Client.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveTime, EC.Cycle);
                // Use the client to send and receive data
                // ...

                // Close the connection when you're done  
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //public static async Task<int> StartInstall()
        //{
        //    //Process process = new Process();
        //    //string unc = "\\\\192.168.11.8\\sumpay_cifs_server\\Public\\Software\\EasyConnect\\EasyConnectInstaller.exe";
        //    //Process.Start(unc);
        //    //int exitCode = process.ExitCode;
        //    //MessageBox.Show("安装程序退出码: " + exitCode);
        //    ////return Task.CompletedTask;
        //    using (var process = new Process())
        //    {
        //        process.StartInfo.FileName = @"\\192.168.11.8\sumpay_cifs_server\Public\Software\EasyConnect\EasyConnectInstaller.exe";
        //        process.StartInfo.UseShellExecute = false;
        //        process.Start();
        //        process.WaitForExit();
        //        return process.ExitCode;
        //    }
        //}
    }
}
