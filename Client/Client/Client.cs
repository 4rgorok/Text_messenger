using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        private TcpClient client = null;
        private BinaryReader reading = null;
        private BinaryWriter writing = null;
        private bool activeConnection = false;
        private bool boldClick = false;
        private bool italicClick = false;
        private bool underlineClick = false;

        public Client()
        {
            InitializeComponent();
        }

        
        private void btConnect_Click(object sender, EventArgs e)
        {
            string addressIP = tbAddress.Text;
            int port = Convert.ToInt16(nudPort.Value);
            string name = tbName.Text;
            try
            {
                client = new TcpClient(addressIP, port);
                NetworkStream ns = client.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                writing.Write(name);
                btDisconnect.Enabled = true;
                btConnect.Enabled = false;
                activeConnection = true;
                bwReading.RunWorkerAsync();
                scrollListBox("Nawiązano połączenie z " + addressIP + " na porcie: " + port.ToString());
               
            }
            catch (Exception ex)
            {
                activeConnection = false;
                scrollListBox("Błąd. Nie udało sie nawiązać połączenia!");
                
            }
        }

       
        private void btDisconnect_Click(object sender, EventArgs e)
        {
            scrollListBox("Zerwano połączenie z serverem.");
            btDisconnect.Enabled = false;
            btConnect.Enabled = true;
            activeConnection = false;
            client.Close();
        }

        
        private void scrollListBox(String msg)
        {
            lbInfo.Invoke(new MethodInvoker(delegate { lbInfo.Items.Add(msg); }));
            lbInfo.Invoke(new MethodInvoker(delegate { lbInfo.TopIndex = lbInfo.Items.Count - 1; }));
        }

        private void bwReading_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string messageReceived;
                while ((messageReceived = reading.ReadString()) != "END")
                {
                    wbChat.Invoke(new MethodInvoker(delegate { wbChat.DocumentText +=  messageReceived ; }));
                }
                scrollListBox("Server zakończył połączenie.");
                btConnect.Invoke(new MethodInvoker(delegate { btConnect.Enabled = true; }));
                btDisconnect.Invoke(new MethodInvoker(delegate { btDisconnect.Enabled = false; }));
                activeConnection = false;
                client.Close();
                
            }
            catch
            {
         
                activeConnection = false;
               
            }
        }

       
        private void btClear_Click(object sender, EventArgs e)
        {
            wbChat.DocumentText = "";
            tbMessage.Focus();
        }

      
        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                string messageSent = tbMessage.Text;
                tbMessage.Text = "";

       

                if (messageSent != "")
                {
                    if (boldClick)
                        messageSent = "<b>" + messageSent + "</b>";
                    if (italicClick)
                        messageSent = "<i>" + messageSent + "</i>";
                    if (underlineClick)
                        messageSent = "<u>" + messageSent + "</u>";
                    writing.Write(messageSent);
                }
                tbMessage.Focus();

            }
            catch
            {
                scrollListBox("Błąd podczas wysyłania wiadomości!");
                
                activeConnection = false;
            }
        }

        
        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSend.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        
        private void wbChat_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wbChat.Document.Window.ScrollTo(0, wbChat.Document.Body.ScrollRectangle.Height);
         
        }

  

        private void btBold_Click(object sender, EventArgs e)
        {
      
            tbMessage.Text =  "<b>" + tbMessage.Text  + "</b>";
            btSend.Focus();
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            
            tbMessage.Text = "<i>" + tbMessage.Text + "</i>";
            btSend.Focus();
        }

        private void btUnderline_Click(object sender, EventArgs e)
        {
            
            tbMessage.Text = "<u>" + tbMessage.Text + "</u>";
            btSend.Focus();
        }

        

        private void btLike_Click(object sender, EventArgs e)
        {
            tbMessage.Text += (sender as Button).Text;
        }

        private void btBic_Click(object sender, EventArgs e)
        {
            tbMessage.Text += (sender as Button).Text;
        }

        private void btLove_Click(object sender, EventArgs e)
        {
            tbMessage.Text += (sender as Button).Text;
        }
    }
}
