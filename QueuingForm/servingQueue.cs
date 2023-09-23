using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class servingQueue : Form
    {
        CashierWindowQueueForm c = new CashierWindowQueueForm();

        public servingQueue()
        {
            InitializeComponent();
        }

        private void servingQueue_Load(object sender, EventArgs e)
        {

            timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if (CashierClass.CashierQueue.Count > 0)
            {
                servinglbl.Text = CashierClass.CashierQueue.Peek().ToString();
            }
            else
            {
                servinglbl.Text = "";

            }
           
        }
    }
}
