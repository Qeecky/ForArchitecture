namespace ForArchitecture
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
            this.OK1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.way = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.weight_way = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK1
            // 
            this.OK1.Location = new System.Drawing.Point(12, 459);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(75, 23);
            this.OK1.TabIndex = 0;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = true;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(12, 394);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(87, 13);
            this.label_city.TabIndex = 2;
            this.label_city.Text = "Введдите город";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 459);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 3;
            // 
            // way
            // 
            this.way.AutoSize = true;
            this.way.Location = new System.Drawing.Point(286, 431);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(90, 13);
            this.way.TabIndex = 4;
            this.way.Text = "Найденный путь";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(608, 459);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 6;
            // 
            // weight_way
            // 
            this.weight_way.AutoSize = true;
            this.weight_way.Location = new System.Drawing.Point(605, 431);
            this.weight_way.Name = "weight_way";
            this.weight_way.Size = new System.Drawing.Size(51, 13);
            this.weight_way.TabIndex = 7;
            this.weight_way.Text = "Вес пути";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(847, 506);
            this.Controls.Add(this.weight_way);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.way);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OK1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label way;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label weight_way;
    }
}

