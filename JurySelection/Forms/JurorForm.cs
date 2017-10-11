using JurySelection.Logic_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurySelection.Forms
{
    public partial class JurorForm : Form
    {
        private int button_clicked;
        public Panel panel;
        TextBox answerTextbox;
        TextBox questionTextbox;
        public Juror TheJuror { get; set; }
        public CaseForm TheCaseForm { get; set; }
        public JurorForm(Juror j)
        
        {
            
            panel = new Panel();
            answerTextbox = new TextBox();
            questionTextbox = new TextBox();
            TheJuror = j;
            FormClosed += new FormClosedEventHandler(t_FormClosed);
            InitializeComponent();
            cancelButton.Focus();
            
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
            this.SizeChanged += new EventHandler(sizeChanged);
            jurorNumber.Text = "Juror " + j.Number.ToString();
            jurorNumber.Location = new Point((int)(Width * .5), (int)(Height * .08));
            tableLayoutPanel.ControlAdded += new ControlEventHandler(scrollbaradded);
            UpdateInformation();
            UpdateLikeStatus(j.TheLikeState);
            addButton.Width = (tableLayoutPanel.Width);
            addButton.Height = (int)(addButton.Width / 1.6);
            addButton.Location = new Point(jurorNumber.Location.X, (int)(Height * .72));
        }
        private void scrollbaradded(object sender, EventArgs e)
        {
            tableLayoutPanel.HorizontalScroll.Enabled = false;
            tableLayoutPanel.HorizontalScroll.Visible = false;
        }

        private void UpdateButtonClicked(object sender, EventArgs e)
        {
            tableLayoutPanel.Enabled = false;
            addButton.Enabled = false;
            sidePanel.Enabled = false ;
            Button b = sender as Button;
            button_clicked = (int)b.Tag;
            questionLabel.Text = TheJuror.TheInfo[button_clicked].Question;
            answerLabel.Text = TheJuror.TheInfo[button_clicked].Answer;
            if (answerLabel.Text == "")
                answerLabel.Size = questionLabel.Size;
            updatePanel.Show();
            updatePanel.BringToFront();
        }

        private void sizeChanged(Object sender, EventArgs e)
        {
            newPanel.Width = (int)(Width * .4);
            newPanel.Height = (int)(Height * .4);
            panel1.Location = new Point(
                newPanel.Width / 2 - panel1.Width / 2,
                newPanel.Height / 2 - panel1.Height / 2
                );
            panel1.Anchor = AnchorStyles.None;
            jurorNumber.Location = new Point((int)(Width * .5), (int)(Height * .08));
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
            tableLayoutPanel.Location = new Point((int)(.3 * Size.Width), (int)(.25 * Size.Height));
            tableLayoutPanel.Width = (int)(.6 * Size.Width);
            panel.Width = (int)(Width * .33 * 1.6);
            panel.Height = (int)(Width * .33);
            panel.Location = new Point(panel.Width, panel.Width);
            addButton.Width = (tableLayoutPanel.Width);
            addButton.Height = (int)(Height * .2);
            addButton.Location = new Point(tableLayoutPanel.Location.X, (int)(Height * .72));
            //addButton.Font = jurorNumber.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (updateButton.Text.ToLower() == "update")
            {
                updateButton.Text = "Save";
                answerTextbox.Width = answerLabel.Width;
                answerTextbox.Height = answerLabel.Height + 10;
                answerTextbox.Location = answerLabel.Location;
                answerTextbox.Text = answerLabel.Text;
                answerLabel.Hide();
                updatePanel.Controls.Add(answerTextbox);
                answerTextbox.Show();
                questionTextbox.Width = questionLabel.Width;
                questionTextbox.Height = questionLabel.Height + 10;
                questionTextbox.Multiline = true;
                answerTextbox.Multiline = true;
                questionTextbox.Location = questionLabel.Location;
                questionTextbox.Text = questionLabel.Text;
                questionLabel.Hide();
                if (answerTextbox.Text == "")
                    answerTextbox.Size = questionTextbox.Size;
                updatePanel.Controls.Add(questionTextbox);
                questionTextbox.Show();

                answerTextbox.TextChanged += (s, ev) =>
                {
                    Size size = TextRenderer.MeasureText(answerTextbox.Text, answerTextbox.Font);
                    answerTextbox.Width = size.Width;
                    answerTextbox.Height = size.Height + 10;
                   
                };

                questionTextbox.TextChanged += (s, ev) =>
                {
                    Size size = TextRenderer.MeasureText(questionTextbox.Text, questionTextbox.Font);
                    questionTextbox.Width = size.Width;
                    questionTextbox.Height = size.Height + 10;
                };



            }
            else
            {
                updateButton.Text = "Update";
                TheJuror.TheInfo[button_clicked].Question = questionTextbox.Text;
                TheJuror.TheInfo[button_clicked].SetAnswer(answerTextbox.Text);
                answerTextbox.Hide();
                answerLabel.Show();
                questionTextbox.Hide();
                questionLabel.Show();
                updatePanel.Hide();
                sidePanel.Enabled = true;
                tableLayoutPanel.Enabled = true;
                addButton.Enabled = true;
                UpdateInformation();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Are you sure you want to delete this information", 
                "Delete Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TheJuror.TheInfo.RemoveAt(button_clicked);
                updatePanel.Hide();
                tableLayoutPanel.Enabled = true;
                addButton.Enabled = true;
                sidePanel.Enabled = true;
                UpdateInformation();
            }
        }

     

        private void UpdateInformation()
        {
            tableLayoutPanel.Hide();
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 0;
            for (int i = 0; i < TheJuror.TheInfo.Count; i++)
            {
                tableLayoutPanel.RowCount++;
                //tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel.Controls.Add(new Label()
                {
                    Text = TheJuror.TheInfo[i].Question,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true
                }, 0, i);
                tableLayoutPanel.Controls.Add(new Label()
                {
                    Text = TheJuror.TheInfo[i].Answer,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true
                }, 1, i);
                Button button = new Button();
                button.Text = "Update";
                button.Tag = i;
                button.BackColor = SystemColors.Control;
                button.Click += new EventHandler(UpdateButtonClicked);
                tableLayoutPanel.Controls.Add(button, 2, i);
            }
            tableLayoutPanel.Location = new Point((int)(.3 * Size.Width), (int)(.25 * Size.Height));
            tableLayoutPanel.Width = (int)(.6 * Size.Width);
            if (TheJuror.TheInfo.Count == 0)
            {
                jurorNumber.Text = jurorNumber.Text + "(No Information)";
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            }
            else
            {
                jurorNumber.Text = "Juror " + TheJuror.Number.ToString();
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            }
            scrollbaradded(null, null);
            tableLayoutPanel.HorizontalScroll.Visible = false;
            tableLayoutPanel.HorizontalScroll.Enabled = false;
            tableLayoutPanel.Show();
            tableLayoutPanel.HorizontalScroll.Enabled = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newButton.Click -= newButton_Click;
            button1.Click -= button1_Click_1;
            if (MessageBox.Show(this, "Is this Information Correct?", "Information Correct?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TheJuror.TheInfo.Add(new Info(textBox1.Text, textBox2.Text));
                newPanel.Hide();
                tableLayoutPanel.Enabled = true;
                addButton.Enabled = true;
                sidePanel.Enabled = true;
                UpdateInformation();
            }
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Question";
            textBox2.Text = "Answer";
            textBox1.TextChanged += (s, ev) =>
            {
                Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
                textBox1.Width = size.Width;
                textBox1.Height = size.Height + 10;
            };
            textBox2.TextChanged += (s, ev) =>
            {
                Size size = TextRenderer.MeasureText(textBox2.Text, textBox2.Font);
                textBox2.Width = size.Width;
                textBox2.Height = size.Height + 10;
                if ((answerTextbox.Location.X + answerTextbox.Width) -
                   (panel1.Location.X + panel1.Width) > 0 && ((panel1.Location.X + panel1.Width) + 10 < Width))
                {
                    panel1.Width += 10;
                }
            };
            //newPanel.Controls.Clear();
            Controls.Add(newPanel);
            newPanel.Width = (int)(Width * .4);
            newPanel.Height = (int)(Height * .4);
           
            
            panel1.Location = new Point(
                newPanel.Width/2 - panel1.Width / 2,
                newPanel.Height / 2 - panel1.Height / 2
                );
            newButton.Click += newButton_Click;
            button1.Click += button1_Click_1;
            panel1.Anchor = AnchorStyles.None;
            tableLayoutPanel.Enabled = false;
            sidePanel.Enabled = false;
            addButton.Enabled = false;
            newPanel.Controls.Add(panel1);
            newPanel.Show();
            newPanel.BringToFront();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(updateButton.Text == "Save")
            {
                updateButton.Text = "Update";
                questionLabel.Show();
                questionTextbox.Hide();
                answerLabel.Show();
                answerTextbox.Show();
            }
            updatePanel.Hide();
            tableLayoutPanel.Enabled = true;
            addButton.Enabled = true;
            sidePanel.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            newButton.Click -= newButton_Click;
            button1.Click -= button1_Click_1;
            newPanel.Hide();
            tableLayoutPanel.Enabled = true;
            addButton.Enabled = true;
            sidePanel.Enabled = true;
        }

        void t_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            TheCaseForm.Location = Location;
            TheCaseForm.Size = Size;
            TheCaseForm.Show();
            this.FormClosed -= t_FormClosed;
            this.Close();
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            if (TheJuror.TheLikeState != Juror.LikeState.Like)
                UpdateLikeStatus(Juror.LikeState.Like);
            else
                UpdateLikeStatus(Juror.LikeState.Neutral);

        }

        private void UpdateLikeStatus(Juror.LikeState likeState)
        {
            TheJuror.TheLikeState = likeState;
            if(likeState == Juror.LikeState.Like)
            {
                likeButton.Text = "Unlike Juror";
                dislikeButton.Text = "Dislike Button";
                BackColor = Color.LightBlue;
            }

            else if(likeState == Juror.LikeState.Dislike)
            {
                likeButton.Text = "Like Juror";
                dislikeButton.Text = "Undislike Juror";
                BackColor = Color.LightCoral;
            }

            else
            {
                likeButton.Text = "Like Juror";
                dislikeButton.Text = "Dislike Button";
                BackColor = SystemColors.Control;
            }
        }

        private void dislikeButton_Click(object sender, EventArgs e)
        {
            if (TheJuror.TheLikeState != Juror.LikeState.Dislike)
                UpdateLikeStatus(Juror.LikeState.Dislike);
            else
                UpdateLikeStatus(Juror.LikeState.Neutral);
        }

        private void deleteJurorButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete this juror?",
                "Delete juror?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TheJuror.Deleted = true;
                backButton_Click(null, null);
            }
        }

        private void newButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
