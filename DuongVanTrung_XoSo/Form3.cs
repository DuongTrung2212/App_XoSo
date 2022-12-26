using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongVanTrung_XoSo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

            switch (Form1.maDai)
            {
                case "dataHN":
                    show("Hà Nội", "XSHN", Form1.maDai);
                    break;
                case "dataDaN":
                    show("Đà Nẵng", "XSDaN", Form1.maDai);
                    break;
                case "dataHCM":
                    show("TP.HCM", "XSHCM", Form1.maDai);
                    break;
                default:
                    break;
            }
        }
        private void show(String dai,String maDai,String file)
        {
            Label[] arrGiai = {lb_Giai8,lb_Giai7,lb_Giai6_1,lb_Giai6_2,lb_Giai6_3,lb_Giai5
                ,lb_Giai4_1,lb_Giai4_2,lb_Giai4_3,lb_Giai4_4,lb_Giai4_5
                ,lb_Giai3_1,lb_Giai3_2,lb_Giai2,lb_Giai1
                ,lb_GiaiDB};
            lb_date.Text = Form1.checkResult;
            lb_name.Text = dai;
            this.Text = dai;
            lb_maDai.Text = maDai;
            String[] line=File.ReadAllLines("D:\\dataXoSo\\" + file + ".txt");
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].Trim() == "") continue;

                string[] data = line[i].Trim().Replace(" ", "").Split(',');
                if (DateTime.Parse(data[0]) == DateTime.Parse(Form1.checkResult))
                {
                    for (int j = 1; j < data.Length; j++)
                    {
                        arrGiai[j - 1].Text= data[j];
                    }
                    break;

                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
