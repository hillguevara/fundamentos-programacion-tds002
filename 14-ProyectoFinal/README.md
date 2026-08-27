# 🍰 La Repostería de Hill — Sistema de Gestión de Inventario

Aplicación de consola desarrollada en **C# (.NET 8)** para la administración de inventario, registro de ventas, control de stock mínimo y balance financiero de **La Repostería de Hill**.

## Funcionalidades Principales

* **Agregar Producto:** Permite registrar nuevos productos ingresando nombre, precio y cantidad.
* **Ver Inventario:** Muestra la lista completa de productos registrados con su precio y stock disponible.
* **Vender Producto:** Permite realizar ventas buscando por nombre, validando y descontando el stock correspondiente.
* **Reporte de Inventario Bajo:** Muestra una alerta con los productos que tienen menos de 5 unidades en existencia.
* **Valor Total del Inventario:** Calcula de forma acumulada el valor financiero total del inventario disponible (`precio * cantidad`).

## Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Core / Console Application)
* **Estructuras de datos:** Listas genéricas (`List<T>`)
* **Control de versiones:** Git & GitHub
  
## Información de la Autora

* **Estudiante:** Hillary Stephanie Guevara Segura
* **Matrícula:** 2026-0946
* **Asignatura:** Fundamenos de programación
* **Proyecto:** Trabajo final

## Requisitos Previos

Antes de ejecutar el proyecto, asegúrate de tener instalado:

* **.NET SDK 8.0** o superior (verifícalo ejecutando `dotnet --version` en tu terminal).
* **Visual Studio Code** o la terminal de tu preferencia (PowerShell / Command Prompt).

## Cómo ejecutarlo

* **1.** Clona el repositorio o descarga la carpeta `14-ProyectoFinal`.
* **2.** Abre una terminal dentro de la carpeta `14-ProyectoFinal`.
* **3.** Ejecuta el comando: `dotnet run`
* **4.** Sigue el menú en pantalla escribiendo el número de la opción deseada.
