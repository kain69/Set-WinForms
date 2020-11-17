using Set;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace SetWinForms
{
    public partial class Form1 : Form
    {
        ResourceManager rm = new ResourceManager("SetWinForms.MyString", Assembly.GetExecutingAssembly());

        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
            
        }

        private bool StringToSet(out Set<string> set1, out Set<string> set2)
        {
            string s1 = this.txtBoxSet1.Text;
            string s2 = this.txtBoxSet2.Text;
            set1 = new Set<string>();
            set2 = new Set<string>();

            List<string> list;
            try
            {
                list = s1.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries).ToList();
                set1 = new Set<string>(list);

                list.Clear();

                list = s2.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries).ToList();
                set2 = new Set<string>(list);
            }
            catch
            {
                this.lblSetAnswer.Text = rm.GetString("Error");
                return false;
            }

            return true;
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSet1.Text == "" || this.txtBoxSet2.Text == "")
                return;
            this.lblSetAnswerName.Text = rm.GetString("Union");


            Set<string> set1;
            Set<string> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (var item in set1.Union(set2))
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
            this.lblSetAnswerName.Text = rm.GetString("Intersection");

            Set<string> set1;
            Set<string> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (var item in set1.Intersection(set2))
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
            this.lblSetAnswerName.Text = rm.GetString("Difference");

            Set<string> set1;
            Set<string> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (var item in set1.Difference(set2))
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
            this.lblSetAnswerName.Text = rm.GetString("SubSet");

            Set<string> set1;
            Set<string> set2;

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
            this.lblSetAnswerName.Text = rm.GetString("SymDifference");

            Set<string> set1;
            Set<string> set2;

            if (this.StringToSet(out set1, out set2))
            {
                string s3 = "";
                foreach (var item in set1.SymmetricDifference(set2))
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
            this.lblSetAnswerName.Text = rm.GetString("Action");
            this.lblSetAnswer.Text = ""; 
        }

        private void btnRU_Click(object sender, EventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "ru")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru");
                Properties.Settings.Default.Language = "ru";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void btnENG_Click(object sender, EventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "en")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");
                Properties.Settings.Default.Language = "en";
                Properties.Settings.Default.Save();
                Application.Restart();
            }

        }
    }
}
