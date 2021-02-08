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

namespace SMS_Language
{
    public partial class Keywords : Form
    {
        public Keywords()
        {
            InitializeComponent();
        }

        private void Keywords_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (File.Exists("Abbreviations.txt") && File.Exists("Definitions.txt"))
            {
                string definition = txtDefinition.Text.Trim();
                string abbreviation = txtAbbreviation.Text.Trim();
                StreamWriter writer = new StreamWriter("Definitions.txt", true);
                using (writer)
                {
                    writer.WriteLine(definition);
                }
                StreamWriter writer1 = new StreamWriter("Abbreviations.txt", true);
                using (writer1)
                {
                    writer1.WriteLine(abbreviation);
                }
            }
            else
            {
                File.Create("Abbreviations.txt");
                File.Create("Definitions.txt");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            int i = 0;
            var defFiles = File.ReadLines("Definitions.txt");
            var abbFiles = File.ReadLines("Abbreviations.txt");

            foreach (string line in defFiles)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1[0, i].Value = line;
                i++;
            }
            i = 0;
            foreach (string line in abbFiles)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1[1, i].Value = line;
                i++;
            }
        }
    }
}
