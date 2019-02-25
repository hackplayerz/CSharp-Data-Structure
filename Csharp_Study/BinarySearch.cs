using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Class of Binary Search Algorithm
/// </summary>
class BinarySearch
{
    /// <summary>
    /// Get index of searched node
    /// </summary>
    /// <param name="searchNumber">(int) search node number</param>
    /// <returns>if searched data return index number, can't find return -1 </returns>
    public static int BinarySearching(int[] _dataContainers , int _searchNumber)
    {
        int middle = _dataContainers.Length / 2;
        Console.WriteLine( middle );
        // if middle data is equal as searchNumber
        if ( _dataContainers[ middle ] == _searchNumber )
        {
            return middle;
        }

        // if searchNumber bigger than middle data
        if ( _dataContainers[ middle ] < _searchNumber )
        {
            int loopIndex = loopIndex = _dataContainers.Length - middle;

            for ( int i = middle; i < _dataContainers.Length; i++ )
            {
                if ( _dataContainers[ i ] == _searchNumber )
                {
                    return i;
                }
            }
        }

        else
        {
            for ( int i = 0; i < middle; i++ )
            {
                if ( _dataContainers[ i ] == _searchNumber )
                {
                    return i;
                }
            }
        }

        // Can't find data
        Console.WriteLine( _searchNumber + " don't exist" );
        return -1;
    }
}

