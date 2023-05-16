using System.Runtime.Serialization.Formatters;

namespace ConversorAlgarismosRomanos;
public class Conversor : ConversorRomano
{
    public string InteiroParaRomano(int numero)
    {
        string convertidoRomano = "";

        Dictionary<int, string> simbolos = new Dictionary<int, string>()
        { { 1000, "M" }, { 500, "D" }, { 100, "C" }, { 50, "L" }, { 10, "X" }, { 5, "V" },{ 3, "III" }, { 1, "I"} };

        foreach (int valor in simbolos.Keys)
        {
            while (numero >= valor)
            {
                convertidoRomano += simbolos[valor];
                numero -= valor;
            }
        }
        return convertidoRomano; 
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