using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MultiEditor
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            //Init Material design
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            var fileNameBox = filePicker;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = false,
                ShowReadOnly = false
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameBox.Text = openFileDialog1.FileName;
            }
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            var fileSelector = filePicker;
            var stringA = txtStringA;
            var stringB = txtStringB;
            ShowStep2(false);
            if(fileSelector.Text.Length < 1)
            {
                MessageBox.Show("Please select a file!");
                return;
            }
            if(stringA.Text.Trim().Length < 1)
            {
                MessageBox.Show("Please input search string!");
                stringA.Text = string.Empty;
                return;
            }
            if(stringB.Text.Length < 1)
            {
                var selectedOption = MessageBox.Show("The replacing string is blank. The search string will be cleared on clicking replace button. Continue?", "Action requested", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(selectedOption == DialogResult.Yes)
                {
                    //Search for stringA in the File.
                    SearchStringInFile();
                }
            }
            SearchStringInFile();
        }

        private void SearchStringInFile()
        {
            var filePath = filePicker.Text;
            var stringA = txtStringA.Text;
            var stringB = txtStringB.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File doesn't exist anymore, please select any other file to continue.");
                lblSuccess.Text = "Failed";
                lblSuccess.BackColor = Color.Red;
                lblSuccess.Visible = true;
                return;
            }
            SearchAlgo(filePath, stringA);
        }

        private void SearchAlgo(string filePath, string stringA)
        {
            
            var count = 0;
            var positions = string.Empty;
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //TODO fix the search logic!!
                    if (line.Contains(stringA))
                    {
                        count++;
                        positions += line.IndexOfAny(stringA.ToCharArray()) > -1 ? line.IndexOfAny(stringA.ToCharArray()).ToString() + ", " : string.Empty;
                    }
                }
            }
            lblCount.Text = count.ToString();
            lblPositions.Text = positions;
            lblSuccess.Text = "Success";
            lblSuccess.BackColor = Color.Green;
            ShowStep2(true);
        }
        public void ShowStep2(bool toShow)
        {
            lbl4.Visible = toShow;
            lblCount.Visible = toShow;
            lbl5.Visible = toShow;
            lblPositions.Visible = toShow;
            lblSuccess.Visible = toShow;
        }
    }
}
