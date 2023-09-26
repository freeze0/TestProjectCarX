using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MyListScript : MonoBehaviour
{


    public class MyList
    {
        private int[] m_array = new int[10];
        private int m_count = 0;
        private int m_capacity = 10;

        public int Count
        {
            get
            {
                return m_count;
            }
            set 
            {
                if (value <= m_capacity)
                {
                    this.m_count = value;
                }
                else
                {
                    throw new Exception("Invalid count");
                }
            }
        }

        public int Capacity
        {
            get
            {
                return m_capacity;
            }
            set
            {
                this.m_capacity = value;
                int [] _m_array = new int[m_capacity];
                for (int i = 0; i < m_capacity; i++)
                {
                    _m_array[i] = m_array[i];
                }
                m_array = _m_array;
            }
        }

        public MyList()
        {

        }

        public MyList(int capacity)
        {
            m_capacity = capacity;
            m_array = new int[m_capacity];
        }

        /*public MyList(int capacity, int count) 
        {
            m_capacity = capacity;
            m_count = count;
        }*/

        public int this[int index]
        {
            get
            {
                return m_array[index];
            }
            set
            {
                m_array[index] = value;
            }
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
            m_count++;
            if (m_count <= m_capacity)
            {
                m_array[m_count - 1] = item;
            }
            else
            {
                throw new Exception("Invalid count");
            }

        }

        public void Insert(int index, int item)
        {
            m_count += 1;
            bool flag = false;
            int _item = 0;
            int _curr;
            if (m_count <= m_capacity)
            {
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
            else
            {
                m_count--;
                throw new Exception("Invalid count");
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
            throw new Exception("Wrong index");
        }

        public void Remove(int item)
        {
            bool flag = false;
            for (int i = 0; i < m_array.Length - 1; i++) 
            {
                if (m_array[i] == item)
                {
                    m_count--;
                    m_array[i] = m_array[i + 1];
                    flag = true;
                }
                if (flag) 
                {
                    m_array[i] = m_array[i + 1];
                }
                if (i== m_array.Length - 1)
                {
                    m_array[i] = 0;
                }
            }
            // Print();
        }

        public void RemoveAt(int index)
        {
            bool flag = true;
            for (int i = 0;i < m_array.Length - 1; i++)
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
            for (int i = 0; i < m_array.Length; i++) 
            {
                if (m_array[i] == item) 
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            for (int i = 0; i < m_array.Length; i++)
            {
                m_array[i] = 0;
            }
        }
    }


    void Start()
    {
        MyList myList = new MyList();
        myList.Add(1);
        myList.Add(5);
        myList.Insert(1, 3);
        myList.Capacity = 4;
        myList.Remove(3);
        myList.RemoveAt(0);

        for (int i = 0; i < myList.Count; ++i)
        {
            Debug.Log(myList[i]);
        }

    }

}
