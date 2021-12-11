using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace simple_ytdl_cs
{
    public partial class SYTDLWindow : Window
    {
        //private string sURL = string.Empty;
        private void toggleUrlLock(object sender, RoutedEventArgs e)
        {

        }
        private async void downloadSingle(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Globals.url);
            //Globals.url = urlInputField.Text;
            //sURL = sUrl.Text;
            //MessageBox.Show(sURL);

            ProcessStartInfo process = new ProcessStartInfo("./youtube-dl");
            process.Arguments = "--help";
            process.CreateNoWindow = true;

            using (Process ytdl = Process.Start(process))
            {
                Task exit = ytdl.WaitForExitAsync();
                await exit;
                MessageBox.Show(exit.IsCompleted.ToString());
                MessageBox.Show(exit.IsCompletedSuccessfully.ToString());
            }
        }
        private void downloadPlaylist(object sender, RoutedEventArgs e)
        {

        }
        private void toggleFolderLock(object sender, RoutedEventArgs e)
        {
            
        }
        private void selectFolder(object sender, RoutedEventArgs e)
        {

        }
    }
}
