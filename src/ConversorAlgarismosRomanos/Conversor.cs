namespace ConversorAlgarismosRomanos;
public class Conversor : ConversorRomano
{
    public string InteiroParaRomano(int numero)
    {
        throw new NotImplementedException();
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