using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dickbutt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(0, 0);

            Stage.openMSPaint();
            Stage.setBrush();

            Dickbutt.drawFrame();

            Environment.Exit(0);
        }
    }
}
