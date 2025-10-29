using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Cliente
{
    public partial class ClienteChatForm : Form
    {
        ////hasta aqui hoy es viernes 29/ñoquis
        ///01/09
        ///
        private NetworkStream salida; //flujo para recibir datos
        private BinaryWriter escritor; //facilita la escritura en el flujo
        private BinaryReader lector; //facilita la lectura del flujo
        private Thread lecturaThread; //thread para procesar mensajes entrantes
        private string mensaje = "";

        //inicializa el subproceso para la lectura

        private void ClienteChatForm_Load(object sender, EventArgs e)
        {
            //lecturaThread = new Thread(new ThreadStart(EjecutarCliente));
            //lecturaThread.Start();
        }

        //cierra todos los subprocesos asociados con esta aplicacion
        private void ClienteChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        //delegado ? que permite llamar al metodo Mostar Mensaje
        private delegate void DisplayDelegate(string messaje);

        private void MostrarMensaje(string menssaje)
        {
            if (mostrarTextbox.InvokeRequired)
            {
                Invoke(new DisplayDelegate(MostrarMensaje), new object[] { mensaje });

            }
            else
            
                mostrarTextbox.Text += mensaje;
            }

        private delegate void DisableInputDelegate(bool value);
            
        private void DeshabilitarSalida(bool valor)
        {
            if (entradaTextbox.InvokeRequired)
            {
                Invoke(new DisableInputDelegate(DeshabilitarSalida), new object[] { valor });

            }
            else
                entradaTextbox.ReadOnly = valor;
        }


        private void entradaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && entradaTextbox.ReadOnly == false)
                {
                    escritor.Write("CLIENTE>>>" + entradaTextbox.Text);
                    mostrarTextbox.Text += "\r\nCLIENTE>>>" + entradaTextbox.Text;
                    entradaTextbox.Clear();
                }
            }
            catch (SocketException)
            {
                mostrarTextbox.Text += "\n Error al escribir el objeto";
            }
        }
        //se conecta al servidor y muestra el texto generado por el servidor
        public void EjecutarCliente()
        {
            TcpClient cliente;
            //crea instancia de TcpClient para enviar datos al servidor 
            /////////quedamos aca. pag 13 linea 103
            try
            {
                MostrarMensaje("Tratando de conectar\r\n");
                cliente = new TcpClient();
                cliente.Connect(this.IPtextbox.Text, 50000);

                salida = cliente.GetStream();

                escritor = new BinaryWriter(salida);
                lector = new BinaryReader(salida);

                MostrarMensaje("\r\nSe recibieron flujos de E/S\r\n");
                DeshabilitarSalida(false);

                do
                {
                    try
                    {
                        //lee el mensaje del servidor
                        mensaje = lector.ReadString();
                        MostrarMensaje("\r\n" + mensaje);

                    }
                    catch (Exception)
                    {
                        System.Environment.Exit(System.Environment.ExitCode);
                    }
                } while (mensaje != "SERVIDOR>>> TERMINAR ");

                escritor.Close();
                lector.Close();
                salida.Close();
                cliente.Close();
                Application.Exit();
            }
            catch (Exception error )
            {
                MessageBox.Show(error.ToString(), "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(System.Environment.ExitCode);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lecturaThread = new Thread(new ThreadStart(EjecutarCliente));
            lecturaThread.Start();
        }

        private void entradaTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

