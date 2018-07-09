using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class ModeSelection : Form
    {
        public ModeSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            this.Hide();
            
            long authnKey = 0;

            var lo = new LogOn();
            lo.ShowDialog();

            authnKey = lo.authenKey;
            
            new MainDetention(authnKey).ShowDialog();
            this.Show();
        }

        private void serverRecorder_B(object sender , EventArgs e)
        {
            this.Hide();
            new ServerRecorder().ShowDialog();
            this.Show();
        }
    }
}
