# 🏥 Sistema de Inventario para Farmacia - Botica Sila

## 📌 Descripción del Proyecto
Este es un sistema de inventario computarizado desarrollado en **C# con Visual Studio**, diseñado para gestionar las **entradas y salidas de mercancía** en la botica Sila. Su propósito es **optimizar el control de stock** y facilitar el seguimiento de productos, empleados y movimientos en el inventario.

---

## 🚀 Funcionalidades Principales
✅ **Gestión de productos**: Registro, actualización y eliminación de productos.  
✅ **Control de inventario**: Monitoreo de entradas y salidas de mercancía.  
✅ **Administración de empleados**: Gestión del personal que manipula el inventario.  
✅ **Categorías de productos**: Clasificación organizada de los artículos.  
✅ **Consultas y reportes**: Generación de informes detallados sobre movimientos, productos y empleados.  
✅ **Sistema de seguridad**: Control de accesos y respaldo de datos.  

---

## 🛠️ Tecnologías Utilizadas
- **Lenguaje**: C#  
- **Entorno**: Visual Studio  
- **Base de Datos**: SQL Server  
- **Interfaz Gráfica**: Windows Forms  

---

## 📊 Diseño de la Base de Datos
### 🗃️ Entidades Principales:
- **Productos**: ID, Nombre, Categoría, Estado, Marca, Fecha de Vencimiento, Existencia, Precio.  
- **Empleados**: ID, Nombre, Apellido, Cargo, Teléfono, Dirección, Fecha de Nacimiento, Estado.  
- **Movimientos de Inventario**: ID, Tipo de Movimiento (Entrada/Salida), Fecha, Cantidad, Producto, Empleado.  

### 🔗 Relación entre Entidades:
- Un **empleado** puede realizar múltiples **movimientos de inventario**.  
- Un **producto** pertenece a una **categoría** específica.  
- Un **movimiento** está vinculado a un **producto** y a un **empleado**.  

---

## 🖥️ Diseño de la Interfaz de Usuario
📌 **Menús organizados**:  
🔹 **Mantenimientos**: Para registrar y modificar productos, empleados y categorías.  
🔹 **Procesos**: Para registrar entradas y salidas de productos.  
🔹 **Consultas**: Para visualizar información específica.  
🔹 **Reportes**: Para generar documentos detallados.  
🔹 **Seguridad**: Copias de seguridad y gestión de accesos.  

---

## 📸 Capturas de Pantalla
### Pantalla de Inicio  
![Pasted image 20250202164212](https://github.com/user-attachments/assets/d9b770de-8f85-4669-a2c7-a14852346509)


### Formulario de Gestión de Productos  
![Pasted image 20250202164456](https://github.com/user-attachments/assets/16e302d8-0992-47b4-9148-c64749438b85)


---

## 📜 Estándares del Sistema
✅ **Interfaz amigable y fácil de usar**  
✅ **Mensajes de confirmación y validaciones**  
✅ **Atajos de teclado para mejorar la experiencia del usuario**  
✅ **Generación de reportes en diferentes formatos**  

---

## 📂 Reportes Generados
📌 **Reporte de empleados**  
📌 **Reporte de productos por categoría/marca/fecha de vencimiento**  
📌 **Historial de movimientos de inventario**  
📌 **Consulta de stock disponible**  

---

## 📌 Instalación y Uso
1️⃣ Clona el repositorio  
```bash
git clone https://github.com/tu-repo/sistema-inventario-botica.git
```
2️⃣ Abre el proyecto en **Visual Studio**  
3️⃣ Configura la base de datos en **SQL Server**  
4️⃣ Ejecuta la aplicación y comienza a gestionar tu inventario  

---

## 🏗️ Futuras Mejoras
✔ Integración con código de barras  
✔ Generación automática de alertas por stock bajo  
✔ Implementación de un sistema de usuarios con roles  

---

## 📢 Créditos
👨‍💻 **Desarrollado por**: Jeremy De La Cruz  
📆 **Fecha**: 14/08/2022  
📚 **Materia**: Análisis y Diseño de Sistemas II  
👨‍🏫 **Profesor**: José Ramón Capellán María  

---

📌 **¡Gracias por revisar el proyecto!**  
🚀 **Si tienes alguna sugerencia o mejora, no dudes en contribuir.**
