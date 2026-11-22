# ADR-002: Semantic Kernel con Ollama como proveedor de IA

- **Estado:** Propuesto
- **Fecha:** 2026-11-22
- **Responsable:** Ronald

## Contexto

El asistente de EnvDoctor debe explicar hallazgos, resumir diagnósticos, responder preguntas y comparar ejecuciones. Necesitamos una capa de orquestación en .NET que permita al modelo consultar los hallazgos guardados mediante funciones, sin costo para el equipo, sin depender de internet durante la demo y con la posibilidad de cambiar de proveedor. Las pruebas en CI no pueden depender de un modelo real.

## Decisión

- Orquestar la IA con **Microsoft Semantic Kernel** desde la capa de infraestructura.
- Usar por defecto un **modelo local con Ollama** (`qwen2.5:3b` o `llama3.2:3b`), corriendo como un contenedor más en Docker Compose.
- El backend depende de la interfaz `IChatCompletionService`; el proveedor (Ollama, Azure OpenAI u OpenAI) se elige por configuración.
- Los plugins que ve el modelo son **solo de consulta**: leen hallazgos y nunca modifican archivos ni ejecutan comandos.
- Las plantillas de prompts viven en `/prompts` y cambian por PR.
- En CI se usa un proveedor simulado.

## Alternativas consideradas

| Alternativa | Por qué no |
|:--|:--|
| Llamar directo a la API de OpenAI | Costo, dependencia de internet y acoplamiento a un proveedor |
| LangChain (Python) | Rompe el stack .NET y agrega otro servicio |
| Sin IA, solo reglas | No cumple el objetivo de IA de la asignatura y pierde la explicación en lenguaje claro |

## Consecuencias

- **Positivas:** sin costo, funciona sin conexión, proveedor intercambiable y pruebas deterministas.
- **Negativas:** los modelos de 3B son más lentos y menos precisos en laptops modestas; la imagen y el modelo ocupan varios GB.
- **Mitigación:** respuestas en streaming, modelo precargado en un volumen y opción de proveedor externo con consentimiento del usuario.
