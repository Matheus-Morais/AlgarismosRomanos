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
     */

    Conversor conversor = new Conversor();

    [Fact]
    public void TesteConversorInteiroParaRomano()
    {
        int a = 10;
        string esperado = "X";

        string algarismo = conversor.InteiroParaRomano(a);

        Assert.Equal(esperado, algarismo);
    }
}