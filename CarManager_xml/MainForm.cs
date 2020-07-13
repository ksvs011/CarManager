using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentTime.ForeColor = Color.White;
            date.ForeColor = Color.OliveDrab;
        
        }

        private void time_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToLongTimeString();
             date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
