using System;
using System.Windows.Forms;
using Ivi.Visa.Interop;

namespace Keysight_VISA_IDN_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var rm = new ResourceManager();
            var conn = new FormattedIO488();
            conn.IO = (IMessage) rm.Open(textboxAddress.Text);
            conn.IO.Clear();
            conn.WriteString("*IDN?", true);
            MessageBox.Show(conn.ReadString());
        }
    }
}
