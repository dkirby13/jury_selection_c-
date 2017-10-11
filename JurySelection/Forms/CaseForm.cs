﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JurySelection.Logic_Objects;
using System.Reflection;

namespace JurySelection.Forms
{
    public partial class CaseForm : Form
    {
        int numberOfSearchs;
        List<Color> colors;
        List<Label> searchButtons;
        string GroupQuestion;
        Dictionary<String, List<String>> QandAs;
        private bool inGroupMode;
        private bool inSearchMode;
        public Case TheCase { get; set; }
        public CaseForm(Case c, List<Info> DefaultInfo)
        {
            numberOfSearchs = 0;
            inGroupMode = false;
            inSearchMode = false;
            TheCase = c;
            InitializeComponent();
            TextBox textBox1 = new TextBox();
            textBox1.TabStop = false;
            textBox1.Focus();
            textBox1.Left = -300;
            this.Text = "Jury Selection Helper";
            this.SizeChanged += new EventHandler(sizeChanged);
            Activated += new EventHandler(theFormShowed);
            jurorButtonPanel.TabIndex = 0;
            caseNameLabel.Text = c.Name;
            sidePanel.Width = (int)(Width * .25);
            sidePanel.Height = Height;
            int h = 0;
            askButton.Click += askButton_Click;
            cancelButton.Click += cancelButton_Click;
            textBox1.Multiline = true;
            label1.Dock = DockStyle.Top;
            textBox1.Dock = DockStyle.Fill;
            cancelButton.Dock = DockStyle.Bottom;
            askButton.Dock = DockStyle.Bottom;
            textBox1.TextChanged += (s, ev) =>
            {
                Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
                textBox1.Width = size.Width;
                textBox1.Height = size.Height + 10;
            };
            questionComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            answerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            groupQuestonPanel.Controls.Add(askButton);
            groupQuestonPanel.Controls.Add(cancelButton);
            groupQuestonPanel.Controls.Add(textBox1);
            groupQuestonPanel.Controls.Add(label1);
            intComparatorTextBox.GotFocus += (s, e) =>
            {
                intComparatorTextBox.Text = "";
            };
            intComparatorTextBox.KeyPress += (s, e) =>
            {
                 if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                     e.Handled = true;
            };
            groupQuestonPanel.Dock = DockStyle.None;
            searchLabel.Dock = DockStyle.Top;
            searchCancelButton.Dock = DockStyle.Bottom;
            sbutton.Dock = DockStyle.Bottom;
            sbutton.Click += Sbutton_Click;
            typeComboBox.Dock = DockStyle.Top;
            intPanel.Dock = DockStyle.None;
            boolIntPanel.Dock = DockStyle.None;
            searchLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            searchLayoutPanel1.Dock = DockStyle.None;
            searchLayoutPanel1.Anchor = AnchorStyles.Top;
            searchCancelButton.Click += cancelButton_Click;
            typeComboBox.SelectedValueChanged += (s, e) =>
            {
                ComboBox comboBox = s as ComboBox;
                searchLabel.Text = "Search Type: " + (string)comboBox.SelectedItem;
                questionComboBox1.Text = "";
                answerComboBox.Text = "";
                if ((string)comboBox.SelectedItem == "Number")
                {
                    holderPanel.Controls.Clear();
                    //searchLayoutPanel1.Controls.Add(intPanel);
                    //searchLayoutPanel1.Controls.Add(searchLabel);
                    //searchLayoutPanel1.Controls.Add(searchCancelButton);
                    //searchLayoutPanel1.Controls.Add(typeComboBox);
                    holderPanel.Controls.Add(searchLayoutPanel1);
                    searchLayoutPanel1.Controls.Clear();
                    searchLayoutPanel1.Controls.Add(searchLabel);
                    searchLayoutPanel1.Controls.Add(typeComboBox);
                    searchLayoutPanel1.Controls.Add(intPanel);
                    searchLayoutPanel1.Controls.Add(sbutton);
                    searchLayoutPanel1.Controls.Add(searchCancelButton);
                }

                else if ((string)comboBox.SelectedItem == "T/F")
                {
                    answerLabel.Text = "Answer(T/F)";
                    holderPanel.Controls.Add(searchLayoutPanel1);
                    searchLayoutPanel1.Controls.Clear();
                    searchLayoutPanel1.Controls.Add(searchLabel);
                    searchLayoutPanel1.Controls.Add(typeComboBox);
                    searchLayoutPanel1.Controls.Add(boolIntPanel);
                    searchLayoutPanel1.Controls.Add(sbutton);
                    searchLayoutPanel1.Controls.Add(searchCancelButton);


                    answerComboBox.Items.Clear();
                    questionComboBox1.Items.Clear();
                    answerComboBox.Items.Add("True");
                    answerComboBox.Items.Add("False");
                    QandAs = TheCase.GetQADictionaryByType(Info.theType.aBool);
                    questionComboBox1.Items.AddRange(TheCase.GetQuestionsByType(Info.theType.aBool).ToArray());
                }

                else
                {
                    answerLabel.Text = "Answer";
                    holderPanel.Controls.Add(searchLayoutPanel1);
                    searchLayoutPanel1.Controls.Clear();
                    searchLayoutPanel1.Controls.Add(searchLabel);
                    searchLayoutPanel1.Controls.Add(typeComboBox);
                    searchLayoutPanel1.Controls.Add(boolIntPanel);
                    searchLayoutPanel1.Controls.Add(sbutton);
                    searchLayoutPanel1.Controls.Add(searchCancelButton);

                    answerComboBox.Items.Clear();
                    questionComboBox1.Items.Clear();
                    QandAs = TheCase.GetQADictionaryByType(Info.theType.aString);
                    questionComboBox1.Items.AddRange(QandAs.Keys.ToArray());
                    answerComboBox.Items.Add("Not filled in yet");
                   
                    
                }
            };
            foreach (Control con in sidePanel.Controls)
            {
                con.Width = sidePanel.Width;
                con.Height = (int)(sidePanel.Height * .1);
                con.Location = new Point(0, h);
                h = h + con.Height;
            }
            questionComboBox1.SelectedValueChanged += questionComboBoxValueChanged;
            sidePanel.Location = new Point(0, 0);
            caseNameLabel.Location = new Point((int)(Width * .5), (int)(Height * .08));
            jurorButtonPanel.Width = (int)(Width * .75);
            jurorButtonPanel.Height = (int)(Height * .75);
            jurorButtonPanel.Location = new Point((int)(Width * .25), (int)(Height * .15));
            FormClosed += new FormClosedEventHandler(t_FormClosed);
            int buttonWidth = (int)(Math.Sqrt((jurorButtonPanel.Width * jurorButtonPanel.Height)/TheCase.NumberOfJurors) * .8);
            int buttonHeight = (int)(Math.Sqrt((jurorButtonPanel.Width * jurorButtonPanel.Height) / TheCase.NumberOfJurors) * .8);
            for (int i = 1; i < TheCase.NumberOfJurors + 1; i++)
            {
                TheCase.TheJurors.Add(new Juror(i));
                foreach(Info info in DefaultInfo)
                {
                    TheCase.TheJurors[i - 1].TheInfo.Add(new Info(info.Question, info.Answer));
                }
                Button theButton = new Button();
                theButton.Text = i.ToString();
                theButton.Height = buttonHeight;
                theButton.Width = buttonWidth;
                theButton.Tag = 0;
                theButton.Click += new EventHandler(JurorButtonClicked);
                theButton.BackColor = Color.Gray;
                jurorButtonPanel.Controls.Add(theButton);
            }
            
            searchButtons = new List<Label>(new Label[] { sb1, sb2, sb3, sb4, sb5 });
            colors = new List<Color>(new Color[] { SystemColors.Control, Color.Gold, Color.ForestGreen, Color.CadetBlue, Color.Azure, Color.LightSalmon });


        }

