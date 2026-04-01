# 🧩 Task Tracker CLI (C#)

<p align="center">
  <img src="assets/Menu.png" width="700">
</p>

<p align="center">
  A simple Command Line Interface (CLI) application built with <b>C#</b> to manage and track tasks using JSON storage.
</p>

---

🇺🇸 English | 🇧🇷 Português

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
├── assets/
│   └── screenshot.png
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

### Clone repository

```
git clone https://github.com/your-username/task-tracker.git
```

### Enter folder

```
cd task-tracker
```

### Run project

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

Status:

```
Todo
InProgress
Done
```

### Mark in progress

```
dotnet run mark-in-progress 1
```

### Mark done

```
dotnet run mark-done 1
```

### Delete

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

* Unit tests
* Logging
* Task creation date
* Task update date
* Colored console
* Build executable
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
* Desenvolvimento CLI
* Manipulação de JSON
* Leitura e escrita de arquivos
* Organização de código
* Validação de entrada

---

## 🚀 Funcionalidades

* Adicionar tarefas
* Listar tarefas
* Atualizar status
* Marcar em progresso
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

## 📁 Estrutura

```
Task-Tracker/
│
├── assets/
│   └── screenshot.png
│
├── Models/
├── Services/
├── Program.cs
├── tasks.json
└── README.md
```

---

## ⚙️ Como Executar

### Clonar

```
git clone https://github.com/seu-usuario/task-tracker.git
```

### Entrar

```
cd task-tracker
```

### Rodar

```
dotnet run
```

---

## 📌 Comandos

```
dotnet run add "Estudar C#"
dotnet run list
dotnet run update 1 Done
dotnet run mark-in-progress 1
dotnet run mark-done 1
dotnet run delete 1
dotnet run help
```

---

## 📈 Melhorias Futuras

* Testes unitários
* Logs
* Data de criação
* Data de atualização
* Cores no console
* Executável
* Atalhos de comando

---

## 👨‍💻 Autor

**Fellipe Augusto**
Desenvolvedor C# em formação 🚀
