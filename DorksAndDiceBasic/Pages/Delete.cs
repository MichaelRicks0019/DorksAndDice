using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorksAndDiceBasic.Pages
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dorksAndDiceDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dorksAndDiceDataSet.Product);
            // TODO: This line of code loads data into the 'dorksAndDiceDataSet.Dice' table. You can move, or remove it, as needed.
            this.diceTableAdapter.Fill(this.dorksAndDiceDataSet.Dice);

        }
    }
}
