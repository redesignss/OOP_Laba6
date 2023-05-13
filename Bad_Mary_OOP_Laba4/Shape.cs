using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Bad_Mary_OOP_Laba4
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
        public Color color = Color.Blue;
        public int x, y, r;
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

        
        public virtual void Move(int dx, int dy) { //метод передвижения фигуры
            x = x + dx;
            y = y + dy;
        } 
        public virtual void ChangeR(int dr) { //изминения размера
            r += dr;
            if (r < 1)
            {
                r = 1;
            }
        } 
        public abstract bool CheckPoint(int _x, int _y); 
        public abstract bool CheckBorder(int _x, int _y); 
        public abstract void Draw(Graphics graph);  
    }
    public class Circle : Shape

    {
        public Circle(Obj value) : base(value)
        {
        }

        public Circle(int x1, int y1, int r1) : base(x1, y1, r1) 
        {
        }

       
        public override bool CheckBorder(int _x, int _y) //проверка на границы 
        {
            if (x - r <= 0) 
            {
                return false; 
            }
            if (x + r >= _x) //_x гроница формы
            {
                return false;
            }
            if (y - r <= 0)
            {
                return false;
            }
            if (y + r >= _y)
            {
                return false;
            }
            return true;
        }
        
        public override bool CheckPoint(int dx, int dy) //проверка на ножатие
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
        
        public override void Draw(Graphics graph) //рисование фигуры
        {
           Pen pen;
           
            if (flag)
            {
                
                pen = new Pen(color, 5);
            }
            else
            {
                
                pen = new Pen(color);
            }
            graph.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);   
          
        }
    }
    public class Square : Shape //квадрат
    {
        public Square(Obj value) : base(value)
        {
        }
        public Square(int x1, int y1, int r1) : base(x1, y1, r1)
        {
        }
        public override bool CheckPoint(int dx, int dy) //проверка на нажатие
        {
            
            if (dx >= (x - r) && dx <= (x + r) && dy >= (y - r) && dy <= (y + r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public override void Draw(Graphics graph)
        {
            Pen pen;

            if (flag)
            {
                
                pen = new Pen(color, 5);
            }
            else
            {
                
                pen = new Pen(color);
            }
            graph.DrawRectangle(pen, x - r, y - r, 2 * r, 2 * r);   

        }
        public override bool CheckBorder(int width, int height) //границы
        {
            if (x - r  <= 0)
            {
                return false;
            }
            if (x + r >= width)
            {
                return false;
            }
            if (y - r  <= 0)
            {
                return false;
            }
            if (y + r  >= height)
            {
                return false;
            }
            return true;
        }
        
    }
    public class Triangle : Shape //треугольник
    {
        private Point[] points = new Point[4]; //массив из 4 точек
        public Triangle(Obj value) : base(value)
        {
        }

        public Triangle(int x1, int y1, int r1) : base(x1, y1, r1)
        {
            points[0].X = (int)(x1 - r1 / 2 * Math.Sqrt(3));
            points[0].Y = (y1 + r1 / 2);
            points[1].X = x1;
            points[1].Y = y1 - r1;
            points[2].X = (int)(x1 + r1 / 2 * Math.Sqrt(3));
            points[2].Y = (y1 + r1 / 2);
            points[3].X = points[0].X;
            points[3].Y = points[0].Y;

        }
        public void CountPoints() {
            points[0].X = (int)(x - r / 2 * Math.Sqrt(3));
            points[0].Y = (y + r / 2);
            points[1].X = x;
            points[1].Y = y - r;
            points[2].X = (int)(x + r / 2 * Math.Sqrt(3));
            points[2].Y = (y + r / 2);
            points[3].X = points[0].X;
            points[3].Y = points[0].Y;
        }

        public override void ChangeR(int dr) {
            r += dr;
            if (r < 1)
            {
                r = 1;
            }
            CountPoints();
        }
        public override bool CheckBorder(int _x, int _y)
        {
            if (x - r <= 0)
            {
                return false;
            }
            if (x + r >= _x)
            {
                return false;
            }
            if (y - r <= 0)
            {
                return false;
            }
            if (y + r >= _y)
            {
                return false;
            }
            return true;
        }

        public override void Move(int dx, int dy) //движение
        {
            x += dx;
            y += dy;
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += dx;
                points[i].Y += dy;
            }
        }

        public override bool CheckPoint(int dx, int dy)
        {
            var p1 = (points[0].X - dx) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - dy);
            var p2 = (points[1].X - dx) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - dy);
            var p3 = (points[2].X - dx) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - dy);
            //векторная площадь треугольника
            if (p1 <= 0 && p2 <= 0 && p3 <= 0 || p1 >= 0 && p2 >= 0 && p3 >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Draw(Graphics graph)
        {
            Pen pen;
            if (flag)
            {
                pen = new Pen(color, 5);
            }
            else
            {
                pen = new Pen(color);
            }
            graph.DrawLines(pen, points); 

        }
    }

}
