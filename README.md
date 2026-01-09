# English Dictionary Desktop App

## 📌 Breve Descrição
Aplicação desktop para consulta de vocabulário em inglês, com interface reativa e consumo de APIs externas.

## 🎯 Problema / Desafio
Criar uma ferramenta de estudo rápida que não dependesse do navegador, exigindo uma arquitetura que separasse a interface gráfica da lógica de busca de dados, garantindo performance e evitando o travamento da UI durante requisições assíncronas.

## 🧠 Solução
Implementação da arquitetura **MVVM (Model-View-ViewModel)** utilizando o **CommunityToolkit.Mvvm**, promovendo baixo acoplamento entre a UI (XAML) e a regra de negócio (C#).  
Essa abordagem facilitou a testabilidade, manutenção e escalabilidade da aplicação.

## 🛠️ Tecnologias Utilizadas
- C# (.NET 8)
- WPF (Windows Presentation Foundation)
- CommunityToolkit.Mvvm (Source Generators, RelayCommands)
- REST API (HttpClient com tratamento de JSON)

## 👨‍💻 Minhas Contribuições
- Desenvolvimento da interface gráfica em XAML com foco em usabilidade.
- Implementação de propriedades observáveis utilizando `ObservableProperty`, reduzindo boilerplate e garantindo atualização automática da UI.
- Criação do serviço de consumo da API de dicionário, com tratamento de erros e estados assíncronos de carregamento.

## ✅ Resultados
Uma aplicação fluida e responsiva, demonstrando domínio sobre o ciclo de vida de aplicações desktop, padrões modernos da plataforma .NET e boas práticas de arquitetura de software.
