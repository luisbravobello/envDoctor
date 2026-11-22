<div align="center">

<img src="https://img.shields.io/badge/EnvDoctor-El_m%C3%A9dico_de_los_entornos-0EA5E9?style=for-the-badge&labelColor=0F172A" alt="EnvDoctor" height="40">

# EnvDoctor

**Diagnostica por qué un proyecto no compila, no inicia o se comporta distinto entre computadoras,<br>
con reglas verificables y un asistente de IA que siempre cita la evidencia.**

[![CI](https://img.shields.io/github/actions/workflow/status/luisbravobello/envDoctor/ci.yml?branch=main&style=for-the-badge&logo=githubactions&logoColor=white&label=CI)](https://github.com/luisbravobello/envDoctor/actions/workflows/ci.yml)
![Fase](https://img.shields.io/badge/Fase-0_%C2%B7_Fundaci%C3%B3n-F59E0B?style=for-the-badge)
![Producción](https://img.shields.io/badge/Producci%C3%B3n-En_proceso-EF4444?style=for-the-badge)
![Versión](https://img.shields.io/badge/Versi%C3%B3n-0.1.0-22C55E?style=for-the-badge)
![Asignatura](https://img.shields.io/badge/SCM_I-Proyecto_integral-8B5CF6?style=for-the-badge)

<br>

<a href="#stack-tecnológico">
  <img src="https://skillicons.dev/icons?i=dotnet,cs,react,ts,vite,tailwind,postgres,docker,githubactions,nginx&theme=dark" alt="Stack" />
</a>

<br><br>

[Características](#características) ·
[Arquitectura](#arquitectura) ·
[Inicio rápido](#inicio-rápido) ·
[Documentación](#documentación) ·
[Contribuir](CONTRIBUTING.md)

</div>

---

## Estado del proyecto

<div align="center">

![Fase actual](https://img.shields.io/badge/Fase_actual-0_%C2%B7_Fundaci%C3%B3n-F59E0B?style=for-the-badge&labelColor=0F172A)
![Producción](https://img.shields.io/badge/Producci%C3%B3n-En_proceso-EF4444?style=for-the-badge&labelColor=0F172A)
![Entorno](https://img.shields.io/badge/Entorno-Desarrollo-0EA5E9?style=for-the-badge&labelColor=0F172A)

| Indicador | Progreso |
|:--|:--|
| **Fase 0 · Fundación** | ![](https://img.shields.io/badge/%E2%96%88%E2%96%88%E2%96%88%E2%96%88%E2%96%88%E2%96%88%E2%96%88%E2%96%88%E2%96%88%E2%96%91-90%25-F59E0B?style=for-the-badge&labelColor=0F172A) |
| **Desarrollo total (fases 0 a 5)** | ![](https://img.shields.io/badge/%E2%96%88%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91-10%25-0EA5E9?style=for-the-badge&labelColor=0F172A) |
| **Camino a producción (v1.0.0)** | ![](https://img.shields.io/badge/%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91%E2%96%91-0%25-EF4444?style=for-the-badge&labelColor=0F172A) |

</div>

| Fase 0: entregable | Estado |
|:--|:--:|
| Repositorio con ramas `main` y `develop` | ![](https://img.shields.io/badge/Listo-22C55E?style=flat-square) |
| Esqueleto de backend (.NET) y frontend (React) | ![](https://img.shields.io/badge/Listo-22C55E?style=flat-square) |
| Docker Compose básico | ![](https://img.shields.io/badge/Listo-22C55E?style=flat-square) |
| CI mínimo en GitHub Actions | ![](https://img.shields.io/badge/Listo-22C55E?style=flat-square) |
| Protección de ramas | ![](https://img.shields.io/badge/Listo-22C55E?style=flat-square) |
| PRD | ![](https://img.shields.io/badge/En_revisi%C3%B3n-0EA5E9?style=flat-square) |
| Backlog inicial en GitHub Issues | ![](https://img.shields.io/badge/Pendiente-94A3B8?style=flat-square) |
| ADR-001 a ADR-005 | ![](https://img.shields.io/badge/En_revisi%C3%B3n-0EA5E9?style=flat-square) |

> [!NOTE]
> El repositorio contiene la estructura base, sin lógica de negocio. Proyecto integral de **Software Configuration Management I**, opción 1 (Full Stack + IA + DevOps).

## Tabla de contenidos

- [Estado del proyecto](#estado-del-proyecto)
- [Qué es EnvDoctor](#qué-es-envdoctor)
- [Características](#características)
- [Stack tecnológico](#stack-tecnológico)
- [Arquitectura](#arquitectura)
- [Estructura del repositorio](#estructura-del-repositorio)
- [Inicio rápido](#inicio-rápido)
- [Flujo de trabajo](#flujo-de-trabajo)
- [Plan por fases](#plan-por-fases)
- [Documentación](#documentación)
- [Equipo](#equipo)

## Qué es EnvDoctor

En el desarrollo de software es común que una aplicación funcione en una computadora y falle en otra: versiones de SDK distintas, paquetes, variables de entorno, contenedores o puertos ocupados. EnvDoctor convierte esa información dispersa en un **informe de salud priorizado y trazable**.

Su diferencial es combinar **reglas deterministas**, que verifican hechos concretos, con **IA**, que ayuda a interpretarlos. La herramienta no inventa errores ni ejecuta reparaciones sin autorización del usuario.

## Características

| Módulo | Qué hace |
|:--|:--|
| ![](https://img.shields.io/badge/Proyectos_y_an%C3%A1lisis-0EA5E9?style=flat-square) | Registrar un proyecto, subir el reporte del agente o un paquete del proyecto y seguir el progreso del análisis |
| ![](https://img.shields.io/badge/Agente_local_(CLI)-512BD4?style=flat-square&logo=dotnet&logoColor=white) | `dotnet tool` de solo lectura que detecta SDK, runtimes, Docker y puertos, y envía un reporte JSON con consentimiento |
| ![](https://img.shields.io/badge/Escaneo_del_proyecto-6366F1?style=flat-square) | Lectura de `.sln`, `.csproj`, `TargetFramework`, paquetes NuGet y `global.json` |
| ![](https://img.shields.io/badge/Motor_de_diagn%C3%B3stico-EF4444?style=flat-square) | Reglas versionadas de SDK, dependencias, archivos, variables, Docker Compose y puertos |
| ![](https://img.shields.io/badge/Informe_de_salud-22C55E?style=flat-square) | Hallazgos por severidad con evidencia, impacto y recomendación; filtros y marca de "no aplica" |
| ![](https://img.shields.io/badge/Asistente_IA-F59E0B?style=flat-square&logo=ollama&logoColor=white) | Chat sobre el diagnóstico que explica causas probables y cita el hallazgo que lo respalda |
| ![](https://img.shields.io/badge/Historial-64748B?style=flat-square) | Análisis anteriores y comparación de hallazgos entre dos ejecuciones |

## Stack tecnológico

| Capa | Tecnología |
|:--|:--|
| **Frontend** | ![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB) ![TypeScript](https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=typescript&logoColor=white) ![Vite](https://img.shields.io/badge/Vite-646CFF?style=for-the-badge&logo=vite&logoColor=white) ![Tailwind](https://img.shields.io/badge/Tailwind_CSS-06B6D4?style=for-the-badge&logo=tailwindcss&logoColor=white) |
| **Backend** | ![.NET](https://img.shields.io/badge/.NET_8_LTS-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white) ![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white) ![EF Core](https://img.shields.io/badge/EF_Core-68217A?style=for-the-badge&logo=nuget&logoColor=white) |
| **IA** | ![Semantic Kernel](https://img.shields.io/badge/Semantic_Kernel-0078D4?style=for-the-badge&logo=microsoft&logoColor=white) ![Ollama](https://img.shields.io/badge/Ollama-000000?style=for-the-badge&logo=ollama&logoColor=white) |
| **Datos** | ![PostgreSQL](https://img.shields.io/badge/PostgreSQL_16-4169E1?style=for-the-badge&logo=postgresql&logoColor=white) ![pgvector](https://img.shields.io/badge/pgvector_(opcional)-336791?style=for-the-badge&logo=postgresql&logoColor=white) |
| **Pruebas** | ![xUnit](https://img.shields.io/badge/xUnit-5E1F87?style=for-the-badge&logo=dotnet&logoColor=white) ![Testcontainers](https://img.shields.io/badge/Testcontainers-291A3F?style=for-the-badge&logo=testcontainers&logoColor=white) ![Vitest](https://img.shields.io/badge/Vitest-6E9F18?style=for-the-badge&logo=vitest&logoColor=white) ![Playwright](https://img.shields.io/badge/Playwright-2EAD33?style=for-the-badge&logo=playwright&logoColor=white) |
| **Calidad** | ![Roslyn](https://img.shields.io/badge/Analizadores_Roslyn-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![ESLint](https://img.shields.io/badge/ESLint-4B32C3?style=for-the-badge&logo=eslint&logoColor=white) ![Prettier](https://img.shields.io/badge/Prettier-1A2B34?style=for-the-badge&logo=prettier&logoColor=F7B93E) |
| **DevOps** | ![Docker](https://img.shields.io/badge/Docker_Compose-2496ED?style=for-the-badge&logo=docker&logoColor=white) ![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-2088FF?style=for-the-badge&logo=githubactions&logoColor=white) ![GHCR](https://img.shields.io/badge/GHCR-181717?style=for-the-badge&logo=github&logoColor=white) ![Nginx](https://img.shields.io/badge/Nginx-009639?style=for-the-badge&logo=nginx&logoColor=white) |

## Arquitectura

Cuatro servicios contenerizados más el agente que corre en la máquina del desarrollador. Solo la API habla con PostgreSQL y con Ollama.

```mermaid
flowchart LR
    U([Usuario<br/>navegador]) --> FE
    AG([Agente local<br/>dotnet tool]) -- reporte JSON --> API

    subgraph compose [Docker Compose · red envdoctor]
        FE[Frontend<br/>React + Nginx] --> API[API + Worker<br/>ASP.NET Core · EF Core<br/>Motor de reglas · Semantic Kernel]
        API --> DB[(PostgreSQL<br/>+ pgvector opcional)]
        API --> LLM[Ollama<br/>LLM local]
    end

    GH[GitHub] --> GA[GitHub Actions<br/>build · pruebas · imágenes] --> GHCR[(GHCR)]

    classDef user fill:#0F172A,stroke:#0EA5E9,color:#E0F2FE
    classDef front fill:#0EA5E9,stroke:#0369A1,color:#ffffff
    classDef api fill:#512BD4,stroke:#2E1A87,color:#ffffff
    classDef db fill:#4169E1,stroke:#1E3A8A,color:#ffffff
    classDef ai fill:#F59E0B,stroke:#B45309,color:#111827
    classDef ci fill:#22C55E,stroke:#15803D,color:#052E16
    class U,AG user
    class FE front
    class API api
    class DB db
    class LLM ai
    class GH,GA,GHCR ci
    style compose fill:#F1F5F9,stroke:#94A3B8,color:#0F172A
```

El backend sigue **Clean Architecture**: las dependencias apuntan hacia el dominio.

```mermaid
flowchart LR
    Api[EnvDoctor.Api] --> Application[EnvDoctor.Application]
    Api --> Infrastructure[EnvDoctor.Infrastructure]
    Infrastructure --> Application
    Application --> Domain[EnvDoctor.Domain]
    Agent[EnvDoctor.Agent]

    classDef domain fill:#22C55E,stroke:#15803D,color:#052E16
    classDef app fill:#0EA5E9,stroke:#0369A1,color:#ffffff
    classDef infra fill:#F59E0B,stroke:#B45309,color:#111827
    classDef host fill:#512BD4,stroke:#2E1A87,color:#ffffff
    class Domain domain
    class Application app
    class Infrastructure infra
    class Api,Agent host
```

## Estructura del repositorio

```text
envDoctor/
├── src/
│   ├── EnvDoctor.Domain/           # Entidades y reglas del dominio, sin dependencias
│   ├── EnvDoctor.Application/      # Casos de uso e interfaces
│   ├── EnvDoctor.Infrastructure/   # EF Core, PostgreSQL, Semantic Kernel, analizadores
│   ├── EnvDoctor.Api/              # ASP.NET Core Web API + worker
│   └── EnvDoctor.Agent/            # Agente local (dotnet tool)
├── tests/
│   ├── EnvDoctor.UnitTests/
│   └── EnvDoctor.IntegrationTests/
├── frontend/                       # React + Vite, servido con Nginx en Docker
├── prompts/                        # Plantillas de prompts versionadas
├── samples/                        # Proyectos de ejemplo con errores conocidos
├── docs/                           # PRD, ADR, RFC, especificación y planes
├── .github/                        # Workflows y plantillas de PR e issues
├── docker-compose.yml
└── EnvDoctor.sln
```

## Inicio rápido

### Requisitos

| Herramienta | Versión |
|:--|:--|
| ![.NET](https://img.shields.io/badge/.NET_SDK-512BD4?style=flat-square&logo=dotnet&logoColor=white) | 8.0 (ver `global.json`) |
| ![Node.js](https://img.shields.io/badge/Node.js-5FA04E?style=flat-square&logo=nodedotjs&logoColor=white) | 22 |
| ![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat-square&logo=docker&logoColor=white) | Docker Desktop o Engine con Compose |

### Opción 1: todo con Docker

```bash
git clone https://github.com/luisbravobello/envDoctor.git
cd envDoctor
cp .env.example .env
docker compose up --build
```

| Servicio | URL |
|:--|:--|
| ![](https://img.shields.io/badge/Frontend-0EA5E9?style=flat-square&logo=react&logoColor=white) | http://localhost:3000 |
| ![](https://img.shields.io/badge/API-512BD4?style=flat-square&logo=dotnet&logoColor=white) | http://localhost:8080/health |
| ![](https://img.shields.io/badge/PostgreSQL-4169E1?style=flat-square&logo=postgresql&logoColor=white) | `localhost:5432` |
| ![](https://img.shields.io/badge/Ollama-000000?style=flat-square&logo=ollama&logoColor=white) | http://localhost:11434 |

### Opción 2: desarrollo local

```bash
# Backend
dotnet build EnvDoctor.sln
dotnet test EnvDoctor.sln
dotnet run --project src/EnvDoctor.Api

# Frontend (en otra terminal)
cd frontend
npm install
npm run dev
```

> [!TIP]
> Antes de abrir un PR ejecuta `dotnet format EnvDoctor.sln` y, en `frontend/`, `npm run lint && npm run format:check`.

## Flujo de trabajo

Git Flow simplificado. Todo cambio entra por Pull Request y pasa el CI.

```mermaid
%%{init: {'theme': 'base', 'gitGraph': {'mainBranchName': 'main'}, 'themeVariables': {'git0': '#EF4444', 'git1': '#0EA5E9', 'git2': '#22C55E', 'git3': '#F59E0B', 'gitBranchLabel0': '#ffffff', 'gitBranchLabel1': '#ffffff', 'gitBranchLabel2': '#052E16', 'gitBranchLabel3': '#111827'}}}%%
gitGraph
    commit id: "base"
    branch develop
    checkout develop
    branch feature/12-registro
    commit id: "feat"
    checkout develop
    merge feature/12-registro
    branch release/0.1.0
    commit id: "fix"
    checkout main
    merge release/0.1.0 tag: "v0.1.0"
    checkout develop
    merge release/0.1.0
```

| Rama | Propósito | Regla |
|:--|:--|:--|
| ![](https://img.shields.io/badge/main-EF4444?style=flat-square&logo=git&logoColor=white) | Producción; cada merge genera una versión | Solo PR desde `release/*`, CI verde, 1 aprobación |
| ![](https://img.shields.io/badge/develop-0EA5E9?style=flat-square&logo=git&logoColor=white) | Integración del sprint | Solo PR desde `feature/*`, CI verde, 1 aprobación |
| ![](https://img.shields.io/badge/feature%2F*-22C55E?style=flat-square&logo=git&logoColor=white) | Una historia de usuario | Nace de `develop` |
| ![](https://img.shields.io/badge/release%2F*-F59E0B?style=flat-square&logo=git&logoColor=white) | Estabilizar la entrega | Se fusiona en `main` y `develop` |

**Convenciones:** [Conventional Commits](https://www.conventionalcommits.org/es/) (`feat:`, `fix:`, `docs:`), versiones [SemVer](https://semver.org/lang/es/) con tags `vX.Y.Z`. Detalles en [CONTRIBUTING.md](CONTRIBUTING.md).

## Plan por fases

| Fase | Meta | Estado |
|:--:|:--|:--:|
| 0 | Fundación: repo, ramas, esqueleto, Compose y CI mínimo | ![](https://img.shields.io/badge/En_curso-F59E0B?style=flat-square) |
| 1 | Escaneo básico de proyectos .NET | ![](https://img.shields.io/badge/Pendiente-94A3B8?style=flat-square) |
| 2 | Diagnóstico: agente local y motor de reglas | ![](https://img.shields.io/badge/Pendiente-94A3B8?style=flat-square) |
| 3 | Interfaz, historial e imágenes en GHCR | ![](https://img.shields.io/badge/Pendiente-94A3B8?style=flat-square) |
| 4 | Asistente IA con Semantic Kernel y Ollama | ![](https://img.shields.io/badge/Pendiente-94A3B8?style=flat-square) |
| 5 | Calidad, CD completo y release `v1.0.0` | ![](https://img.shields.io/badge/Pendiente-94A3B8?style=flat-square) |

## Documentación

Toda la documentación vive en [`/docs`](docs/README.md), versionada junto al código.

| Producto | Técnica | Procesos |
|:--|:--|:--|
| [PRD](docs/01-prd.md) | [Especificación técnica](docs/05-especificacion-tecnica.md) | [Plan de pruebas](docs/08-plan-pruebas.md) |
| [Historias de usuario](docs/02-historias.md) | [Diseño de base de datos](docs/06-base-de-datos.md) | [Plan de implementación](docs/09-plan-implementacion.md) |
| [Reglas de negocio](docs/03-reglas-negocio.md) | [Catálogo de reglas](docs/04-catalogo-reglas.md) | [ADR](docs/adr/README.md) |
| [Guía UI/UX](docs/07-guia-ui-ux.md) | | [RFC](docs/rfc/0000-plantilla.md) |

## Equipo

| Integrante | Rol | Responsabilidades |
|:--|:--|:--|
| **Luis Bravo** | ![](https://img.shields.io/badge/Backend-512BD4?style=flat-square&logo=dotnet&logoColor=white) | API, dominio, motor de reglas, agente local, base de datos |
| **Jeifferson** | ![](https://img.shields.io/badge/Frontend_y_UX-0EA5E9?style=flat-square&logo=react&logoColor=white) | Interfaz React, informe, historial y pantalla del asistente |
| **Ronald** | ![](https://img.shields.io/badge/IA_·_DevOps_·_QA-F59E0B?style=flat-square&logo=githubactions&logoColor=white) | Semantic Kernel, Ollama, Docker, GitHub Actions, pruebas · Scrum Master |

---

<div align="center">

![Hecho con .NET](https://img.shields.io/badge/Hecho_con-.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SCM I](https://img.shields.io/badge/Software_Configuration_Management-I-0F172A?style=for-the-badge)

</div>
