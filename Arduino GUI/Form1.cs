using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }
        // Controlling the flexation motion 
        private void button1_Click(object sender, EventArgs e)
        {
            // Commanding arduino to turn pin 11 ON
            serialPort1.Write("A");
                 
        }

        // Controlling the Extension motion 
        private void button2_Click(object sender, EventArgs e)
        {
            // Commanding adruino to turn pin 12 ON
            serialPort1.Write("B");
        }
        
        // Controlling the Right Rotation motion
        private void button3_Click(object sender, EventArgs e)
        {
            // Commanding arduino to turn pin 9 ON
            serialPort1.Write("C");
        }
        // Controlling the Left Rotation motion
        private void button4_Click(object sender, EventArgs e)
        {
            // Commanding arduino to turn pin 10 ON
            serialPort1.Write("D");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // For testing the connection by turning pin 13 ON
            serialPort1.Write("z");
        }
    }
}
