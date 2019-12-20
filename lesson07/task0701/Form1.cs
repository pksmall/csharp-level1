using System;
using System.Collections;
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
 * 1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
 *    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число 
 *       должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
 *    в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный 
 *       класс Stack
 */

namespace task0701
{
    public partial class Form1 : Form
    {
        private int globalNum = 0;
        Stack st = new Stack();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCountCommands.Text = (int.Parse(lblCountCommands.Text) + 1).ToString();
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            // играем!
            CheckGlobalNum();
            st.Push('+');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCountCommands.Text = (int.Parse(lblCountCommands.Text) + 1).ToString();
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            // играем!
            CheckGlobalNum();
            st.Push('*');
        }

        private void CheckGlobalNum()
        {
            if (globalNum != 0)
            {
                int currentNum = int.Parse(lblNumber.Text);
                if (globalNum == currentNum)
                {
                    string msg = string.Format("Поздоравялем!\nВы получили число {0} за {1} ходов.\nСпасибо.", globalNum, lblCountCommands.Text);
                    MessageBox.Show(msg);
                    groupBox1.Text = string.Format("Нажмите в меню - Играть");
                    ResetValues();
                } else if(globalNum < currentNum)
                {
                    string msg = string.Format("Вы привысили число {0} -> {1}.\nКоличество ходов {2}.\nСпасибо.", globalNum, currentNum, lblCountCommands.Text);
                    MessageBox.Show(msg);
                    groupBox1.Text = string.Format("Нажмите в меню - Играть");
                    ResetValues();
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (st.Count > 0)
            {
                switch (st.Pop())
                {
                    case '+':
                        lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
                        break;
                    case '*':
                        lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ResetValues()
        {
            lblCountCommands.Text = "0";
            lblNumber.Text = "1";
            st = new Stack();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblCountCommands_Click(object sender, EventArgs e)
        {

        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            globalNum = r.Next(1, 100);
            string msg = string.Format("Получите число {0} за наименьшее количество ходов.\nУдачи", globalNum);
            MessageBox.Show(msg);
            groupBox1.Text = string.Format("Играем! Получаем число {0}", globalNum);
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Угадайка. версия 0.1.\n(c) GeekBrains");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
