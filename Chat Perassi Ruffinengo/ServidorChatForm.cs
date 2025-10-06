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
        string miIP = "";

        // _load el _ indica que es un evento
        private void ServidorChatForm_Load(object sender, EventArgs e)
        {
            miIP = ObtenerIPLocal();
            IPtextbox.Text = miIP;
            lecturaThread = new Thread(new ThreadStart( EjecutarServidor ));
            lecturaThread.Start();
        }

        //hoy 18/8
        //este evento se ejecuta desde que se hace el click de cerrar hasta que se termina de cerrar el form
        private void ServidorChatForm_FormClosing(object sander,
            FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        //delegate 
        //es un metodo creado por mi
        private delegate void DisplayDelegate(string mensaje);
        private void MostrarMensaje(string mensaje)
        {
            if (mostrarTextbox.InvokeRequired)
            {

                Invoke(new DisplayDelegate(MostrarMensaje),
                    new object[] { mensaje });
            }
            else
                mostrarTextbox.Text += mensaje;
        }


        //606060
        private delegate void DisableInputDelegate(bool value);

        private void DeshabilitarEntrada(bool valor)
        //si la modificacion de entrarTextBox no es segura para el subproceso
        {
            if (entradaTextbox.InvokeRequired)

            {
                //usa el metodo heredado Invoke para ejecutar DeshabilitandoEntrada 
                //a traves de un delegado

                Invoke(new DisableInputDelegate(DeshabilitarEntrada),

                   new object[] { valor });
            } // fin de if

            else
                // Se puede modificar entradaTextBox en el subproceso actual
                entradaTextbox.ReadOnly = valor;
        } // fin del metodo DeshabilitarEntrada

        //envia al cliente el texto escrito en el servidor
        //79
        private void entradaTextBox_KeyDown(object sender, KeyEventArgs e)

        {
            try
            {
                if (e.KeyCode == Keys.Enter && entradaTextbox.ReadOnly == false)
                {

                    escritor.Write("SERVIDOR>>> " + entradaTextbox.Text);
                    mostrarTextbox.Text += "\r\nSERVIDOR>>> " + entradaTextbox.Text;

                    //SI EL USUARIO EN EL SERVIDOR INDICO LA TERMINACION
                    //DE LA CONEXION CON EL CLIENTE
                    if (entradaTextbox.Text == "TERMINAR")
                        conexion.Close();

                    entradaTextbox.Text = ""; // borra la entrada del usuario
                } // fin de if
            }// fin de try
            catch (SocketException)
            {
                mostrarTextbox.Text += "\nError al escribir objeto";
            } //fin de catch
        }//fin del metodo entradaTextBox_KeyDown

        //permite que el cliente se conecte; muestra el texto que envia el cliente
        //104

        public static string ObtenerIPLocal()
        {
            string ipLocal = "No se pudo obtener la IP";

            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (var ip in host.AddressList)
                {
                    // Solo IPv4
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipLocal = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                ipLocal = $"Error: {ex.Message}";
            }

            return ipLocal;
        }

        public void EjecutarServidor()
        {
            TcpListener oyente;
            int contador = 1;

            //espera la conexion de un cliente y muestra el texto
            // que envia el cliente
            try
            {

                //Paso 1: crea TcpListener
                //192.168.100.19 HACER FUNC PARA OBTENER IP PROPIA
                IPAddress local = IPAddress.Parse(miIP);
                oyente = new TcpListener(local, 50000);
                //Paso 2: TcpListener espera la solicitud de conexion
                oyente.Start();
                //Paso 3: establece la conexion con la base en la solicitud del cliente
                while (true)
                {
                    MostrarMensaje("Esperando una conexion\r\n");
                    //acepta una conexion entrante
                    conexion = oyente.AcceptSocket();
                    //crea un objeto para transferir datos a traves de un flujo

                    socketStream = new NetworkStream(conexion);
                    escritor = new BinaryWriter(socketStream);
                    lector = new BinaryReader(socketStream);

                    MostrarMensaje("conexion " + contador + "recibida.\r\n");



                    //informa al cliente que la conexion fue exitosa 
                    escritor.Write("SERVIDOR>>> Conexion exitosa");

                    //140

                    DeshabilitarEntrada(false); //habilita entradaTextBox

                    string laRespuesta = "";

                    // Paso 4: lee los datos de cadena que envìa el cliente
                    do

                    {
                        try
                        {
                            //lee la cadena que se envia al cliente
                            laRespuesta = lector.ReadString();
                            //muestra el mensaje
                            //MostrarMensaje("\r\n" + laRespuesta);
                            MostrarMensaje(laRespuesta);
                        } // fin de try

                        //155

                        catch (Exception)

                        {

                            // maneja la excepcion si hay error al leer los datos
                            break;
                        } // fin de catch
                    } while (laRespuesta != "CLIENTE>>> TERMINAR" &&
                    conexion.Connected);

                    MostrarMensaje("\r\nE1 usuario termino la conexion\r\n");

                    // Paso 5: cierra la conexion
                    escritor.Close();
                    lector.Close();
                    socketStream.Close();
                    conexion.Close();


                    DeshabilitarEntrada(true); // deshabilita entradaTextBox
                    contador++;
                }// fin de while
            }

            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string miIP = ObtenerIPLocal();
            Console.WriteLine("Mi IP local es: " + miIP);
            IPtextbox.Text = miIP;
        }
    }
}

