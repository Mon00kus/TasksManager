# TasksManager 
Aplicación blazor web app, server-side, para manejar tareas.

Configuración y ejecución.

Si es necesario instala el SDK de .Net 8, puedes descargarlo aqui:
https://dotnet.microsoft.com/es-es/download

Usar Visual Studio 2022, version 17.8.6, con la carga para .Net 8 instalada

Para ejecutar la aplicacion "Desde el entorno de Visual Studio 2022"

Abrir la Solución, luego de abierta hacer click derecho sobre la misma (la solución) 
y realizar un "Build" de la solución.

en visual studio Menu: Tools-->Nuget Package Manager--> Package Manager Console

con el Default project establecido a TasksManager.Infrastructure, escribir:

update-database -context TasksManagerDbContext

Luego,

con el Default project establecido a TasksManager.AuthUi, escribir:

update-database -context ApplicationDbContext

De esta manera se crea la BD y las tablas necesarias, y quedaria lista para ser usada la app.
Presionar F5

Puedes Verificar si se han instalado las tablas o si se ha agregado data a las mismas ingresando desde el 
Menu de Visual Studio, selecciona View-->Sql Server Explorer, luego en el Object explorer que se muestra 
selecciona Sql Server-->localdb\Instance-->Databases-->TaskManager-->Tables
ó
desde el Managment Studio, apertura (localdb)\MSSQLLocalDB con Windows Authentication y verifica la BD por ahi.