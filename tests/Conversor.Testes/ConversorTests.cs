namespace Conversor.Testes;

using ConversorAlgarismosRomanos;

public class ConversorTests
{

    /*
     * Tabela de Conversão Romano-Inteiro
        I - 1
        II - 2
        III - 3
        IV - 4
        V - 5
        X - 10
     */

    Conversor conversor = new Conversor();

    [Theory]
    [InlineData(1, "I")]
    [InlineData(3, "III")]
    [InlineData(5, "V")]
    [InlineData(10, "X")]
    [InlineData(50, "L")]
    [InlineData(100, "C")]
    [InlineData(500, "D")]
    [InlineData(1000, "M")]
    [InlineData(1555, "MDLV")]
    [InlineData(3510, "MMMDX")]
    [InlineData(3999, "MMMCMXCIX")]
    public void TesteConversorInteiroParaRomano(int inteiro, string romano)
    {

        string algarismo = conversor.InteiroParaRomano(inteiro);

        Assert.Equal(romano, algarismo);
    }
}