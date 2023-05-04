﻿using DorksAndDice.DB.DBAccess;
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

        private void comboBox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Products.Text != string.Empty) 
            { 
                label_AmountLeft.Text = $"{label_AmountLeft} {UOW.Dice.GetByName(comboBox_Products.Text).Result.FirstOrDefault().Dice_Quantity}";
            }
        }
    }
}