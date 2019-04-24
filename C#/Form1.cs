using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;


namespace LaberintoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbRaton.SelectedIndex = 0;
        }

        //EnviarDATOS envia los datos para ejecutar el juego
        //EnviarDATOS(x), si x=2 ABAJO, si x=4 IZQ, si x=6 DER, si x=8 ARRIBA.
        private string EnviarDATOS(int Direccion) {
            string request = cbRaton.Text + Direccion.ToString() + "\r\n";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[256];

            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ClientSocket.Connect(edtHost.Text, 3000);
                if (!ClientSocket.Connected)
                    throw new Exception();
                ClientSocket.Send(bytesSent, bytesSent.Length, 0);
                int bytes = 0;
                string result = "";

                // Esto hace que funcione como un blocking connection
                do
                {
                    bytes = ClientSocket.Receive(bytesReceived, bytesReceived.Length, 0);
                    result = result + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);
                return result;
            }
            catch (Exception)
            {
                return "No se pudo conectar";
            }

            
        }

        //printInTextBox imprime un string en el recuadro.
        private void PrintInTextBox(string texto)
        {
            listBox1.Items.Add(texto);
        }
        private void PrintInTextBox2(string texto)
        {
            listBox2.Items.Add(texto);
        }


        class Array {
            private const int tablaLargo = 40;
            private const int tablaAlto = 23;
            private int[,] array = new int[tablaAlto, tablaLargo];
            private int[] ubicacionActual = new int[] { 3, 1 };

            public Array() {
                //Inicializo el Array en 0's
                for (int i = 0; i < tablaAlto; ++i)
                {
                    for (int j = 0; j < tablaLargo; ++j)
                    {
                        array[i, j] = 0;
                    }
                }

                for (int i = 0; i < tablaLargo; i++)
                {
                    array[0, i] = 1;
                    array[tablaAlto - 1, i] = 1;
                }

                for (int i = 0; i < tablaAlto; i++)
                {
                    array[i, 0] = 1;
                    array[i, tablaLargo - 1] = 1;
                    array[i, 1] = 1;
                }

                array[3, 1] = 0;
            }
            public void UpdateLocation(int x, int y)
            {
                ubicacionActual[0] = x;
                ubicacionActual[1] = y;
            }

            public void UpdateLocation(int direccion)
            {
                if (direccion == 2)
                    UpdateLocation(ubicacionActual[0] + 1, ubicacionActual[1]);
                else if (direccion == 4)
                    UpdateLocation(ubicacionActual[0], ubicacionActual[1] - 1);
                else if (direccion == 6)
                    UpdateLocation(ubicacionActual[0], ubicacionActual[1] + 1);
                else if (direccion == 8)
                    UpdateLocation(ubicacionActual[0] -1 , ubicacionActual[1]);

            }

            public void Obstaculo(int direccion, int numero)
            {
                if (direccion == 2)
                    array[ubicacionActual[0] + 1, ubicacionActual[1]] = numero;
                else if (direccion == 4)
                    array[ubicacionActual[0], ubicacionActual[1] - 1] = numero;
                else if (direccion == 6)
                    array[ubicacionActual[0], ubicacionActual[1] + 1] = numero;
                else if (direccion == 8)
                    array[ubicacionActual[0] - 1, ubicacionActual[1]] = numero;

            }

            public bool Exist(int ubicacion, int valorABuscar)
            {
                if (ubicacion == 2)
                    if (GetElement(ubicacionActual[0] + 1, ubicacionActual[1]) == valorABuscar)
                        return true;
                    else
                        return false;
                else if (ubicacion == 4)
                    if (GetElement(ubicacionActual[0], ubicacionActual[1] - 1) == valorABuscar)
                        return true;
                    else
                        return false;
                else if (ubicacion == 6)
                    if (GetElement(ubicacionActual[0], ubicacionActual[1] + 1) == valorABuscar)
                        return true;
                    else
                        return false;
                else if (ubicacion == 8)
                    if (GetElement(ubicacionActual[0] - 1, ubicacionActual[1]) == valorABuscar)
                        return true;
                    else
                        return false;
                else
                    return false;

            }

            public void MarcarUbicacionActual()
            {
                array[ubicacionActual[0], ubicacionActual[1]] = 2;
            }

            public int GetTablaLenX()
            {
                return tablaLargo;
            }

            public int GetTablaLenY()
            {
                return tablaAlto;
            }

            public int GetElement(int x, int y) {
                return array[x, y];
            }

            public string GetElementString(int x, int y)
            {
                string resultado = array[x, y].ToString();
                return resultado;
            }


        };

        private void BtnArriba_Click(object sender, EventArgs e)
        {
            string request = cbRaton.Text + ((Button)sender).Tag.ToString() + "\r\n";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[256];

            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ClientSocket.Connect(edtHost.Text, 3000);
                if (!ClientSocket.Connected)
                    throw new Exception();
                ClientSocket.Send(bytesSent, bytesSent.Length, 0);
                int bytes = 0;
                string result = "";

                // Esto hace que funcione como un blocking connection
                do
                {
                    bytes = ClientSocket.Receive(bytesReceived, bytesReceived.Length, 0);
                    result = result + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);

                listBox1.Items.Add(result);
            }
            catch (Exception)
            {
                listBox1.Items.Add("No se pudo conectar");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            while (true)
            {
                Random r = new Random((int)DateTime.Now.Ticks);
                int Direccion = r.Next(1, 4) * 2;
                PrintInTextBox(EnviarDATOS(Direccion));
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Cp = "Cp", De = "De", Iz = "Iz", Ab = "Ab", Ar = "Ar", Cc = "Cc";
            
            Array arreglo = new Array();
            // Creo un Array con el Laberinto.
            // 0: Camino no explorado
            // 1: Pared
            // 2: Posicion Actual

            ArrayList movimientosRetorno = new ArrayList();
            // Creo una lista para almacenar los movimientos y poder retornar al home una vez que recoja un choclo.

            int dirActual;
            Random r = new Random((int)DateTime.Now.Ticks);

            for (int choclosRestantes = 68;;)
            {
                dirActual = r.Next(1, 5) * 2;
                //Creo un valor aleatorio que puede tomar 2 ABAJO, 4 IZQ, 6 DER y 8 ARRIBA.

                if (!arreglo.Exist(dirActual, 1))
                    //Verifica si existe una pared previamente detectada en el array. Si hay pared, busca otro numero random.
                {
                    string mensaje = EnviarDATOS(dirActual);
                    // Envio la direccion y asigno el mensaje que retorna el servidor a un string.

                    if (mensaje.StartsWith(Cc))
                        //Si come el choclo, retorna a home.
                    {
                        choclosRestantes--;
                        RetornarAHome(arreglo, movimientosRetorno);
                    }
                    else
                        //Si no come el choclo...
                    {
                        if (mensaje.StartsWith(Ab) || mensaje.StartsWith(Iz) || mensaje.StartsWith(De) || mensaje.StartsWith(Ar))
                            arreglo.UpdateLocation(dirActual);
                        // actualizo la direccion de a donde se movio al array.

                        AgregarMovimientosDeRetorno(De, Iz, Ab, Ar, movimientosRetorno, dirActual, mensaje);
                        //Agrego los movimientos para realiar el retorno.

                        if (mensaje.StartsWith(Cp))
                            arreglo.Obstaculo(dirActual, 1);
                        //En caso que choque con la pared, registro la pared en el array.
                    }
                    PrintInTextBox(mensaje + " -> " + dirActual.ToString());
                    //Imprimo la direccion en el cuadro de texto.
                }

                if (choclosRestantes == 0)
                    break;
            }

            ImprimirArreglo(arreglo);
            //Al comer todos los choclos, imprimo el array final que fue utilizado como el mapa del laberinto.

        }

        private static void AgregarMovimientosDeRetorno(string De, string Iz, string Ab, string Ar, ArrayList movimientosRetorno, int dirActual, string mensaje)
        {
            if (dirActual == 2 && mensaje.StartsWith(Ab))
                movimientosRetorno.Add(8);

            if (dirActual == 4 && mensaje.StartsWith(Iz))
                movimientosRetorno.Add(6);

            if (dirActual == 6 && mensaje.StartsWith(De))
                movimientosRetorno.Add(4);

            if (dirActual == 8 && mensaje.StartsWith(Ar))
                movimientosRetorno.Add(2);
        }

        private void RetornarAHome(Array arreglo, ArrayList movimientosRetorno)
        {
            movimientosRetorno.Reverse();
            foreach (int j in movimientosRetorno)
            {
                EnviarDATOS(j);
                arreglo.UpdateLocation(j);
            }
            movimientosRetorno.Clear();
        }

        private void ImprimirArreglo(Array arreglo)
        {
            arreglo.MarcarUbicacionActual();

            listBox2.Items.Clear();

            string print = "";

            for (int i = 0; i < arreglo.GetTablaLenY(); ++i)
            {
                for (int j = 0; j < arreglo.GetTablaLenX(); ++j)
                {
                    print += arreglo.GetElementString(i, j); print += " ";
                }
                PrintInTextBox2(print);
                print = "";
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
