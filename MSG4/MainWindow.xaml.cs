using System.Windows;
using System.Diagnostics;

namespace MSG4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            string srv = server.Text;
            string us = user.Text;
            string warten = "";
            string msg = text.Text;

            if (wait.IsChecked == true)
            {
                warten = "/w";
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
            }

            if (us == "")
            {
                us = "*";
            }

            startInfo.Arguments = @" /c C:\Windows\Sysnative\msg.exe " + warten.ToString() + " /server:" + srv.ToString() + " " + us.ToString() + " \"" + msg.ToString() + "\"";
            Process.Start(startInfo);

            text.Text = "";
        }
    }
}
