# ADR-001: PostgreSQL como base de datos

- **Estado:** Propuesto
- **Fecha:** 2026-11-22
- **Responsable:** Luis Bravo

## Contexto

EnvDoctor guarda proyectos, ejecuciones de análisis, hallazgos, hechos del entorno y conversaciones con el asistente. Los datos son relacionales (un proyecto tiene muchas ejecuciones y cada ejecución muchos hallazgos), necesitamos migraciones versionadas en el repositorio y una base que corra igual en local, en CI y en el entorno de demostración. Además, la funcionalidad opcional de "casos parecidos" requiere búsqueda vectorial.

## Decisión

Usar **PostgreSQL 16** como única base de datos, accedida solo desde la API mediante **Entity Framework Core** con el proveedor Npgsql. El esquema evoluciona con migraciones de EF Core versionadas en el repositorio. En Docker Compose se usa la imagen `pgvector/pgvector:pg16`, que permite activar la extensión vectorial sin agregar otro servicio (ver [ADR-005](005-busqueda-vectorial-pgvector.md)).

## Alternativas consideradas

| Alternativa | Por qué no |
|:--|:--|
| SQL Server | Imagen pesada, licencia de desarrollo y sin búsqueda vectorial integrada en la versión gratuita |
| SQLite | Sencilla, pero no representa un entorno real ni permite probar concurrencia del worker |
| MongoDB | El modelo es relacional; perderíamos integridad referencial y migraciones de EF Core |

## Consecuencias

- **Positivas:** gratuita y de código abierto; imagen oficial liviana; pruebas de integración con PostgreSQL real usando Testcontainers; base vectorial en la misma instancia.
- **Negativas:** el equipo debe aprender particularidades de Npgsql (tipos, nombres en minúscula).
- **Pendiente:** definir el diagrama ER y el diccionario de datos en [06-base-de-datos.md](../06-base-de-datos.md).
