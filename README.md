# 🧩 Task Tracker CLI (C#)

A simple Command Line Interface (CLI) application built with **C#** to manage and track tasks using a JSON file for storage.

---

🇺🇸 [English](#-english) | 🇧🇷 [Português](#-português)

---

# 🇺🇸 English

## 📌 About the Project

Task Tracker CLI is a command line application built in **C#** that allows users to manage tasks using a JSON file as storage.

This project was created to practice:

* C# fundamentals
* CLI development
* JSON manipulation
* File handling
* Clean code structure
* Input validation

---

## 🚀 Features

* Add new tasks
* List all tasks
* Update task status
* Mark task as in progress
* Mark task as done
* Delete tasks
* Help command
* JSON file storage
* Safe input validation

---

## 🛠️ Technologies

* C#
* .NET
* System.Text.Json
* CLI
* JSON
* File System

---

## 📁 Project Structure

```
Task-Tracker/
│
├── Models/
│   ├── TaskItem.cs
│   └── TaskStatus.cs
│
├── Services/
│   └── TaskService.cs
│
├── tasks.json
├── Program.cs
└── README.md
```

---

## ⚙️ How to Run

### Clone the repository

```
git clone https://github.com/your-username/task-tracker.git
```

### Enter the folder

```
cd task-tracker
```

### Run the project

```
dotnet run
```

---

## 📌 Commands

### Add task

```
dotnet run add "Study C#"
```

### List tasks

```
dotnet run list
```

### Update task

```
dotnet run update 1 Done
```

Available status:

```
Todo
InProgress
Done
```

### Mark in progress

```
dotnet run mark-in-progress 1
```

### Mark as done

```
dotnet run mark-done 1
```

### Delete task

```
dotnet run delete 1
```

### Help

```
dotnet run help
```

---

## 💾 Storage

Tasks are stored in:

```
tasks.json
```

Example:

```json
[
  {
    "Id": 1,
    "Title": "Study C#",
    "Status": "Todo"
  }
]
```

---

## 📈 Future Improvements

* Unit Tests
* Logging
* Task creation date
* Task update date
* Colored console output
* Packaging as executable
* Command aliases

---

## 👨‍💻 Author

**Fellipe Augusto**

C# Developer in training 🚀

---

# 🇧🇷 Português

## 📌 Sobre o Projeto

Task Tracker CLI é uma aplicação de linha de comando desenvolvida em **C#** que permite gerenciar tarefas utilizando um arquivo JSON como armazenamento.

Este projeto foi criado para praticar:

* Fundamentos de C#
* Desenvolvimento de CLI
* Manipulação de JSON
* Leitura e escrita de arquivos
* Organização de código
* Validação de entrada

---

## 🚀 Funcionalidades

* Adicionar tarefas
* Listar tarefas
* Atualizar status
* Marcar como em progresso
* Marcar como concluída
* Deletar tarefas
* Comando de ajuda
* Armazenamento em JSON
* Validação de entrada

---

## 🛠️ Tecnologias

* C#
* .NET
* System.Text.Json
* CLI
* JSON
* Sistema de arquivos

---

## 📁 Estrutura do Projeto

```
Task-Tracker/
│
├── Models/
│   ├── TaskItem.cs
│   └── TaskStatus.cs
│
├── Services/
│   └── TaskService.cs
│
├── tasks.json
├── Program.cs
└── README.md
```

---

## ⚙️ Como Executar

### Clonar o repositório

```
git clone https://github.com/seu-usuario/task-tracker.git
```

### Entrar na pasta

```
cd task-tracker
```

### Rodar o projeto

```
dotnet run
```

---

## 📌 Comandos

### Adicionar tarefa

```
dotnet run add "Estudar C#"
```

### Listar tarefas

```
dotnet run list
```

### Atualizar tarefa

```
dotnet run update 1 Done
```

Status disponíveis:

```
Todo
InProgress
Done
```

### Marcar em progresso

```
dotnet run mark-in-progress 1
```

### Marcar como concluída

```
dotnet run mark-done 1
```

### Deletar tarefa

```
dotnet run delete 1
```

### Ajuda

```
dotnet run help
```

---

## 💾 Armazenamento

As tarefas são armazenadas em:

```
tasks.json
```

Exemplo:

```json
[
  {
    "Id": 1,
    "Title": "Estudar C#",
    "Status": "Todo"
  }
]
```

---

## 📈 Melhorias Futuras

* Testes unitários
* Logs
* Data de criação da tarefa
* Data de atualização
* Cores no console
* Gerar executável
* Atalhos de comandos

---

## 👨‍💻 Autor

**Fellipe Augusto**

Desenvolvedor C# em formação 🚀
