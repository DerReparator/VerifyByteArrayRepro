namespace VerifyByteArrayRepro.Tests;

public class ArrayCalculatorTests
{
    /// <summary>
    /// For this test, an *.verified.* file was created manually.
    /// </summary>
    [Fact]
    public async Task TestThat3ElementsAreCorrectlyCreated()
    {
        byte[] result = ArrayCalculator.CreateBuffer(3);

        await Verifier.Verify(result);
    }
    
    [Fact]
    public async Task TestThat5ElementsAreCorrectlyCreated()
    {
        byte[] result = ArrayCalculator.CreateBuffer(5);

        await Verifier.Verify(result);
    }
}