using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microboinc_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = @"[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server
[TASKS] Received 0 assignments from server";
            for(int i = 1; i <= System.Environment.ProcessorCount; i++)
            { 
                comboBox.Items.Add(i.ToString());
            }
            comboBox.SelectedIndex = 0;
        }
        private bool APIAuthenticate(string apikey)
        {
            try
            {
                HttpClient hc = new HttpClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api.microboinc.com/Accounts");
                requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(apikey);
                var v = hc.SendAsync(requestMessage).Result;
                string s = v.StatusCode.ToString();
                string s1 = v.Content.ReadAsStringAsync().Result;
                //MessageBox.Show(s +  "\n\n" + s1);
                if (s.Contains("OK"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
                return false;
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password != "")
            {
                if (!APIAuthenticate(passwordBox.Password))
                {
                    MessageBox.Show("APIKey failed!!");
                }
                else
                {
                    MessageBox.Show("APIKey success!!");
                }
            }
            else
            {
                MessageBox.Show("Please enter an API Key to proceed.");
            }
        }
    }
}
