# NonLinealSystemEquation

Este proyecto tiene como objetivo crear una aplicación que permita resolver un sistema de ecuaciones no lineales. Se basa en el funcionamiento de la extensión del algoritmo de **Newtón-Raphlson** para varias variables.

## Dependencias

El proyecto está desarrollado en **C# .NET 6.0**, en la plataforma de **WPF**, en la cual se basa la interfaz gráfica. Para ejecutarlo debe abrir su terminal en la raíz del proyecto y ejecutar el siguiente comando.

```bash
dotnet run --project UserInterface
```

Además la biblioteca de clases `NonLinealSystemEquation` cuenta con la siguiente dependencia: <a href="https://numerics.mathdotnet.com/">Math.NET Numerics</a>.