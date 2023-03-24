using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btBinhPhuong_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            int ketqua = number * number;
            txtkq.Text = ketqua.ToString();
            
        }

        private void btLapPhuong_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            int ketqua = number * number* number;
            txtkq.Text = ketqua.ToString();
        }

        private void btGiaiThua_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            int ketqua = 1;
            for(int i = 1; i <= number; i++)
            {
                 ketqua = ketqua * i;
            }
            txtkq.Text = ketqua.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình ?",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạn
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("không phải số");
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void btBinhPhuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btBinhPhuong.PerformClick();
        }*/
    }
}
