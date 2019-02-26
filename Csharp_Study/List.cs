using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// List used Template
/// </summary>
/// <typeparam name="T"></typeparam>
public class List<T>
{
    private T[] arr; // Container of List data

    public List()
    {
        arr = new T[2];
    }
    /// <summary>
    /// Get Length of list
    /// </summary>
    public int Length
    {
        get { return arr.Length; }
    }
    /// <summary>
    /// Create Array
    /// </summary>
    /// <param name="index">(int) input new index </param>
    /// <param name="value">(T) data value</param>
    public void InitArray(int index, T value)
    {
        arr[index] = value;
    }
    /// <summary>
    /// Getter
    /// </summary>
    public T this[int index]
    {
        get
        {
            return arr[index];
        }
    }
}