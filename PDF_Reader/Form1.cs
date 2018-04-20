using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PDF_Reader
{
    public partial class Pdf_form : Form
    {
        public Pdf_form()
        {
            InitializeComponent();
        }

        private void Open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            if (File.ShowDialog()==DialogResult.OK)
            {
                axAcroPDF1.src = File.FileName;
            }
        }

        private void Other_files_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            if (File.ShowDialog()==DialogResult.OK)
            {
                String FilePath = File.FileName;
                Process.Start(FilePath);
            }
        }
    }
}
