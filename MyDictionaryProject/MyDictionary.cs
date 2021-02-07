using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
   public class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        //constructor ctor*2 sadece new'lediğin yerde çalışır.
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
          
        }

        public void Add(TKey key, TValue value)
            //uzunluğun -1.elemanı, index'e göre davranmak 
        {
            IncreaseArraySize();

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        private void IncreaseArraySize()
        {
            ArrayManager<TKey>.IncreaseSize(ref _keys);
            ArrayManager<TValue>.IncreaseSize(ref _values);
        }

        public TValue GetValue(TKey key) => _values[ArrayManager<TKey>.Get(ref _keys, key)];
        
        public TKey GetKey(TValue value) => _keys[ArrayManager<TValue>.Get(ref _values, value)];
        public TValue[] GetAllValues() => _values;
        public TKey[] GetAllKeys() => _keys;

        public string[] GetAll()
        {
            string[] myArray = new string[_keys.Length];

            for (int i = 0; i < _keys.Length; i++)
            {
                myArray[i] = $"{_keys[i]}:{_values[i]}";
            }
            return myArray;
        }
    } 
}
