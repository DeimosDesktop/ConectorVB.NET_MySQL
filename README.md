# ConectorVB.NET_MySQL
Este programa simple utiliza la .dll llamada Connector NET en su versión 4.5.2 y que podrás descargar desde la siguiente URL:
https://dev.mysql.com/downloads/connector/net/
Una vez instalado, deberás de importar en tu proyecto el archivo .dll llamado MySql.Data.dll que estará instalado en el directorio %ProgramFiles%/MySQL (por defecto).
El programa te permitirá conectar a una base de datos MySQL en la cual deberás de especificar en la variable connectionString el servidor, el nombre de la base de datos, usuario y contraseña en una cadena alfanumerica. Ten en cuenta que la conexión se realiza sobre localhost, por lo que deberás de tener una base de datos MySQL instalada en tu PC a modo de base virtual. Para ello puedes usar MariaDb integrado en XAMPP o WAMPP. Si quieres conectar la aplicación a una base de datos remota, deberás de configurar un tunel SSH, ya que por lo general, los servidores remotos incluyen seguridad que no permite que una aplicación se conecte a ellos.
Sobre el formulario, es muy básico.
Tiene dos botones; uno para comprobar la conexión; otro para realizar la acción especificada. Además tiene un control DataGridView para mostrar los datos de la tabla específica de la base de datos. Por lo tanto es importante que la consulta a mostrar llame directamente a la tabla de la base de datos en cuestión.

YA PUEDES CONSULTAR LA PRÁCTICA EN:
https://mirpas.com/content/Lenguajes/projects/VBNET/conectorMysql.php

Este proyecto está reglado mediante una licencia abierta GNU General Public License, con lo cual puedes descargar, usar, estudiar, compartir (copiar) y modificar el software.
