using DorksAndDiceBasic.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorksAndDiceBasic
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.ShowDialog();
        }

        private void button_ViewAllItems_Click(object sender, EventArgs e)
        {
            ViewAll viewAll = new ViewAll();
            viewAll.ShowDialog();
        }
    }
}
