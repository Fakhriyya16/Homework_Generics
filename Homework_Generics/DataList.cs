﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Generics
{
    internal class DataList<T>
    {
        private T[] _datas;
        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }

        public void Delete(T data)
        {
            var temp = _datas[Array.FindIndex(_datas, m=> m.Equals(data))];

            _datas[Array.FindIndex(_datas, m => m.Equals(data))] = _datas[_datas.Length-1];

            _datas[_datas.Length - 1] = temp;

            Array.Resize(ref _datas, _datas.Length - 1);
        }
    }
}
