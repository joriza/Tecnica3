https://www.sql-practice.com/

Carga de datos: 500 pacientes y 500 citas

https://www.sql-easy.com/es/tutorial/

https://www.genbeta.com/desarrollo/cuatro-mejores-plataformas-gratis-para-practicar-sql-lenguaje-bases-datos-excelencia


### Markdown to PDF converter

Header
<div style="font-size: 9px; margin-left: 1cm;"> <span class='title'></span></div> <div style="font-size: 9px; margin-left: auto; margin-right: 1cm; ">%%ISO-DATE%%</div>
<div style="font-size: 9px; margin: 0 auto;"> <span class='title'></span></div>

Footer
<div style="font-size: 9px; margin: 0 auto;"> <span class='pageNumber'></span> / <span class='totalPages'></span></div>










## Reiniciar servicio de SQL Server

Para reiniciar el servicio de SQL Server en Windows, puedes usar diferentes métodos según tu entorno:
📌 Opción 1: Usando SQL Server Configuration Manager (Recomendado)

    Abre el SQL Server Configuration Manager.

        Puedes buscarlo en el menú Inicio como SQL Server Configuration Manager.

    En el panel izquierdo, selecciona SQL Server Services.

    En el panel derecho, haz clic derecho sobre SQL Server (MSSQLSERVER) y selecciona Restart.


## Activar un usuario deshabilitado

Para activar un usuario deshabilitado en SQL Server, sigue estos pasos:
📌 1. Conectar con una cuenta con permisos suficientes

Debes iniciar sesión en SQL Server con una cuenta que tenga permisos de administrador (sa o un usuario con rol sysadmin).
📌 2. Verificar el estado del usuario

Ejecuta la siguiente consulta para ver si el usuario está deshabilitado:

SELECT name, is_disabled 
FROM sys.sql_logins 
WHERE name = 'nombre_usuario';

    Si is_disabled = 1, el usuario está deshabilitado.

📌 3. Activar el usuario con ALTER LOGIN

Ejecuta este comando para habilitar el usuario:

ALTER LOGIN nombre_usuario ENABLE;

📌 4. Restablecer la contraseña (opcional)

Si el usuario está bloqueado o se olvidó la contraseña, puedes restablecerla:

ALTER LOGIN nombre_usuario WITH PASSWORD = 'NuevaContraseña';

⚠️ Nota: Asegúrate de cumplir con las políticas de seguridad de SQL Server para contraseñas.
📌 5. Confirmar que el usuario está activo

Ejecuta nuevamente:

SELECT name, is_disabled 
FROM sys.sql_logins 
WHERE name = 'nombre_usuario';

    is_disabled = 0 significa que el usuario está habilitado.

