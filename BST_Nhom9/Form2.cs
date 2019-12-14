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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int x;
        BTS_Tree tree = new BTS_Tree();
        int a = 0;
        int b = 0;
        int[] trai = new int[100];
        int phiatrai;
        //Graphics g = pt_cay.CreateGraphics();
        int[] A = new int[100];

        public int kt(int[] A, int n, int x)
        {
            for (int i = 0; i <= n; i++)
                if (A[i] == x)
                    return 1;
            return 0;
        }
        public static int mu(int x, int y)
        {
            int kq = 1;
            for (int i = 1; i <= x; i++)
                kq = kq * y;
            return kq;
        }
        private void bt_random_Click(object sender, EventArgs e)
        {
            //int[] A = new int[100];
            Graphics g = pt_cay.CreateGraphics();
            int sonut = Int32.Parse(txt_sonut.Text);
            if (sonut > 8)
            {
                MessageBox.Show("DỮ LIỆU NHẬP SAI. VUI LÒNG NHẬP LẠI");
                return;

            }
            string s;
            //int nhi = 0;

            //int x = Convert.ToInt32(txt_sonut.Text);
            x = Convert.ToInt32(txt_sonut.Text);
            Random rd = new Random();
            A[0] = rd.Next(9, 13);
            for (int i = 1; i < x; i++)
            {
                int t = rd.Next(1, 20);

                while (kt(A, i, t) == 1)
                    t = rd.Next(1, 20);
                A[i] = t;
                // s = s + A[i].ToString();
                //MessageBox.Show("a "+A[i].ToString());
            }

            for (int i = 0; i < Convert.ToInt32(txt_sonut.Text); i++)
            {
                phiatrai = 1;
                tree.Add_node(ref trai, ref g, A[i], ref tree.tree, ref phiatrai, pt_cay.Height, pt_cay.Width, ref a, ref b);

                //Thread.Sleep(1000);
            }
            bt_random.Enabled = false;
        }

        private void BT_search_Click(object sender, EventArgs e)
        {
            Graphics g = pt_cay.CreateGraphics();
            int value = Convert.ToInt32(txt_value.Text);
            int kt = tree.search(ref g, tree.tree, value);
            if (kt == 1)
                MessageBox.Show("ĐÃ TÌM THẤY GIÁ TRỊ VALUE!!!");
            else
                MessageBox.Show("KHÔNG TÌM THẤY GIÁ TRỊ VALUE!!!");
            Draw_node.eclip_white(ref g, 10, 10, 40, 40, value);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            //int[] A = new int[100];
            Graphics g = pt_cay.CreateGraphics();
            int t = Convert.ToInt32(txt_value.Text);
            Random rd = new Random();
            for (int j = 1; j < x; j++)
            {
                if (kt(A, j, t) == 1)
                {

                    MessageBox.Show("Dữ liệu nhập vào không phù hợp!. Random giá trị value");
                }
                while (kt(A, j, t) == 1)
                {

                    t = rd.Next(1, 20);
                }

            }

            A[x] = t;
            x++;
            //Graphics g = pt_cay.CreateGraphics();
            g.FillEllipse(Brushes.Red, 10, 10, 40, 40);
            g.DrawEllipse(Pens.Brown, new Rectangle(10, 10, 40, 40));
            g.DrawString(Convert.ToString(A[x - 1]), new Font("Tahoma", 12), Brushes.Black, new PointF(10 + 40 / 3, 10 + 40 / 3));
            phiatrai = 1;
            tree.Add(ref trai, ref g, A[x - 1], ref tree.tree, ref phiatrai, pt_cay.Height, pt_cay.Width, ref a, ref b);

        }

        private void bt_de_Click(object sender, EventArgs e)
        {
            Graphics g = pt_cay.CreateGraphics();
            int t = Convert.ToInt32(txt_value.Text);
            int kt = tree.delete(ref g, ref tree.tree, t);
            if (kt == 0)
                MessageBox.Show("KHÔNG CÓ GIÁ TRỊ VALUE TRONG CÂY ĐỂ XÓA.");
            else

            {
                MessageBox.Show("XÓA THÀNH CÔNG!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt_random.Enabled = true;
            Graphics g = pt_cay.CreateGraphics();
            tree.deleteall(ref g, ref tree.tree);
        }

        private void bt_pre_Click(object sender, EventArgs e)
        {
            string s = "Preorder: ";
            Graphics g = pt_cay.CreateGraphics();
            tree.Preorder(ref g, tree.tree, ref s);
            lb_duye.Text = s;
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            string s = "Inorder: ";
            Graphics g = pt_cay.CreateGraphics();
            tree.Inorder(ref g, tree.tree, ref s);
            lb_duye.Text = s;
        }

        private void bt_post_Click(object sender, EventArgs e)
        {
            string s = "Postorder: ";
            Graphics g = pt_cay.CreateGraphics();
            tree.Postorder(ref g, tree.tree, ref s);
            lb_duye.Text = s;
        }
    }
}
