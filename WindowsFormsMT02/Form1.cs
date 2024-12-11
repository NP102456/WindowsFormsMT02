using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMT02
{
    public partial class Form1 : Form
    {
        private double d;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // double r = 0;
            // if (!double.TryParse(txtRadius.Text, out r)) 
            // {
            //     MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            // }
            // CircleArea(r);

            //CircleArea(txtRadius); 

            CircleArea(txtRadius, lblRusult);
        }
        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lblRusult.Text = area.ToString();
        }
        void CircleArea(TextBox txt)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            }
            double area = Math.PI * r * r;
            lblRusult.Text = area.ToString();
        }
        void CircleArea(TextBox txt, Label lbl)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString();
        }

        private void btncircumference_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            lblRusult.Text = Circunference(r).ToString();
        }
        double Circunference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        string triangle(string latter = "*", int size=5)
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    result += latter;
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private void btnTriangle01_Click(object sender, EventArgs e)
        {
            //txtoutput.Text = triangle();
            //txtoutput.Text = triangle(txtletter.Text);
            txtoutput.Text = triangle(txtletter.Text,9);
        }
        void ImproveName(ref string name)
        {
            name = name.Trim();
            if (name .Length<2)
            {
                MessageBox.Show("โปรดกรอกชื่อให้ถูกต้อง", "ข้อมูลผิดพลาด");
                return;
            }
            
        }

        private void btnRefparameter_Click(object sender, EventArgs e)
        {
            string FName = txtinput.Text;
           // ImproveName(FName);
            txtinput.Text = ImproveName02 (FName);
        }
        string ImproveName02(string name)
        {
            name = name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("โปรดกรอกชื่อให้ถูกต้อง", "ข้อมูลผิดพลาด");
            }
            return name;
        }
        Boolean ImproveName03(string name,out string x)
        {
            x = name.Trim();
            if (x.Length < 2) 
            {
                x= "";
                return false;
            }
            return true;
        }

        private void btnoutputParameter_Click(object sender, EventArgs e)
        {
            string Fname = "";
            if (ImproveName03(txtinput.Text, out Fname))
            {
                txtinput.Text = Fname;
            }
            else 
            {
                MessageBox.Show("ข้อมูลผิดพลาด", "โปรดกรอกให้ถูกต้อง");
            }
        }

        private void btnArrayparameter_Click(object sender, EventArgs e)
        {
            double[] data = new double[] {1.5, 2.0, 3.25, 0.15};
            double summary = sum(data);
            string result = string.Join("/",data);
            result += Environment.NewLine;
            result += summary.ToString();
            MessageBox.Show(result, "ผลรวมของค่าใน Array");
        }
        double sum(double[] dataArray) 
        {
            double sum = 0;
            foreach (double d in dataArray) 
            {
                sum += d;
            }
            return sum;
        }
    }
}
