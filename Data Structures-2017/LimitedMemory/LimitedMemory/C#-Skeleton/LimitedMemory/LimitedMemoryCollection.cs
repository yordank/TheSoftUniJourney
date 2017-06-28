using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Wintellect.PowerCollections;
using System;

namespace LimitedMemory
{
    public class LimitedMemoryCollection<K, V> : ILimitedMemoryCollection<K, V>
         where K : IComparable<K>
    {

        public static int number = 0;

        private OrderedSet<Pair<K, V>> set = new OrderedSet<Pair<K, V>>();

        private Dictionary<K, V> dict = new Dictionary<K, V>();

        public LimitedMemoryCollection(int capacity)
        {
            this.capacity = capacity;
    
       
            
        }

        public int capacity { get; set; }

        public IEnumerator<Pair<K, V>> GetEnumerator()
        {
            foreach (var item in set)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set { }
        }

        public int Count
        {
            get
            {
                return dict.Count;
                
            }
            private set { }
        }

        public void Set(K key, V value)
        {
            if (capacity > dict.Count)
            {
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, value);
                }
                else
                {
                    dict[key] = value;

                    Pair<K, V> item = set.Where(x => x.Key.CompareTo(key) == 0).First();

                    set.Remove(item);

                }

                set.Add(new Pair<K, V>(key, value,number));

                number++;

                return;

            }

            if(dict.ContainsKey(key))
            {

                Pair<K, V> item = set.Where(x => x.Key.CompareTo(key) == 0).First();

                set.Remove(item);

                dict[key] = value;

                set.Add(new Pair<K, V>(key, value, number++));
                return;
            }

            else
            {
               
                                
                    var pair = set.RemoveLast();

                    dict.Remove(pair.Key);

                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, value);
                    }
                    else
                    {
                        dict[key] = value;
                    }
                    set.Add(new Pair<K, V>(key, value, number++));
                     
                
            }

        }

        public V Get(K key)
        {
            if (!dict.ContainsKey(key))
            {
                throw new KeyNotFoundException();             
            }
            else
            {
                Pair<K,V> item=set.Where(x=>x.Key.CompareTo(key)==0).First();
                set.Remove(item);

                set.Add(new Pair<K, V>(key, dict[key],number++));

                return dict[key];
            }
               
        }
    }
}
