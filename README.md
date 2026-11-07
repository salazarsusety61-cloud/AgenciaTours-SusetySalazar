# Naturaleza y Aventura CR
Sistema de gestión de reservas de tours turísticos desarrollado en C# con Windows Forms.

## Funcionalidades
- Registrar nuevas reservas con datos del cliente, tour, cantidad de personas y fecha
- Catálogo de tours precargados de tipo Aventura y Cultural
- Visualización de todas las reservas en tabla
- Ver detalle completo con cálculos: subtotal, descuento, cargo, IVA y total
- Eliminar reservas con confirmación
- Cálculo automático de ingresos totales y contadores
- Validaciones y mensajes de advertencia
- Confirmación al salir del sistema
- Imagen de fondo personalizada

## Estructura del proyecto
AgenciaTours/
├── Form1.cs               # Ventana principal
├── FrmReserva.cs          # Formulario de nueva reserva y detalle
├── Logica/
│   ├── Reserva.cs         # Clase base
│   ├── ReservaAventura.cs # Herencia - tipo aventura
│   ├── ReservaCultural.cs # Herencia - tipo cultural
│   ├── GestorReservas.cs  # Lógica de negocio
│   └── CatalogoTours.cs   # Lista de tours disponibles

## Tecnologías
- C# / .NET Framework
- Windows Forms
- Visual Studio

## Autor
Susety Melissa Rodriguez Salazar — Proyecto de Programación
