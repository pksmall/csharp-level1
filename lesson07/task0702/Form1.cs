using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Павел Корженко
 */

/*
 * 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
 *    а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше 
 *    загаданное число введенного.  
 *    
 *    a) Для ввода данных от человека используется элемент TextBox;
 *    б) **Реализовать отдельную форму c TextBox для ввода числа.
 */

namespace task0702
{
    public partial class Form1 : Form
    {
        int globalNum = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Угадай число!";
            this.txtEnterNum.Enabled = false;
            this.txtEnterNum.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                try
                {
                    int currentNum = int.Parse(txtEnterNum.Text);
                    lstViewTurn.Items.Add(txtEnterNum.Text);
                    if (globalNum == currentNum)
                    {
                        string msg = string.Format("Вы Угадали! Спасибо за игру.");
                        lblCountTurn.Text = msg;
                        btnRunGame.Text = "Играть!";
                        btnRunGame.Enabled = true;
                        this.txtEnterNum.Enabled = false;
                        lstViewTurn.Clear();
                    }
                    else if (globalNum < currentNum)
                    {
                        string msg = string.Format("Меньше!");
                        lblCountTurn.Text = msg;
                    }
                    else if (globalNum > currentNum)
                    {
                        string msg = string.Format("Больше!");
                        lblCountTurn.Text = msg;
                    }
                    txtEnterNum.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEnterNum.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите пожалуста только числа!");
                txtEnterNum.Text = txtEnterNum.Text.Remove(txtEnterNum.Text.Length - 1);
            }
       }

        private void btnRunGame_Click(object sender, EventArgs e)
        {
            btnRunGame.Text = "в игре";
            lblCountTurn.Text = "Введите ваше число и нажмите клавишу Enter";
            btnRunGame.Enabled = false;
            this.txtEnterNum.Enabled = true;
            lstViewTurn.Clear();
            Random r = new Random();
            globalNum = r.Next(1, 10);
            txtEnterNum.Focus();   
        }
    }
}
