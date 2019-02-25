using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Main Processor
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        arrayList.AddLast( 10 );
        arrayList.AddLast( 20 );
        arrayList.AddLast( 30 );
        arrayList.AddAtFirst( 4000 );
        arrayList.Add( 500 , 2 );

        Console.WriteLine( arrayList.toString() );
    }
}