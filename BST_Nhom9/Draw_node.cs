using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Nhom9
{
    class Draw_node
    {
        public static void eclip(ref Graphics g, int trai, int doc, int dai, int rong, int x)
        {
            g.DrawEllipse(Pens.Brown, new Rectangle(trai, doc, dai, rong));// x, y, with, heigh// quan tâm tới rộng, và dài.tham số đươc truyền vào
            Brush brush = new SolidBrush(Color.ForestGreen);
            g.FillEllipse(brush, trai, doc, dai, rong);
            Brush br = new SolidBrush(Color.Black);
            g.DrawString(Convert.ToString(x), new Font("Tahoma", 12), br, new PointF(trai + dai / 3, doc + rong / 3));
        }
        public static void duongthang(ref Graphics g, int trai, int doc, int dai, int rong)
        {
            //Graphics g = pt_cay.CreateGraphics();
            g.DrawLine(Pens.ForestGreen, trai + 20, doc + 20, dai + 20, rong + 20);// sử dụng drawLine để vẽ đường
        }
        public static void eclip_red(ref Graphics g, int trai, int doc, int dai, int rong, int x)
        {
            g.DrawEllipse(Pens.Brown, new Rectangle(trai, doc, dai, rong));// x, y, with, heigh// quan tâm tới rộng, và dài.tham số đươc truyền vào
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, trai, doc, dai, rong);
            Brush br = new SolidBrush(Color.Black);
            g.DrawString(Convert.ToString(x), new Font("Tahoma", 12), br, new PointF(trai + dai / 3, doc + rong / 3));
        }
        public static void eclip_yellow(ref Graphics g, int trai, int doc, int dai, int rong, int x)
        {
            g.DrawEllipse(Pens.Brown, new Rectangle(trai, doc, dai, rong));// x, y, with, heigh// quan tâm tới rộng, và dài.tham số đươc truyền vào
            Brush brush = new SolidBrush(Color.Yellow);
            g.FillEllipse(brush, trai, doc, dai, rong);
            Brush br = new SolidBrush(Color.Black);
            g.DrawString(Convert.ToString(x), new Font("Tahoma", 12), br, new PointF(trai + dai / 3, doc + rong / 3));
        }
        public static void eclip_white(ref Graphics g, int trai, int doc, int dai, int rong, int x)
        {
            g.DrawEllipse(Pens.White, new Rectangle(trai, doc, dai, rong));// x, y, with, heigh// quan tâm tới rộng, và dài.tham số đươc truyền vào
            Brush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, trai, doc, dai, rong);
            Brush br = new SolidBrush(Color.White);
            g.DrawString(Convert.ToString(x), new Font("Tahoma", 12), br, new PointF(trai + dai / 3, doc + rong / 3));
        }
        public static void duongthang_trang(ref Graphics g, int trai, int doc, int dai, int rong)
        {
            //Graphics g = pt_cay.CreateGraphics();
            g.DrawLine(Pens.White, trai + 20, doc + 20, dai + 20, rong + 20);// sử dụng drawLine để vẽ đường
        }
        public static void eclip_pink(ref Graphics g, int trai, int doc, int dai, int rong, int x)
        {
            g.DrawEllipse(Pens.Brown, new Rectangle(trai, doc, dai, rong));// x, y, with, heigh// quan tâm tới rộng, và dài.tham số đươc truyền vào
            Brush brush = new SolidBrush(Color.HotPink);
            g.FillEllipse(brush, trai, doc, dai, rong);
            Brush br = new SolidBrush(Color.Black);
            g.DrawString(Convert.ToString(x), new Font("Tahoma", 12), br, new PointF(trai + dai / 3, doc + rong / 3));
        }
    }
}
