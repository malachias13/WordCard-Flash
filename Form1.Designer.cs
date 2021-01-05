namespace WordGUI_Frameworks_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.WordText = new System.Windows.Forms.Label();
            this.previou_Btn = new System.Windows.Forms.Button();
            this.next_Btn = new System.Windows.Forms.Button();
            this.DefineDox = new System.Windows.Forms.RichTextBox();
            this.addWord_Btn = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.WordList = new System.Windows.Forms.ListBox();
            this.Read_Btn = new System.Windows.Forms.Button();
            this.remove_Btn = new System.Windows.Forms.Button();
            this.CardCount = new System.Windows.Forms.Label();
            this.addWordPanel = new System.Windows.Forms.Panel();
            this.WordList2 = new System.Windows.Forms.ListBox();
            this.Home_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.addDefinition = new System.Windows.Forms.RichTextBox();
            this.addWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HomePanel.SuspendLayout();
            this.addWordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.label1.Location = new System.Drawing.Point(699, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Card-Flash";
            // 
            // WordText
            // 
            this.WordText.AutoSize = true;
            this.WordText.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.WordText.ForeColor = System.Drawing.Color.Tomato;
            this.WordText.Location = new System.Drawing.Point(803, 365);
            this.WordText.Name = "WordText";
            this.WordText.Size = new System.Drawing.Size(303, 65);
            this.WordText.TabIndex = 1;
            this.WordText.Text = "WORD_Input";
            this.WordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previou_Btn
            // 
            this.previou_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previou_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.previou_Btn.Location = new System.Drawing.Point(517, 600);
            this.previou_Btn.Name = "previou_Btn";
            this.previou_Btn.Size = new System.Drawing.Size(91, 29);
            this.previou_Btn.TabIndex = 3;
            this.previou_Btn.Text = "Previous";
            this.previou_Btn.UseVisualStyleBackColor = true;
            this.previou_Btn.Click += new System.EventHandler(this.previou_Btn_Click);
            // 
            // next_Btn
            // 
            this.next_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.next_Btn.Location = new System.Drawing.Point(1278, 600);
            this.next_Btn.Name = "next_Btn";
            this.next_Btn.Size = new System.Drawing.Size(91, 29);
            this.next_Btn.TabIndex = 4;
            this.next_Btn.Text = "Next";
            this.next_Btn.UseVisualStyleBackColor = true;
            this.next_Btn.Click += new System.EventHandler(this.next_Btn_Click);
            // 
            // DefineDox
            // 
            this.DefineDox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DefineDox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DefineDox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DefineDox.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.DefineDox.Location = new System.Drawing.Point(671, 456);
            this.DefineDox.Name = "DefineDox";
            this.DefineDox.ReadOnly = true;
            this.DefineDox.Size = new System.Drawing.Size(570, 203);
            this.DefineDox.TabIndex = 6;
            this.DefineDox.Text = resources.GetString("DefineDox.Text");
            // 
            // addWord_Btn
            // 
            this.addWord_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.addWord_Btn.Location = new System.Drawing.Point(1591, 42);
            this.addWord_Btn.Name = "addWord_Btn";
            this.addWord_Btn.Size = new System.Drawing.Size(96, 33);
            this.addWord_Btn.TabIndex = 7;
            this.addWord_Btn.Text = "Add Word";
            this.addWord_Btn.UseVisualStyleBackColor = true;
            this.addWord_Btn.Click += new System.EventHandler(this.addWord_Btn_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.AutoSize = true;
            this.HomePanel.Controls.Add(this.WordList);
            this.HomePanel.Controls.Add(this.Read_Btn);
            this.HomePanel.Controls.Add(this.remove_Btn);
            this.HomePanel.Controls.Add(this.CardCount);
            this.HomePanel.Controls.Add(this.addWord_Btn);
            this.HomePanel.Controls.Add(this.next_Btn);
            this.HomePanel.Controls.Add(this.label1);
            this.HomePanel.Controls.Add(this.previou_Btn);
            this.HomePanel.Controls.Add(this.WordText);
            this.HomePanel.Controls.Add(this.DefineDox);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1904, 1041);
            this.HomePanel.TabIndex = 8;
            // 
            // WordList
            // 
            this.WordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList.FormattingEnabled = true;
            this.WordList.ItemHeight = 20;
            this.WordList.Location = new System.Drawing.Point(120, 216);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(257, 564);
            this.WordList.TabIndex = 12;
            this.WordList.SelectedIndexChanged += new System.EventHandler(this.WordList_SelectedIndexChanged);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Read_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Read_Btn.Location = new System.Drawing.Point(881, 742);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(91, 29);
            this.Read_Btn.TabIndex = 11;
            this.Read_Btn.Text = "Read";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // remove_Btn
            // 
            this.remove_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.remove_Btn.Location = new System.Drawing.Point(83, 43);
            this.remove_Btn.Name = "remove_Btn";
            this.remove_Btn.Size = new System.Drawing.Size(96, 33);
            this.remove_Btn.TabIndex = 9;
            this.remove_Btn.Text = "Remove";
            this.remove_Btn.UseVisualStyleBackColor = true;
            this.remove_Btn.Click += new System.EventHandler(this.remove_Btn_Click);
            // 
            // CardCount
            // 
            this.CardCount.AutoSize = true;
            this.CardCount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.CardCount.ForeColor = System.Drawing.Color.DarkRed;
            this.CardCount.Location = new System.Drawing.Point(917, 697);
            this.CardCount.Name = "CardCount";
            this.CardCount.Size = new System.Drawing.Size(17, 20);
            this.CardCount.TabIndex = 8;
            this.CardCount.Text = "0";
            // 
            // addWordPanel
            // 
            this.addWordPanel.Controls.Add(this.WordList2);
            this.addWordPanel.Controls.Add(this.Home_btn);
            this.addWordPanel.Controls.Add(this.label4);
            this.addWordPanel.Controls.Add(this.add_btn);
            this.addWordPanel.Controls.Add(this.addDefinition);
            this.addWordPanel.Controls.Add(this.addWord);
            this.addWordPanel.Controls.Add(this.label3);
            this.addWordPanel.Controls.Add(this.label2);
            this.addWordPanel.Location = new System.Drawing.Point(12, 12);
            this.addWordPanel.Name = "addWordPanel";
            this.addWordPanel.Size = new System.Drawing.Size(1877, 880);
            this.addWordPanel.TabIndex = 8;
            this.addWordPanel.Visible = false;
            // 
            // WordList2
            // 
            this.WordList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList2.FormattingEnabled = true;
            this.WordList2.ItemHeight = 20;
            this.WordList2.Location = new System.Drawing.Point(108, 204);
            this.WordList2.Name = "WordList2";
            this.WordList2.Size = new System.Drawing.Size(207, 544);
            this.WordList2.TabIndex = 8;
            // 
            // Home_btn
            // 
            this.Home_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Home_btn.Location = new System.Drawing.Point(1523, 81);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(79, 26);
            this.Home_btn.TabIndex = 7;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.label4.Location = new System.Drawing.Point(686, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 86);
            this.label4.TabIndex = 6;
            this.label4.Text = "Word Card Flash";
            // 
            // add_btn
            // 
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.add_btn.Location = new System.Drawing.Point(880, 684);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(78, 30);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // addDefinition
            // 
            this.addDefinition.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.addDefinition.Location = new System.Drawing.Point(585, 514);
            this.addDefinition.Name = "addDefinition";
            this.addDefinition.Size = new System.Drawing.Size(684, 125);
            this.addDefinition.TabIndex = 3;
            this.addDefinition.Text = "";
            // 
            // addWord
            // 
            this.addWord.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addWord.Location = new System.Drawing.Point(560, 421);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(733, 29);
            this.addWord.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(880, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Definition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(897, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Word";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.addWordPanel);
            this.Controls.Add(this.HomePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Word Card - Flash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.addWordPanel.ResumeLayout(false);
            this.addWordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WordText;
        private System.Windows.Forms.Button previou_Btn;
        private System.Windows.Forms.Button next_Btn;
        private System.Windows.Forms.RichTextBox DefineDox;
        private System.Windows.Forms.Button addWord_Btn;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel addWordPanel;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.RichTextBox addDefinition;
        private System.Windows.Forms.TextBox addWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CardCount;
        private System.Windows.Forms.Button remove_Btn;
        private System.Windows.Forms.Button Read_Btn;
        private System.Windows.Forms.ListBox WordList;
        private System.Windows.Forms.ListBox WordList2;
    }
}

