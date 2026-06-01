using System;

class Program
{
    static void Main(string[] args)
    {
        // =====================================================
        // ERRADO — já não é possível fazer isto
        // =====================================================
        // Tesouro tesouro1 = new Tesouro();  ← ERRO de compilação
        // Tesouro tesouro2 = new Tesouro();  ← ERRO de compilação


        // =====================================================
        // CORRECTO — pedir a instância pelo "porteiro"
        // =====================================================

        Tesouro tesouro1 = Tesouro.GetInstancia();
        Tesouro tesouro2 = Tesouro.GetInstancia();


        // =====================================================
        // PROVA que é o mesmo objecto
        // =====================================================

        Console.WriteLine("HashCode tesouro1: " + tesouro1.GetHashCode());
        Console.WriteLine("HashCode tesouro2: " + tesouro2.GetHashCode());

        // Resultado: os dois numeros sao IGUAIS


        // =====================================================
        // CONFIRMAÇÃO extra com ReferenceEquals
        // =====================================================
        bool eMesmoObjecto = object.ReferenceEquals(tesouro1, tesouro2);
        Console.WriteLine("São o mesmo objecto? " + eMesmoObjecto);
        // Resultado: True


        // =====================================================
        // PROVA com o conteúdo — alterar num afecta o outro
        // =====================================================
        tesouro1.Conteudo = "Moedas de ouro";

        Console.WriteLine("tesouro1: " + tesouro1.Conteudo); // Moedas de ouro
        Console.WriteLine("tesouro2: " + tesouro2.Conteudo); // Moedas de ouro
        // São iguais porque é literalmente o MESMO objecto!


        Console.ReadKey();
    }
}