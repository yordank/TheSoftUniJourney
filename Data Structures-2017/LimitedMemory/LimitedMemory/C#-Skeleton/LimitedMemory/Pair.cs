using System;

namespace LimitedMemory
{
    public class Pair<K, V>:IComparable<Pair<K,V>>
        where K : IComparable<K>
    {
        public Pair(K key,V value,int hit)
        {
            this.Key=key;
            this.Value=value;
            this.Hit = hit;
        }


        public K Key { get; set; }

        public V Value { get; set; }

        public int Hit { get; set; }
        public int CompareTo(Pair<K, V> other)
        {
            return -this.Hit.CompareTo(other.Hit);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Pair<K,V>;

            return this.Key.CompareTo(item.Key)==0;
        }

         

    }
}
