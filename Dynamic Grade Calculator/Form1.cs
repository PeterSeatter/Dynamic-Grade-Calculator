using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dynamic_Grade_Calculator
{
    
    public partial class MainForm : Form
    {
        private string subjectName;
        private int subjectNameLength;

        public MainForm()
        {
            InitializeComponent();
        }

        private void numberOfPapersInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows the input of whole numbers.
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void nameOfSubjectInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (char.IsControl(e.KeyChar)))
            {
                e.Handled = true;                
            }  

            subjectName = nameOfSubjectInput.Text;            
            subjectNameLength = nameOfSubjectInput.TextLength;
            
        }

        private void numberOfPapersInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numberOfPapersInput.Text))
            {
                e.Cancel = true;
                numberOfPapersInput.Focus();
                errorProviderPaperNumbers.SetError(numberOfPapersInput, "Please enter the number of papers!");
                MessageBox.Show(numberOfPapersInput, "Please enter the number of papers!");
            }
            else
            {
                e.Cancel = false;
                errorProviderPaperNumbers.SetError(numberOfPapersInput, "");
            }
        }

        private void generateTable_Click(object sender, EventArgs e)
        {            
            TabPage newTab = new TabPage(subjectName);
            Debug.WriteLine(subjectName);
            Debug.WriteLine(subjectNameLength);
            tabControl1.TabPages.Add(newTab);
            Debug.WriteLine(numberOfPapersInput);
        }

        private void nameOfSubjectInput_Validating(object sender, CancelEventArgs e)
        {
            if (subjectName.Equals(subjectNameLength))
            {
                e.Cancel = true;
                nameOfSubjectInput.Focus();
                errorProviderSubjectName.SetError(nameOfSubjectInput, "Please press either space or enter");
                MessageBox.Show(nameOfSubjectInput, "Press enter or space");
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
