using ItbLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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

namespace ItbLearn.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly HttpClient httpClient = new HttpClient();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var now = DateTimeOffset.Now;
            var userName = "taro";
            var timecard = new TimeCard(userName,now);

            var option = new JsonSerializerOptions();
            option.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            var json = JsonSerializer.Serialize(timecard,option);

            var content = new StringContent(json,Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://app-timecards-onodera.azurewebsites.net/api/timecards",content);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseBody);

            }
            

        }
    }
}
