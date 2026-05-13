public class atividade1
{
    static char DescobrirCategoria(int idade)
    {
        if(idade <= 7)
        {
            return 'F';
        }else if(idade <= 10)
        {
            return 'E';
        }else if(idade <= 13)
        {
            return 'D';
        }else if(idade <= 15)
        {
            return 'C';
        }else if(idade <= 17)
        {
            return 'B';
        }
        else
        {
            return 'A';
        }

    }

    public static void Rodar()
    {
        int idade = 0;

        Console.Write("Insira a idade do nadador: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"O nadador é da categoria: {DescobrirCategoria(idade)}");
    }
}

