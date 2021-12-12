
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.incSugarAmountButton = new System.Windows.Forms.Button();
            this.decSugarAmountButton = new System.Windows.Forms.Button();
            this.incCupsAmountButton = new System.Windows.Forms.Button();
            this.decCupsAmountButton = new System.Windows.Forms.Button();
            this.teaVarietyComboBox = new System.Windows.Forms.ComboBox();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sugarAmounTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cupsAmountTextBox = new System.Windows.Forms.TextBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.addCupButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fullPriceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // incSugarAmountButton
            // 
            this.incSugarAmountButton.Location = new System.Drawing.Point(37, 90);
            this.incSugarAmountButton.Name = "incSugarAmountButton";
            this.incSugarAmountButton.Size = new System.Drawing.Size(75, 67);
            this.incSugarAmountButton.TabIndex = 0;
            this.incSugarAmountButton.Text = "+";
            this.incSugarAmountButton.UseVisualStyleBackColor = true;
            this.incSugarAmountButton.Click += new System.EventHandler(this.incSugarAmountButton_Click);
            // 
            // decSugarAmountButton
            // 
            this.decSugarAmountButton.Location = new System.Drawing.Point(118, 90);
            this.decSugarAmountButton.Name = "decSugarAmountButton";
            this.decSugarAmountButton.Size = new System.Drawing.Size(75, 67);
            this.decSugarAmountButton.TabIndex = 1;
            this.decSugarAmountButton.Text = "-";
            this.decSugarAmountButton.UseVisualStyleBackColor = true;
            this.decSugarAmountButton.Click += new System.EventHandler(this.decSugarAmountButton_Click);
            // 
            // incCupsAmountButton
            // 
            this.incCupsAmountButton.Location = new System.Drawing.Point(69, 88);
            this.incCupsAmountButton.Name = "incCupsAmountButton";
            this.incCupsAmountButton.Size = new System.Drawing.Size(75, 67);
            this.incCupsAmountButton.TabIndex = 4;
            this.incCupsAmountButton.Text = "+";
            this.incCupsAmountButton.UseVisualStyleBackColor = true;
            this.incCupsAmountButton.Click += new System.EventHandler(this.incCupsAmountButton_Click);
            // 
            // decCupsAmountButton
            // 
            this.decCupsAmountButton.Location = new System.Drawing.Point(150, 88);
            this.decCupsAmountButton.Name = "decCupsAmountButton";
            this.decCupsAmountButton.Size = new System.Drawing.Size(75, 67);
            this.decCupsAmountButton.TabIndex = 5;
            this.decCupsAmountButton.Text = "-";
            this.decCupsAmountButton.UseVisualStyleBackColor = true;
            this.decCupsAmountButton.Click += new System.EventHandler(this.decCupsAmountButton_Click);
            // 
            // teaVarietyComboBox
            // 
            this.teaVarietyComboBox.FormattingEnabled = true;
            this.teaVarietyComboBox.Items.AddRange(new object[] {
            "Улун",
            "Гречневый"});
            this.teaVarietyComboBox.Location = new System.Drawing.Point(26, 40);
            this.teaVarietyComboBox.Name = "teaVarietyComboBox";
            this.teaVarietyComboBox.Size = new System.Drawing.Size(121, 21);
            this.teaVarietyComboBox.TabIndex = 6;
            this.teaVarietyComboBox.Text = "Улун";
            this.teaVarietyComboBox.SelectedIndexChanged += new System.EventHandler(this.teaVarietyComboBox_SelectedIndexChanged);
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Location = new System.Drawing.Point(26, 116);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(15, 14);
            this.milkCheckBox.TabIndex = 7;
            this.milkCheckBox.UseVisualStyleBackColor = true;
            this.milkCheckBox.CheckedChanged += new System.EventHandler(this.milkCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.milkCheckBox);
            this.groupBox1.Controls.Add(this.teaVarietyComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Молоко";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сорт";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sugarAmounTextBox);
            this.groupBox2.Controls.Add(this.decSugarAmountButton);
            this.groupBox2.Controls.Add(this.incSugarAmountButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 163);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сахар";
            // 
            // sugarAmounTextBox
            // 
            this.sugarAmounTextBox.Location = new System.Drawing.Point(69, 44);
            this.sugarAmounTextBox.Name = "sugarAmounTextBox";
            this.sugarAmounTextBox.ReadOnly = true;
            this.sugarAmounTextBox.Size = new System.Drawing.Size(100, 20);
            this.sugarAmounTextBox.TabIndex = 2;
            this.sugarAmounTextBox.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cupsAmountTextBox);
            this.groupBox4.Controls.Add(this.decCupsAmountButton);
            this.groupBox4.Controls.Add(this.incCupsAmountButton);
            this.groupBox4.Location = new System.Drawing.Point(292, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 163);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Чашек";
            // 
            // cupsAmountTextBox
            // 
            this.cupsAmountTextBox.Location = new System.Drawing.Point(97, 44);
            this.cupsAmountTextBox.Name = "cupsAmountTextBox";
            this.cupsAmountTextBox.ReadOnly = true;
            this.cupsAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.cupsAmountTextBox.TabIndex = 3;
            this.cupsAmountTextBox.Text = "0";
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(250, 13);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(143, 160);
            this.orderListBox.TabIndex = 10;
            // 
            // addCupButton
            // 
            this.addCupButton.Location = new System.Drawing.Point(399, 108);
            this.addCupButton.Name = "addCupButton";
            this.addCupButton.Size = new System.Drawing.Size(75, 67);
            this.addCupButton.TabIndex = 6;
            this.addCupButton.Text = "Добавить";
            this.addCupButton.UseVisualStyleBackColor = true;
            this.addCupButton.Click += new System.EventHandler(this.addCupButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(480, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 67);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fullPriceLabel
            // 
            this.fullPriceLabel.AutoSize = true;
            this.fullPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullPriceLabel.Location = new System.Drawing.Point(453, 34);
            this.fullPriceLabel.Name = "fullPriceLabel";
            this.fullPriceLabel.Size = new System.Drawing.Size(36, 39);
            this.fullPriceLabel.TabIndex = 13;
            this.fullPriceLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 362);
            this.Controls.Add(this.fullPriceLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addCupButton);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incSugarAmountButton;
        private System.Windows.Forms.Button decSugarAmountButton;
        private System.Windows.Forms.Button incCupsAmountButton;
        private System.Windows.Forms.Button decCupsAmountButton;
        private System.Windows.Forms.ComboBox teaVarietyComboBox;
        private System.Windows.Forms.CheckBox milkCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox sugarAmounTextBox;
        private System.Windows.Forms.TextBox cupsAmountTextBox;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button addCupButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fullPriceLabel;
    }
}

