# ASP-MVC
<!--- ASP MVC Demo Project -->
Demostración de proyecto de ASP-MVC - SQL Server - Entity Framework - ASP Core.

### Descripción

En este proyecto se verán las bases y estructura principal de conexión de una aplicación Model-View-Controller usando ASP .NET y SQL Server.

El proyecto MVC se estructura en las carpetas Controller, Models y Views. Models se crea desde cero como una clase y se crean parametros get and set para cada propiedad.

La clase Startup maneja los elementos a iniciar con la aplicación como assets, routing y conexión con la base de datos y los objetos.

### Base de datos (SQL Server)

- Se crea el contexto de Base de Datos
- Se crea el objeto y se utiliza como objeto interno de base de datos con elementos de IEnumerable para iterar el objeto de DB
- Para crear nuevos modelos de base de datos o nuevos cambios primero se realiza una *migracion* con el SHELL del Package Manager y se usando los comandos *add-migration agregandoElemento* y se actualiza *update-database* para realizar y subir la migracion a la base de datos, cualidad del Entity Frameworks, Code - First.
- Si la migracion no funciona, probar *enable-migrations* antes de realizar cualquier de unas opciones de agregar migraciones.

### Para correr aplicación

- Primero deberá tener instalado una versión de VS Studio (Actualmente 19)
- Instalar Microsoft SQL Management Studio (Manejador de base de datos SQL Server)
- *git clone* y abrir proyecto
- CTRL + F5 para correr sin debugging y directamente
- Probar web app con HTTPS

### Datos a tomar en cuenta

- Se debe crear la base de datos primero en SQL Server Management Studio (En este caso se llama Demo y se usa la dirección local)
- El string de conexión debe ser sin espacios en blanco
- Es una aplicacion sencilla de CRUD de elementos en la base de datos
- El string de la conexión se encuentra en *appsettings.json*
- En Dependencias/Packages se verán los paquetes necesarios para la conexión con el Entity Framework.


### Curso de referencia

https://www.youtube.com/watch?v=DqD-NJf7-OM&t=9012s