        private void Sbutton_Click(object sender, EventArgs e)
        {

            numberOfSearchs++;
            if(numberOfSearchs > 3)
            {
                sbutton.Text = "Max 3 Searches";
                return;
            }
            if(typeComboBox.Text.ToLower() == "t/f")
            {
                if (questionComboBox1.Text == "" || answerComboBox.Text == "")
                {
                    MessageBox.Show(this, "Please enter all the neccesary search information", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SearchButtons(questionComboBox1.Text, answerComboBox.Text, Info.theType.aBool);

            }

            else if (typeComboBox.Text.ToLower() == "word")
            {
                if (questionComboBox1.Text == "" || answerComboBox.Text == "")
                {
                    MessageBox.Show(this, "Please enter all the neccesary search information", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SearchButtons(questionComboBox1.Text, answerComboBox.Text, Info.theType.aString);

            }

            else
            {

            }

            doneButton.Show();
            searchCancelButton.Hide();
            sbutton.Text = "Additional Search";
            legendpanel.Show();

        }

        private void SearchButtons(string question, string answer, Info.theType type)
        {
            int max = 0;
            foreach (Control c in jurorButtonPanel.Controls)
            {
                Button b = c as Button;
               
                Juror j = TheCase.TheJurors[Convert.ToInt16(b.Text) - 1];
                if(j.MeetsSearchCriteria(question, answer, type))
                {
                    int i = (int)c.Tag;
                    b.BackColor = colors[i + numberOfSearchs];
                    b.Tag = i + 1;
                    if (i > max)
                        max = i;
                }
                
            }

            //for (int n = max; n >= 0; n--)
            //    searchButtons[n].Visible = true; 

        }

        private void questionComboBoxValueChanged(object sender, EventArgs e)
        {
            
            answerComboBox.Items.Clear();
            answerComboBox.Items.Add("Not filled in yet");
            if (typeComboBox.Text.ToLower() == "word")
                answerComboBox.Items.AddRange(QandAs[(string)questionComboBox1.SelectedItem].ToArray());
            else
            {
                answerComboBox.Items.Add("True");
                answerComboBox.Items.Add("False");
            }
            answerComboBox.Text = "";
            
        }
        private void sizeChanged(Object sender, EventArgs e)
        {
           
            jurorButtonPanel.TabIndex = 0;
            sidePanel.Width = (int)(Width * .25);
            sidePanel.Height = Height;
            int h = 0;
            foreach (Control con in sidePanel.Controls)
            {
                con.Width = sidePanel.Width;
                con.Height = (int)(sidePanel.Height * .1);
                con.Location = new Point(0, h);
                h = h + con.Height;
            }
            sidePanel.Location = new Point(0, 0);
            jurorButtonPanel.Width = (int)(Width * .75);
            jurorButtonPanel.Height = (int)(Height * .75);
            caseNameLabel.Location = new Point((int)(Width * .5), (int)(Height * .08));
            jurorButtonPanel.Location = new Point((int)(Width * .25), (int)(Height * .15));
            int buttonWidth = (int)(Math.Sqrt((jurorButtonPanel.Width * jurorButtonPanel.Height) / TheCase.NumberOfJurors) * .8);
            int buttonHeight = (int)(Math.Sqrt((jurorButtonPanel.Width * jurorButtonPanel.Height) / TheCase.NumberOfJurors) * .8);
            List < int > ins = new List<int>();
            if (inSearchMode)
            {
                foreach (Control b in jurorButtonPanel.Controls)
                {
                    
                    ins.Add((int)b.Tag);
                }
            }
            jurorButtonPanel.Controls.Clear();
            for (int i = 1; i < TheCase.NumberOfJurors + 1; i++)
            {
                if (!TheCase.TheJurors[i - 1].Deleted)
                {
                    Button theButton = new Button();
                    theButton.Text = i.ToString();
                    theButton.Height = buttonHeight;
                    theButton.Width = buttonWidth;
                    if (inSearchMode)
                    {
                        theButton.Tag = ins[0];
                        theButton.BackColor = colors[ins[0] + numberOfSearchs - 1];
                        ins.RemoveAt(0);
                    }
                    else
                        theButton.Tag = 0;
                    theButton.Click += new EventHandler(JurorButtonClicked);
                    jurorButtonPanel.Controls.Add(theButton);
                   
                }
            }
            if (inGroupMode)
            {
                caseNameLabel.Location = new Point(caseNameLabel.Location.X - Width / 5, caseNameLabel.Location.Y);
                doneButton.Location = new Point(caseNameLabel.Location.X + caseNameLabel.Width + 10, caseNameLabel.Height);
                doneButton.Size = caseNameLabel.Size;
                holderPanel.Width = (int)(Width * .25);
                holderPanel.Height = (int)(Width * .25);
                holderPanel.Location = new Point(groupQuestonPanel.Width, (int)(Height * .25));
            }

            if(inSearchMode)
            {

            }
            
            legendpanel.Controls.Clear();
            legendpanel.Width = (int)(Width * .25);
            legendpanel.Height = Height - holderPanel.Height;
            h = legendpanel.Height;
            for (int i = 0; i < searchButtons.Count; i++)
            {
                searchButtons[i].BackColor = colors[i + 1];
                searchButtons[i].Width = legendpanel.Width;
                searchButtons[i].Height = (int)(legendpanel.Height * .2);
                searchButtons[i].Location = new Point(0, h);
                h = h + searchButtons[i].Height;
                legendpanel.Controls.Add(searchButtons[i]);
                searchButtons[i].Show();
                searchButtons[i].BringToFront();
            }
            legendpanel.Location = new Point(0, holderPanel.Height);
            Controls.Add(legendpanel);
            legendpanel.Show();
            legendpanel.BringToFront();
        }

        private void JurorButtonClicked(Object sender, EventArgs e)
        {
            Button b = sender as Button;
            Juror j = TheCase.TheJurors[Convert.ToInt32(b.Text) - 1];
            if (inGroupMode)
            {
                b.BackColor = Color.Gray;
                return;
            }

            if(inSearchMode)
            {
                return;
            }
            JurorForm jurorForm = new JurorForm(j);
            jurorForm.Location = Location;
            jurorForm.Size = Size;
            
            //jurorForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            jurorForm.TheCaseForm = this;
            jurorForm.Show();
            this.Hide();
            
        }


        void t_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void theFormShowed(object sender, EventArgs e)
        {
            List<int> ins = new List<int>();
            if (inSearchMode)
            {
                foreach (Control b in jurorButtonPanel.Controls)
                {

                    ins.Add((int)b.Tag);
                }
            }
            jurorButtonPanel.Controls.Clear();
            int buttonWidth = (int)(Math.Sqrt((jurorButtonPanel.Width * jurorButtonPanel.Height) / TheCase.NumberOfJurors) * .8);
            int buttonHeight = (int)(Math.Sqrt((jurorButtonPanel.Width * jurorButtonPanel.Height) / TheCase.NumberOfJurors) * .8);

            for (int i = 1; i < TheCase.NumberOfJurors + 1; i++)
            {
                if (!TheCase.TheJurors[i - 1].Deleted)
                {
                    Button theButton = new Button();
                    theButton.Text = i.ToString();
                    theButton.Height = buttonHeight;
                    theButton.Width = buttonWidth;
                    if (inSearchMode)
                    {
                        theButton.Tag = ins[0];
                        theButton.BackColor = colors[ins[0] + numberOfSearchs - 1];
                        ins.RemoveAt(0);
                    }
                    else
                        theButton.Tag = 0;
                    theButton.Click += new EventHandler(JurorButtonClicked);
                    theButton.BackColor = Color.Gray;
                    jurorButtonPanel.Controls.Add(theButton);
                }
            }

            if (TheCase == null || TheCase.TheJurors == null)
                return;
            if (!inSearchMode)
            {
                foreach (Control b in jurorButtonPanel.Controls)
                {
                    Button button = b as Button;
                    b.Tag = 0;
                    Juror j = TheCase.TheJurors[Convert.ToInt16(button.Text) - 1];
                    if (j.TheLikeState == Juror.LikeState.Like)
                        b.BackColor = Color.LightBlue;
                    if (j.TheLikeState == Juror.LikeState.Dislike)
                        b.BackColor = Color.LightCoral;
                    if (j.TheLikeState == Juror.LikeState.Neutral)
                        b.BackColor = SystemColors.Control;
                }
            }
        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in jurorButtonPanel.Controls)
            {
                Button b = c as Button;


                Juror j = TheCase.TheJurors[Convert.ToInt16(b.Text) - 1];

                if (j.TheLikeState == Juror.LikeState.Like)
                    b.BackColor = Color.LightBlue;
                if (j.TheLikeState == Juror.LikeState.Dislike)
                    b.BackColor = Color.LightCoral;
                if (j.TheLikeState == Juror.LikeState.Neutral)
                    b.BackColor = SystemColors.Control;
                doneButton.Hide();
                caseNameLabel.Text = TheCase.Name;
                caseNameLabel.Enabled = true;
                sidePanel.Enabled = true;
                inGroupMode = false;
                inSearchMode = false;
                textBox1.Text = "";
                
            }
            caseNameLabel.Location = new Point((int)(Width * .5), (int)(Height * .08));
            holderPanel.Controls.Clear();
            holderPanel.Hide();
            ((TextBox)groupQuestonPanel.Controls[3]).Text = "";
            caseNameLabel.Click += caseNameLabel_Click;
            typeComboBox.Text = "";
            questionComboBox1.Text = "";
            answerComboBox.Text = "";
            searchLabel.Text = "Search Type";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            TextBox t = new TextBox();
            t.Size = caseNameLabel.Size;
            t.Location = caseNameLabel.Location;
            t.Text = caseNameLabel.Text;
            t.Font = caseNameLabel.Font;
            Controls.Add(t);
            t.Show();
            t.BringToFront();
            caseNameLabel.Hide();
            t.Focus();
            t.KeyDown += (s, events) =>
            {
                if (events.KeyCode == Keys.Enter)
                {
                    caseNameLabel.Text = t.Text;
                    t.Hide();
                    caseNameLabel.Location = t.Location;
                    caseNameLabel.Size = t.Size;
                    caseNameLabel.Show();
                }
            };
            t.LostFocus += (s, events) =>
            {
                caseNameLabel.Text = t.Text;
                t.Hide();
                caseNameLabel.Location = t.Location;
                caseNameLabel.Size = t.Size;
                caseNameLabel.Show();
            };

            t.TextChanged += (s, ev) =>
            {
                Size size = TextRenderer.MeasureText(t.Text, t.Font);
                t.Width = size.Width;
                t.Height = size.Height;
            };
        }

        private void caseNameLabel_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void groupquestionButton_Click(object sender, EventArgs e)
        {
            sidePanel.Enabled = false; 
            holderPanel.Controls.Clear();
            holderPanel.Width = (int)(Width * .25);
            holderPanel.Height = (int)(Width * .25);
            holderPanel.Location = new Point(groupQuestonPanel.Width, (int)(Height * .25));
            ((TextBox)(groupQuestonPanel.Controls[3])).Text = "";
            holderPanel.Controls.Add(groupQuestonPanel);
            groupQuestonPanel.Show();
            Controls.Add(holderPanel);
            holderPanel.Show();
            holderPanel.BringToFront();
            textBox1.Hide();
            
        }

        private void askButton_Click(object sender, EventArgs e)
        {
            caseNameLabel.Click -= caseNameLabel_Click;
            inGroupMode = true;
            groupQuestonPanel.Hide();
            holderPanel.Hide();
            caseNameLabel.Location = new Point(caseNameLabel.Location.X - Width / 5, 0);
            GroupQuestion = ((TextBox)(groupQuestonPanel.Controls[3])).Text;
            caseNameLabel.Text = GroupQuestion;
            doneButton.Location = new Point(caseNameLabel.Location.X + caseNameLabel.Width + 10, caseNameLabel.Height);
            doneButton.Size = caseNameLabel.Size;
            doneButton.Show();
            sidePanel.Enabled = false;
            foreach (Control c in jurorButtonPanel.Controls)
            {
                Button b = c as Button;
                b.BackColor = SystemColors.Control;
            }
            holderPanel.Controls.Clear();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            
            foreach(Control c in jurorButtonPanel.Controls)
            {
                Button b = c as Button;
                

                Juror j = TheCase.TheJurors[Convert.ToInt16(b.Text) - 1];
                if (inGroupMode)
                {
                    if (b.BackColor == Color.Gray)
                        j.TheInfo.Add(new Info((GroupQuestion), "True"));
                    else
                        j.TheInfo.Add(new Info(GroupQuestion, "False"));
                }

                if (j.TheLikeState == Juror.LikeState.Like)
                    b.BackColor = Color.LightBlue;
                if (j.TheLikeState == Juror.LikeState.Dislike)
                    b.BackColor = Color.LightCoral;
                if (j.TheLikeState == Juror.LikeState.Neutral)
                    b.BackColor = SystemColors.Control; 
            }
            doneButton.Hide();
            caseNameLabel.Text = TheCase.Name;
            caseNameLabel.Enabled = true;
            sidePanel.Enabled = true;
            inGroupMode = false;
            caseNameLabel.Location = new Point((int)(Width * .5), (int)(Height * .08));
            caseNameLabel.Click += caseNameLabel_Click;
            holderPanel.Controls.Clear();
            holderPanel.Hide();
            typeComboBox.Text = "";
            inSearchMode = false;
            numberOfSearchs = 0;
            sbutton.Text = "Search";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            sidePanel.Enabled = false;
            holderPanel.Controls.Clear();
            holderPanel.Width = (int)(Width * .25);
            holderPanel.Height = (int)(Width * .25);
            holderPanel.Location = new Point(0, 0);
            //holderPanel.Location = new Point(groupQuestonPanel.Width, (int)(Height * .25));
            searchLayoutPanel1.Dock = DockStyle.Fill;
            searchLayoutPanel1.Controls.Clear();
            searchLayoutPanel1.Controls.Add(searchLabel);
            searchLayoutPanel1.Controls.Add(typeComboBox);
            searchLayoutPanel1.Controls.Add(searchCancelButton);
            holderPanel.Controls.Add(searchLayoutPanel1);
            Controls.Add(holderPanel);
            holderPanel.Show();
            holderPanel.BringToFront();
            inSearchMode = true;
            legendpanel.Width = (int)(Width * .25);
            legendpanel.Height = Height- holderPanel.Height;
            legendpanel.Controls.Clear();
            int h = legendpanel.Height;
            for (int i = 0; i < 5; i++)
            {
                searchButtons[i].BackColor = colors[i + 1];
                searchButtons[i].Text = "Help";
                searchButtons[i].Width = legendpanel.Width;
                searchButtons[i].Height = (int)(legendpanel.Height * .2);
                searchButtons[i].Location = new Point(0, h);
                h = h + searchButtons[i].Height;
                legendpanel.Controls.Add(searchButtons[i]);
                searchButtons[i].BringToFront();


            }
            legendpanel.Location = new Point(0, holderPanel.Height);
            legendpanel.Show();
            legendpanel.BringToFront();
        }
    }
}
