public class atividade2
{
    public static void Rodar()
    {
        int nota1, nota2, nota3;
        double media = 0;
        char letra;

        Console.Write("Insira a 1° nota: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("Insira a 2° nota: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Insira a 3° nota: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.Write("Insira a Letra (A ou P): ");
        letra = char.Parse(Console.ReadLine());

        CaucularMedia(nota1, nota2, nota3, letra, ref media);

        Console.WriteLine($"A media do Aluno foi: {media}");

    }

    public static void CaucularMedia(int n1, int n2, int n3, char letra, ref double media)
    {
        if(letra == 'A')
        {
            media = (n1 + n2 + n3) / 3;
        }else if(letra== 'P')
        {
            media = ((n1 * 5)+(n2 * 3)+(n3 * 2)) / 10;
        }
    }
}