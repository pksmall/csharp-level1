using System;
using System.Windows.Forms;

/*
 * Павел Корженко
 */

/*
 * 2. Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
 */
namespace task0802
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;
        string defaultFileName = "c:/Users/small/OneDrive/Documents/mydata.xml";
        // текущий вопрос
        int numQuest = 0;
        // наши очки
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                numQuest = 1;
                score = 0;
                lblScoreTxt.Text = string.Format("{0,-5}", score);
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            if (database.Count > numQuest)
            {
                if (database[numQuest - 1].trueFalse)
                {
                    score++;
                    lblScoreTxt.Text = string.Format("{0,-5}", score);
                }
                numQuest++;
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
            }
            else
            {
                // game over
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
                MessageBox.Show("Игра завершена. Спасибо.", "Собщение");
            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            if (database.Count > numQuest)
            {
                if (!database[numQuest - 1].trueFalse)
                {
                    score++;
                    lblScoreTxt.Text = string.Format("{0,-5}", score);
                }
                numQuest++;
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
            } else
            {
                // game over
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
                MessageBox.Show("Игра завершена. Спасибо.", "Собщение");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                numQuest = 1;
                score = 0;
                lblScoreTxt.Text = string.Format("{0,-5}", score);
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
            } else
            {
                MessageBox.Show("Загрузите данные.", "Собщение");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(defaultFileName))
            {
                database = new TrueFalse(defaultFileName);
                database.Load();
                numQuest = 1;
                score = 0;
                lblScoreTxt.Text = string.Format("{0,-5}", score);
                lblNumQTxt.Text = string.Format("{0,-5}", numQuest);
                txtQText.Text = database[numQuest - 1].text;
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Верю-Не-Верю\nВерси 0.0.1\n(c) 12/2019", "О программе");
        }
    }
}
