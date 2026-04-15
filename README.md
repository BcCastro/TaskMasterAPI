# 🚀 TaskMaster API - Gestión de Tareas con .NET 9

Este proyecto es una **Web API robusta** diseñada para la gestión de tareas, utilizando estándares de la industria y arquitectura limpia. Es ideal para servir como backend de aplicaciones web o móviles.

## 🛠️ Stack Tecnológico
*   **Lenguaje:** C# (.NET 9)
*   **Base de Datos:** SQLite (Persistencia real de datos)
*   **ORM:** Entity Framework Core
*   **Documentación:** Swagger / OpenAPI
*   **Arquitectura:** RESTful API con Patrón Controlador y Asincronismo (`async/await`)

## 🌟 Funcionalidades Implementadas
- ✅ **Persistencia de Datos:** Los datos se guardan en una base de datos SQL real (`TaskMaster.db`).
- ✅ **Operaciones CRUD:**
  - `GET /api/Tareas`: Recupera todas las tareas desde la base de datos.
  - `POST /api/Tareas`: Crea y guarda nuevas tareas.
  - `DELETE /api/Tareas/{id}`: Elimina tareas específicas por su ID.
- ✅ **Documentación Interactiva:** Interfaz completa en Swagger para pruebas de endpoints.

## 🚀 Cómo empezar
1. Clona el repositorio.
2. Ejecuta `dotnet ef database update` para generar la base de datos local.
3. Ejecuta `dotnet run` y abre `http://localhost:5219/swagger`.
