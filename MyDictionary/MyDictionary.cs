using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {

        TKey[] _keyArray, _tempKeyArray;
        TValue[] _valueArray, _tempValueArray;


        public MyDictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;

            _keyArray = new TKey[_keyArray.Length + 1];
            _valueArray = new TValue[_valueArray.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
                _tempKeyArray[i] = _keyArray[i];

            for (int i = 0; i < _tempValueArray.Length; i++)
                _tempValueArray[i] = _valueArray[i];

            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;
        }
    }
}
