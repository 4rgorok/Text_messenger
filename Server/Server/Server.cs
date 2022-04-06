using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private IPAddress addressIP = null;
        private int port;
        private TcpListener server = null;
        private TcpClient client = null;
        private BinaryReader reading;
        private BinaryWriter writing;
        private static List<Client> users = new List<Client>();
        private static bool activeConnection = false;
        private static bool exitClicked = false;

        public Server()
        {
            InitializeComponent();
        }
        
        
        private void btStart_Click(object sender, EventArgs e)
        {
            if (!bwConnection.IsBusy)
                bwConnection.RunWorkerAsync();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (bwConnection.IsBusy)
                server.Stop();
        }

        
        private void scrollListBox(String msg)
        {
            lbInfo.Invoke(new MethodInvoker(delegate { lbInfo.Items.Add(msg); }));
            lbInfo.Invoke(new MethodInvoker(delegate { lbInfo.TopIndex = lbInfo.Items.Count - 1; }));
        }

        
        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                btStart.Invoke(new MethodInvoker(delegate { btStart.Enabled = false; }));
                btStop.Invoke(new MethodInvoker(delegate { btStop.Enabled = true; }));
                activeConnection = true;
                addressIP = IPAddress.Parse(tbAddress.Text);
                port = Convert.ToInt16(nudPort.Value);
                server = new TcpListener(addressIP, port);
                server.Start();
                scrollListBox("Server rozpoczął nasłuchiwanie.");
                
                try
                {
                    while (activeConnection) {
                        client = server.AcceptTcpClient();
                        NetworkStream ns = client.GetStream();
                        reading = new BinaryReader(ns);
                        writing = new BinaryWriter(ns);
                        string name = reading.ReadString();
                        foreach (Client client in users)
                            if (client.nick == name)
                                name += "_copy";
                        IPEndPoint clientIP = (IPEndPoint)client.Client.RemoteEndPoint;
                        scrollListBox("Nawiązano połączenie z użytkownikiem " + name + " [" + clientIP.ToString() + "]");
                       users.Add(new Client(client, reading, name, lbInfo));
                    }
                }
                catch
                {
                    btStart.Invoke(new MethodInvoker(delegate { btStart.Enabled = true; }));
                    btStop.Invoke(new MethodInvoker(delegate { btStop.Enabled = false; }));
                    activeConnection = false;
                    foreach (Client client in users)
                        client.writing.Write("END");
                    users.Clear();
                    scrollListBox("Server zakończył nasłuchiwanie.");
                    
                }
            }
            catch
            {
                if (!exitClicked)
                {
                    btStart.Invoke(new MethodInvoker(delegate { btStart.Enabled = true; }));
                    btStop.Invoke(new MethodInvoker(delegate { btStop.Enabled = false; }));
                    scrollListBox("Błąd inicjacji połączenia.");
                }
                else
                {
                    foreach (Client client in users)
                        client.writing.Write("END");
                }
                activeConnection = false;
                users.Clear();
                
            }
        }

       
        internal static void Broadcast(String nick, String msg)
        {
           
            if (msg.StartsWith("/priv"))
            {
                string[] words = msg.Split(' ');
                msg = string.Join(" ", words, 2, words.Length-2);
                Client destination = users.SingleOrDefault(client => client.nick == words[1]);
                if (destination != null)
                {
                    foreach (Client client in users)
                    {
                        if (client.nick == nick)
                            client.writing.Write("<div style='width: 100%; margin-bottom: 5px;'><div style='float: left; width: 74%; padding:0 10px; border: 1px solid black;'>TY: " + msg + " </div>" + "<div style='float: right; width: 25%; padding:0 10px; text-align: center; clear:both;'>" + DateTime.Now.ToString("HH:mm tt") + "</div></div>");
                        else if (client.nick == words[1])
                            client.writing.Write("<div style='width: 100%; margin-bottom: 5px;'><div style='float: left; width: 25%; padding:0 10px; text-align: center;'>" + DateTime.Now.ToString("HH:mm tt") + "</div>" + "<div style='float: right; width: 74%; padding:0 10px; background-color: rgb(66, 134, 244);'>" + nick + ": " + msg + "</div></div>");
                    }
                }
            }
            
            else
            {
                foreach (Client client in users)
                {
                    if (client.nick != nick)
                        client.writing.Write("<div style='width: 100%; margin-bottom: 5px;'><div style='float: left; width: 25%; padding:0 10px; text-align: center;'>" + DateTime.Now.ToString("HH:mm tt") + "</div>" + "<div style='float: right; width: 74%; padding:0 10px; background-color: rgb(66, 134, 244);'>" + nick + ": " + msg + "</div></div>");
                    else
                        client.writing.Write("<div style='width: 100%; margin-bottom: 5px;'><div style='float: left; width: 74%; padding:0 10px; border: 1px solid black;'>TY: " + msg + " </div>" + "<div style='float: right; width: 25%; padding:0 10px; text-align: center; clear:both;'>" + DateTime.Now.ToString("HH:mm tt") + "</div></div>");
                }
            }
        }

        
        internal static void Delete(Client disconnectedClient, ListBox lbInfo)
        {
            if (!exitClicked)
            {
                lbInfo.Invoke(new MethodInvoker(delegate { lbInfo.Items.Add("Zerwano połączenie z użytkownikiem " + disconnectedClient.nick); }));
                lbInfo.Invoke(new MethodInvoker(delegate { lbInfo.TopIndex = lbInfo.Items.Count - 1; }));
            }
            users.Remove(disconnectedClient);
            disconnectedClient.messages.Abort();
        }

        
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bwConnection.IsBusy)
            {
                exitClicked = true;
                server.Stop();
            }
        }
    }

    
    class Client
    {
        public TcpClient connection;
        public Thread messages;
        public String nick;
        public BinaryWriter writing;
        public BinaryReader reading;
        public TcpClient client;

        
        public Client(TcpClient newConnection, BinaryReader newReader, String newNick, ListBox lbInfo)
        {
            connection = newConnection;
            reading = newReader;
            nick = newNick;
            writing = new BinaryWriter(connection.GetStream());

            messages = new Thread(() =>
            {
                for (; ; )
                {
                    try
                    {
                        Server.Broadcast(nick, reading.ReadString());
                    }
                    catch (Exception ex)
                    {
                        Server.Delete(this, lbInfo);
                    }
                }
            });
            messages.Start();
        }
    }
}
