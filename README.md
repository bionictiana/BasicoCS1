# Projeto C++ - Hello World

![C++](https://img.shields.io/badge/C%2B%2B-Programming-blue?style=for-the-badge\&logo=cplusplus)
![Beginner Friendly](https://img.shields.io/badge/Level-Beginner-green?style=for-the-badge)

---

> 💡 **Nota:** Este README foi criado para ajudar iniciantes a dar os primeiros passos em C++, explicando de forma simples como criar e executar o clássico "Hello World".

---

##  Sobre o Projeto

Este é o primeiro programa que qualquer programador aprende em uma nova linguagem.

🎯 Objetivo:

* Entender a estrutura básica de um programa em C++
* Aprender a compilar e executar código

---

## 💻 Código

```cpp
#include <iostream>
using namespace std;

int main() {
    cout << "Hello, World!" << endl;
    return 0;
}
```

---

##  Explicação do Código

###  1. Biblioteca

```cpp
#include <iostream>
```

Permite usar entrada e saída (ex: mostrar texto no ecrã).

---

###  2. Namespace

```cpp
using namespace std;
```

Evita escrever `std::cout` sempre.

---

###  3. Função principal

```cpp
int main()
```

É o ponto de entrada do programa.

---

###  4. Saída de dados

```cpp
cout << "Hello, World!" << endl;
```

* `cout` → imprime no ecrã
* `endl` → quebra de linha

---

###  5. Final do programa

```cpp
return 0;
```

Indica que o programa terminou com sucesso.

---

## ⚙️ Como instalar C++

###  Windows

1. Instalar o compilador (MinGW)
2. Adicionar ao PATH
3. Verificar no terminal:

```bash
g++ --version
```

---

##  Usando VS Code

1. Instalar o VS Code
2. Instalar extensão **C/C++**
3. Criar ficheiro:

```
hello.cpp
```

---

## 🚀 Como executar

### 1. Compilar

```bash
g++ hello.cpp -o hello
```

### 2. Executar

```bash
./hello
```

---

##  Resultado esperado

```bash
Hello, World!
```

---

##  Objetivo Educacional

Este projeto ajuda iniciantes a:

* Entender a base do C++
* Dar o primeiro passo na programação
* Preparar-se para conceitos mais avançados

---

##  Próximos passos

Depois deste, podes aprender:

* Variáveis
* Condições (if)
* Ciclos (for, while)

---

## 👩🏽‍💻 Autora

**Erica Tatiana**
Desenvolvedora em evolução

---

## ⭐ Apoio

Se este projeto te ajudou, deixa uma ⭐ no repositório!
