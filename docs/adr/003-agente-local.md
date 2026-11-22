# ADR-003: Agente local como dotnet tool de solo lectura

- **Estado:** Propuesto
- **Fecha:** 2026-11-22
- **Responsable:** Luis Bravo

## Contexto

Muchos problemas de entorno (SDK y runtimes instalados, Docker, puertos ocupados) solo se pueden observar en la máquina del desarrollador. Un servidor no puede verlos, y pedir al usuario que copie la salida de varios comandos es lento y propenso a errores. A la vez, inspeccionar una máquina ajena es sensible: no podemos ejecutar código del proyecto ni leer secretos.

## Decisión

Construir un **agente de consola en C#** distribuido como **.NET global tool** (`EnvDoctor.Agent`, comando `envdoctor`):

- Solo lectura: detecta SDK, runtimes, Docker y puertos con comandos permitidos, argumentos controlados y límite de tiempo.
- Nunca ejecuta código ni scripts del repositorio.
- Lectura restringida a la carpeta seleccionada, con bloqueo de path traversal.
- Excluye `.env`, claves y certificados; solo informa si una variable existe o falta.
- Genera un reporte JSON y lo envía a la API **solo con consentimiento** del usuario.
- Se publica con `dotnet pack` en GitHub Packages desde el pipeline de CD.

## Alternativas consideradas

| Alternativa | Por qué no |
|:--|:--|
| Solo subir un paquete del proyecto a la web | No ve el entorno real (SDK instalados, puertos, Docker) |
| Script de PowerShell o Bash | Distinto por sistema operativo y difícil de probar |
| Extensión de VS Code | Fuera de alcance y limita a un editor |

## Consecuencias

- **Positivas:** diagnóstico del entorno real, un solo lenguaje para todo el backend, instalación con `dotnet tool install`.
- **Negativas:** comportamiento distinto entre Windows, Linux y macOS.
- **Mitigación:** documentar qué reglas soporta cada sistema y probar el agente en los tres.
