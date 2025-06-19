# Blazor MVVM Todo App

A simple Todo List application built with **Blazor Server (.NET 8)** using a **MVVM-style pattern**.  
This project is designed to be containerized with Docker and deployed to AWS EC2.

## 🧱 Architecture

- **Model:** `TodoItem.cs` — Represents a todo task
- **ViewModel:** `TodoService.cs` — Handles logic and state
- **View:** `Index.razor` — UI binding to ViewModel

## 🖥️ Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/Darkus1t0262/blazor-mvvm-todo.git
   cd blazor-mvvm-todo
