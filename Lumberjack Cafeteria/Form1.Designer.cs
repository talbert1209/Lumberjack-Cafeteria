namespace Lumberjack_Cafeteria
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddLumberjackButton = new System.Windows.Forms.Button();
            this.breakfastLineListBox = new System.Windows.Forms.ListBox();
            this.breakfastLineLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.numberOfFlapjacksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.crispyRadioButton = new System.Windows.Forms.RadioButton();
            this.soggyRadioButton = new System.Windows.Forms.RadioButton();
            this.brownedRadioButton = new System.Windows.Forms.RadioButton();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.addFlapjacksButton = new System.Windows.Forms.Button();
            this.flapjackCountListBox = new System.Windows.Forms.ListBox();
            this.nextLumberjackButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfFlapjacksNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(122, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Lumberjack Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(141, 24);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(130, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // AddLumberjackButton
            // 
            this.AddLumberjackButton.Location = new System.Drawing.Point(16, 62);
            this.AddLumberjackButton.Name = "AddLumberjackButton";
            this.AddLumberjackButton.Size = new System.Drawing.Size(255, 29);
            this.AddLumberjackButton.TabIndex = 2;
            this.AddLumberjackButton.Text = "Add Lumberjack";
            this.AddLumberjackButton.UseVisualStyleBackColor = true;
            this.AddLumberjackButton.Click += new System.EventHandler(this.AddLumberjackButton_Click);
            // 
            // breakfastLineListBox
            // 
            this.breakfastLineListBox.FormattingEnabled = true;
            this.breakfastLineListBox.ItemHeight = 16;
            this.breakfastLineListBox.Location = new System.Drawing.Point(16, 137);
            this.breakfastLineListBox.Name = "breakfastLineListBox";
            this.breakfastLineListBox.Size = new System.Drawing.Size(120, 324);
            this.breakfastLineListBox.TabIndex = 3;
            // 
            // breakfastLineLabel
            // 
            this.breakfastLineLabel.AutoSize = true;
            this.breakfastLineLabel.Location = new System.Drawing.Point(16, 114);
            this.breakfastLineLabel.Name = "breakfastLineLabel";
            this.breakfastLineLabel.Size = new System.Drawing.Size(99, 17);
            this.breakfastLineLabel.TabIndex = 4;
            this.breakfastLineLabel.Text = "Breakfast Line";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.nextLumberjackButton);
            this.groupBox.Controls.Add(this.flapjackCountListBox);
            this.groupBox.Controls.Add(this.addFlapjacksButton);
            this.groupBox.Controls.Add(this.bananaRadioButton);
            this.groupBox.Controls.Add(this.brownedRadioButton);
            this.groupBox.Controls.Add(this.soggyRadioButton);
            this.groupBox.Controls.Add(this.crispyRadioButton);
            this.groupBox.Controls.Add(this.numberOfFlapjacksNumericUpDown);
            this.groupBox.Location = new System.Drawing.Point(152, 97);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(171, 364);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Feed a Lumberjack";
            // 
            // numberOfFlapjacksNumericUpDown
            // 
            this.numberOfFlapjacksNumericUpDown.Location = new System.Drawing.Point(6, 31);
            this.numberOfFlapjacksNumericUpDown.Name = "numberOfFlapjacksNumericUpDown";
            this.numberOfFlapjacksNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.numberOfFlapjacksNumericUpDown.TabIndex = 0;
            // 
            // crispyRadioButton
            // 
            this.crispyRadioButton.AutoSize = true;
            this.crispyRadioButton.Location = new System.Drawing.Point(6, 68);
            this.crispyRadioButton.Name = "crispyRadioButton";
            this.crispyRadioButton.Size = new System.Drawing.Size(68, 21);
            this.crispyRadioButton.TabIndex = 1;
            this.crispyRadioButton.TabStop = true;
            this.crispyRadioButton.Text = "Crispy";
            this.crispyRadioButton.UseVisualStyleBackColor = true;
            // 
            // soggyRadioButton
            // 
            this.soggyRadioButton.AutoSize = true;
            this.soggyRadioButton.Location = new System.Drawing.Point(6, 95);
            this.soggyRadioButton.Name = "soggyRadioButton";
            this.soggyRadioButton.Size = new System.Drawing.Size(69, 21);
            this.soggyRadioButton.TabIndex = 2;
            this.soggyRadioButton.TabStop = true;
            this.soggyRadioButton.Text = "Soggy";
            this.soggyRadioButton.UseVisualStyleBackColor = true;
            // 
            // brownedRadioButton
            // 
            this.brownedRadioButton.AutoSize = true;
            this.brownedRadioButton.Location = new System.Drawing.Point(6, 122);
            this.brownedRadioButton.Name = "brownedRadioButton";
            this.brownedRadioButton.Size = new System.Drawing.Size(84, 21);
            this.brownedRadioButton.TabIndex = 3;
            this.brownedRadioButton.TabStop = true;
            this.brownedRadioButton.Text = "Browned";
            this.brownedRadioButton.UseVisualStyleBackColor = true;
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(6, 149);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(78, 21);
            this.bananaRadioButton.TabIndex = 4;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "Banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // addFlapjacksButton
            // 
            this.addFlapjacksButton.Location = new System.Drawing.Point(7, 187);
            this.addFlapjacksButton.Name = "addFlapjacksButton";
            this.addFlapjacksButton.Size = new System.Drawing.Size(158, 27);
            this.addFlapjacksButton.TabIndex = 5;
            this.addFlapjacksButton.Text = "Add Flapjacks";
            this.addFlapjacksButton.UseVisualStyleBackColor = true;
            this.addFlapjacksButton.Click += new System.EventHandler(this.addFlapjacksButton_Click);
            // 
            // flapjackCountListBox
            // 
            this.flapjackCountListBox.FormattingEnabled = true;
            this.flapjackCountListBox.ItemHeight = 16;
            this.flapjackCountListBox.Location = new System.Drawing.Point(7, 221);
            this.flapjackCountListBox.Name = "flapjackCountListBox";
            this.flapjackCountListBox.Size = new System.Drawing.Size(158, 84);
            this.flapjackCountListBox.TabIndex = 6;
            // 
            // nextLumberjackButton
            // 
            this.nextLumberjackButton.Location = new System.Drawing.Point(7, 322);
            this.nextLumberjackButton.Name = "nextLumberjackButton";
            this.nextLumberjackButton.Size = new System.Drawing.Size(158, 27);
            this.nextLumberjackButton.TabIndex = 7;
            this.nextLumberjackButton.Text = "Next Lumberjack";
            this.nextLumberjackButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 474);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.breakfastLineLabel);
            this.Controls.Add(this.breakfastLineListBox);
            this.Controls.Add(this.AddLumberjackButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfFlapjacksNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddLumberjackButton;
        private System.Windows.Forms.ListBox breakfastLineListBox;
        private System.Windows.Forms.Label breakfastLineLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.RadioButton brownedRadioButton;
        private System.Windows.Forms.RadioButton soggyRadioButton;
        private System.Windows.Forms.RadioButton crispyRadioButton;
        private System.Windows.Forms.NumericUpDown numberOfFlapjacksNumericUpDown;
        private System.Windows.Forms.Button nextLumberjackButton;
        private System.Windows.Forms.ListBox flapjackCountListBox;
        private System.Windows.Forms.Button addFlapjacksButton;
    }
}

