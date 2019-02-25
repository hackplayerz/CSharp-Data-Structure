using System;

public class ArrayList
{
    private const int MAX_LENGTH = 100;
    private int size = 0;
    private object[] elementDatas = new object[ MAX_LENGTH ];

    /// <summary>
    /// Get Size of ArrayList
    /// </summary>
    /// <returns>(int)size</returns>
    public int GetSize()
    {
        return size;
    }

    #region Add Processor

    /// <summary>
    /// Add data in last index
    /// </summary>
    /// <param name="_data">data value</param>
    public void AddLast(object _data)
    {
        // If data is full, exit add process.
        if ( size >= MAX_LENGTH )
        {
            Console.WriteLine( "Data is Full" );
            return;
        }
        elementDatas[ size ] = _data;
        size++;
    }

    /// <summary>
    /// Input Data in index
    /// </summary>
    /// <param name="_data">data value</param>
    /// <param name="_index">element's index</param>
    public void Add(object _data,int _index)
    {
        // If data is full, exit add process.
        if(size >= MAX_LENGTH )
        {
            Console.WriteLine( "Data is Full" );
            return;
        }
        // Index Range Exception.
        if(_index > size)
        {
            Console.WriteLine( "Wrong Input Range" );
            return;
        }
        for(int i = size;i>_index;i-- )
        {
            elementDatas[ i ] = elementDatas[ i -1 ];
        }
        elementDatas[ _index ] = _data;
        size++;
    }

    /// <summary>
    /// Add in First index
    /// </summary>
    /// <param name="_data">data value</param>
    public void AddAtFirst(int _data)
    {
        Add( _data , 0 );
    }

    // End of Add Processor
    #endregion

    #region Remove Processor



        // End of Remove Processor
    #endregion

    /// <summary>
    /// Indexer
    /// </summary>
    /// <param name="_index">searching data of index</param>
    /// <returns>value of index of elementData</returns>
    public object this[int _index]
    {
        get
        {
            return elementDatas[ _index ];
        }
    }
    
    /// <summary>
    /// Get all element of arrayList
    /// </summary>
    /// <returns>(string) all data to string</returns>
    public string toString()
    {
        string str = "[";

        for(int i=0;i<size;i++ )
        {
            str += elementDatas[ i ];
            if(i < size-1)
            {
                str += ",";
            }
        }
        str += "]";
        return str;
    }
}