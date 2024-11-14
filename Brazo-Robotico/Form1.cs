using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brazo_Robotico
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(s);  // Rellenar los puertos disponibles
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarBase.Minimum = 0;
            trackBarBase.Maximum = 180;
            trackBarCodo.Minimum = 0;
            trackBarCodo.Maximum = 180;
            trackBarBrazo.Minimum = 0;
            trackBarBrazo.Maximum = 180;
            trackBarMano.Minimum = 0;
            trackBarMano.Maximum = 180;
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
            serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
            serialPort.Open();
        }

        private void trackBarBase_Scroll(object sender, EventArgs e)
        {
            SendServoCommand('B', trackBarBase.Value);
        }
        private void SendServoCommand(char servoId, int angle)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(new byte[] { (byte)servoId, (byte)angle }, 0, 2);
            }
            else
            {
                MessageBox.Show("Seleccione un puerto COM antes de enviar comandos.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void trackBarCodo_Scroll(object sender, EventArgs e)
        {
            SendServoCommand('C', trackBarCodo.Value);
        }

        private void trackBarBrazo_Scroll(object sender, EventArgs e)
        {
            SendServoCommand('A', trackBarBrazo.Value);
        }

        private void trackBarMano_Scroll(object sender, EventArgs e)
        {
            SendServoCommand('M', trackBarMano.Value);
        }
    }
}
