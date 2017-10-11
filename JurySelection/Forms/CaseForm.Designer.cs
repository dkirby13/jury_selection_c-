namespace JurySelection.Forms
{
    partial class CaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jurorButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.holderPanel = new System.Windows.Forms.Panel();
            this.searchLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.sbutton = new System.Windows.Forms.Button();
            this.intPanel = new System.Windows.Forms.Panel();
            this.intComparatorTextBox = new System.Windows.Forms.TextBox();
            this.greateThanButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.lessThanButton = new System.Windows.Forms.Button();
            this.boolIntPanel = new System.Windows.Forms.Panel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answerComboBox = new System.Windows.Forms.ComboBox();
            this.questionComboBox1 = new System.Windows.Forms.ComboBox();
            this.searchCancelButton = new System.Windows.Forms.Button();
            this.groupQuestonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.askButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupquestionButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.legendpanel = new System.Windows.Forms.Panel();
            this.sb5 = new System.Windows.Forms.Label();
            this.sb3 = new System.Windows.Forms.Label();
            this.sb2 = new System.Windows.Forms.Label();
            this.sb4 = new System.Windows.Forms.Label();
            this.sb1 = new System.Windows.Forms.Label();
            this.jurorButtonPanel.SuspendLayout();
            this.holderPanel.SuspendLayout();
            this.searchLayoutPanel1.SuspendLayout();
            this.intPanel.SuspendLayout();
            this.boolIntPanel.SuspendLayout();
            this.groupQuestonPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.legendpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // jurorButtonPanel
            // 
            this.jurorButtonPanel.Controls.Add(this.holderPanel);
            this.jurorButtonPanel.Location = new System.Drawing.Point(133, 73);
            this.jurorButtonPanel.Name = "jurorButtonPanel";
            this.jurorButtonPanel.Size = new System.Drawing.Size(1038, 449);
            this.jurorButtonPanel.TabIndex = 0;
            // 
            // holderPanel
            // 
            this.holderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holderPanel.Controls.Add(this.searchLayoutPanel1);
            this.holderPanel.Controls.Add(this.groupQuestonPanel);
            this.holderPanel.Location = new System.Drawing.Point(3, 3);
            this.holderPanel.Name = "holderPanel";
            this.holderPanel.Size = new System.Drawing.Size(733, 320);
            this.holderPanel.TabIndex = 5;
            this.holderPanel.Visible = false;
            // 
            // searchLayoutPanel1
            // 
            this.searchLayoutPanel1.Controls.Add(this.searchLabel);
            this.searchLayoutPanel1.Controls.Add(this.typeComboBox);
            this.searchLayoutPanel1.Controls.Add(this.sbutton);
            this.searchLayoutPanel1.Controls.Add(this.intPanel);
            this.searchLayoutPanel1.Controls.Add(this.boolIntPanel);
            this.searchLayoutPanel1.Controls.Add(this.searchCancelButton);
            this.searchLayoutPanel1.Location = new System.Drawing.Point(204, 54);
            this.searchLayoutPanel1.Name = "searchLayoutPanel1";
            this.searchLayoutPanel1.Size = new System.Drawing.Size(500, 247);
            this.searchLayoutPanel1.TabIndex = 7;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchLabel.Location = new System.Drawing.Point(3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(131, 25);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "T/F",
            "Number",
            "Word"});
            this.typeComboBox.Location = new System.Drawing.Point(140, 3);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 1;
            // 
            // sbutton
            // 
            this.sbutton.Location = new System.Drawing.Point(267, 3);
            this.sbutton.Name = "sbutton";
            this.sbutton.Size = new System.Drawing.Size(75, 23);
            this.sbutton.TabIndex = 4;
            this.sbutton.Text = "Search";
            this.sbutton.UseVisualStyleBackColor = true;
            // 
            // intPanel
            // 
            this.intPanel.Controls.Add(this.intComparatorTextBox);
            this.intPanel.Controls.Add(this.greateThanButton);
            this.intPanel.Controls.Add(this.equalButton);
            this.intPanel.Controls.Add(this.lessThanButton);
            this.intPanel.Location = new System.Drawing.Point(3, 33);
            this.intPanel.Name = "intPanel";
            this.intPanel.Size = new System.Drawing.Size(200, 71);
            this.intPanel.TabIndex = 8;
            // 
            // intComparatorTextBox
            // 
            this.intComparatorTextBox.Location = new System.Drawing.Point(48, 46);
            this.intComparatorTextBox.MaxLength = 4;
            this.intComparatorTextBox.Name = "intComparatorTextBox";
            this.intComparatorTextBox.Size = new System.Drawing.Size(100, 22);
            this.intComparatorTextBox.TabIndex = 3;
            this.intComparatorTextBox.Text = "Enter Number";
            // 
            // greateThanButton
            // 
            this.greateThanButton.Location = new System.Drawing.Point(131, 4);
            this.greateThanButton.Name = "greateThanButton";
            this.greateThanButton.Size = new System.Drawing.Size(58, 23);
            this.greateThanButton.TabIndex = 2;
            this.greateThanButton.Text = ">";
            this.greateThanButton.UseVisualStyleBackColor = true;
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(67, 4);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(58, 23);
            this.equalButton.TabIndex = 1;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            // 
            // lessThanButton
            // 
            this.lessThanButton.Location = new System.Drawing.Point(3, 4);
            this.lessThanButton.Name = "lessThanButton";
            this.lessThanButton.Size = new System.Drawing.Size(58, 23);
            this.lessThanButton.TabIndex = 0;
            this.lessThanButton.Text = "<";
            this.lessThanButton.UseVisualStyleBackColor = true;
            // 
            // boolIntPanel
            // 
            this.boolIntPanel.Controls.Add(this.answerLabel);
            this.boolIntPanel.Controls.Add(this.label2);
            this.boolIntPanel.Controls.Add(this.answerComboBox);
            this.boolIntPanel.Controls.Add(this.questionComboBox1);
            this.boolIntPanel.Location = new System.Drawing.Point(209, 33);
            this.boolIntPanel.Name = "boolIntPanel";
            this.boolIntPanel.Size = new System.Drawing.Size(200, 129);
            this.boolIntPanel.TabIndex = 9;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(19, 92);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(85, 17);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "Answer(T/F)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question";
            // 
            // answerComboBox
            // 
            this.answerComboBox.FormattingEnabled = true;
            this.answerComboBox.Location = new System.Drawing.Point(18, 62);
            this.answerComboBox.Name = "answerComboBox";
            this.answerComboBox.Size = new System.Drawing.Size(121, 24);
            this.answerComboBox.TabIndex = 1;
            // 
            // questionComboBox1
            // 
            this.questionComboBox1.FormattingEnabled = true;
            this.questionComboBox1.Items.AddRange(new object[] {
            "T",
            "F"});
            this.questionComboBox1.Location = new System.Drawing.Point(18, 3);
            this.questionComboBox1.Name = "questionComboBox1";
            this.questionComboBox1.Size = new System.Drawing.Size(121, 24);
            this.questionComboBox1.TabIndex = 0;
            // 
            // searchCancelButton
            // 
            this.searchCancelButton.Location = new System.Drawing.Point(415, 33);
            this.searchCancelButton.Name = "searchCancelButton";
            this.searchCancelButton.Size = new System.Drawing.Size(75, 23);
            this.searchCancelButton.TabIndex = 11;
            this.searchCancelButton.Text = "Cancel";
            this.searchCancelButton.UseVisualStyleBackColor = true;
            // 
            // groupQuestonPanel
            // 
            this.groupQuestonPanel.Controls.Add(this.cancelButton);
            this.groupQuestonPanel.Controls.Add(this.askButton);
            this.groupQuestonPanel.Controls.Add(this.textBox1);
            this.groupQuestonPanel.Controls.Add(this.label1);
            this.groupQuestonPanel.Location = new System.Drawing.Point(60, 54);
            this.groupQuestonPanel.Name = "groupQuestonPanel";
            this.groupQuestonPanel.Size = new System.Drawing.Size(200, 169);
            this.groupQuestonPanel.TabIndex = 1;
            this.groupQuestonPanel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(123, 81);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // askButton
            // 
            this.askButton.Location = new System.Drawing.Point(62, 110);
            this.askButton.Name = "askButton";
            this.askButton.Size = new System.Drawing.Size(82, 32);
            this.askButton.TabIndex = 2;
            this.askButton.Text = "Ask";
            this.askButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(58, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.caseNameLabel.Location = new System.Drawing.Point(532, 27);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(95, 36);
            this.caseNameLabel.TabIndex = 0;
            this.caseNameLabel.Text = "label1";
            this.caseNameLabel.Click += new System.EventHandler(this.caseNameLabel_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.searchButton);
            this.sidePanel.Controls.Add(this.groupquestionButton);
            this.sidePanel.Controls.Add(this.button4);
            this.sidePanel.Controls.Add(this.button3);
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Location = new System.Drawing.Point(1, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 542);
            this.sidePanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(-3, 165);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(200, 47);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search Jurors";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupquestionButton
            // 
            this.groupquestionButton.Location = new System.Drawing.Point(0, 248);
            this.groupquestionButton.Name = "groupquestionButton";
            this.groupquestionButton.Size = new System.Drawing.Size(200, 47);
            this.groupquestionButton.TabIndex = 4;
            this.groupquestionButton.Text = "Ask Group Question";
            this.groupquestionButton.UseVisualStyleBackColor = true;
            this.groupquestionButton.Click += new System.EventHandler(this.groupquestionButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save Case";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Export Case";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rename Case";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back to Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.AutoSize = true;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.doneButton.Location = new System.Drawing.Point(1024, 22);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(96, 46);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // legendpanel
            // 
            this.legendpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legendpanel.Controls.Add(this.sb5);
            this.legendpanel.Controls.Add(this.sb3);
            this.legendpanel.Controls.Add(this.sb2);
            this.legendpanel.Controls.Add(this.sb4);
            this.legendpanel.Controls.Add(this.sb1);
            this.legendpanel.Location = new System.Drawing.Point(292, 528);
            this.legendpanel.Name = "legendpanel";
            this.legendpanel.Size = new System.Drawing.Size(200, 100);
            this.legendpanel.TabIndex = 4;
            this.legendpanel.Visible = false;
            // 
            // sb5
            // 
            this.sb5.Location = new System.Drawing.Point(132, 41);
            this.sb5.Name = "sb5";
            this.sb5.Size = new System.Drawing.Size(46, 17);
            this.sb5.TabIndex = 4;
            this.sb5.Text = "label7";
            // 
            // sb3
            // 
            this.sb3.Location = new System.Drawing.Point(132, 15);
            this.sb3.Name = "sb3";
            this.sb3.Size = new System.Drawing.Size(46, 17);
            this.sb3.TabIndex = 3;
            this.sb3.Text = "label6";
            // 
            // sb2
            // 
            this.sb2.Location = new System.Drawing.Point(63, 15);
            this.sb2.Name = "sb2";
            this.sb2.Size = new System.Drawing.Size(46, 17);
            this.sb2.TabIndex = 2;
            this.sb2.Text = "label5";
            // 
            // sb4
            // 
            this.sb4.Location = new System.Drawing.Point(23, 41);
            this.sb4.Name = "sb4";
            this.sb4.Size = new System.Drawing.Size(46, 17);
            this.sb4.TabIndex = 1;
            this.sb4.Text = "label4";
            // 
            // sb1
            // 
            this.sb1.Location = new System.Drawing.Point(3, 15);
            this.sb1.Name = "sb1";
            this.sb1.Size = new System.Drawing.Size(46, 17);
            this.sb1.TabIndex = 0;
            this.sb1.Text = "Help";
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 628);
            this.Controls.Add(this.legendpanel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.caseNameLabel);
            this.Controls.Add(this.jurorButtonPanel);
            this.Name = "CaseForm";
            this.Text = "CaseForm";
            this.jurorButtonPanel.ResumeLayout(false);
            this.holderPanel.ResumeLayout(false);
            this.searchLayoutPanel1.ResumeLayout(false);
            this.searchLayoutPanel1.PerformLayout();
            this.intPanel.ResumeLayout(false);
            this.intPanel.PerformLayout();
            this.boolIntPanel.ResumeLayout(false);
            this.boolIntPanel.PerformLayout();
            this.groupQuestonPanel.ResumeLayout(false);
            this.groupQuestonPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.legendpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel jurorButtonPanel;
        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button groupquestionButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel holderPanel;
        private System.Windows.Forms.Panel groupQuestonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button askButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel searchLayoutPanel1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button sbutton;
        private System.Windows.Forms.Panel intPanel;
        private System.Windows.Forms.TextBox intComparatorTextBox;
        private System.Windows.Forms.Button greateThanButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button lessThanButton;
        private System.Windows.Forms.Panel boolIntPanel;
        private System.Windows.Forms.ComboBox answerComboBox;
        private System.Windows.Forms.ComboBox questionComboBox1;
        private System.Windows.Forms.Button searchCancelButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel legendpanel;
        private System.Windows.Forms.Label sb5;
        private System.Windows.Forms.Label sb3;
        private System.Windows.Forms.Label sb2;
        private System.Windows.Forms.Label sb4;
        private System.Windows.Forms.Label sb1;
    }
}