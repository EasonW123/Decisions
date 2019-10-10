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

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // object 
            Graphics g = this.CreateGraphics();
            SolidBrush letterBrush = new SolidBrush(Color.White);
            Font letterFont = new Font("Arial", 15, FontStyle.Regular);

            g.Clear(Color.Black);
            g.DrawString("Hello World", letterFont, letterBrush, 200, 70);
            Thread.Sleep(3000);
            g.DrawString("Hello World", letterFont, letterBrush, 200, 70);
            g.Clear(Color.Red);
            Thread.Sleep(350);
            g.DrawString("Hello World", letterFont, letterBrush, 200, 70);
            g.Clear(Color.Black);
            Thread.Sleep(350);
            g.DrawString("Hello World", letterFont, letterBrush, 200, 70);
            g.Clear(Color.Red);
            Thread.Sleep(350);
            g.DrawString("Hello World", letterFont, letterBrush, 200, 70);
            g.Clear(Color.Black);
            Thread.Sleep(350);
            g.DrawString("Press exit button", letterFont, letterBrush, 200, 70);
            Thread.Sleep(350);
            



        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // object 
            Graphics g = this.CreateGraphics();
            SolidBrush letterBrush = new SolidBrush(Color.White);
            Font letterFont = new Font("Arial", 15, FontStyle.Regular);

            g.Clear(Color.Black);
            g.DrawString("Good bye", letterFont, letterBrush, 200, 70);
            Thread.Sleep(2500);
            this.Close();
        }
    }
}
