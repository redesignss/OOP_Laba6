using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_Mary_OOP_Laba3
{
	class MyStorage
	{
		private Shape[] _values;
		int _maxcount;
		
		MyStorage(int maxcount)
		{
			_maxcount = maxcount;
			_values = new Shape[_maxcount];
		}
		public void DeleteAll()
		{
				Array.Clear(_values, 0, _maxcount);
				_maxcount = 0;
		}

		int getMaxCount()
		{
			return _maxcount;
		}

		Shape getObj(int i)
		{ // возвращение объекта класса
			if (i < _maxcount) return _values[i];
			return null;
		}

		void addElem(Shape obj, int cout)
		{
			if (cout <= _maxcount)
			{
				_values[cout] = obj;
			}
		}
		public void DeleteItem()
		{
			if (_maxcount> 0)
			{
				_maxcount--;
				Array.Clear(_values, _maxcount, 1);
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
					for (int i = index - 1; i < _maxcount - 1; i++)
					{
						_values[i] = _values[i + 1];
					}
					_maxcount--;
					Array.Clear(_values, _maxcount, 1);
					//Console.WriteLine("Удален {0}-й элемент", index);
				}
			}
			else
			{
				Console.WriteLine("В хранилище больше нет фигур");
			}
		}
	};
}
