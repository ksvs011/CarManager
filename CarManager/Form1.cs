using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CurrentTime.ForeColor = Color.White;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // form 움직이게 하는 소스
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParamm, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MoveSidePanel(Control c)
        {
            SidePanel.Height = c.Height;
            SidePanel.Top = c.Top;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnMain);
            panelContent.Controls.Clear();
            try
            {
                MainForm temp = new MainForm();

                temp.TopLevel = false;
                panelContent.Controls.Add(temp);
                temp.Show();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void btnParkingInformation_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnParkingInformation);
            panelContent.Controls.Clear();
            try
            {
                ParkingForm temp = new ParkingForm();

                temp.TopLevel = false;
                panelContent.Controls.Add(temp);
                temp.Show();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnCharge);
            panelContent.Controls.Clear();
            try
            {
                ChargeForm temp = new ChargeForm();

                temp.TopLevel = false;
                panelContent.Controls.Add(temp);
                temp.Show();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }
      
        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void time_Tick(object sender, EventArgs e)
        {
           CurrentTime.Text = DateTime.Now.ToString();
           CurrentTime.Location = new Point(
           this.ClientSize.Width / 6 - CurrentTime.Width / 2,
           this.ClientSize.Height / 4 - CurrentTime.Height / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToString();

        }
    }
}

