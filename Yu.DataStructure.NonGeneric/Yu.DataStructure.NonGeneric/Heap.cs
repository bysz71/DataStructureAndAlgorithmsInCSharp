using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.NonGeneric
{
    public class Heap
    {
        private List<int> _list;

        public Heap()
        {
            _list = new List<int>();
        }

        /// <summary>
        /// Insert an item to the heap
        /// swap if needed
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int item)
        {
            if (_list.Contains(item))
            {
                Console.WriteLine("Error: Duplicate item");
                return;
            }

            _list.Add(item);
            if (_list.Count() == 1) return;

            int motherIndex = 0;
            int childIndex = _list.Count() - 1;
            int buff = 0;

            while (true)
            {
                motherIndex = (childIndex - 1) / 2;
                if (_list[childIndex] > _list[motherIndex])
                {
                    buff = _list[childIndex];
                    _list[childIndex] = _list[motherIndex];
                    _list[motherIndex] = buff;
                    childIndex = motherIndex;
                }
                else break;
            }
        }

        /// <summary>
        /// Delete largest value of the heap which is the root
        /// </summary>
        /// <returns></returns>
        public int DeleteRoot()
        {
            int result;
            //empty heap case
            //if (_list.Count() == 0)
            //{
                //Console.WriteLine("Error: Empty heap");
                //return null;
            //}

            //one item cases
            if (_list.Count() == 1)
            {
                result = _list[0];
                _list.RemoveAt(0);
                return result;
            }

            //other cases
            result = _list[0];
            _list[0] = _list[_list.Count() - 1];
            _list.RemoveAt(_list.Count() - 1);
            //swap
            int motherIndex = 0;
            int childIndex = 1;
            int buff = 0;
            while (true)
            {
                if (childIndex < _list.Count() - 1)
                {
                    Console.WriteLine("both in range");
                    if (_list[motherIndex] < Math.Max(_list[childIndex], _list[childIndex + 1]))
                    {

                        buff = _list[motherIndex];
                        childIndex = MaxIndex(childIndex);
                        _list[motherIndex] = _list[childIndex];
                        _list[childIndex] = buff;

                        motherIndex = childIndex;
                        childIndex = motherIndex * 2 + 1;
                    }
                    else break;
                }
                else if (childIndex == _list.Count() - 1)
                {
                    if (_list[motherIndex] < _list[childIndex])
                    {
                        buff = _list[motherIndex];
                        _list[motherIndex] = _list[childIndex];
                        _list[childIndex] = buff;
                    }
                    break;
                }
                else break;
            }
            return result;
        }

        /// <summary>
        /// returns the index of the biggest node in the 2 children node
        /// serves DeleteRoot()
        /// </summary>
        /// <param name="childIndex"></param>
        /// <returns></returns>
        public int MaxIndex(int childIndex)
        {
            return _list.FindIndex(x => x == Math.Max(_list[childIndex], _list[childIndex + 1]));
        }

        /// <summary>
        /// Return how many items in the heap
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _list.Count();
        }

        /// <summary>
        /// print the whole heap
        /// </summary>
        public void Print()
        {
            foreach (int item in _list)
                Console.Write(item + " ");
            Console.Write("\n");
        }

        public void Swap(int indexLeft, int indexRight)
        {
            int buff = _list[indexLeft];
            _list[indexLeft] = _list[indexRight];
            _list[indexRight] = buff;
        }
    }
}
