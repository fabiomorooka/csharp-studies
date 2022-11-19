# Namespaces

[Documentação Oficial da Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/namespaces)

Os namespaces são muito utilizados em programação C# por dois motivos:
1. Organização das classes
```
System.Console.WriteLine("Olá, Mundo!");
```

Neste  caso, a classe _Console_ pertence ao namespace _System_.

A fim de faciltar o uso das classes ao longo de um programa em C#, é possível usar a palvra-chave _using_, como mostrado a seguir.

```
using System;

Console.WriteLine("Olá, Mundo!");
```

2. Controlar o escopo das classes (e métodos) em projetos maiores, realizando a criação do próprio namespace do sistema. Para isso, basta usar a palavra [_namespace_](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/namespace).

```
namespace MyTest
{
    class MyTestClass
    {
        public void MyTestMethod()
        {
            System.Console.WriteLine(
                "Testing namespace");
        }
    }
}
```

Mais informações a respeito de namespaces podem ser encontradas [aqui](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/namespaces).

Clique [aqui](namespaces.md#namespaces) para voltar ao início da página.
