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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm cashierWindowQueueForm = new CashierWindowQueueForm();
        servingQueue servingQueue = new servingQueue();
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            cashierWindowQueueForm.Show();
            servingQueue.Show();

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
       
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            
          
        }
    }
}
