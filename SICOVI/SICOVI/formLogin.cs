using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICOVI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            Thread thread = new Thread(ejecutarSplash);
            thread.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            thread.Abort();
        }

        public void ejecutarSplash()
        {
            Application.Run(new formSplash());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
