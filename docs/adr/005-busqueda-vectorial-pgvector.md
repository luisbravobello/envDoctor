# ADR-005: Búsqueda vectorial con pgvector (opcional)

- **Estado:** Propuesto
- **Fecha:** 2026-11-22
- **Responsable:** Ronald

## Contexto

Como extensión opcional, el asistente puede sugerir soluciones de hallazgos parecidos que ya se resolvieron (RAG). Para eso necesitamos guardar embeddings de documentación y hallazgos resueltos y buscarlos por similitud. El docente recomendó priorizar caché o base vectorial sobre Kubernetes, y queremos evitar sumar servicios que compliquen el entorno.

## Decisión

- Usar la extensión **pgvector en la misma instancia de PostgreSQL** (imagen `pgvector/pgvector:pg16`), sin un servicio adicional.
- Acceso con `Pgvector.EntityFrameworkCore` y el conector de Semantic Kernel.
- Nueva entidad `KnowledgeChunks` (Id, Source, Content, Embedding, RuleCode, CreatedAt).
- La funcionalidad se activa o desactiva con el feature flag `Features__VectorSearch`.
- Se descartan Kubernetes y Redis para este proyecto.

## Alternativas consideradas

| Alternativa | Por qué no |
|:--|:--|
| Qdrant, Weaviate o Chroma | Otro contenedor que mantener, respaldar y documentar |
| Azure AI Search | Costo y dependencia de la nube |
| Redis como caché | No aporta a la funcionalidad de casos parecidos |

## Consecuencias

- **Positivas:** una sola base de datos, transacciones y respaldos compartidos, sin servicios nuevos.
- **Negativas:** rendimiento menor que un motor vectorial dedicado a gran escala (irrelevante para el volumen del MVP).
- **Riesgo:** al ser opcional, puede quedar fuera si el tiempo no alcanza; el flag permite entregar sin ella.
