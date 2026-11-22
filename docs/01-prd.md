# PRD: Documento de requisitos del producto

| Campo | Detalle |
|:--|:--|
| **Producto** | EnvDoctor: el médico de los entornos de desarrollo |
| **Versión del documento** | 1.0 |
| **Fecha** | 2026-11-22 |
| **Responsable** | Todo el equipo (Luis Bravo, Jeifferson, Ronald) |
| **Estado** | En revisión |

## 1. Visión

Que cualquier integrante de un equipo pueda clonar un proyecto y saber, en minutos y con evidencia, qué le falta a su entorno para compilarlo y ejecutarlo. EnvDoctor combina reglas deterministas, que verifican hechos concretos, con un asistente de IA que los explica en lenguaje claro sin inventar causas.

## 2. Problema

En el desarrollo de software es común que una aplicación funcione en una computadora y falle en otra. Las causas suelen ser:

- Versiones distintas de SDK o runtimes.
- Paquetes o dependencias desalineadas.
- Variables de entorno faltantes.
- Configuración de contenedores incorrecta.
- Puertos ocupados.

El equipo pierde horas buscando la causa, incorporar a un integrante nuevo es lento y todo depende de la persona que "sabe cómo se configura el proyecto".

## 3. Usuarios objetivo

| Perfil | Necesidad principal |
|:--|:--|
| Estudiantes y equipos universitarios | Poner en marcha proyectos compartidos sin depender de una sola persona |
| Desarrolladores que clonan un repositorio | Saber qué instalar o corregir antes de perder tiempo |
| Equipos pequeños | Estandarizar los requisitos del entorno |
| Docentes y mentores | Revisar si un proyecto documenta bien su entorno |

## 4. Propuesta de valor

- **Informe priorizado y trazable:** cada hallazgo tiene severidad, evidencia, impacto y recomendación.
- **Reglas verificables y versionadas:** el diagnóstico no depende de la IA; la IA solo interpreta.
- **Asistente basado en evidencia:** toda respuesta cita el hallazgo, archivo o regla que la respalda.
- **Seguro por diseño:** solo lectura, sin ejecutar código del proyecto y sin enviar secretos.

## 5. Alcance del MVP

El MVP se limita a proyectos .NET y comprobaciones básicas del entorno local.

| # | Módulo | Funcionalidades | Prioridad |
|:--:|:--|:--|:--:|
| 1 | Proyectos y análisis | Registrar un proyecto, subir el reporte del agente o un paquete del proyecto, iniciar un análisis y ver su progreso | Alta |
| 2 | Agente local (CLI) | `dotnet tool` de solo lectura que detecta SDK, runtimes, Docker y puertos, y envía un reporte JSON con consentimiento | Alta |
| 3 | Escaneo del proyecto | Detección de `.sln` y `.csproj`, `TargetFramework`, paquetes NuGet y `global.json` | Alta |
| 4 | Motor de diagnóstico | Reglas de SDK, dependencias, archivos requeridos, variables declaradas, Docker Compose y puertos; cada regla con código y versión | Alta |
| 5 | Informe de salud | Hallazgos por severidad con estado, evidencia, impacto y recomendación; filtros y marca de "no aplica" | Alta |
| 6 | Asistente IA | Explicar hallazgo, resumen del diagnóstico, chat, comparar ejecuciones y guía de incorporación | Media |
| 7 | Historial | Análisis anteriores por proyecto y comparación entre dos ejecuciones | Media |
| — | Casos parecidos (opcional) | Recuperar soluciones de hallazgos similares con búsqueda vectorial en pgvector | Baja |

## 6. Fuera de alcance

- Reparación automática o instalación de herramientas.
- Soporte para todos los lenguajes (la arquitectura queda preparada para sumarlos).
- Auditoría de seguridad.
- Ejecución de scripts del repositorio analizado.
- Extensiones de Visual Studio o VS Code.
- Diagnóstico de servidores en la nube.

## 7. Requisitos funcionales principales

| ID | Requisito |
|:--|:--|
| RF-01 | El usuario puede registrar un proyecto y aceptar qué se va a inspeccionar. |
| RF-02 | El agente local genera un inventario del entorno y lo envía a la API solo con consentimiento. |
| RF-03 | El sistema detecta soluciones, proyectos, frameworks, paquetes y `global.json`. |
| RF-04 | Cada análisis registra la versión del conjunto de reglas (`RulesVersion`). |
| RF-05 | Cada hallazgo tiene severidad, evidencia, impacto y recomendación. |
| RF-06 | El usuario puede filtrar hallazgos por severidad y marcarlos como "no aplica". |
| RF-07 | El asistente responde sobre el diagnóstico activo citando la evidencia. |
| RF-08 | El usuario puede comparar dos ejecuciones del mismo proyecto. |

## 8. Requisitos no funcionales

| ID | Requisito |
|:--|:--|
| RNF-01 | **Seguridad:** el análisis es de solo lectura, limitado a la carpeta seleccionada y sin ejecutar código del proyecto. |
| RNF-02 | **Privacidad:** valores de `.env`, claves y certificados nunca se guardan ni se envían al modelo. |
| RNF-03 | **Reproducibilidad:** todo el sistema levanta con `docker compose up`. |
| RNF-04 | **Calidad:** cobertura de al menos 70 % en la capa de aplicación y CI en verde en cada PR. |
| RNF-05 | **Desacople de IA:** el proveedor de IA se cambia por configuración; en CI se usa un proveedor simulado. |
| RNF-06 | **Rendimiento:** el análisis corre en segundo plano sin bloquear la petición HTTP. |

## 9. Métricas de éxito

| Métrica | Meta para la demo |
|:--|:--|
| Proyectos de ejemplo con errores conocidos (`/samples`) diagnosticados correctamente | 100 % |
| Respuestas del asistente que citan evidencia | 100 % |
| Tiempo desde clonar el repo hasta tener el sistema corriendo | Menos de 10 minutos |
| PR que pasan por CI antes de fusionarse | 100 % |
| Cobertura de pruebas en la capa de aplicación | 70 % o más |

## 10. Supuestos y preguntas abiertas

- Fecha exacta de entrega, pendiente de confirmar con el docente.
- Si se exige despliegue en la nube o basta el entorno local.
- Si el agente local puede presentarse como parte del sistema o debe quedar dentro de la aplicación web.
- Formato esperado de ADR y RFC.

## 11. Referencias

- Propuesta formal del proyecto (EnvDoctor, 21 nov 2026).
- [Decisiones de arquitectura](adr/README.md).
