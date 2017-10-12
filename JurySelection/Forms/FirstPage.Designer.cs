namespace JurySelection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.loadCaseButton = new System.Windows.Forms.Button();
            this.newCaseButton = new System.Windows.Forms.Button();
            this.caseNameTextbox = new System.Windows.Forms.TextBox();
            this.noOfJurorsTextBox = new System.Windows.Forms.TextBox();
            this.createCaseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addAllButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(418, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jury Selection Helper";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loadCaseButton
            // 
            this.loadCaseButton.Location = new System.Drawing.Point(458, 400);
            this.loadCaseButton.Name = "loadCaseButton";
            this.loadCaseButton.Size = new System.Drawing.Size(100, 48);
            this.loadCaseButton.TabIndex = 0;
            this.loadCaseButton.Text = "Load Case";
            this.loadCaseButton.UseVisualStyleBackColor = true;
            this.loadCaseButton.Click += new System.EventHandler(this.loadCaseButton_Click);
            // 
            // newCaseButton
            // 
            this.newCaseButton.Location = new System.Drawing.Point(458, 314);
            this.newCaseButton.Name = "newCaseButton";
            this.newCaseButton.Size = new System.Drawing.Size(100, 48);
            this.newCaseButton.TabIndex = 0;
            this.newCaseButton.Text = "New Case";
            this.newCaseButton.UseVisualStyleBackColor = true;
            this.newCaseButton.Click += new System.EventHandler(this.newCaseButton_Click);
            // 
            // caseNameTextbox
            // 
            this.caseNameTextbox.Location = new System.Drawing.Point(606, 327);
            this.caseNameTextbox.Name = "caseNameTextbox";
            this.caseNameTextbox.Size = new System.Drawing.Size(108, 22);
            this.caseNameTextbox.TabIndex = 3;
            this.caseNameTextbox.Text = "Case Name";
            // 
            // noOfJurorsTextBox
            // 
            this.noOfJurorsTextBox.Location = new System.Drawing.Point(765, 327);
            this.noOfJurorsTextBox.Name = "noOfJurorsTextBox";
            this.noOfJurorsTextBox.Size = new System.Drawing.Size(108, 22);
            this.noOfJurorsTextBox.TabIndex = 4;
            this.noOfJurorsTextBox.Text = "No. of Jurors";
            // 
            // createCaseButton
            // 
            this.createCaseButton.Location = new System.Drawing.Point(945, 326);
            this.createCaseButton.Name = "createCaseButton";
            this.createCaseButton.Size = new System.Drawing.Size(108, 23);
            this.createCaseButton.TabIndex = 5;
            this.createCaseButton.Text = "Create Case";
            this.createCaseButton.UseVisualStyleBackColor = true;
            this.createCaseButton.Click += new System.EventHandler(this.createCaseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.addAllButton);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(606, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 159);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(281, 94);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(122, 21);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "Military History";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(145, 94);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(116, 21);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "Police History";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(25, 94);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(116, 21);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Marital Status";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(281, 67);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(119, 21);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Has Children?";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(145, 67);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(67, 21);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Name";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(145, 40);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 21);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Occupation";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(281, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(63, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Race";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Gender";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Age";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pick The Default Information That You Want to Start With";
            // 
            // addAllButton
            // 
            this.addAllButton.Location = new System.Drawing.Point(74, 121);
            this.addAllButton.Name = "addAllButton";
            this.addAllButton.Size = new System.Drawing.Size(88, 26);
            this.addAllButton.TabIndex = 7;
            this.addAllButton.Text = "Add All";
            this.addAllButton.UseVisualStyleBackColor = true;
            this.addAllButton.Click += new System.EventHandler(this.addAllButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(256, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 26);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createCaseButton);
            this.Controls.Add(this.noOfJurorsTextBox);
            this.Controls.Add(this.caseNameTextbox);
            this.Controls.Add(this.newCaseButton);
            this.Controls.Add(this.loadCaseButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jury Selection Helper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadCaseButton;
        private System.Windows.Forms.Button newCaseButton;
        private System.Windows.Forms.TextBox caseNameTextbox;
        private System.Windows.Forms.TextBox noOfJurorsTextBox;
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addAllButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

