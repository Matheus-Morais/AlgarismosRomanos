using System.Runtime.Serialization.Formatters;

namespace ConversorAlgarismosRomanos;
public class Conversor : ConversorRomano
{
    public string InteiroParaRomano(int numero)
    {
        Dictionary<int, string> simbolos = new Dictionary<int, string>()
        { { 1000, "M" }, { 500, "D" }, { 100, "C" }, { 50, "L" }, { 10, "X" }, { 5, "V" },{ 3, "III" }, { 1, "I"} };

        foreach (int valor in simbolos.Keys)
        {
            if (simbolos.ContainsKey(valor))
            {
                return simbolos[numero];
            }
        }
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