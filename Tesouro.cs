public class Tesouro
{
    // =====================================================
    // PASSO 1: Guardar a única instância
    // =====================================================
    // "static" significa que pertence à CLASSE, não a um objecto
    // "private" significa que só a própria classe pode tocár-lhe
    // Começa a null porque ainda não foi criada nenhuma instância

    private static Tesouro _instancia = null;

    // =====================================================
    // PASSO 2: Bloquear o "new" para o exterior
    // =====================================================
    // Com o construtor "private", qualquer tentativa de fazer
    // Tesouro t = new Tesouro()  ← dá ERRO de compilação
    // Assim forçamos toda a gente a usar GetInstancia()
    private Tesouro()
    { 
    }

    // =====================================================
    // PASSO 3: Ponto de acesso global (o "porteiro")
    // =====================================================
    // "static" permite chamar SEM ter um objecto:
    //    Tesouro.GetInstancia()  ← correcto
    //    t.GetInstancia()        ← errado
    public static Tesouro GetInstancia()
    {
        // Verifica se ainda não existe nenhuma instância

        if (_instancia == null)
        {
            // Só entra aqui UMA vez em toda a vida do programa
            // A partir daqui _instancia nunca mais será null

            _instancia = new Tesouro(); // ← o único "new" permitido
        }

        // Quer já existisse, quer acabasse de criar,
        // devolve SEMPRE o mesmo objecto

        return _instancia;
    }

    // =====================================================
    // PASSO 4: Dados do objecto (o conteúdo do tesouro)
    // =====================================================
    // Propriedade normal — existe apenas UMA vez porque
    // só há um objecto Tesouro em toda a aplicação


    public string Conteudo { get; set; } = "Ouro e joias";
}