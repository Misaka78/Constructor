namespace Constructor
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.LabelPrize1 = new System.Windows.Forms.Label();
            this.LabelPrize2 = new System.Windows.Forms.Label();
            this.LabelGuarantee = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(25, 25);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(122, 17);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Название товара";
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(203, 25);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(103, 17);
            this.LabelSize.TabIndex = 1;
            this.LabelSize.Text = "Кол-во товара";
            // 
            // LabelPrize1
            // 
            this.LabelPrize1.AutoSize = true;
            this.LabelPrize1.Location = new System.Drawing.Point(362, 25);
            this.LabelPrize1.Name = "LabelPrize1";
            this.LabelPrize1.Size = new System.Drawing.Size(116, 17);
            this.LabelPrize1.TabIndex = 2;
            this.LabelPrize1.Text = "Розничная цена";
            // 
            // LabelPrize2
            // 
            this.LabelPrize2.AutoSize = true;
            this.LabelPrize2.Location = new System.Drawing.Point(534, 25);
            this.LabelPrize2.Name = "LabelPrize2";
            this.LabelPrize2.Size = new System.Drawing.Size(101, 17);
            this.LabelPrize2.TabIndex = 3;
            this.LabelPrize2.Text = "Оптовая цена";
            // 
            // LabelGuarantee
            // 
            this.LabelGuarantee.AutoSize = true;
            this.LabelGuarantee.Location = new System.Drawing.Point(691, 25);
            this.LabelGuarantee.Name = "LabelGuarantee";
            this.LabelGuarantee.Size = new System.Drawing.Size(131, 17);
            this.LabelGuarantee.TabIndex = 4;
            this.LabelGuarantee.Text = "Гарантийный срок";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(527, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(694, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 22);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(28, 185);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(624, 159);
            this.textBox6.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить в буфер";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Запись в файл";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelGuarantee);
            this.Controls.Add(this.LabelPrize2);
            this.Controls.Add(this.LabelPrize1);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.LabelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label LabelPrize1;
        private System.Windows.Forms.Label LabelPrize2;
        private System.Windows.Forms.Label LabelGuarantee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

