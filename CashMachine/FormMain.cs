using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public partial class FormMain : Form
    {
        Cash cash = new Cash();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxMoneyType.SelectedIndex = 0;
            labelState.Text = cash.GetState();
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMoneyType.Enabled = radioButtonAdd.Checked;
            numCountMoney.Enabled = radioButtonAdd.Checked;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked == true)
            {
                int type = comboBoxMoneyType.SelectedIndex;
                int count = (int)numCountMoney.Value;
                bool check = cash.AcceptBanknote(type, count);
                labelState.Text = cash.GetState();
                if (!check)
                {
                    MessageBox.Show("Невозможно добавить купюры из-за ограничения по количеству хранимых купюр.");
                }

            }

            if (radioButtonGet.Checked == true)
            {
                int needSum = (int)numSum.Value;
                int type = comboBoxMoneyType.SelectedIndex;
                var giveOutSum = cash.GiveOutBanknotes(needSum, checkBoxSmall.Checked, type);
                int sum = cash.GetSumMoney(giveOutSum);
                labelState.Text = cash.GetState();
                if (sum == 0)
                {
                    if (checkBoxSmall.Checked == true)
                    {
                        MessageBox.Show("Невозможно выдать запрашиваемую сумму указанного номинала.");
                    }
                    else
                    {
                        MessageBox.Show("Невозможно выдать запрашиваемую сумму.");
                    }
                }
                else
                {
                    MessageBox.Show(cash.GetSumWithMoneyType(giveOutSum), "Сумма выдачи");
                }
            }
        }

        private void radioButtonGet_CheckedChanged(object sender, EventArgs e)
        {
            numSum.Enabled = radioButtonGet.Checked;
            checkBoxSmall.Enabled = radioButtonGet.Checked;
        }

        private void checkBoxSmall_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMoneyType.Enabled = checkBoxSmall.Checked;
        }
    }
}
