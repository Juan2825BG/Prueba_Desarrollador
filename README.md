#  Prueba técnica desarrollador Junior AZ Smart Technology

### Descripción del Proyecto
Este proyecto es una aplicación web desarrollada en **.NET ASP.NET Core MVC)** diseñada para gestionar un catálogo de autores y sus libros. La aplicación permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) de manera eficiente, asegurando la integridad referencial de los datos y una experiencia de usuario fluida.

###Diagrama entidad relación de la base de datos 

* **Autores:** Almacena la información principal del escritor.
* **Libros:** Contiene los detalles de la obra y está vinculado obligatoriamente a un Autor mediante una clave foránea (`AutorId`).


    AUTORES {
        int AutorID PK
        string Nombre
    }
    
    LIBROS {
        int ID PK
        string Titulo
        int AutorID FK
    }

![Diagrama Entidad Relación](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/c97c716d257c0d90d6a61d365c872332950b8d4e/Imagenes/DER.png)

### Configuración y ejecución

1.  **Clonación:**
    ```bash
    git clone https://github.com/Juan2825BG/Prueba_Desarrollador
    ```
2.  **Conexión DB:**
Para la conexión a la base de datos verificar que en el archivo appsettings.json la cadena de conexión DefaultConnection apunte a su instancia de SQL Server.

    "ConnectionStrings": {   "DefaultConnection": "Server=DESKTOP-VL0HIE0;Database=GestionBiblioteca;Trusted_Connection=True;TrustServerCertificate=True;" }

Modificar DESKTOP-VL0HIE0 por el servidor en el cual se realizar la revisión.

3.  **Base de Datos:**
    Ejecute el siguiente comando en la Consola de Administrador de Paquetes para generar las tablas:
    ```powershell
    EntityFrameworkCore\Update-Database
    ```
4.  **Ejecutar el programa en Visual Studio**

###Funcionalidades

A primera vista se encontrara con la siguiente inmediatamente despues de ejecutar el programa: 

![Inicio](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/Home.png)

En este se encontrara una barra de navegación en la cual podra ir a los distintas funcionalidades. En el boton Inicio es la funcionalidad en la cual se encuentra en este momento, visualiza los libros registrados en este momento en formato de tabla en la parte central, ademas en la parte central derecha se encuentran dos botones, cada uno de ellos estara demarcado como Libros o Autores, al hacer click en ellos podra acceder a la funcionalidad de gestionar los libros o autores registrados en el sistema. Adicionalmente en la barra de navegación encontrara estos mismos botones, los cuales tienen la misma función al hacer click en ellos como se explico anteriormente. Esta barra de navegación sirve para ir a cada funcionalidad principal; sin que haya que retroceder a la pagina anterior en las funciones de crear, editar o eliminar un libro o autor en dado caso. 

Al hacer click en el boton de autores, se observara lo siguiente: 

![Pantalla Autor](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/Autores.png)

En el parte central se encontrara los autores registrados en el sistema, ademas, en cada fila se encontraran botones para editar o eliminar cada uno de estos registros. En la parte superior a la tabla se encontara un boton con un icon de "MAS" el cual hacer referencia a la funcionalidad de crear o adicionar un nuevo registro de un autor.

En las siguientes imagenes se observa las 3 funcionalidades detalladas crear, eliminar y editar con sus respectivos formularios para la información y la confirmación de realizar la acción seleccionada.

![Agregar Autor](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/AG%20Autor.png)

![Editar Autor](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/ED%20Autor.png)

![Eliminar Autor](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/DL%20Autor.png)

###### Nota: Para la funcionalidad de eliminar autor, se indica que si no se gestionan los libros relacionados a dicho autor a eliminar, los libros relacionados a este tambien se eliminaran del sistema. 

Al hacer click en el boton de libro, se observara lo siguiente: 

![Pantalla Libro](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/Libros.png)

Como se explico anteriormente para las funcionalidades de autores, estas son las mismas funcionalidades para los libros. Con sus mismo ¿s botones para ejecutar cada una de las acciones correspodnientes a crear, eliminar y editar.

![Agregar Libro](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/AG%20Libro.png)

![Editar Libro](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/10efb5a6bf245f880200327404069622a7f69fd7/Imagenes/ED%20Libro.png)

![Eliminar Libro](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/344e04ca0c4fef1fe2be48d0c421e498573a2747/Imagenes/DL%20Libro.png)
