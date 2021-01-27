using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] key;
        T2[] value;
        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];
        }
        public void Add(T1 ke, T2 val)
        {
            T1[] tempKeys = key;
            T2[] tempVals = value;

            key = new T1[key.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                key[i] = tempKeys[i];
            }
            key[key.Length - 1] = ke;

            value = new T2[value.Length + 1];
            for (int i = 0; i < tempVals.Length; i++)
            {
                value[i] = tempVals[i];
            }
            value[value.Length - 1] = val;
        }
        public T1[] ilk
        {
            get { return key; }
        }
        public T2[] son
        {
            get { return value; }
        }
    }
}
