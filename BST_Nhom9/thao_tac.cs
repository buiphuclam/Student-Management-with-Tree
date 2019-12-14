using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Nhom9
{
    class thao_tac
    {

        public static void Themnut(int x, int y, int data, ref int k, int[] B, ref int wi, ref int h)
        {

            h = 0;
            int height = x;
            //k = 1;
            int width = y;
            B[1] = 1;
            B[0] = 1;
            //MessageBox.Show(k.ToString());
            //tree.Add_node(A[i], ref k, ref B, ref DL);
            wi = width;
            for (int j = 1; j <= k; j++)
            {

                h = h + height / 8;
                // dai[j] = h;
                Console.WriteLine("h= {0}", h);
                if (B[j - 1] == 1)
                {
                    if (B[j] == 1)
                    {
                        if ((B[2] == 1 && j > 2) || j <= 2)
                        {
                            wi = wi / 2; // 1
                                         // rong[j] = wi;
                        }


                        //
                        if (B[2] == 0 && j > 2)
                        {
                            wi = wi - width / Form2.mu(j, 2);
                            // rong[j] = wi;
                        }
                    }
                    else
                    {
                        wi = wi + (width / Form2.mu(j, 2));//1
                        //rong[j] = wi;
                    }
                }
                else
                {
                    if (B[j] == 1)
                    {
                        wi = wi - width / Form2.mu(j, 2);//1
                        //rong[j] = wi;
                    }

                    else
                    {
                        wi = wi + width / Form2.mu(j, 2);
                        //rong[j] = wi;
                    }

                }

            }
        }
    }
}
