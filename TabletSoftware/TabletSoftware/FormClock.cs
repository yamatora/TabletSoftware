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
    public partial class FormClock : Form
    {
        Timer m_timer;

        public FormClock()
        {
            InitializeComponent();

            // event
            lblClock.MouseDoubleClick += new MouseEventHandler(FormClock_MouseDoubleClick);

            // timer
            m_timer = new Timer();
            m_timer.Tick += new EventHandler(timer_tick);
            m_timer.Interval = 100;
            m_timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblClock.Text = String.Format("{0}:{1}:{2}", now.Hour.ToString("00"), now.Minute.ToString("00"), now.Second.ToString("00"));
        }

        private void FormClock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
