using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Павел Корженко
 */

/*
 * 3. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 */
namespace task0803
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        StudentsToXml database;
        string dcsvFileName = "c:/Users/small/OneDrive/Documents/students.csv";
        string dXmlFileName = "c:/Users/small/OneDrive/Documents/students.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.csv)|*.csv|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadCsvFile(ofd.FileName);
            }
        }

        private void LoadCsvFile(string csvFileName)
        {
            if (File.Exists(csvFileName))
            {
                using (var reader = new StreamReader(csvFileName))
                {
                    database = new StudentsToXml();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        txtCsvBox.Text += line;
                        txtCsvBox.Text += "\n";
                        database.Add(values[0],
                            values[1],
                            values[2],
                            values[3],
                            values[4],
                            int.Parse(values[5]),
                            int.Parse(values[6]),
                            int.Parse(values[7]),
                            values[8]);
                    }
                }
                database.Save(dXmlFileName);
                txtXmlBox.Text = database.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCsvFile(dcsvFileName);
        }
    }
}
