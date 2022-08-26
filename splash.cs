using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_system
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void splash_Load(object sender, EventArgs e)
        {
            startpoint += 1;
            if(Myprogress.Value==startpoint)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login log= new login();
                this.Hide();
                log.Show();
            }
        }
    }
}
