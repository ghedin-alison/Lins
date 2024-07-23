# Anotações

## Iniciando o projeto
- Dentro do diretorio do projeto criar a solution
`dotnet new sln`
- Criar uma classlib
  `dotnet new classlib -o Lins.Core`
- Criar um .Tests
`dotnet new mstest -o Lins.Core.Tests`
- Adicionar os projetos criados Core e Tests na solução
`dotnet sln add ./Lins.Core.Tests/`
`dotnet sln add ./Lins.Core/`
- Entrar em testes e adicionar Core como referencia. Lembre que está em um diretório acima.
`dotnet add reference ../Lins.Core`
