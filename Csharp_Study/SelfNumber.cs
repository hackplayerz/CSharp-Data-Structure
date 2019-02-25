/// <summary>
/// Class of SelfNumber Calculator
/// </summary>
public class SelfNumber
{
    /// <summary>
    /// Calculate to self number
    /// </summary>
    /// <param name="_getNumber">(string) input number </param>
    /// <returns>(int) Calculated number </returns>
    public static int GetSelfNumber(string _getNumber)
    {
        int sNum = 0;
        for ( int i = 0; i < _getNumber.Length; i++ )
        {
            sNum += ( int )_getNumber[ i ] - 48;
        }
        sNum += int.Parse( _getNumber );
        return sNum;
    }

// end of SelfNumber
}