using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MyListScript : MonoBehaviour
{


    public class MyClass
    { 
        private int[] m_array = new int[10];

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return m_array.Length;
            }
            set
            {
                if (value > m_array.Length)
                {
                    System.Array.Resize(ref m_array, value);
                }
            }
        }

        public MyClass()
        {

        }

        public MyClass(int capacity)
        {
            Capacity = capacity;
            m_array = new int[Capacity];
        }

        public int this[int index]
        {
            get
            {
                CheckIndexRange(index);
                return m_array[index];
            }
            set
            {
                CheckIndexRange(index);
                m_array[index] = value;
            }
        }

        private void IncreaseCapacityIfNeed()
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        private bool CheckIndexRange(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException();

            return true;
        }

        public void Print()
        {
            for (int i = 0; i < m_array.Length; i++)
            {
                Debug.Log("Index = " + i + " Element = " + m_array[i]);
            }
        }

        public void Add(int item)
        {
            Count++;
            IncreaseCapacityIfNeed();
            m_array[Count-1] = item;

        }

        public void Insert(int index, int item)
        {
            Count += 1;
            bool flag = false;
            int _item = 0;
            int _curr;
            if (Count > Capacity)
            {
                IncreaseCapacityIfNeed();
            }
            for (int i = 0; i < m_array.Length; i++)
            {
                if (flag)
                {
                    _curr = m_array[i];
                    m_array[i] = _item;
                    _item = _curr;
                }
                if (index - 1 == i)
                {
                    _item = m_array[i];
                    m_array[i] = item;
                    flag = true;
                }
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < m_array.Length; i++)
            {
                if (m_array[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(int item)
        {
            int _m_count = Count;
            bool flag = false;
            for (int i = 0; i < _m_count; i++) 
            {
                if (m_array[i] == item)
                {
                    Count--;
                    m_array[i] = m_array[i + 1];
                    flag = true;
                }
                if (flag) 
                {
                    m_array[i] = m_array[i + 1];
                }
                if (i== Count)
                {
                    m_array[i] = 0;
                }
            }
        }

        public void RemoveAt(int index)
        {
            bool flag = true;
            for (int i = 0;i < Count; i++)
            {
                if (flag)
                {
                    m_array[i] = m_array[i + 1];
                }
                if (i == index)
                {
                    m_array[i] = m_array[i+1];
                    flag = true;
                }
            }
        }

        public bool Contains(int item)
        {
            return IndexOf(item) >= 0;
        }

        public void Clear()
        {
            System.Array.Clear(m_array, 0, m_array.Length);
            Count = 0;
        }
    }

    public class MyList <TItem>
    {
        private TItem[] m_array = new TItem[10];

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return m_array.Length;
            }
            set
            {
                if (value > m_array.Length)
                {
                    System.Array.Resize(ref m_array, value);
                }
            }
        }

        public MyList()
        {

        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            m_array = new TItem[Capacity];
        }

        public TItem this[int index]
        {
            get
            {
                CheckIndexRange(index);
                return m_array[index];
            }
            set
            {
                CheckIndexRange(index);
                m_array[index] = value;
            }
        }

        private void IncreaseCapacityIfNeed()
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        private bool CheckIndexRange(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException();

            return true;
        }

        public void Print()
        {
            for (int i = 0; i < m_array.Length; i++)
            {
                Debug.Log("Index = " + i + " Element = " + m_array[i]);
            }
        }

        public void Add(TItem item)
        {
            Count++;
            IncreaseCapacityIfNeed();
            m_array[Count - 1] = item;

        }

        public void Insert(int index, TItem item)
        {
            Count += 1;
            bool flag = false;
            TItem _item = default;
            TItem _curr;
            if (Count > Capacity)
            {
                IncreaseCapacityIfNeed();
            }
            for (int i = 0; i < m_array.Length; i++)
            {
                if (flag)
                {
                    _curr = m_array[i];
                    m_array[i] = _item;
                    _item = _curr;
                }
                if (index - 1 == i)
                {
                    _item = m_array[i];
                    m_array[i] = item;
                    flag = true;
                }
            }
        }

        public int IndexOf(TItem item)
        {
            for (int i = 0; i < m_array.Length; i++)
            {
                if (m_array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(TItem item)
        {
            int _m_count = Count;
            bool flag = false;
            for (int i = 0; i < _m_count; i++)
            {
                if (m_array[i].Equals(item))
                {
                    Count--;
                    m_array[i] = m_array[i + 1];
                    flag = true;
                }
                if (flag)
                {
                    m_array[i] = m_array[i + 1];
                }
                if (i == Count)
                {
                    m_array[i] = default;
                }
            }
        }

        public void RemoveAt(int index)
        {
            bool flag = true;
            for (int i = 0; i < Count; i++)
            {
                if (flag)
                {
                    m_array[i] = m_array[i + 1];
                }
                if (i == index)
                {
                    m_array[i] = m_array[i + 1];
                    flag = true;
                }
            }
        }

        public bool Contains(TItem item)
        {
            return IndexOf(item) >= 0;
        }

        public void Clear()
        {
            System.Array.Clear(m_array, 0, m_array.Length);
            Count = 0;
        }
    }


    void Start()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(5);
        myList.Insert(1, 3);
        //myList.Capacity = 4;
        //myList.Remove(3);
        myList.RemoveAt(0);

        for (int i = 0; i < myList.Count; ++i)
        {
            Debug.Log(myList[i]);
        }

        System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
        MyList<MyClass> myList1 = new MyList<MyClass>();
        for (int i = 0; i < 1000000; i++)
        {
            myList1.Add(new MyClass());
        }
        myList1.RemoveAt(5000);
        myList1.RemoveAt(250000);
        myList1.Insert(555555, new MyClass());
        Debug.Log($"MyList time {sw.ElapsedMilliseconds}");

        List<MyClass> standartList = new List<MyClass>();
        for (int i = 0; i < 1000000; i++)
        {
            standartList.Add(new MyClass());
        }

        standartList.RemoveAt(5000);
        standartList.RemoveAt(250000);
        standartList.Insert(555555, new MyClass());
        Debug.Log($"StandartList time {sw.ElapsedMilliseconds}");



    }

}
