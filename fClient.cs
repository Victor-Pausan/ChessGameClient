using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class fClient : Form
    {
        Form1 mainForm;

        public TcpClient client;
        public NetworkStream clientStream;
        public bool ascult;
        public fClient clientForm;
        public Thread t;

        public fClient(Form1 mainForm)
        {
            InitializeComponent();

            textBox1.Hide();
            tbDate.Hide();
            btnSend.Hide();

            this.mainForm = mainForm;
            clientForm = this;
            btnConect.Click += btnConect_Click;
            tbDate.KeyPress += tbDate_KeyPress;
            btnSend.Click += btnSend_Click;
            this.FormClosed += FServer_FormClosed;
        }

        private void Asculta_client()
        {
            StreamReader citire = new StreamReader(clientStream);
            String dateClient;
            while (ascult)
            {
                dateClient = citire.ReadLine();

                MethodInvoker m = new MethodInvoker(() => clientForm.textBox1.Text += ("Server: " + dateClient + Environment.NewLine)) ;
                clientForm.textBox1.Invoke(m);

                MethodInvoker n = new MethodInvoker(() => mainForm.game.UpdateTable(Convert.ToInt32(dateClient[0] - '0'),
                            Convert.ToInt32(dateClient[1] - '0'),
                            Convert.ToInt32(dateClient[2] - '0'),
                            Convert.ToInt32(dateClient[3]) - '0'));
                mainForm.Invoke(n);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true; // enable automatic flushing
                scriere.WriteLine(tbDate.Text);
                textBox1.Text += "Client: " + tbDate.Text + Environment.NewLine;
                tbDate.Clear();
                // s_text.Close();
            }
            finally
            {
                // code in finally block is guranteed 
                // to execute irrespective of 
                // whether any exception occurs or does 
                // not occur in the try block
                //  client.Close();
            }
        }

        private void FServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ascult = false;
            t.Abort();
            clientStream.Close();
            client.Close();
        }

        private void tbDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSend_Click(sender, e);
            }
        }

        private void btnConect_Click(object sender, EventArgs e)
        {

            if (btnConect.Text == "Start")
            {
                if (tbAddress.Text.Length > 0)
                {
                    try
                    {
                        client = new TcpClient(tbAddress.Text, 3000);
                        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                        mainForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    }
                    catch(Exception exp)
                    {
                        textBox2.Text = "Waiting for server...";
                    }
                    
                    ascult = true;
                    t = new Thread(new ThreadStart(Asculta_client));
                    t.Start();
                    clientStream = client.GetStream();
                    tbDate.Enabled = true;
                    btnSend.Enabled = true;
                    label1.Visible = false;
                    tbAddress.Visible = false;
                    btnConect.Text = "Disconect";
                }
                else
                {
                    MessageBox.Show("Specificati adresa de IP");
                }
            }
            else
            {
                ascult = false;
                t.Abort();
                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true; // enable automatic flushing
                scriere.WriteLine("#Gata");
            }

        }

        public void Set_tbDate(string pozitii)
        {
            tbDate.Text = pozitii;
            try
            {

                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true; // enable automatic flushing
                scriere.WriteLine(tbDate.Text);
                textBox1.Text += "Client: " + tbDate.Text + Environment.NewLine;
                tbDate.Clear();
                // s_text.Close();
            }
            finally
            {
                // code in finally block is guranteed 
                // to execute irrespective of 
                // whether any exception occurs or does 
                // not occur in the try block
                //  client.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
