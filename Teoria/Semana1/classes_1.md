# Classes

[Documentação Oficial da Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/classes)

O tipo _class_ é um tipo de referência, ou seja, no tempo de execução do programa, a variável declarada de um tipo de referência contém o valor [_null_](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/null) até que seja criado explicitamente uma instância (objeto) da classe usando o operador [_new_](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/new-operator).

Ao criar um objeto (instância) da classe, memória suficiente é alocada no _heap gerenciado_ para o objeto específico. A variável contém apenas uma referência para o local onde o objeto está alocado.

Os tipos que são alocados no heap gerenciado requerem sobrecarga quando são alocados e são recuperados pelo [_coletor de lixo_](https://learn.microsoft.com/pt-br/dotnet/standard/garbage-collection/fundamentals), que é o gerenciamento automático de memória do CLR.

```
// [Modificador de acesso] - [class] - [Nome da classe]
public class Person
{
   // Atributos
   // Métodos
   // Propriedades
   // Eventos
   // ...
}
```

Os modificadores de acesso são palavras-chave utilizadas para especifcar a acessibilidade da classe declarada. Existem 5 modificadores de acesso (public, protected, internal, private, file) que possuem 7 níveis de acessibildiade, como mostrado na [documentação](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/access-modifiers).

A palavra-chave _class_ é utilizada para declarar o tipo de referência **Classe**. Por fim, o nome da classe deve seguir o padrão de nomenclatura do C#, como mostrado na [documentação](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/identifier-names)


Clique [aqui](introduction_class.md#classes) para voltar ao início da página.

