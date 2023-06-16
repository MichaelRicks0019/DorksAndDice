using DorksAndDice.DB.DataRepositories.ProductRepositories;
using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.ProductInterfaces;
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
    public partial class Add : Form
    {
        UnitOfWork UOW;
        ISqlDataAccess _db;
        public Add()
        {
            InitializeComponent();
            _db = new SqlDataAccess();
            UOW = new UnitOfWork(_db);
        }

        private void ResetTexts()
        {
            textBox_Name.Text = string.Empty;
            textBox_Quantity.Text = string.Empty;
            textBox_Price.Text = string.Empty;
            textBox_Edge.Text = string.Empty;
            textBox_Color.Text = string.Empty;
            textBox_Material.Text = string.Empty;
            textBox_Style.Text = string.Empty;
            textBox_Type.Text = string.Empty;
            textBox_Size.Text = string.Empty;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Dice dice;
             
                try 
                {
                    dice = new Dice() { Dice_Id = 1,
                        Dice_Name = textBox_Name.Text,
                        Dice_Quantity = int.Parse(textBox_Quantity.Text),
                        Dice_Price = decimal.Parse(textBox_Price.Text),
                        Edge = textBox_Edge.Text,
                        Color = textBox_Color.Text,
                        Material = textBox_Material.Text,
                        Style = textBox_Style.Text,
                        Type = textBox_Type.Text,
                        Size = textBox_Size.Text };

                    
                    UOW.Dice.Insert(dice);
                    ResetTexts();
                    MessageBox.Show($"{dice.Dice_Name} was added Successfully");
                }
                catch(System.FormatException ex)
                {
                    MessageBox.Show(ex.Message + "\n Please make sure input info is correct", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Issue found, please make sure input info is correct.", "Error Found");
                }
            
            
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ResetTexts();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Type_Click(object sender, EventArgs e)
        {

        }
    }
}
