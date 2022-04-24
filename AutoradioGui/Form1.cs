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

namespace AutoradioGui
{
    public partial class Form1 : Form
    {
        private readonly FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();
        private readonly NameCorrector _nameCorrector = new NameCorrector();
        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void _btnSelectFolder_Click(object sender, EventArgs e)
        {
            var result = _folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = _folderBrowserDialog.SelectedPath;
                path = Path.GetFullPath(path);
                StringBuilder sb = new StringBuilder();
                //files first
                foreach (string s in _nameCorrector.CorrectDirectories(_nameCorrector.GetAllDirectories(path)).Reverse())
                {
                    sb.AppendLine(s);
                }

                _rtbResult.Text = sb.ToString();
            }
        }
    }
}