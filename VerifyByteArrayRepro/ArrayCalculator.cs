namespace VerifyByteArrayRepro;

public class ArrayCalculator
{
    /// <summary>
    /// Some half-interesting method-under-test that creates a buffer.
    /// </summary>
    /// <param name="noOfElements"></param>
    /// <returns></returns>
    public static byte[] CreateBuffer(byte noOfElements)
    {
        byte[] buffer = new byte[noOfElements];
        for (byte i = 0; i < noOfElements; ++i)
        {
            buffer[i] = i;
        }

        return buffer;
    }
}