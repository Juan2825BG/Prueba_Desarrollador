#  Prueba técnica desarrollador Juniro AZ Smart Technology

### Descripción del Proyecto
Este proyecto es una aplicación web desarrollada en **.NET 8 ASP.NET Core MVC)** diseñada para gestionar un catálogo de autores y sus libros. La aplicación permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) de manera eficiente, asegurando la integridad referencial de los datos y una experiencia de usuario fluida.

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



### Configuración y ejecución

1.  **Clonación:**
    ```bash
    git clone https://github.com/Juan2825BG/Prueba_Desarrollador
    ```
2.  **Base de Datos:**
    Ejecute el siguiente comando en la Consola de Administrador de Paquetes para generar las tablas:
    ```powershell
    EntityFrameworkCore\Update-Database
    ```
![Diagrama Entidad Relación](https://github.com/Juan2825BG/Prueba_Desarrollador/blob/c97c716d257c0d90d6a61d365c872332950b8d4e/Imagenes/DER.png)
