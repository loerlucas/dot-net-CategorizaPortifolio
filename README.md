Estrutura do Projeto CategorizaPortifólio
  1.	App/
    o	Contém o ponto de entrada da aplicação, Program.cs.
  2.	Domain/
    o	Contém as classes e interfaces que representam o núcleo do domínio do problema.
      o	Categories/: Contém as implementações das categorias (ExpiredCategory, HighRiskCategory, MediumRiskCategory) e a classe base TradeCategoryBase.
      o	Factories/: Contém a fábrica TradeCategoryFactory.
      o	Interfaces/: Armazena as interfaces como ITrade e ITradeCategory.
      o	Models/: Contém a implementação de modelos, como a classe Trade.
  3.	Services/
    o	Contém classes que implementam a lógica de negócio e serviços, como TradeProcessor e InputReader.
  4.	Tests/
    o	Contém os testes unitários, como TradeProcessorTests.
Benefícios da Estrutura
  •	Organização clara: Cada classe está em um diretório que reflete sua responsabilidade.
  •	Facilidade de manutenção: Alterações em uma parte do código não afetam outras partes.
  •	Testabilidade: Classes estão desacopladas, facilitando a criação de testes unitários.
  •	Escalabilidade: Adicionar novas funcionalidades ou categorias é simples e organizado.
Padrões utilizados
  1.	Separação de Responsabilidades:
    o	InputReader cuida da leitura de entrada.
    o	TradeProcessor cuida do processamento das negociações.
    o	Program apenas orquestra a execução.
  2.	Injeção de Dependência:
    o	TradeProcessor recebe TradeCategoryFactory via construtor.
  3.	Clean Code:
    o	Nomes mais descritivos.
    o	Métodos menores e mais focados.
  4.	Testabilidade:
    o	Facilita a criação de testes unitários para TradeProcessor, InputReader e TradeCategoryFactory.
  5.	Flexibilidade:
    o	Adicionar novas categorias é fácil, basta implementar ITradeCategory e adicionar à fábrica.

Explicação da Estrutura
  Domain/  
    Contém as classes e interfaces que representam o núcleo do domínio do problema.
      Interfaces/: Armazena as interfaces como ITrade e ITradeCategory.   
      Models/: Contém a implementação de modelos, como a classe Trade.    
      Categories/: Contém as implementações das categorias (ExpiredCategory, HighRiskCategory, MediumRiskCategory) e a classe base TradeCategoryBase.
      Factories/: Contém a fábrica TradeCategoryFactory.
  
  Services/  
    Contém classes que implementam a lógica de negócio e serviços, como TradeProcessor e InputReader.
  App/  
    Contém o ponto de entrada da aplicação, Program.cs.
  Tests/
    Contém os testes unitários, como TradeProcessorTests.


