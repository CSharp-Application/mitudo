using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人口密度
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change(object sender,EventArgs e)
        {
            double i_km2 = 0;
            double i_hito = 0;
            if(!double.TryParse(km2.Text,out i_km2))
            {
                kekka.Text = "1㎢当たり人";
                return;
            }
            if(!double.TryParse(hito.Text,out i_hito))
            {
                kekka.Text = "1㎢当たり人";
                return;
            }
            kekka.Text = $"1㎢当たり{i_hito / i_km2}人";
        }
    }
}