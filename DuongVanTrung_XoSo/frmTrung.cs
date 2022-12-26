using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace DuongVanTrung_XoSo
{
    public partial class Form1 : Form
    {
        Color color;
        DateTime timeOpen;
        int selectDai = -1;
        public static string checkResult,maDai;
        public static bool Open = false;
        
        Label[] arr_GiaiHN, arr_GiaiDaN, arr_GiaiHCM;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void lb_MouseHover(object sender, System.EventArgs e)
        {
            var lb = (Label)sender;
            color = lb.BackColor;
            lb.BackColor = Color.White;

        }
        private void lb_MouseLeave(object sender, System.EventArgs e)
        {
            var lb = (Label)sender;
            lb.BackColor = color;
        }

        private void comboBox_dai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectDai=comboBox.SelectedIndex;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Label[] arr_HN = {lb_HNGiai8,lb_HNGiai7,lb_HNGiai6_1,lb_HNGiai6_2,lb_HNGiai6_3,lb_HNGiai5
            ,lb_HNGiai4_1,lb_HNGiai4_2,lb_HNGiai4_3,lb_HNGiai4_4,lb_HNGiai4_5
            ,lb_HNGiai3_1,lb_HNGiai3_2,lb_HNGiai2,lb_HNGiai1
            ,lb_HNGiaiDB};
            Label[] arr_DaN = {lb_DaNGiai8,lb_DaNGiai7,lb_DaNGiai6_1,lb_DaNGiai6_2,lb_DaNGiai6_3,lb_DaNGiai5
            ,lb_DaNGiai4_1,lb_DaNGiai4_2,lb_DaNGiai4_3,lb_DaNGiai4_4,lb_DaNGiai4_5
            ,lb_DaNGiai3_1,lb_DaNGiai3_2,lb_DaNGiai2,lb_DaNGiai1
            ,lb_DaNGiaiDB};
            Label[] arr_HCM = {lb_HCMGiai8,lb_HCMGiai7,lb_HCMGiai6_1,lb_HCMGiai6_2,lb_HCMGiai6_3,lb_HCMGiai5
            ,lb_HCMGiai4_1,lb_HCMGiai4_2,lb_HCMGiai4_3,lb_HCMGiai4_4,lb_HCMGiai4_5
            ,lb_HCMGiai3_1,lb_HCMGiai3_2,lb_HCMGiai2,lb_HCMGiai1
            ,lb_HCMGiaiDB};

            arr_GiaiHN = arr_HN;
            arr_GiaiDaN = arr_DaN;
            arr_GiaiHCM = arr_HCM;
            dateTime_xoSo.Value=DateTime.Now;
            dateTime_search.Value = DateTime.Now;
            if (checkRolled("dataHN") == true && checkRolled("dataDaN") == true
                && checkRolled("dataHCM") == true)
            {
                Open = true;
                //MessageBox.Show("hh");
            } else
            {
                //MessageBox.Show("dd");

            }

            show(arr_GiaiHN, "dataHN");
            show(arr_GiaiDaN, "dataDaN");
            show(arr_GiaiHCM, "dataHCM");


            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime crTime = DateTime.Now;

            DateTime setTime = Form2.dateTime;
            if (checkRolled("dataHN") == true && checkRolled("dataDaN") == true
                    && checkRolled("dataHCM") == true)
            {
                Open = true;
            }

            if (Open == false)
            {
                if (crTime >= setTime)
                {
                    
                    bool rollHN=false, rollDaN=false, rollHCM = false;
                    if(checkRolled("dataHN") == false)
                    {
                        rollHN = true;
                    }
                    if (checkRolled("dataDaN") == false)
                    {
                        rollDaN = true;
                    }
                    if (checkRolled("dataHCM") == false)
                    {
                        rollHCM = true;
                    }
                    open(rollHN, rollDaN, rollHCM);
                    Open = true;
                }
                if (crTime < setTime)
                {
                    if (checkRolled("dataHN") == false && checkRolled("dataDaN") == false
                    && checkRolled("dataHCM") == false)
                    {
                        Open = false;
                    }
                }

                if (Form2.click_manual == true)
                {
                    checkRolled("dataHN");
                    checkRolled("dataDaN");
                    checkRolled("dataHCM");
                    open(Form2.HN, Form2.DaN, Form2.HCM);
                    Form2.click_manual = false;

                    if (checkRolled("dataHN") == true && checkRolled("dataDaN") == true
                    && checkRolled("dataHCM") == true)
                    {
                        Open = true;
                    }
                }

            }


            if (Open == true)
            {
                lb_timeResult.Text = "Hôm nay đã mở thưởng";
            }
            else
            {
                lb_timeResult.Text = "Tự động mở thưởng tất cả đài sau: " + setTime;
            }
        }

        public bool checkRolled(string dai)
        {
            try
            {
                string[] lines = File.ReadAllLines("D:\\dataXoSo\\" + dai + ".txt");
                switch (dai)
                {
                    case "dataDaN":
                        foreach (string line in lines)
                        {
                            if(line.Trim() == "")
                            {
                                continue;
                            }
                            string[] splitData = line.Trim().Replace(" ", "").Split(',');
                            if (DateTime.Parse(splitData[0]) == DateTime.Parse(DateTime.Now.ToShortDateString())) {
                                Form2.DaN = false;

                                return true;
                            }
                        }
                        return false;
                    case "dataHN":
                        foreach (string line in lines)
                        {
                            if (line.Trim() == "")
                            {
                                continue;
                            }
                            string[] splitData = line.Trim().Replace(" ", "").Split(',');
                            if (DateTime.Parse(splitData[0]) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                            {
                                Form2.HN = false;

                                return true;
                            }
                        }
                        return false;
                    case "dataHCM":
                        foreach (string line in lines)
                        {
                            if (line.Trim() == "")
                            {
                                continue;
                            }
                            string[] splitData = line.Trim().Replace(" ", "").Split(',');
                            if (DateTime.Parse(splitData[0]) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                            {
                                Form2.HCM = false;

                                return true;
                            }
                        }
                        return false;
                    default:
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        public async void open(bool HN, bool DaN, bool HCM)
        {
            if (HN == true)
            {
                open_dai(arr_GiaiHN,"HN");
                Form2.HN=false;
            }
            if (DaN == true)
            {
                
                open_dai(arr_GiaiDaN,"DaN");
                Form2.DaN = false;
            }
            if (HCM == true)
            {
                Form2.HCM = false;
                open_dai(arr_GiaiHCM,"HCM");
            }
            
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (selectDai == 0)
            {
                search("dataHN");
            }
            if (selectDai == 1)
            {
                search("dataDaN");
            }
            if (selectDai == 2)
            {
                search("dataHCM");
            }
            if (selectDai == -1)
            {
                MessageBox.Show("Vui lòng chọn đài");
            }
        }

        public void search(String file)
        {
            try
            {
                string[] line = File.ReadAllLines("D:\\dataXoSo\\" + file + ".txt");
                
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i].Trim() == "") continue;
                    string[] data = line[i].Trim().Replace(" ", "").Split(',');
                    if (DateTime.Parse(data[0]) == DateTime.Parse(dateTime_search.Value.ToShortDateString()))
                    {
                        bool kq = false;
                        for (int j = 1; j < data.Length; j++)
                        {
                            if (data[j] == nbUpDown_search.Text.ToString())
                            {

                                lb_searchResult.Text = "Chúc mừng bạn !!!!!\n " +
                                    "Có kết quả tìm kiếm vào ngày : "
                                    + dateTime_search.Value.ToShortDateString();
                                btn_check.Visible = true;
                                checkResult = dateTime_search.Value.ToShortDateString();
                                maDai = file;
                                kq = true;
                                break;
                            }
                        }
                        if (kq == false)
                        {
                            lb_searchResult.Text = "Không tìm thấy kết quả !!!!!";
                            btn_check.Visible = false;
                            checkResult = dateTime_search.Value.ToShortDateString();
                            maDai = file;
                        }
                        break;

                    }
                    else
                    {
                        btn_check.Visible = false;
                        maDai = "";
                        checkResult = "";
                        lb_searchResult.Text = "Không tìm thấy kết quả !!!!!";
                    }
                }
            }
            catch(Exception e)
            {
                btn_check.Visible = false;
                maDai = "";
                checkResult = "";
                lb_searchResult.Text = "Không tìm thấy kết quả !!!!!";
            }

        }

        private void dateTime_xoSo_ValueChanged(object sender, EventArgs e)
        {
            show(arr_GiaiHN, "dataHN");
            show(arr_GiaiDaN, "dataDaN");
            show(arr_GiaiHCM, "dataHCM");
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
        private void show(Label[] arr, String file)
        {
            try
            {
                
                    String[] line = File.ReadAllLines("D:\\dataXoSo\\" + file + ".txt");

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].Trim() == "")
                        {
                            continue;
                        }
                        string[] data = line[i].Trim().Replace(" ","").Split(',');
                        if (DateTime.Parse(data[0]) == DateTime.Parse(dateTime_xoSo.Value.ToShortDateString()))
                        {
                            for (int j = 1; j < data.Length; j++)
                            {
                                arr[j - 1].Text = data[j];
                            }
                            break;

                        }
                        else
                        {
                            switch (file)
                            {
                                case "dataHN":
                                    dataDefault(arr_GiaiHN);
                                    break;
                                case "dataDaN":
                                    dataDefault(arr_GiaiDaN);
                                    break;
                                case "dataHCM":
                                    dataDefault(arr_GiaiHCM);
                                    break;
                                default:
                                    break;
                            }

                        }

                    }
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                switch (file)
                {
                    case "dataHN":
                        dataDefault(arr_GiaiHN);
                        break;
                    case "dataDaN":
                        dataDefault(arr_GiaiDaN);
                        break;
                    case "dataHCM":
                        dataDefault(arr_GiaiHCM);
                        break;
                    default:
                        break;
                }
            }
            
            
        }

        private void nbUpDown_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void dataDefault(Label[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (i < 1)
                {
                    arr[i].Text = "XX" ;
                }
                else if (i < 2)
                {
                    arr[i].Text = "XXX";
                }
                else if (i < 13)
                {
                    arr[i].Text = "XXXX";
                }
                else if (i < 15)
                {
                    arr[i].Text = "XXXXX";
                }
                else if (i < 16)
                {
                    arr[i].Text = "XXXXXX";
                }
            }
        }

        public async void open_dai(Label[] arr,String dai)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < 20; j++)
                {
                    int so1 = random.Next(9);
                    int so2 = random.Next(9);
                    int so3 = random.Next(9);
                    int so4 = random.Next(9);
                    int so5 = random.Next(9);
                    int so6 = random.Next(9);
                    if (i < 1)
                    {
                        arr[i].Text = "" + so1 + so2;
                    }
                    else if (i < 2)
                    {
                        arr[i].Text = "" + so1 + so2 + so3;
                    }
                    else if (i < 13)
                    {
                        arr[i].Text = "" + so1 + so2 + so3 + so4;
                    }
                    else if (i < 15)
                    {
                        arr[i].Text = "" + so1 + so2 + so3 + so4 + so5;
                    }
                    else if (i < 16)
                    {
                        arr[i].Text = "" + so1 + so2 + so3 + so4 + so5 + so6;
                    }

                    await Task.Delay(100);

                }


            }
            write(arr, dai);
            
        }
        public void write(Label[] arr, string dai)
        {
            
            switch (dai)
            {
                case "HN":
                    string dataHN = "";
                    dataHN += DateTime.Now.ToShortDateString();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string txt = arr[i].Text.ToString();
                        dataHN += "," + txt;
                    }

                    File.AppendAllText("D:\\dataXoSo\\dataHN.txt", dataHN + "\n");
                    

                    break;
                case "DaN":
                    string dataDaN = "";
                    dataDaN += DateTime.Now.ToShortDateString();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string txt = arr[i].Text.ToString();
                        dataDaN += "," + txt;
                    }

                    File.AppendAllText("D:\\dataXoSo\\dataDaN.txt", dataDaN + "\n");
                    

                    break;
                case "HCM":
                    string dataHCM = "";
                    dataHCM += DateTime.Now.ToShortDateString();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string txt = arr[i].Text.ToString();
                        dataHCM += "," + txt;
                    }

                    File.AppendAllText("D:\\dataXoSo\\dataHCM.txt", dataHCM + "\n");
                    

                    break;
                default:
                    break;
            }
        }

    }

}

