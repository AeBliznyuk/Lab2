using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private Order order;
        private int currentCup;
        private Milk milk;
        private Sugar sugar;
        private TeaVariety teaVariety;
        public Form1()
        {
            InitializeComponent();
            order = new Order();
            milk = new Milk(milkCheckBox.Checked);
            sugar = new Sugar(int.Parse(sugarAmounTextBox.Text));
            teaVariety = new TeaVariety(teaVarietyComboBox.SelectedItem.ToString());
            currentCup = 0;
        }

        private void milkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            milk = new Milk(milkCheckBox.Checked);                
        }

        private void teaVarietyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teaVariety = new TeaVariety(teaVarietyComboBox.SelectedItem.ToString());
        }

        private void incSugarAmountButton_Click(object sender, EventArgs e)
        {
            int currentSugar = int.Parse(sugarAmounTextBox.Text);
            currentSugar++;
            sugarAmounTextBox.Text = currentSugar.ToString();
            sugar = new Sugar(currentSugar);
        }

        private void decSugarAmountButton_Click(object sender, EventArgs e)
        {
            int currentSugar = int.Parse(sugarAmounTextBox.Text);
            currentSugar--;
            sugarAmounTextBox.Text = currentSugar.ToString();
            sugar = new Sugar(currentSugar);
        }

        private void incCupsAmountButton_Click(object sender, EventArgs e)
        {
            currentCup = int.Parse(cupsAmountTextBox.Text);
            currentCup++;
            cupsAmountTextBox.Text = currentCup.ToString();            
        }

        private void decCupsAmountButton_Click(object sender, EventArgs e)
        {
            currentCup = int.Parse(cupsAmountTextBox.Text);
            currentCup--;
            cupsAmountTextBox.Text = currentCup.ToString();
        }

        private void addCupButton_Click(object sender, EventArgs e)
        {
            CupOfTea cupOfTea = new CupOfTea(milk,sugar,teaVariety);
            for (int i = 0; i < currentCup; i++)
            {
                order.Add(cupOfTea);
                orderListBox.Items.Add(cupOfTea.TeaVariety.Name);
            }
            order.CalculatePrice();
            fullPriceLabel.Text = order.Price.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            milkCheckBox.Checked = false;
            sugarAmounTextBox.Text = 0.ToString();
            cupsAmountTextBox.Text = 0.ToString();
            teaVarietyComboBox.SelectedItem = "Улун";
            orderListBox.Items.Clear();
            fullPriceLabel.Text = 0.ToString();
            order = new Order();
            milk = new Milk(milkCheckBox.Checked);
            sugar = new Sugar(int.Parse(sugarAmounTextBox.Text));
            teaVariety = new TeaVariety(teaVarietyComboBox.SelectedItem.ToString());
            currentCup = 0;
        }
    }
}
