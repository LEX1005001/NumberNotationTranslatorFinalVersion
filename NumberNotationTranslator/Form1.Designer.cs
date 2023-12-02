namespace NumberNotationTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInputNumber = new System.Windows.Forms.TextBox();
            this.buttonDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNotationFrom = new System.Windows.Forms.TextBox();
            this.textBoxNotationTo = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxNumbersAfter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInputNumber
            // 
            this.textBoxInputNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxInputNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputNumber.Location = new System.Drawing.Point(33, 75);
            this.textBoxInputNumber.Name = "textBoxInputNumber";
            this.textBoxInputNumber.Size = new System.Drawing.Size(330, 50);
            this.textBoxInputNumber.TabIndex = 0;
            // 
            // buttonDo
            // 
            this.buttonDo.BackColor = System.Drawing.Color.Lime;
            this.buttonDo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDo.Location = new System.Drawing.Point(557, 311);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(122, 50);
            this.buttonDo.TabIndex = 3;
            this.buttonDo.Text = "Вычислить";
            this.buttonDo.UseVisualStyleBackColor = false;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите число";
            // 
            // textBoxNotationFrom
            // 
            this.textBoxNotationFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxNotationFrom.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotationFrom.Location = new System.Drawing.Point(33, 194);
            this.textBoxNotationFrom.Name = "textBoxNotationFrom";
            this.textBoxNotationFrom.Size = new System.Drawing.Size(122, 50);
            this.textBoxNotationFrom.TabIndex = 8;
            // 
            // textBoxNotationTo
            // 
            this.textBoxNotationTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxNotationTo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotationTo.Location = new System.Drawing.Point(393, 194);
            this.textBoxNotationTo.Name = "textBoxNotationTo";
            this.textBoxNotationTo.Size = new System.Drawing.Size(122, 50);
            this.textBoxNotationTo.TabIndex = 9;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(33, 311);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(482, 50);
            this.textBoxResult.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Его система счисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Перевести в";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Cyan;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonHelp.Location = new System.Drawing.Point(758, 341);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(103, 55);
            this.buttonHelp.TabIndex = 14;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBoxNumbersAfter
            // 
            this.textBoxNumbersAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxNumbersAfter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumbersAfter.Location = new System.Drawing.Point(403, 75);
            this.textBoxNumbersAfter.Name = "textBoxNumbersAfter";
            this.textBoxNumbersAfter.Size = new System.Drawing.Size(163, 50);
            this.textBoxNumbersAfter.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Кол-во знаков поле ,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 408);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNumbersAfter);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNotationTo);
            this.Controls.Add(this.textBoxNotationFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.textBoxInputNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Перевод чисел в различные системы счисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputNumber;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNotationFrom;
        private System.Windows.Forms.TextBox textBoxNotationTo;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxNumbersAfter;
        private System.Windows.Forms.Label label6;
    }
}

