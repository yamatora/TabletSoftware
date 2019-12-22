using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TabletSoftware
{
    public partial class FormMain : Form
    {
        private FormClock m_clock;
        private bool m_isMoving = false;
        private Point m_startPos;

        public FormMain()
        {
            InitializeComponent();

            m_clock = new FormClock();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_clock.ShowDialog();
            this.Show();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            m_startPos = e.Location;
            m_isMoving = true;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button&MouseButtons.Left)!=MouseButtons.Left || !m_isMoving)
                return;
            this.Left += e.X - m_startPos.X;
            this.Top += e.Y - m_startPos.Y;
            //this.Location = new Point(e.X + m_mouseDiff.X, e.Y + m_mouseDiff.Y);
            Console.WriteLine("{0},{1}", e.X, e.Y);
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            m_isMoving = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
