namespace EspacioCalculadora;

public class Calculadora
{
    private double valor;
    public Calculadora()
    {
        valor=0;
    }
    public double Resultado 
    {
        get => valor;
    }
    public void Suma (double termino)
    {
        valor+=termino;
    }

    public void Resta (double termino)
    {
        valor-=termino;
    }

    public void Multiplicar (double termino)
    {
        valor*=termino;
    }

       public void Dividir (double termino)
    {
        valor/=termino;
    }

    public void Limpiar ()
    {
        valor = 0;
    }

}