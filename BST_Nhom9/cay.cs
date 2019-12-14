using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BST_Nhom9
{
    public class cay
    {
        public int Data;
        public cay Left;
        public cay Right;
        public int Toadongang;
        public int Toadodoc;
        public cay()
        {

        }
        public cay(int key, int height, int width)
        {
            Toadongang = width;
            Toadodoc = height;
            Data = key;
            Left = Right = null;
        }

    }
    public class BTS_Tree
    {
        public cay tree;

        public BTS_Tree()
        {
            tree = null;
        }
        int ngang = 0;
        int doc = 0;

        //internal cay Tree { get => tree; set => tree = value; }
        // int toadongangtruoc = 0;
        //int toadodoctruoc = 0;
        public void Add_node(ref int[] trai, ref Graphics g, int newdata, ref cay node, ref int x, int height_pt, int width_pt, ref int toadodoctruoc, ref int toadongangtruoc)
        {


            if (node == null)
            {
                thao_tac.Themnut(height_pt, width_pt, newdata, ref x, trai, ref ngang, ref doc);
                node = new cay(newdata, doc, ngang);
                Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                //MessageBox.Show(toadongangtruoc.ToString());
                if (x != 1)
                    Draw_node.duongthang(ref g, node.Toadongang, node.Toadodoc, toadongangtruoc, toadodoctruoc);
                toadodoctruoc = node.Toadodoc;
                toadongangtruoc = node.Toadongang;


                // MessageBox.Show(toadodoctruoc.ToString() + " " + toadongangtruoc.ToString());
            }
            else
            {
                // tree.insert(ref g,newdata,ref trai,ref x,height_pt,width_pt,ngang,doc,ref toadodoctruoc,ref toadongangtruoc);
                if (newdata < node.Data)
                {
                    x++;
                    trai[x] = 1;
                    toadodoctruoc = node.Toadodoc;
                    toadongangtruoc = node.Toadongang;
                    Add_node(ref trai, ref g, newdata, ref node.Left, ref x, height_pt, width_pt, ref toadodoctruoc, ref toadongangtruoc);
                }
                else
                {
                    x++;
                    trai[x] = 0;
                    toadodoctruoc = node.Toadodoc;
                    toadongangtruoc = node.Toadongang;
                    Add_node(ref trai, ref g, newdata, ref node.Right, ref x, height_pt, width_pt, ref toadodoctruoc, ref toadongangtruoc);
                }
            }
        }

        public void Preorder(ref Graphics g, cay node, ref string s)
        {

            if (node == null) return;
            s = s + node.Data.ToString() + " ";
            Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
            Thread.Sleep(1000);
            Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
            Preorder(ref g, node.Left, ref s);
            Preorder(ref g, node.Right, ref s);
        }


        public void Inorder(ref Graphics g, cay node, ref string s)
        {

            if (node == null) return;
            Inorder(ref g, node.Left, ref s);
            s = s + node.Data.ToString() + " ";
            Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
            Thread.Sleep(1000);
            Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
            Inorder(ref g, node.Right, ref s);
        }
        public void Postorder(ref Graphics g, cay node, ref string s)
        {
            if (node == null)
                return;
            Postorder(ref g, node.Left, ref s);
            Postorder(ref g, node.Right, ref s);
            s = s + node.Data.ToString() + " ";
            Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
            Thread.Sleep(1000);
            Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
        }
        public int search(ref Graphics g, cay node, int key)
        {
            Draw_node.eclip_red(ref g, 10, 10, 40, 40, key);
            if (node == null)
                return 0;

            // MessageBox.Show(A[0].ToString() + i.ToString());
            if (node.Data == key)
            {
                Draw_node.eclip_yellow(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                Thread.Sleep(1000);
                Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                return 1;
            }
            if (node.Data < key)
            {
                Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                Thread.Sleep(1000);
                Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                return search(ref g, node.Right, key);

            }
            else
                if (node.Data > key)
            {
                Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                Thread.Sleep(1000);
                Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                return search(ref g, node.Left, key);
            }
            else
                return 0;

        }
        public void Add(ref int[] trai, ref Graphics g, int newdata, ref cay node, ref int x, int height_pt, int width_pt, ref int toadodoctruoc, ref int toadongangtruoc)
        {


            if (node == null)
            {
                thao_tac.Themnut(height_pt, width_pt, newdata, ref x, trai, ref ngang, ref doc);
                node = new cay(newdata, doc, ngang);


                //MessageBox.Show(toadongangtruoc.ToString());
                if (x != 1)
                    Draw_node.duongthang(ref g, node.Toadongang, node.Toadodoc, toadongangtruoc, toadodoctruoc);
                Draw_node.eclip_yellow(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                Thread.Sleep(1000);
                Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                toadodoctruoc = node.Toadodoc;
                toadongangtruoc = node.Toadongang;


                // MessageBox.Show(toadodoctruoc.ToString() + " " + toadongangtruoc.ToString());
            }
            else
            {
                // tree.insert(ref g,newdata,ref trai,ref x,height_pt,width_pt,ngang,doc,ref toadodoctruoc,ref toadongangtruoc);
                if (newdata < node.Data)
                {
                    x++;
                    trai[x] = 1;
                    toadodoctruoc = node.Toadodoc;
                    toadongangtruoc = node.Toadongang;
                    Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                    Thread.Sleep(1000);
                    Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                    Add(ref trai, ref g, newdata, ref node.Left, ref x, height_pt, width_pt, ref toadodoctruoc, ref toadongangtruoc);
                }
                else
                {
                    x++;
                    trai[x] = 0;
                    toadodoctruoc = node.Toadodoc;
                    toadongangtruoc = node.Toadongang;
                    Draw_node.eclip_red(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                    Thread.Sleep(1000);
                    Draw_node.eclip(ref g, node.Toadongang, node.Toadodoc, 40, 40, node.Data);
                    Add(ref trai, ref g, newdata, ref node.Right, ref x, height_pt, width_pt, ref toadodoctruoc, ref toadongangtruoc);
                }
            }
            Draw_node.eclip_white(ref g, 10, 10, 40, 40, newdata);
        }

        public int delete(ref Graphics g, ref cay node, int data)
        {
            Draw_node.eclip_red(ref g, 10, 10, 40, 40, data);
            cay prdelnode = null;
            int ontheleft = 0;
            cay delnode = node;
            while (delnode != null)
            {
                if (delnode.Data == data)
                {

                    break;
                }
                prdelnode = delnode;

                if (delnode.Data > data)
                {
                    //MessageBox.Show("co dô");
                    Draw_node.eclip_red(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                    Thread.Sleep(1000);
                    Draw_node.eclip(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                    delnode = delnode.Left;
                    ontheleft = 1;
                }
                else
                {
                    //MessageBox.Show("cung co co dô");
                    Draw_node.eclip_red(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                    Thread.Sleep(1000);
                    Draw_node.eclip(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                    delnode = delnode.Right;
                    ontheleft = 0;
                }
            }
            // MessageBox.Show(Convert.ToString(prdelnode.Data));
            if (delnode == null)

                return 0;
            if (prdelnode == null)//delnode là nút gốc
            {

                if (delnode.Left == null && delnode.Right == null)
                {
                    Draw_node.eclip_white(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                    node = null;
                }
                else
                {
                    if (delnode.Left == null)// delnode có 1 cây con phải
                    {
                        Draw_node.eclip_white(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                        Draw_node.duongthang_trang(ref g, delnode.Toadongang, delnode.Toadodoc, delnode.Right.Toadongang, delnode.Right.Toadodoc);
                        Draw_node.eclip(ref g, delnode.Right.Toadongang, delnode.Right.Toadodoc, 40, 40, delnode.Right.Data);
                        node = node.Right;
                        delnode.Right = null;
                    }
                    else
                    {
                        if (delnode.Right == null) // delnode có 1 cây con trái
                        {
                            Draw_node.eclip_white(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                            Draw_node.duongthang_trang(ref g, delnode.Toadongang, delnode.Toadodoc, delnode.Left.Toadongang, delnode.Left.Toadodoc);
                            Draw_node.eclip(ref g, delnode.Left.Toadongang, delnode.Left.Toadodoc, 40, 40, delnode.Left.Data);
                            node = node.Left;
                            delnode.Left = null;
                        }
                    }

                }

            }
            else
            {

                if (delnode.Left == null && delnode.Right == null)// lá
                {

                    if (ontheleft == 1)
                    {
                        Draw_node.eclip_yellow(ref g, prdelnode.Left.Toadongang, prdelnode.Left.Toadodoc, 40, 40, prdelnode.Left.Data);
                        Thread.Sleep(1000);
                        Draw_node.eclip_white(ref g, prdelnode.Left.Toadongang, prdelnode.Left.Toadodoc, 40, 40, prdelnode.Left.Data);
                        Draw_node.duongthang_trang(ref g, prdelnode.Left.Toadongang, prdelnode.Left.Toadodoc, prdelnode.Toadongang, prdelnode.Toadodoc);
                        Draw_node.eclip(ref g, prdelnode.Toadongang, prdelnode.Toadodoc, 40, 40, prdelnode.Data);
                        prdelnode.Left = null;
                    }
                    else
                    {
                        Draw_node.eclip_yellow(ref g, prdelnode.Right.Toadongang, prdelnode.Right.Toadodoc, 40, 40, prdelnode.Right.Data);
                        Thread.Sleep(1000);
                        Draw_node.eclip_white(ref g, prdelnode.Right.Toadongang, prdelnode.Right.Toadodoc, 40, 40, prdelnode.Right.Data);
                        Draw_node.duongthang_trang(ref g, prdelnode.Right.Toadongang, prdelnode.Right.Toadodoc, prdelnode.Toadongang, prdelnode.Toadodoc);
                        Draw_node.eclip(ref g, prdelnode.Toadongang, prdelnode.Toadodoc, 40, 40, prdelnode.Data);
                        prdelnode.Right = null;
                    }
                }
                else
                {

                    if (delnode.Left == null)// delnode có 1 cây con phải
                    {
                        if (ontheleft == 1)
                        {
                            prdelnode.Left = delnode.Right;
                        }
                        else
                        {
                            prdelnode.Right = delnode.Right;
                        }
                        Draw_node.eclip_yellow(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                        Thread.Sleep(1000);
                        Draw_node.eclip_white(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                        Draw_node.duongthang_trang(ref g, prdelnode.Toadongang, prdelnode.Toadodoc, delnode.Toadongang, delnode.Toadodoc);
                        Draw_node.duongthang_trang(ref g, delnode.Right.Toadongang, delnode.Right.Toadodoc, delnode.Toadongang, delnode.Toadodoc);
                        Draw_node.duongthang(ref g, delnode.Right.Toadongang, delnode.Right.Toadodoc, prdelnode.Toadongang, prdelnode.Toadodoc);
                        Draw_node.eclip(ref g, prdelnode.Toadongang, prdelnode.Toadodoc, 40, 40, prdelnode.Data);
                        Draw_node.eclip(ref g, delnode.Right.Toadongang, delnode.Right.Toadodoc, 40, 40, delnode.Right.Data);
                        delnode.Right = null;
                    }
                    else // delnode có 1 cây con trái
                    {
                        if (delnode.Right == null)
                        {
                            if (ontheleft == 1)
                                prdelnode.Left = delnode.Left;
                            else
                                prdelnode.Right = delnode.Left;
                            Draw_node.eclip_yellow(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                            Thread.Sleep(1000);
                            Draw_node.eclip_white(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                            Draw_node.duongthang_trang(ref g, prdelnode.Toadongang, prdelnode.Toadodoc, delnode.Toadongang, delnode.Toadodoc);
                            Draw_node.duongthang_trang(ref g, delnode.Left.Toadongang, delnode.Left.Toadodoc, delnode.Toadongang, delnode.Toadodoc);
                            Draw_node.duongthang(ref g, delnode.Left.Toadongang, delnode.Left.Toadodoc, prdelnode.Toadongang, prdelnode.Toadodoc);
                            Draw_node.eclip(ref g, prdelnode.Toadongang, prdelnode.Toadodoc, 40, 40, prdelnode.Data);
                            Draw_node.eclip(ref g, delnode.Left.Toadongang, delnode.Left.Toadodoc, 40, 40, delnode.Left.Data);
                            delnode.Left = null;
                        }
                    }
                }
            }
            if (delnode.Left != null && delnode.Right != null)// dell node có 2 cây con
            {
                //y = 2;
                Draw_node.eclip_red(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, delnode.Data);
                Thread.Sleep(1000);
                cay MLNode = delnode.Right;
                cay PrMLNode = delnode;
                while (MLNode.Left != null)
                {
                    Draw_node.eclip_pink(ref g, MLNode.Toadongang, MLNode.Toadodoc, 40, 40, MLNode.Data);
                    Thread.Sleep(1000);
                    Draw_node.eclip(ref g, MLNode.Toadongang, MLNode.Toadodoc, 40, 40, MLNode.Data);
                    PrMLNode = MLNode;
                    MLNode = MLNode.Left;
                }
                Draw_node.eclip_pink(ref g, MLNode.Toadongang, MLNode.Toadodoc, 40, 40, MLNode.Data);
                Thread.Sleep(1000);
                Draw_node.eclip_yellow(ref g, MLNode.Toadongang, MLNode.Toadodoc, 40, 40, MLNode.Data);
                Thread.Sleep(1000);
                //themang[vttmang] = MLNode.Data;
                delnode.Data = MLNode.Data;
                if (PrMLNode == delnode)
                {
                    PrMLNode.Right = MLNode.Right;
                }
                else
                {
                    PrMLNode.Left = MLNode.Right;
                }

                if (MLNode.Right != null)
                {
                    // kiemtra = 1;

                    Draw_node.eclip_white(ref g, MLNode.Toadongang, MLNode.Toadodoc, 40, 40, MLNode.Data);
                    Draw_node.duongthang_trang(ref g, PrMLNode.Toadongang, PrMLNode.Toadodoc, MLNode.Toadongang, MLNode.Toadodoc);
                    Draw_node.duongthang_trang(ref g, MLNode.Right.Toadongang, MLNode.Right.Toadodoc, MLNode.Toadongang, MLNode.Toadodoc);
                    Draw_node.duongthang(ref g, MLNode.Right.Toadongang, MLNode.Right.Toadodoc, PrMLNode.Toadongang, PrMLNode.Toadodoc);
                    Draw_node.eclip(ref g, PrMLNode.Toadongang, PrMLNode.Toadodoc, 40, 40, PrMLNode.Data);
                    Draw_node.eclip(ref g, MLNode.Right.Toadongang, MLNode.Right.Toadodoc, 40, 40, MLNode.Right.Data);
                }
                else
                {
                    Draw_node.eclip_white(ref g, MLNode.Toadongang, MLNode.Toadodoc, 40, 40, MLNode.Data);
                    Draw_node.duongthang_trang(ref g, PrMLNode.Toadongang, PrMLNode.Toadodoc, MLNode.Toadongang, MLNode.Toadodoc);
                    Draw_node.eclip(ref g, PrMLNode.Toadongang, PrMLNode.Toadodoc, 40, 40, PrMLNode.Data);
                }
                Draw_node.eclip(ref g, delnode.Toadongang, delnode.Toadodoc, 40, 40, MLNode.Data);
                delnode = MLNode;
            }

            delnode = null;
            Draw_node.eclip_white(ref g, 10, 10, 40, 40, data);
            return 1;
        }
        public void deleteall(ref Graphics g, ref cay node)
        {

            cay delnode = node;
            int giatri = delnode.Data;
            while (delete(ref g, ref node, giatri) != 0)
            {
                delnode = node;
                if (delnode != null)
                    giatri = delnode.Data;
            }
            return;
            
        }


    }
}
