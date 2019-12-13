using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Nhom9
{
    public partial class Frm_Dn : Form
    {
        public Frm_Dn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "- Cây nhị phân (tiếng Anh: binary tree) là một cấu trúc dữ liệu cây mà mỗi nút có nhiều nhất hai nút con, " +
                            "được gọi là con trái (left child) và con phải (right child).";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "- Bậc của một nút: là số cây con của nút đó." + "\n- Bậc của cây: là bậc lớn nhất của các nút trong cây.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "- Nút gốc: là nút không có nút cha.\n" + "- Nút lá: là nút có bậc bằng không (không có nút con)\n" + "- Nút nhánh: là không phải nút gốc và có bậc khác 0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "- Số nút nằm ở mức i nhỏ hơn hoặc bằng 2^i.\n" + "- Số nút lá <=2^(h-1), với h là chiều cao của cây.\n" + "- Chiều cao cây h>=log2(N), với N là số nút trong cây\n" + "- Số nút trong cây <=2^(h-1)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "- Cây nhị phân tìm kiếm là cây nhị phân nhưng có thêm các ràng buộc:\n+ Giá trị của tất cả các Node ở cây con bên trái phải < giá trị của Node gốc.\n+ Giá trị của tất cả các Node ở cây con bên phải phải > giá trị của Node gốc.\n+ Tất cả các cây con(bao gồm bên trái và phải) cũng đều phải đảm bảo 2 tính chất trên.\n- Cây nhị phân tìm kiếm giúp sắp xếp dữ liệu, tốc độ chèn, xóa và tìm kiếm nhanh hơn so với cây nhị phân thông thường.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "- Luôn so sánh với nút gốc.\n- Bé hơn bên trái, Lớn hơn bên phải.";
        }
    }
}
