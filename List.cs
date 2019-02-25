using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class List<T>
{
    private T[] arr;
    public List()
    {
        arr = new T[2];
    }
    public int Length
    {
        get { return arr.Length; }
    }
    public void InitArray(int index, T value)
    {
        arr[index] = value;
    }
    public T this[int index]
    {
        get
        {
            return arr[index];
        }
    }
}