using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_Mary_OOP_Laba4
{
    public class MyStorage
    {


        public Shape[] _values;
        int _maxcount;
        int lenght = 0;

       public MyStorage(int maxcount)
        {
            _maxcount = maxcount;
            _values = new Shape[_maxcount];
        }
        public void DeleteAll()
        {
            Array.Clear(_values, 0, _maxcount);
            _maxcount = 0;
        }

        public int getMaxCount()
        {
            return lenght;
        }

       public Shape getObj(int i)
        { // возвращение объекта класса
            if (i < lenght) return _values[i];
            return null;
        }

     
        public void DeleteItem()
        {
            if (_maxcount > 0)
            {
                _maxcount--;
                Array.Clear(_values, _maxcount, 1);
                lenght = 0;
            }
            else
            {
                Console.WriteLine("В хранилище больше нет фигур");
            }
        }
        public void DeleteItem(int index)
        {
            if (_maxcount > 0)
            {
                if (index <= _maxcount)
                {
                    for (int i = index; i < lenght; i++)
                    {
                        _values[i] = _values[i + 1];
                    }
                    lenght--;
                    Array.Clear(_values, lenght, 1);
                    //Console.WriteLine("Удален {0}-й элемент", index);
                }
            }
            else
            {
                Console.WriteLine("В хранилище больше нет фигур");
            }
        }
        private bool CheckSpace() // проверка свободных мест
        {
            if (lenght < _maxcount)
            {
                return true;
            }
            return false;
        }

        private void AddSpace()
        {
            Shape[] _bufer = new Shape[_maxcount * 2 + 1];
            for (int i = 0; i < _maxcount; i++)
            {
                _bufer[i] = _values[i];
            }
            _values = _bufer;
            _maxcount = _maxcount * 2;
        }

        public void CreatItem(Shape item)
        {
            if (!CheckSpace()) 
            {
                AddSpace();
            }
            _values[lenght] = item;
            lenght++;
        }
    }
}
