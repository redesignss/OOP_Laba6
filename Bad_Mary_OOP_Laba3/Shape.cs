using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;


namespace Bad_Mary_OOP_Laba3
{
    public class Obj
    {
        public int x, y, r;
        public Obj(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
    }
    public abstract class Shape
    {
        public int x, y, r;
        //public double r;
        public bool flag = false;

        public Shape(Obj value)
        {
            x = value.x;
            y = value.y;
            r = value.r;
        }

        public Shape(int x1, int y1, int r1)
        {
            x = x1;
            y = y1;
            r = r1;
        }

        public abstract void Show();
        public abstract void Move(Obj MyObject); // for 6 laba
        public abstract void ChangeR(Obj MyObject); // for 6 laba
        public abstract bool CheckPoint(int _x, int _y); //proverka na vhodimost
        public abstract void Draw(Obj MyObject);  //drawing figure
    }

    public class Circle : Shape
    {
        public Circle(Obj value) : base(value)
        {
        }

        public Circle(int x1, int y1, int r1) : base(x1, y1, r1)  //как правильно?
        {
        }

        public override void ChangeR(Obj track)
        {

        }

        public override void Show()
        {
            Console.WriteLine("Это окружность с центром Х={0} Y={1} и радиусом R={2}", x, y, r);
        }

        public override void Move(Obj track)
        {

        }

        public override bool CheckPoint(int dx, int dy)
        {
            dx = x - dx;
            dy = y - dy;
            if (dx * dx + dy * dy <= r * r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Draw(Obj bmp)
        {
            /*
            Pen pen;
            if (flag)
            {
                pen = new Pen(Color.Blue);
            }
            else
            {
                pen = new Pen(Color.Red);
            }
            graph.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
            */
        }
    }
}