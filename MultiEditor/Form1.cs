using MaterialSkin;
using MaterialSkin.Controls;
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
            if(fileSelector.Text.Length < 1)
            {
                MessageBox.Show("Please select a file!");
                return;
            }
            if(stringA.Text.Length < 1)
            {
                MessageBox.Show("Please input search string!");
                return;
            }
            if(stringB.Text.Length < 1)
            {
                MessageBox.Show("The replacing string is blank. The search string will be cleared on clicking replace button!");
            }

        }
    }
}
