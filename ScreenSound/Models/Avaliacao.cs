namespace ScreenSound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }
    public int Nota { get; }

    //método estático vira apenas uma função autocontida. o que é executado dentro deste método (static) não usa nenhuma informação da instância desta class.
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
