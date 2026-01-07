using System;

[Serializable]//Define a estrutura de uma quest�o
public class Questao
{
    public string texto;        // Pergunta
    public string[] opcoes;   // Op��es de resposta
    public int correta;   // �ndice da resposta certa
    public string dificuldade;  // "facil", "medio", "dificil"
}

[Serializable]//Define a estrutura de uma lista de quest�es
public class ListaQuestao
{
    public Questao[] questoes;
}
