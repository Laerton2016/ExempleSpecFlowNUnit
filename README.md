# ExempleSpecFlowNUnit
Passo 1
Adicione o plugin do SpecFlow no VS que estiver usando 
No VS 2019 -> Extensions -> Manage Extensions

Passo 2 
Crie um projeto de Test, neste exemplo usamos um NUnit, mas pode ser com uma freamework de sua preferência.

Passo 3 
Exclua a class de teste criada pelo templat

Passo 4 
Adicione as extensões necessárias para SpecFlow
No cano do NUnit são: 
-> SpecFlow
-> SpecFlow.NUnit (caso use outra frame procure a da sua frame)
-> SpecFlow.NUnit.Runners (Nescessário no frame do Unit para rodar os teste, não tem em todas as frame)
-> SpecFlow.Tools.MsBuild.Generation (Essa ferramenta é responsável por cria as classe de teste)

Passo 5 
Crie o arquivo de Cenário (Feature) e configure o cenário desejado.
Cada cenário criado será um teste especifico. 

Passo 6 
Cria a classe de step a partir da classe de cenário clicando na mesma com o botão direito e em seguida em "Generation step definitions"

Passo 7 
Ajuste a classe de step conforme a regra de negócio do teste

Passo 8 
Compile sua aplicação de teste

Passo 9
Rode os teste e veja o resultado.

