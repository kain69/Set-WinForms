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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnRU = new System.Windows.Forms.Button();
            this.btnENG = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSet1
            // 
            resources.ApplyResources(this.lblSet1, "lblSet1");
            this.lblSet1.Name = "lblSet1";
            // 
            // lblSet2
            // 
            resources.ApplyResources(this.lblSet2, "lblSet2");
            this.lblSet2.Name = "lblSet2";
            // 
            // txtBoxSet1
            // 
            resources.ApplyResources(this.txtBoxSet1, "txtBoxSet1");
            this.txtBoxSet1.Name = "txtBoxSet1";
            this.txtBoxSet1.TabStop = false;
            // 
            // txtBoxSet2
            // 
            resources.ApplyResources(this.txtBoxSet2, "txtBoxSet2");
            this.txtBoxSet2.Name = "txtBoxSet2";
            this.txtBoxSet2.TabStop = false;
            // 
            // btnUnion
            // 
            resources.ApplyResources(this.btnUnion, "btnUnion");
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnIntersection
            // 
            resources.ApplyResources(this.btnIntersection, "btnIntersection");
            this.btnIntersection.Name = "btnIntersection";
            this.btnIntersection.UseVisualStyleBackColor = true;
            this.btnIntersection.Click += new System.EventHandler(this.btnIntersection_Click);
            // 
            // btnSubSet
            // 
            resources.ApplyResources(this.btnSubSet, "btnSubSet");
            this.btnSubSet.Name = "btnSubSet";
            this.btnSubSet.UseVisualStyleBackColor = true;
            this.btnSubSet.Click += new System.EventHandler(this.btnSubSet_Click);
            // 
            // btnDifference
            // 
            resources.ApplyResources(this.btnDifference, "btnDifference");
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSymmetricDifference
            // 
            resources.ApplyResources(this.btnSymmetricDifference, "btnSymmetricDifference");
            this.btnSymmetricDifference.Name = "btnSymmetricDifference";
            this.btnSymmetricDifference.UseVisualStyleBackColor = true;
            this.btnSymmetricDifference.Click += new System.EventHandler(this.btnSymmetricDifference_Click);
            // 
            // btnSwap
            // 
            resources.ApplyResources(this.btnSwap, "btnSwap");
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // lblSetAnswer
            // 
            this.lblSetAnswer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSetAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblSetAnswer, "lblSetAnswer");
            this.lblSetAnswer.Name = "lblSetAnswer";
            // 
            // lblSetAnswerName
            // 
            this.lblSetAnswerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSetAnswerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblSetAnswerName, "lblSetAnswerName");
            this.lblSetAnswerName.Name = "lblSetAnswerName";
            // 
            // btnRU
            // 
            resources.ApplyResources(this.btnRU, "btnRU");
            this.btnRU.Name = "btnRU";
            this.btnRU.UseVisualStyleBackColor = true;
            this.btnRU.Click += new System.EventHandler(this.btnRU_Click);
            // 
            // btnENG
            // 
            resources.ApplyResources(this.btnENG, "btnENG");
            this.btnENG.Name = "btnENG";
            this.btnENG.UseVisualStyleBackColor = true;
            this.btnENG.Click += new System.EventHandler(this.btnENG_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnENG);
            this.Controls.Add(this.btnRU);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
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
        private System.Windows.Forms.Button btnRU;
        private System.Windows.Forms.Button btnENG;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

