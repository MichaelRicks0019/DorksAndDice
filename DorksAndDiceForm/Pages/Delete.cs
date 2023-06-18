using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.UOW;
using DorksAndDice.Logic.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorksAndDiceForm.Pages
{
    public partial class Delete : Form
    {
        UnitOfWork UOW;
        ISqlDataAccess _db;
        Dice? dice;
        public Delete()
        {
            InitializeComponent();
            _db = new SqlDataAccess();
            UOW = new UnitOfWork(_db);
            AddItemsNames();
        }

        public async void AddItemsNames()
        {
            var i = UOW.Dice.GetAll();
            await i;
            for (int j = 0; j < i.Result.Count; j++)
            {
                comboBox_Products.Items.Add(i.Result[j].Dice_Name);
            }
        }

        public async void Refresh()
        {
            comboBox_Products.Items.Clear();
            AddItemsNames();
            QuantityLeft();
        }

        public async void QuantityLeft()
        {
            var product = UOW.Dice.GetByName(comboBox_Products.Text);
            await product;
            if (product.Result.FirstOrDefault() != null)
            {
                dice = product.Result.FirstOrDefault();
                label_AmountLeft.Text = $"AmountLeft: {product.Result.FirstOrDefault().Dice_Quantity}";
            }
            else
            {
                dice = null;
                label_AmountLeft.Text = $"AmountLeft:";
            }
        }

        private void comboBox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Products.Text != string.Empty) 
            { 
                QuantityLeft();
            }
        }

        private async void button_Delete_Click(object sender, EventArgs e)
        {
            if(comboBox_Products.Text != string.Empty)
            {
                QuantityLeft();
                if (dice != null)
                {
                    int i = dice.Dice_Quantity - int.Parse(numericUpDown_Quantity.Value.ToString());
                    Dice j = dice;
                    j.Dice_Quantity = i;
                    if (i < 0)
                    {
                        j.Dice_Quantity = 0;
                    }
                    await UOW.Dice.Update(j);
                }
                Refresh();
            }
        }
    }
}
