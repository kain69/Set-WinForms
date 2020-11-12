using Set;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SetWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool StringToSet(out Set<int> set1, out Set<int> set2)
        {
            string s1 = this.txtBoxSet1.Text;
            string s2 = this.txtBoxSet2.Text;
            set1 = new Set<int>();
            set2 = new Set<int>();

            List<int> list = new List<int>();
            try
            {
                list = s1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
                set1 = new Set<int>(list);

                list.Clear();

                list = s2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
                set2 = new Set<int>(list);
            }
            catch
            {
                this.lblSetAnswer.Text = "Неверный ввод";
                return false;
                //throw new Exception("Неверный ввод");
            }

            return true;
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSet1.Text == "" || this.txtBoxSet2.Text == "")
                return;
            this.lblSetAnswerName.Text = "Union";


            Set<int> set1;
            Set<int> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (int item in set1.Union(set2))
                {
                    s3 += item.ToString() + " ";
                }
                this.lblSetAnswer.Text = s3;
            }

            
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSet1.Text == "" || this.txtBoxSet2.Text == "")
                return;
            this.lblSetAnswerName.Text = "Intersection";

            Set<int> set1;
            Set<int> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (int item in set1.Intersection(set2))
                {
                    s3 += item.ToString() + " ";
                }
                this.lblSetAnswer.Text = s3;
            }
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSet1.Text == "" || this.txtBoxSet2.Text == "")
                return;
            this.lblSetAnswerName.Text = "Difference (A \\ B)";

            Set<int> set1;
            Set<int> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (int item in set1.Difference(set2))
                {
                    s3 += item.ToString() + " ";
                }
                this.lblSetAnswer.Text = s3;
            }
        }

        private void btnSubSet_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSet1.Text == "" || this.txtBoxSet2.Text == "")
                return;
            this.lblSetAnswerName.Text = "A SubSet B";

            Set<int> set1;
            Set<int> set2;

            if (this.StringToSet(out set1, out set2))
            {
                if (set1.SubSet(set2))
                    this.lblSetAnswer.Text = "True";
                else
                    this.lblSetAnswer.Text = "False";
            }
        }

        private void btnSymmetricDifference_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSet1.Text == "" || this.txtBoxSet2.Text == "")
                return;
            this.lblSetAnswerName.Text = "Symmetric Difference";

            Set<int> set1;
            Set<int> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (int item in set1.SymmetricDifference(set2))
                {
                    s3 += item.ToString() + " ";
                }
                this.lblSetAnswer.Text = s3;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            var temp = this.txtBoxSet1.Text;
            this.txtBoxSet1.Text = this.txtBoxSet2.Text;
            this.txtBoxSet2.Text = temp;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtBoxSet1.Text = "";
            this.txtBoxSet2.Text = "";
            this.lblSetAnswerName.Text = "Action";
            this.lblSetAnswer.Text = ""; 
        }

        private void btnRU_Click(object sender, EventArgs e)
        {
            this.btnUnion.Text = "Объединение";
            this.btnIntersection.Text = "Пересечение";
            this.btnDifference.Text = "Разность";
            this.btnSubSet.Text = "Подмножество";
            this.btnSymmetricDifference.Text = "Симетрическая Разность";
            this.btnSwap.Text = "Свап ))";
            this.btnReset.Text = "Сбросить";
        }

        private void btnENG_Click(object sender, EventArgs e)
        {
            this.btnUnion.Text = "Union";
            this.btnIntersection.Text = "Intersection";
            this.btnDifference.Text = "Difference";
            this.btnSubSet.Text = "SubSet";
            this.btnSymmetricDifference.Text = "Symmetric Difference";
            this.btnSwap.Text = "Swap";
            this.btnReset.Text = "Reset";

        }
    }
}
