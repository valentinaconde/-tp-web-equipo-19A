# TP WEB - GRUPO 19 A

Realizado por Valentina Conde, Les Yparraguirre y Milagros Dubuis.

• Comando para clonar repo:   

    git clone https://github.com/valentinaconde/tp-web-equipo-19A.git

# Descripcion del proyecto:<br/>
## Promo WEB<br/>
Partiendo de la arquitectura armada en el TP de Catálogo de Productos, construir una aplicación web con las siguientes características:<br/>
<br/>
Se requiere crear una aplicación para una promoción de un importante comercio. El comercio otorga vouchers con códigos para participar de una promoción por el sorteo de determinados premios. Estos vouchers se otorgan cada vez que el cliente realiza una compra en el establecimiento. El cliente debe ingresar a la página web del comercio e ingresar el código promocional que adquirió con la compra realizada. El sistema deberá constatar que el código sea válido chequeando su existencia en la base de datos. Si es correcto, el paso siguiente será seleccionar el premio por el cual se quiere participar. Si el código de voucher es incorrecto o ya ha sido utilizado, se deberá notificar al usuario en una pantalla aclaratoria con un botón para redirigir al inicio.
Luego de seleccionar el premio, el siguiente paso es cargar los datos personales del cliente a modo de registración. Para ello, lo primero que se solicitará será el DNI. Una vez ingresado, el sistema constatará en la base de datos si el cliente ya se ha registrado antes, de ser así, pre cargará la información en el formulario de registro; de lo contrario, el cliente deberá seguir cargando los datos. Una vez que haya cargado todo, deberá presionar el botón “Participar!” (que lanzará la actividad de registración en el sistema). El sistema validará que esté todo correctamente cargado y dará de alta al cliente en la base de datos, redireccionará a una pantalla de éxito.<br/>
<br/>
Opcional: el sistema debe enviar un email de notificación al cliente sobre su registro exitoso y su participación.<br/>
<br/>
Notas:<br/>
Se brinda script de base de datos con algunos registros pre cargados.<br/>
Cada artículo cuenta con más de una imagen que deben ser mostradas en la web.<br/>
Los vouchers se deben constatar contra la base de datos.<br/>
Los códigos de los vouchers son alfanuméricos.<br/>
Los productos ofrecidos como premios se leen desde la base de datos.<br/>
Los datos del cliente deben ser validados/creados en las tablas correspondientes.<br/>
Todos los datos son requeridos para el alta del cliente. Validar números, formato de email.<br/>
Utilizar arquitectura en capas. Modelo de dominio, Negocio, Presentación, Acceso a Datos.<br/>
El diseño presentado es ilustrativo y queda a criterio del desarrollador el formato final.<br/>
<br/>
Consideraciones:
<br/>
No hay que realizar conexiones nuevas a bases de datos.<br/>
Pueden mejorar las conexiones existentes agregando la clase Acceso a Datos.<br/>
Crear el nuevo set de clases necesario.<br/>
Crear un nuevo repositorio y tener en cuenta la distribución de tareas y el manejo con los commits.<br/>
