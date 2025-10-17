# ExamenUnidad2_Patrones_JonathanGarciaSantos
Examen Unidad 2 - Patrones de diseño

*Autor:* Jonathan García Santos  
*Número de Control:* 22210307  
*Proyecto:* Reserva y Seguimiento de Transporte  
*Materia:* Patrones de Diseño   

---
## Descripción General

Este proyecto implementa la **reserva y seguimiento de transportes** aplicando los patrones de diseño **Singleton** y **Object Pool**.  
El sistema permite al usuario **asignar** o **liberar vehículos** dentro de una ruta global fija, optimizando el uso de recursos y garantizando un control centralizado.

---

## Funcionamiento del Sistema

1. **Inicio del programa**  
   - Se inicializa automáticamente el **Administrador de Rutas**, implementado con el patrón **Singleton**.  
   - Esta clase garantiza que solo exista **una instancia global** de la ruta principal (`RUTA CENTRAL - TIJUANA A MEXICALI`).

2. **Gestión de vehículos (Object Pool)**  
   - El sistema crea una cantidad inicial de vehículos reutilizables.  
   - Cada vehículo tiene atributos como `Placa`, `Tipo` y `Estado` (Disponible o En uso).  
   - Cuando un usuario **asigna un vehículo**, este pasa de la lista de disponibles a la de en uso.  
   - Al **liberarlo**, el vehículo regresa al pool disponible, evitando la creación de nuevos objetos.

3. **Interacción con el usuario**  
   - El usuario puede seleccionar manualmente el vehículo que desea usar o liberar mediante su número de placa (por ejemplo, `T001`).  
   - Después de cada acción, el sistema muestra automáticamente el **estado actualizado de toda la flota**, incluyendo qué unidades están en uso o disponibles.

4. **Finalización**  
   - El usuario puede salir del sistema, manteniendo el registro limpio y ordenado de los vehículos gestionados durante la sesión.

---

## Patrones Aplicados

### 🔸 Patrón Singleton
- Garantiza que el administrador de rutas tenga **una sola instancia global**.  
- Evita duplicación de control y centraliza la información del sistema.  
- Implementado en la clase `AdministradorRutas`.

### 🔸 Patrón Object Pool
- Permite **reutilizar vehículos** sin necesidad de crear o eliminar objetos constantemente.  
- Aumenta la eficiencia del sistema al controlar los recursos disponibles.  
- Implementado en la clase `VehiculoPool`.

---

## Ventajas del Diseño

- Eficiencia en el manejo de recursos.
- Control centralizado de la ruta principal.
- Reutilización de objetos sin sobrecargar el sistema.
- Interacción directa del usuario para seleccionar y liberar transportes.

---
## Como ejecutarlo
Sigue estos pasos para compilar y ejecutar el proyecto correctamente en tu entorno local usando **C# (.NET SDK)**.
---
Asegúrate de tener instalado:

- [Visual Studio Code](https://code.visualstudio.com/)
- [SDK de .NET 6 o superior](https://dotnet.microsoft.com/download)
- Extensión de C# para VS Code (instálala desde el Marketplace)

Verifica la instalación ejecutando en la terminal:
```bash
dotnet --version
```
Abre una terminal en Visual Studio Code y escribe:
```bash
dotnet new console -n ExamenUnidad2
```
En la terminal de VS Code, asegúrate de estar dentro de la carpeta del proyecto:
```bash
cd ExamenUnidad2

```
Para iniciar el sistema, ejecuta:
```bash
dotnet run
```
---
