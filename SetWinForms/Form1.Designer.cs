namespace SetWinForms
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
            this.lblSet1 = new System.Windows.Forms.Label();
            this.lblSet2 = new System.Windows.Forms.Label();
            this.txtBoxSet1 = new System.Windows.Forms.TextBox();
            this.txtBoxSet2 = new System.Windows.Forms.TextBox();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnIntersection = new System.Windows.Forms.Button();
            this.btnSubSet = new System.Windows.Forms.Button();
            this.btnDifference = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSymmetricDifference = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.lblSetAnswer = new System.Windows.Forms.Label();
            this.lblSetAnswerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSet1
            // 
            this.lblSet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSet1.Location = new System.Drawing.Point(12, 6);
            this.lblSet1.Name = "lblSet1";
            this.lblSet1.Size = new System.Drawing.Size(185, 45);
            this.lblSet1.TabIndex = 0;
            this.lblSet1.Text = "Задайте множество А: ";
            this.lblSet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet2
            // 
            this.lblSet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSet2.Location = new System.Drawing.Point(12, 80);
            this.lblSet2.Name = "lblSet2";
            this.lblSet2.Size = new System.Drawing.Size(185, 45);
            this.lblSet2.TabIndex = 1;
            this.lblSet2.Text = "Задайте множество B: ";
            this.lblSet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxSet1
            // 
            this.txtBoxSet1.Location = new System.Drawing.Point(12, 57);
            this.txtBoxSet1.Name = "txtBoxSet1";
            this.txtBoxSet1.Size = new System.Drawing.Size(185, 20);
            this.txtBoxSet1.TabIndex = 2;
            this.txtBoxSet1.TabStop = false;
            this.txtBoxSet1.Text = "1 2 3 4";
            // 
            // txtBoxSet2
            // 
            this.txtBoxSet2.Location = new System.Drawing.Point(12, 128);
            this.txtBoxSet2.Name = "txtBoxSet2";
            this.txtBoxSet2.Size = new System.Drawing.Size(185, 20);
            this.txtBoxSet2.TabIndex = 3;
            this.txtBoxSet2.TabStop = false;
            this.txtBoxSet2.Text = "4 5 6 7";
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(12, 173);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(75, 23);
            this.btnUnion.TabIndex = 4;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnIntersection
            // 
            this.btnIntersection.Location = new System.Drawing.Point(122, 173);
            this.btnIntersection.Name = "btnIntersection";
            this.btnIntersection.Size = new System.Drawing.Size(75, 23);
            this.btnIntersection.TabIndex = 5;
            this.btnIntersection.Text = "Intersection";
            this.btnIntersection.UseVisualStyleBackColor = true;
            this.btnIntersection.Click += new System.EventHandler(this.btnIntersection_Click);
            // 
            // btnSubSet
            // 
            this.btnSubSet.Location = new System.Drawing.Point(122, 202);
            this.btnSubSet.Name = "btnSubSet";
            this.btnSubSet.Size = new System.Drawing.Size(75, 23);
            this.btnSubSet.TabIndex = 7;
            this.btnSubSet.Text = "SubSet";
            this.btnSubSet.UseVisualStyleBackColor = true;
            this.btnSubSet.Click += new System.EventHandler(this.btnSubSet_Click);
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(12, 202);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(75, 23);
            this.btnDifference.TabIndex = 6;
            this.btnDifference.Text = "Difference";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 289);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(185, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSymmetricDifference
            // 
            this.btnSymmetricDifference.Location = new System.Drawing.Point(12, 231);
            this.btnSymmetricDifference.Name = "btnSymmetricDifference";
            this.btnSymmetricDifference.Size = new System.Drawing.Size(185, 23);
            this.btnSymmetricDifference.TabIndex = 8;
            this.btnSymmetricDifference.Text = "Symmetric Difference";
            this.btnSymmetricDifference.UseVisualStyleBackColor = true;
            this.btnSymmetricDifference.Click += new System.EventHandler(this.btnSymmetricDifference_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(12, 260);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(185, 23);
            this.btnSwap.TabIndex = 10;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // lblSetAnswer
            // 
            this.lblSetAnswer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSetAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSetAnswer.Location = new System.Drawing.Point(249, 40);
            this.lblSetAnswer.Name = "lblSetAnswer";
            this.lblSetAnswer.Size = new System.Drawing.Size(369, 52);
            this.lblSetAnswer.TabIndex = 11;
            this.lblSetAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetAnswerName
            // 
            this.lblSetAnswerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSetAnswerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSetAnswerName.Location = new System.Drawing.Point(249, 17);
            this.lblSetAnswerName.Name = "lblSetAnswerName";
            this.lblSetAnswerName.Size = new System.Drawing.Size(100, 23);
            this.lblSetAnswerName.TabIndex = 12;
            this.lblSetAnswerName.Text = "Action";
            this.lblSetAnswerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 330);
            this.Controls.Add(this.lblSetAnswerName);
            this.Controls.Add(this.lblSetAnswer);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSymmetricDifference);
            this.Controls.Add(this.btnSubSet);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.btnIntersection);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.txtBoxSet2);
            this.Controls.Add(this.txtBoxSet1);
            this.Controls.Add(this.lblSet2);
            this.Controls.Add(this.lblSet1);
            this.Name = "Form1";
            this.Text = "Set | Кармазин Влад ФИТ-3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSet1;
        private System.Windows.Forms.Label lblSet2;
        private System.Windows.Forms.TextBox txtBoxSet1;
        private System.Windows.Forms.TextBox txtBoxSet2;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnIntersection;
        private System.Windows.Forms.Button btnSubSet;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSymmetricDifference;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Label lblSetAnswer;
        private System.Windows.Forms.Label lblSetAnswerName;
    }
}

