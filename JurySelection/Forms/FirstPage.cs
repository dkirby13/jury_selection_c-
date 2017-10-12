using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JurySelection.Logic_Objects;
using JurySelection.Forms;

namespace JurySelection
{
    public partial class Form1 : Form
    {
        private List<CheckBox> checkboxes;
        private int _dumbcheck = 0;
        public Form1()
        {
            InitializeComponent();
            noOfJurorsTextBox.Hide();
            caseNameTextbox.Hide();
            caseNameTextbox.GotFocus += new EventHandler(caseNameTextbox_Focus);
            noOfJurorsTextBox.GotFocus += new EventHandler(noOfJurorsTextBox_Focus);
            noOfJurorsTextBox.MaxLength = 2;
            noOfJurorsTextBox.KeyPress += new KeyPressEventHandler(newCaseButton_KeyPress);
            createCaseButton.Hide();
            FormClosed += new FormClosedEventHandler(t_FormClosed);
            checkboxes = new List<CheckBox>();
            foreach(Control c in panel1.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                    checkboxes.Add((CheckBox)c);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected void caseNameTextbox_Focus(Object sender, EventArgs e)
        {
            _dumbcheck++;
            caseNameTextbox.Text = "";
        }

        protected void noOfJurorsTextBox_Focus(Object sender, EventArgs e)
        {
            _dumbcheck++;
            noOfJurorsTextBox.Text = "";
        }

        private void newCaseButton_Click(object sender, EventArgs e)
        {
            loadCaseButton.Enabled = false;
            panel1.Show();
            newCaseButton.BackColor = Color.LightBlue;
            caseNameTextbox.Show();
            noOfJurorsTextBox.Show();
            createCaseButton.Show();
        }

        private void newCaseButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void createCaseButton_Click(object sender, EventArgs e)
        {
            if (_dumbcheck < 2 || noOfJurorsTextBox.Text == "" || caseNameTextbox.Text == "")
                MessageBox.Show(this, "Please Fill in the Case Name and Number of Jurors",
                    "Not All Informatin Given", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                List<Info> i = new List<Info>();
                foreach(CheckBox cb in checkboxes)
                    if (cb.Checked)
                        i.Add(new Info(cb.Text));
                Case theCase = new Case(caseNameTextbox.Text, Convert.ToInt32(noOfJurorsTextBox.Text));
                CaseForm theCaseForm = new CaseForm(theCase, i);
                theCaseForm.Location = Location;
                theCaseForm.Size = Size;
                theCaseForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.Hide();
                theCaseForm.Show();
            }
            
        }

        void t_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addAllButton_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if(c.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = c as CheckBox;
                    cb.Checked = true;
                }
            }
        }

        private void loadCaseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\JurySelectionHelper";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Case theCase = new Case(openFileDialog.FileName);
                CaseForm theCaseForm = new CaseForm(theCase, null);
                theCaseForm.Location = Location;
                theCaseForm.Size = Size;
                theCaseForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.Hide();
                theCaseForm.Show();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            newCaseButton.BackColor = SystemColors.Control;
            loadCaseButton.Enabled = true;
            panel1.Hide();
            foreach(Control c in  panel1.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = c as CheckBox;
                    cb.Checked = false;
                }
            }
            createCaseButton.Hide();
            noOfJurorsTextBox.Hide();
            noOfJurorsTextBox.Text = "No. of Jurors";
            caseNameTextbox.Hide();
            caseNameTextbox.Text = "Case Name";
            
        }
    }
}
