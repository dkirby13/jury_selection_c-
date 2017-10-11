namespace JurySelection.Forms
{
    partial class JurorForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.newPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.dislikeButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.deleteJurorButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.jurorNumber = new System.Windows.Forms.Label();
            this.updatePanel.SuspendLayout();
            this.newPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(322, 104);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(724, 306);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // updatePanel
            // 
            this.updatePanel.AutoSize = true;
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatePanel.Controls.Add(this.cancelButton);
            this.updatePanel.Controls.Add(this.deleteButton);
            this.updatePanel.Controls.Add(this.newPanel);
            this.updatePanel.Controls.Add(this.updateButton);
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.answerLabel);
            this.updatePanel.Controls.Add(this.questionLabel);
            this.updatePanel.Location = new System.Drawing.Point(265, 63);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(706, 445);
            this.updatePanel.TabIndex = 2;
            this.updatePanel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(283, 193);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(157, 193);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(26, 193);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 34);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update or Delete Information";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(236, 102);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(46, 17);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "label2";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(66, 102);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(46, 17);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // newPanel
            // 
            this.newPanel.AutoSize = true;
            this.newPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newPanel.Controls.Add(this.panel1);
            this.newPanel.Location = new System.Drawing.Point(45, 143);
            this.newPanel.Name = "newPanel";
            this.newPanel.Size = new System.Drawing.Size(654, 295);
            this.newPanel.TabIndex = 4;
            this.newPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(388, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 255);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Question";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 111);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 188);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 34);
            this.newButton.TabIndex = 12;
            this.newButton.Text = "Add";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add New Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(568, 416);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(233, 38);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Information";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.dislikeButton);
            this.sidePanel.Controls.Add(this.likeButton);
            this.sidePanel.Controls.Add(this.deleteJurorButton);
            this.sidePanel.Controls.Add(this.backButton);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(259, 487);
            this.sidePanel.TabIndex = 5;
            // 
            // dislikeButton
            // 
            this.dislikeButton.Location = new System.Drawing.Point(3, 159);
            this.dislikeButton.Name = "dislikeButton";
            this.dislikeButton.Size = new System.Drawing.Size(256, 46);
            this.dislikeButton.TabIndex = 3;
            this.dislikeButton.Text = "Dislike Juror";
            this.dislikeButton.UseVisualStyleBackColor = true;
            this.dislikeButton.Click += new System.EventHandler(this.dislikeButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.Location = new System.Drawing.Point(3, 105);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(256, 46);
            this.likeButton.TabIndex = 2;
            this.likeButton.Text = "Like Juror";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // deleteJurorButton
            // 
            this.deleteJurorButton.Location = new System.Drawing.Point(3, 52);
            this.deleteJurorButton.Name = "deleteJurorButton";
            this.deleteJurorButton.Size = new System.Drawing.Size(256, 46);
            this.deleteJurorButton.TabIndex = 1;
            this.deleteJurorButton.Text = "Delete Juror";
            this.deleteJurorButton.UseVisualStyleBackColor = true;
            this.deleteJurorButton.Click += new System.EventHandler(this.deleteJurorButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(256, 46);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back to Case";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // jurorNumber
            // 
            this.jurorNumber.AutoSize = true;
            this.jurorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.jurorNumber.Location = new System.Drawing.Point(612, 28);
            this.jurorNumber.Name = "jurorNumber";
            this.jurorNumber.Size = new System.Drawing.Size(181, 36);
            this.jurorNumber.TabIndex = 6;
            this.jurorNumber.Text = "jurorNumber";
            // 
            // JurorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 488);
            this.Controls.Add(this.jurorNumber);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "JurorForm";
            this.Text = "Jury Selection Helper";
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.newPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel newPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button deleteJurorButton;
        private System.Windows.Forms.Button dislikeButton;
        private System.Windows.Forms.Label jurorNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}