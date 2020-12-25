namespace OOP6
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
            this.PanelD = new System.Windows.Forms.Panel();
            this.panelF = new System.Windows.Forms.Panel();
            this.LineRB = new System.Windows.Forms.RadioButton();
            this.SquareRB = new System.Windows.Forms.RadioButton();
            this.CircleRB = new System.Windows.Forms.RadioButton();
            this.panelC = new System.Windows.Forms.Panel();
            this.PurpleRB = new System.Windows.Forms.RadioButton();
            this.MaroonRB = new System.Windows.Forms.RadioButton();
            this.PinkRB = new System.Windows.Forms.RadioButton();
            this.ExitB = new System.Windows.Forms.Button();
            this.ClearstB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.BiggerB = new System.Windows.Forms.Button();
            this.smallerB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelF.SuspendLayout();
            this.panelC.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelD
            // 
            this.PanelD.BackColor = System.Drawing.SystemColors.Info;
            this.PanelD.Location = new System.Drawing.Point(202, 12);
            this.PanelD.Name = "PanelD";
            this.PanelD.Size = new System.Drawing.Size(507, 426);
            this.PanelD.TabIndex = 0;
            this.PanelD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelD_MouseClick);
            // 
            // panelF
            // 
            this.panelF.Controls.Add(this.label1);
            this.panelF.Controls.Add(this.LineRB);
            this.panelF.Controls.Add(this.SquareRB);
            this.panelF.Controls.Add(this.CircleRB);
            this.panelF.Location = new System.Drawing.Point(12, 12);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(180, 100);
            this.panelF.TabIndex = 4;
            // 
            // LineRB
            // 
            this.LineRB.AutoSize = true;
            this.LineRB.Location = new System.Drawing.Point(7, 68);
            this.LineRB.Name = "LineRB";
            this.LineRB.Size = new System.Drawing.Size(57, 17);
            this.LineRB.TabIndex = 2;
            this.LineRB.TabStop = true;
            this.LineRB.Text = "Линия";
            this.LineRB.UseVisualStyleBackColor = true;
            // 
            // SquareRB
            // 
            this.SquareRB.AutoSize = true;
            this.SquareRB.Location = new System.Drawing.Point(7, 45);
            this.SquareRB.Name = "SquareRB";
            this.SquareRB.Size = new System.Drawing.Size(67, 17);
            this.SquareRB.TabIndex = 1;
            this.SquareRB.TabStop = true;
            this.SquareRB.Text = "Квадрат";
            this.SquareRB.UseVisualStyleBackColor = true;
            // 
            // CircleRB
            // 
            this.CircleRB.AutoSize = true;
            this.CircleRB.Location = new System.Drawing.Point(7, 22);
            this.CircleRB.Name = "CircleRB";
            this.CircleRB.Size = new System.Drawing.Size(48, 17);
            this.CircleRB.TabIndex = 0;
            this.CircleRB.TabStop = true;
            this.CircleRB.Text = "Круг";
            this.CircleRB.UseVisualStyleBackColor = true;
            // 
            // panelC
            // 
            this.panelC.Controls.Add(this.label2);
            this.panelC.Controls.Add(this.PurpleRB);
            this.panelC.Controls.Add(this.MaroonRB);
            this.panelC.Controls.Add(this.PinkRB);
            this.panelC.Location = new System.Drawing.Point(12, 118);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(184, 100);
            this.panelC.TabIndex = 5;
            // 
            // PurpleRB
            // 
            this.PurpleRB.AutoSize = true;
            this.PurpleRB.Location = new System.Drawing.Point(4, 68);
            this.PurpleRB.Name = "PurpleRB";
            this.PurpleRB.Size = new System.Drawing.Size(91, 17);
            this.PurpleRB.TabIndex = 2;
            this.PurpleRB.TabStop = true;
            this.PurpleRB.Text = "Фиолетовый";
            this.PurpleRB.UseVisualStyleBackColor = true;
            this.PurpleRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PurpleRB_MouseClick);
            // 
            // MaroonRB
            // 
            this.MaroonRB.AutoSize = true;
            this.MaroonRB.Location = new System.Drawing.Point(4, 46);
            this.MaroonRB.Name = "MaroonRB";
            this.MaroonRB.Size = new System.Drawing.Size(70, 17);
            this.MaroonRB.TabIndex = 1;
            this.MaroonRB.TabStop = true;
            this.MaroonRB.Text = "Красный";
            this.MaroonRB.UseVisualStyleBackColor = true;
            this.MaroonRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaroonRB_MouseClick);
            // 
            // PinkRB
            // 
            this.PinkRB.AutoSize = true;
            this.PinkRB.Location = new System.Drawing.Point(4, 22);
            this.PinkRB.Name = "PinkRB";
            this.PinkRB.Size = new System.Drawing.Size(70, 17);
            this.PinkRB.TabIndex = 0;
            this.PinkRB.TabStop = true;
            this.PinkRB.Text = "Розовый";
            this.PinkRB.UseVisualStyleBackColor = true;
            this.PinkRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PinkRB_MouseClick);
            // 
            // ExitB
            // 
            this.ExitB.Location = new System.Drawing.Point(15, 224);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(110, 62);
            this.ExitB.TabIndex = 6;
            this.ExitB.Text = "Вывод из хранилища";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            this.ExitB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // ClearstB
            // 
            this.ClearstB.Location = new System.Drawing.Point(45, 301);
            this.ClearstB.Name = "ClearstB";
            this.ClearstB.Size = new System.Drawing.Size(110, 65);
            this.ClearstB.TabIndex = 7;
            this.ClearstB.Text = "Очищение хранилища";
            this.ClearstB.UseVisualStyleBackColor = true;
            this.ClearstB.Click += new System.EventHandler(this.ClearstB_Click);
            this.ClearstB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(85, 382);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(111, 56);
            this.ClearB.TabIndex = 8;
            this.ClearB.Text = "Полная очистка";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            this.ClearB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // BiggerB
            // 
            this.BiggerB.Location = new System.Drawing.Point(715, 12);
            this.BiggerB.Name = "BiggerB";
            this.BiggerB.Size = new System.Drawing.Size(81, 23);
            this.BiggerB.TabIndex = 9;
            this.BiggerB.Text = "Увелечение";
            this.BiggerB.UseVisualStyleBackColor = true;
            this.BiggerB.Click += new System.EventHandler(this.BiggerB_Click);
            // 
            // smallerB
            // 
            this.smallerB.Location = new System.Drawing.Point(715, 51);
            this.smallerB.Name = "smallerB";
            this.smallerB.Size = new System.Drawing.Size(81, 23);
            this.smallerB.TabIndex = 10;
            this.smallerB.Text = "Уменьшение";
            this.smallerB.UseVisualStyleBackColor = true;
            this.smallerB.Click += new System.EventHandler(this.smallerB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фигуры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цвета:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.smallerB);
            this.Controls.Add(this.BiggerB);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ClearstB);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.PanelD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panelF.ResumeLayout(false);
            this.panelF.PerformLayout();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelD;
        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.RadioButton LineRB;
        private System.Windows.Forms.RadioButton SquareRB;
        private System.Windows.Forms.RadioButton CircleRB;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.RadioButton PurpleRB;
        private System.Windows.Forms.RadioButton MaroonRB;
        private System.Windows.Forms.RadioButton PinkRB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button ClearstB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Button BiggerB;
        private System.Windows.Forms.Button smallerB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

