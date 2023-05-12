using System.Runtime.Serialization.Formatters;

namespace ConversorAlgarismosRomanos;
public class Conversor : ConversorRomano
{
    public string InteiroParaRomano(int numero)
    {
        Dictionary<int, string> simbolos = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 3, "III" },
            { 5, "V" },
            { 10, "X" },
            { 50, "X" },
            { 100, "X" },
            { 500, "X" },
            { 1000, "X" },
        };

        return simbolos[numero];
    }

    public int RomanoParaInteiro(string romano)
    {
        throw new NotImplementedException();
    }
}

public interface ConversorRomano
{
    string InteiroParaRomano(int numero);
    int RomanoParaInteiro(string romano);
}