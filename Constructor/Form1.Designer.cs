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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxPrize1 = new System.Windows.Forms.TextBox();
            this.textBoxPrize2 = new System.Windows.Forms.TextBox();
            this.textBoxGuarantee = new System.Windows.Forms.TextBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.ButtonSetInBuffer = new System.Windows.Forms.Button();
            this.ButtonWrite = new System.Windows.Forms.Button();
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(26, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(118, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(193, 79);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(118, 22);
            this.textBoxSize.TabIndex = 6;
            // 
            // textBoxPrize1
            // 
            this.textBoxPrize1.Location = new System.Drawing.Point(360, 78);
            this.textBoxPrize1.Name = "textBoxPrize1";
            this.textBoxPrize1.Size = new System.Drawing.Size(118, 22);
            this.textBoxPrize1.TabIndex = 7;
            // 
            // textBoxPrize2
            // 
            this.textBoxPrize2.Location = new System.Drawing.Point(527, 78);
            this.textBoxPrize2.Name = "textBoxPrize2";
            this.textBoxPrize2.Size = new System.Drawing.Size(118, 22);
            this.textBoxPrize2.TabIndex = 8;
            // 
            // textBoxGuarantee
            // 
            this.textBoxGuarantee.Location = new System.Drawing.Point(694, 78);
            this.textBoxGuarantee.Name = "textBoxGuarantee";
            this.textBoxGuarantee.Size = new System.Drawing.Size(118, 22);
            this.textBoxGuarantee.TabIndex = 9;
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(28, 185);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(624, 159);
            this.textBoxRead.TabIndex = 10;
            // 
            // ButtonSetInBuffer
            // 
            this.ButtonSetInBuffer.BackColor = System.Drawing.Color.Silver;
            this.ButtonSetInBuffer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonSetInBuffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonSetInBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetInBuffer.Location = new System.Drawing.Point(28, 125);
            this.ButtonSetInBuffer.Name = "ButtonSetInBuffer";
            this.ButtonSetInBuffer.Size = new System.Drawing.Size(184, 36);
            this.ButtonSetInBuffer.TabIndex = 11;
            this.ButtonSetInBuffer.Text = "Добавить в буфер";
            this.ButtonSetInBuffer.UseVisualStyleBackColor = false;
            this.ButtonSetInBuffer.Click += new System.EventHandler(this.ButtonSetInBuffer_Click);
            // 
            // ButtonWrite
            // 
            this.ButtonWrite.BackColor = System.Drawing.Color.Silver;
            this.ButtonWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWrite.Location = new System.Drawing.Point(656, 125);
            this.ButtonWrite.Name = "ButtonWrite";
            this.ButtonWrite.Size = new System.Drawing.Size(166, 36);
            this.ButtonWrite.TabIndex = 12;
            this.ButtonWrite.Text = "Запись в файл";
            this.ButtonWrite.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(859, 356);
            this.Controls.Add(this.ButtonWrite);
            this.Controls.Add(this.ButtonSetInBuffer);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.textBoxGuarantee);
            this.Controls.Add(this.textBoxPrize2);
            this.Controls.Add(this.textBoxPrize1);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.LabelGuarantee);
            this.Controls.Add(this.LabelPrize2);
            this.Controls.Add(this.LabelPrize1);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.LabelName);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label LabelPrize1;
        private System.Windows.Forms.Label LabelPrize2;
        private System.Windows.Forms.Label LabelGuarantee;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxPrize1;
        private System.Windows.Forms.TextBox textBoxPrize2;
        private System.Windows.Forms.TextBox textBoxGuarantee;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Button ButtonSetInBuffer;
        private System.Windows.Forms.Button ButtonWrite;
    }
}

