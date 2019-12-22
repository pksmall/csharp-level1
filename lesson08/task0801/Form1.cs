using System;
using System.Windows.Forms;

/*
 * Павел Корженко
 */

/*
 * 1. 
 *   а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок 
 *      (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого 
 *      файла и т.д.).
 *   б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие 
 *      «косметические» улучшения на свое усмотрение.
 *   в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, 
 *      авторские права и др.).
 *   г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
 *   д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных 
 *      (элемент SaveFileDialog).
 */

namespace task0801
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }
        // Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
                if (database.Count < nudNumber.Value)
                {
                    MessageBox.Show("В базе данных нет такого вопроса", "Сообщение");
                    return;
                }
            }
            catch
            {
                if (database == null) {
                    MessageBox.Show("Создайте новую базу данных", "Сообщение");
                    return;
                }
            }
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить вопрос?", "Подвердите удаления вопроса", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (nudNumber.Maximum == 1 || database == null) return;
                database.Remove((int)nudNumber.Value);
                nudNumber.Maximum--;
                if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
            } else
            {
                return;
            }
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Save();
                MessageBox.Show("База данных сохранена.");
            }
            else
            {
                MessageBox.Show("База данных не создана");
            }
        }
        // Обработчик пункта меню Open
        private void miOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактор данных для игры \"Верю-Не-Верю\".\nверсия 0.0.1\n(c) 2019", "О программе");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Сохраните свои данные";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                database.Save(saveFileDialog1.FileName);
            }
        }
    }
}
