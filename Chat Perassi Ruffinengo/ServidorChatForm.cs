using System;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_Perassi_Ruffinengo
{
    public partial class ServidorChatForm : Form
    {
        public ServidorChatForm()
        {
            InitializeComponent();
        }
        private Socket conexion;
        private Thread lecturaThread; // thread = hilo. 
        private NetworkStream socketStream; // stream cadena de datos
        private BinaryWriter escritor;
        private BinaryReader lector;

        // _load el _ indica que es un evento
        private void ServidorChatForm_Load( object sender, EventArgs e)
        {
            //lecturaThread = new Thread(new ThreadStart( EjecutarServidor ));
            lecturaThread.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_Click(object sender, EventArgs e)
        {
            mostrarTextbox.Text = entradaTextbox.Text.ToUpper();
            label1.Text = entradaTextbox.Text + " " + mostrarTextbox.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (mostrarTextbox.Text == "hola")
            {
                label1.Text = entradaTextbox.Text + " " + mostrarTextbox.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
