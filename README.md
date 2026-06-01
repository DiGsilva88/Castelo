=====================================================
  PROJECTO CASTELO — PADRÃO SINGLETON
=====================================================

DESCRIÇÃO
---------
Este projecto demonstra a implementação do padrão de design
Singleton em C#, usando a classe Tesouro como exemplo.

O Singleton garante que uma classe tem apenas UMA instância
em toda a aplicação, fornecendo um ponto de acesso global
a essa instância.


O QUE É O SINGLETON?
--------------------
É um padrão de design (Design Pattern) que resolve o problema
de ter múltiplos objectos criados quando só deve existir um.

Sem Singleton:
  Tesouro tesouro1 = new Tesouro();  → objecto A na memória
  Tesouro tesouro2 = new Tesouro();  → objecto B na memória
  (dois objectos diferentes — problema!)

Com Singleton:
  Tesouro tesouro1 = Tesouro.Instancia;  → objecto A na memória
  Tesouro tesouro2 = Tesouro.Instancia;  → objecto A na memória
  (sempre o mesmo objecto — correcto!)


ESTRUTURA DO PROJECTO
---------------------
Castelo/
  Tesouro.cs     → classe com o padrão Singleton implementado
  Program.cs     → programa principal que usa a classe Tesouro


COMO O SINGLETON ESTÁ IMPLEMENTADO
------------------------------------
A classe Tesouro tem 3 elementos essenciais:

1. Campo privado e estático
   Guarda a única instância da classe.
   Começa a null — ainda não foi criado nenhum objecto.

2. Construtor privado
   Impede que alguém faça "new Tesouro()" fora da classe.
   A única forma de obter o objecto é pela propriedade Instancia.

3. Propriedade estática Instancia
   Ponto de acesso global ao objecto.
   Se ainda não existe, cria. Se já existe, devolve o mesmo.


COMO EXECUTAR O PROJECTO
------------------------
Requisitos:
  - Visual Studio 2019 ou superior
  - .NET 6.0 ou superior

Passos:
  1. Abrir o Visual Studio
  2. Abrir a solução "Castelo"
  3. Verificar que o Program.cs está definido como projecto de arranque
  4. Pressionar F5 para executar (ou Ctrl+F5 sem debug)

Resultado esperado no terminal:
  São o mesmo objecto? True
  Tesouro guardado! Conteúdo: Ouro e joias
  tesouro1: Moedas de ouro
  tesouro2: Moedas de ouro


QUANDO USAR O SINGLETON
-----------------------
  - Configurações da aplicação
  - Ligação à base de dados
  - Sistema de logs (registo de eventos)
  - Qualquer recurso que deva ser único e partilhado


AUTOR
-----
  Projecto criado para aprendizagem de Design Patterns em C#.

=====================================================
