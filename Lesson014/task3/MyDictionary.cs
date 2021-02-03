using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    struct KeyValueExample<TKey, TValue>
    {
        public TKey key { get; }
        public TValue value { get; }
        public KeyValueExample(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

    }
    class MyDictionary<TKey, TValue>
    {
        KeyValueExample<TKey, TValue>[] keysvalues;
        public int Count { get { return keysvalues.Length; } }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < keysvalues.Length)
                    return keysvalues[index].key + " - " + keysvalues[index].value;
                return "Попытка обращения за пределы массива.";
            }
        }

        public MyDictionary()
        {
            keysvalues = new KeyValueExample<TKey, TValue>[0];
        }
        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref keysvalues, keysvalues.Length + 1);
            keysvalues[keysvalues.Length - 1] = new KeyValueExample<TKey, TValue>(key, value);
        }
        public IEnumerator<KeyValueExample<TKey, TValue>> GetEnumerator()
        {
            foreach (KeyValueExample<TKey, TValue> keyValue in keysvalues)
                yield return keyValue;
            yield break;
        }
    }
}
