using System.Runtime.Serialization.Formatters;

namespace ConversorAlgarismosRomanos;
public class Conversor : ConversorRomano
{
    public string InteiroParaRomano(int numero)
    {
        string convertidoRomano = "";

        Dictionary<int, string> simbolos = new Dictionary<int, string>()
        { { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" }, { 100, "C" }, { 90, "XC" }, { 50, "L" }, { 40, "XL" }, { 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" } };

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