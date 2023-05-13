using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bad_Mary_OOP_Laba4
{
    public partial class Form1 : Form
    {
        private MyStorage _storage = new MyStorage(20);
        private bool chooseFigure = false;
        public string NameFig = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < _storage.getMaxCount(); i++)
            {

                var shape = _storage.getObj(i);
                if (shape.CheckPoint(e.X, e.Y))     //проверка на нажатие
                {
                    if (shape.flag)               //если попали на выделенный обьект
                    {

                        shape.flag = false;
                        chooseFigure = true; //проверка нажатия на фигуру
                    }
                    else
                    {

                        shape.flag = true;
                        chooseFigure = true;

                    }
                }

            }
            if (chooseFigure == false) //если нажали на пустое место
            {
                if (e.X + 100 <= pictureBox1.Width && e.Y + 100 <= pictureBox1.Height && e.X - 100 >= (pictureBox1.Width - pictureBox1.Width) && e.Y - 100 >= (pictureBox1.Height - pictureBox1.Height))
                    //проверка границы нажатия
                {
                    if (NameFig == "Circle")
                    {
                        Circle circle = new Circle(e.X, e.Y, 100); //размер обьекта
                        _storage.CreatItem(circle);
                    }
                    else if (NameFig == "Square")
                    {
                        Square square = new Square(e.X, e.Y, 100);
                        _storage.CreatItem(square);
                    }
                    else if (NameFig == "Triangle")
                    {
                        Triangle triangle = new Triangle(e.X, e.Y, 100);
                        _storage.CreatItem(triangle);
                    }
                    labelNumber.Text = "Объектов в хранилище " + Convert.ToString(_storage.getMaxCount());
                }
            }
            pictureBox1.Refresh(); //принудительно рисует
            chooseFigure = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e) //удаление обьектов
        {
            for (int i = 0; i < _storage.getMaxCount(); ++i)
            {
                if (_storage.getObj(i).flag)
                {
                    _storage.DeleteItem(i);
                    i--;
                }
            }
            labelNumber.Text = "Объектов в хранилище " + Convert.ToString(_storage.getMaxCount());

            pictureBox1.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < _storage.getMaxCount(); i++)
            {
                _storage.getObj(i).Draw(g);
            }
            labelNumber.Text = "Объектов в хранилище " + Convert.ToString(_storage.getMaxCount());
        }

        private void comboBox_figures_SelectedIndexChanged(object sender, EventArgs e)
            //сохранение из comboBox в nameFig 
        {
            NameFig = comboBox_figures.Text;
        }

        private void comboBox_colors_SelectedIndexChanged(object sender, EventArgs e) //цвет обьекта
        {
            for (int i = 0; i < _storage.getMaxCount(); i++) {
                if (_storage.getObj(i).flag) {
                    switch (comboBox_colors.SelectedIndex) {
                        case 0:
                            _storage.getObj(i).color = Color.Pink;
                            break;
                        case 1:
                            _storage.getObj(i).color = Color.Black;
                            break;
                        case 2:
                            _storage.getObj(i).color = Color.Green;
                            break;
                        case 3:
                            _storage.getObj(i).color = Color.Orange;
                            break;
                    }
                }
            }
            pictureBox1.Refresh();
        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < _storage.getMaxCount(); i++)
            {
                if (e.KeyCode == Keys.A)
                {
                    if (_storage.getObj(i).flag && _storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                    {
                        _storage.getObj(i).Move(-2, 0);
                        if (!_storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                        {
                            _storage.getObj(i).Move(2, 0);
                        }

                    }
                }
                if (e.KeyCode == Keys.D)
                {
                    if (_storage.getObj(i).flag && _storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                    {
                        _storage.getObj(i).Move(2, 0);
                        if (!_storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                        {
                            _storage.getObj(i).Move(-2, 0);
                        }
                    }
                }
                if (e.KeyCode == Keys.W)
                {
                    if (_storage.getObj(i).flag && _storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                    {
                        _storage.getObj(i).Move(0, -2);
                        if (!_storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                        {
                            _storage.getObj(i).Move(0, 2);
                        }
                    }
                }
                if (e.KeyCode == Keys.S)
                {
                    if (_storage.getObj(i).flag && _storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                    {
                        _storage.getObj(i).Move(0, 2);
                        if (!_storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                        {
                            _storage.getObj(i).Move(0, -2);
                        }
                    }
                }
                if (e.KeyCode == Keys.Delete)
                {
                    if (_storage.getObj(i).flag)
                    {
                        _storage.DeleteItem(i);
                        i--;
                    }
                }
                if (e.KeyCode == Keys.Add) //увеличение обьекта
                {
                    if (_storage.getObj(i).flag && _storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                    {
                        _storage.getObj(i).ChangeR(1);
                        if (!_storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                        {
                            _storage.getObj(i).ChangeR(-1);
                        }
                    }
                }
                else if (e.KeyCode == Keys.Subtract) { 
                    
                    if ((_storage.getObj(i).flag)){
                        _storage.getObj(i).ChangeR(-1);
                        if (!_storage.getObj(i).CheckBorder(pictureBox1.Width, pictureBox1.Height))
                        {
                            _storage.getObj(i).ChangeR(1);
                        }
                    }
                    
                }
                pictureBox1.Refresh();
            }
        }

    }
}
