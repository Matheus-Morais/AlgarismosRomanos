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
    [InlineData(10, "X")]
    [InlineData(1, "I")]
    [InlineData(5, "V")]
    [InlineData(3, "III")]
    public void TesteConversorInteiroParaRomano(int inteiro, string romano)
    {

        string algarismo = conversor.InteiroParaRomano(inteiro);

        Assert.Equal(romano, algarismo);
    }
}