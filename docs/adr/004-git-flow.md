# ADR-004: Git Flow simplificado como estrategia de ramas

- **Estado:** Propuesto
- **Fecha:** 2026-11-22
- **Responsable:** Ronald

## Contexto

Somos tres integrantes trabajando en paralelo durante sprints de una semana. La asignatura evalúa gestión de configuración: necesitamos trazabilidad de cada cambio, versiones identificables al cierre de cada sprint y que nada llegue a producción sin pasar el pipeline y una revisión.

## Decisión

Usar **Git Flow simplificado**:

| Rama | Propósito | Regla |
|:--|:--|:--|
| `main` | Código en producción; cada merge genera una versión | Protegida: solo PR desde `release/*`, CI verde, 1 aprobación |
| `develop` | Integración continua del sprint | Protegida: solo PR desde `feature/*`, CI verde, 1 aprobación |
| `feature/<id>-<nombre>` | Una historia de usuario | Nace de `develop`, vive pocos días |
| `release/<versión>` | Estabilizar la entrega al cierre del sprint | Solo correcciones; se fusiona en `main` y `develop` |

Convenciones: **Conventional Commits**, versiones **SemVer** con tags `vX.Y.Z`, plantilla de PR con checklist y cada PR enlazado a su issue. El conjunto de reglas de diagnóstico lleva su propia versión (`RulesVersion`).

## Alternativas consideradas

| Alternativa | Por qué no |
|:--|:--|
| Git Flow completo (con `hotfix/*`) | Más ramas de las que necesita un equipo de tres en seis semanas |
| GitHub Flow (solo `main` + ramas) | No deja un punto claro de estabilización por sprint |
| Trunk-based development | Requiere feature flags y madurez de pruebas que aún no tenemos |

## Consecuencias

- **Positivas:** historial trazable, releases por sprint, revisión cruzada obligatoria.
- **Negativas:** más PR y merges que con un flujo más simple.
- **Pendiente:** automatizar notas de versión en el GitHub Release desde el pipeline de CD.
