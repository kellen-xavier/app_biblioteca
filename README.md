# Curso_CSharp - Sistema de Biblioteca com Padrão MVC

## Descrição

Este projeto é um exemplo simples de um sistema de biblioteca implementado em C# usando o padrão de design **MVC (Model-View-Controller)**.

A aplicação permite:

- Listar todos os livros disponíveis na biblioteca.
- Selecionar um livro e exibir informações como nome, autor, número de páginas e um link para compra online.
- Abrir o link para a loja de ebooks no navegador.

## Exercício

Objetivo:

- Refatorar e otimizar um sistema de biblioteca simples em C# utilizando os conceitos de Programação Orientada a Objetos (POO) e boas práticas de desenvolvimento.

**Refatoração:**
Aplicar os conceitos de classes e objetos, construtores e sobrecarga, e tipos de valor e referência para melhorar a organização e a legibilidade do código. Analise a aplicação visando algumas possíveis melhorias, deixando mais simples:

Exemplos de refatoração:

    Encapsulamento: Criar propriedades privadas e métodos públicos para controlar o acesso aos dados.

    Herança: Identificar classes que podem herdar de uma classe base para evitar duplicação de código.

    Polimorfismo: Utilizar interfaces ou classes abstratas para criar hierarquias de classes e permitir diferentes implementações de métodos.

    Coleções: Empregar coleções como List, Dictionary ou HashSet para armazenar e manipular dados de forma eficiente.

- Refatore o projeto utilizando boas práticas vistas em aula. Pratique alguns conceitos que voltaremos a ver nesta semana:
**Classes e Objetos**
**Construtores e Sobrecarga**
**Tipos de Valor e Tipos de Referência em C#** Melhore a performance desta aplicação. Teste suas implementações com diferentes valores e verifique os resultados, não alterando a regra de negócio.

- **Documente suas observações e a saída dos programas:** Não utilize comentários no código, a ideia é documentar a aplicação de forma objetiva e clara.

- **Extensibilidade:** Deixe o projeto mais flexível para futuras funcionalidades, como adicionar mais interações ou tipos de livros. Adicione mais livros as esta lista, e crie uma interação ao usuário para voltar a esta lista.

### Boas Práticas

    Nomenclatura: Utilizar nomes significativos para classes, métodos e variáveis.

    Comentários: Embora o enunciado original proíba comentários no código, é importante adicionar comentários em locais estratégicos para explicar a lógica complexa ou decisões de design.
    
    Testes: Criar testes unitários para garantir a qualidade do código e detectar possíveis regressões.

## Estrutura do Projeto Inicial

- **Model (Livro.cs):** Representa os dados do livro.
- **View (BibliotecaView.cs):** Responsável pela exibição das informações e interação com o usuário.
- **Controller (BibliotecaController.cs):** Coordena o fluxo da aplicação e faz a ponte entre Model e View.

## Como Executar o Projeto

1. Clone este repositório ou baixe os arquivos.
2. Abra o projeto no **Visual Studio**.
3. Compile e execute o projeto.
4. O programa exibirá uma lista de livros. Selecione um livro digitando o número correspondente e veja os detalhes.

## Tecnologias Utilizadas

- Linguagem: C#
- IDE: Visual Studio

## Licença

Este projeto é de código aberto e pode ser utilizado para estudos e aperfeiçoamento em programação.
