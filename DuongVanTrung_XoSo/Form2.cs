using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongVanTrung_XoSo
{
    public partial class Form2 : Form
    {
        
        public static DateTime dateTime = DateTime.Parse("17:00:00");
        public static bool HN,DaN,HCM,click_auto,click_manual = false;

        
        public Form2()
        {
            InitializeComponent();
        }

        

        private void radio_btn_auto_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radio_btn_auto.Checked==true)
            {
                gr_box_auto.Visible = true;
            }
            else
            {
                gr_box_auto.Visible = false;
                
            }
        }

        private void radio_btn_manual_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_btn_manual.Checked == true)
            {
                gr_box_manual.Visible = true;
            
            }
            else
            {
                gr_box_manual.Visible= false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            dateTime = DateTime.Parse(time_auto.Value.ToShortTimeString());
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (radio_btn_auto.Checked==true)
            {
                
                 dateTime = DateTime.Parse(time_auto.Value.ToShortTimeString());
                MessageBox.Show("Thiết lập quay tự động thành công");

            }
            if (radio_btn_manual.Checked == true)
            {
                if(Form1.Open == false)
                {
                    if(cb_HN.Checked == false && cb_DaN.Checked == false && cb_HCM.Checked == false)
                    {
                        MessageBox.Show("Vui lòng chọn đài");
                    }
                    else
                    {
                        if (cb_HN.Checked == true)
                        {
                            if (HN == true)
                            {
                                MessageBox.Show("Vui lòng quay lại vào ngày mai");
                            }
                            else
                            {
                                HN = true;
                            }
                            
                        }
                        if (cb_DaN.Checked == true)
                        {
                            if (DaN == true)
                            {
                                MessageBox.Show("Vui lòng quay lại vào ngày mai");
                            }
                            else
                            {
                                DaN= true;
                            }
                        }
                        if (cb_HCM.Checked == true)
                        {
                            if (HCM == true)
                            {
                                MessageBox.Show("Vui lòng quay lại vào ngày mai");
                            }
                            else
                            {
                                HCM = true;
                            }
                        }
                        click_manual = true;
                        MessageBox.Show("Đã mở");
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng quay lại vào ngày mai !!!!!");
                }

            }
        }
    }
}
