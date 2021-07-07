using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using Microsoft.AspNet.SignalR.Client;
using SignalRClient_Test.Models;


namespace SignalRClient_Test
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    ///
    /// https://docs.microsoft.com/en-us/aspnet/signalr/overview/guide-to-the-api/hubs-api-guide-net-client#clientsetup
    /// 
    public partial class MainWindow : Window
    {
        private HubConnection hubConnection;
        private IHubProxy _myHubProxy;

        public MainWindow()
        {
            InitializeComponent();
            var querystringData = new Dictionary<string, string>();
            querystringData.Add("WPFClient", "1.0");
            using (hubConnection = new HubConnection("http://localhost:8080", querystringData))
            {
                _myHubProxy = hubConnection.CreateHubProxy("MyHub");
                hubConnection.Error += ex => messageList.Items.Add("SignalR error: " + ex.Message);

                _myHubProxy.On("cl_SendAsync", message =>
                    Dispatcher.InvokeAsync(() =>
                    {
                        messageList.Items.Add(message);
                    })
                );
                _myHubProxy.On<PersonModel>("cl_SendAsyncPerson", person =>
                    // Context is a reference to SynchronizationContext.Current
                    Dispatcher.InvokeAsync(() =>
                    {
                        messageList.Items.Add(string.Format("Fullname: {0}, Number: {1}", person.FullName, person.Number));
                    })
                );
            }
        }

        private async void HubConnect()
        {
            try
            {
                await hubConnection.Start();
                if (hubConnection.ConnectionId != String.Empty)
                {
                    messageList.Items.Add("Connection started");
                    btnConnect.Content = "Send";
                    tbMain.Text = hubConnection.ConnectionId;
                }
            }
            catch (Exception e)
            {
                messageList.Items.Add(e);
            }
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (btnConnect.Content.ToString() == "Connect")
            {
                HubConnect();
            }
            else
            {
                if (txtBox.Text == "GetPerson")
                {
                    _myHubProxy.Invoke("srv_SendAsyncPerson");
                }
                _myHubProxy.Invoke("srv_SendAsync", txtBox.Text);
                txtBox.Text = "";
            }
        }
    }
}
