# EnvDoctor

**El médico de los entornos de desarrollo.** EnvDoctor diagnostica por qué un proyecto no compila, no inicia o se comporta distinto entre computadoras. Revisa SDK, dependencias, archivos de configuración, Docker y puertos con reglas verificables, y un asistente de IA (Microsoft Semantic Kernel + Ollama) explica los hallazgos citando siempre la evidencia.

Proyecto integral de **Software Configuration Management I**, opción 1 (Full Stack + IA + DevOps).

> Estado: Sprint 0 (Fundación). El repositorio contiene solo la estructura base, sin lógica de negocio.

## Equipo

| Integrante | Rol |
|------------|-----|
| Luis Bravo | Backend, motor de diagnóstico y base de datos |
| Jeifferson | Frontend y UX |
| Ronald | IA, DevOps y QA (Scrum Master) |

## Stack

| Capa | Tecnología |
|------|------------|
| Frontend | React + TypeScript + Vite |
| Backend | ASP.NET Core Web API (.NET 8 LTS), Entity Framework Core |
| Agente local | .NET global tool (consola C#) |
| IA | Microsoft Semantic Kernel + Ollama (modelo local) |
| Base de datos | PostgreSQL (pgvector opcional en la misma instancia) |
| Pruebas | xUnit, Testcontainers, Vitest, Playwright |
| Contenedores | Docker, Docker Compose |
| CI/CD | GitHub Actions, GitHub Container Registry |

## Estructura

```
EnvDoctor.sln
src/
  EnvDoctor.Domain/          Entidades y reglas del dominio (sin dependencias)
  EnvDoctor.Application/     Casos de uso e interfaces
  EnvDoctor.Infrastructure/  EF Core, PostgreSQL, Semantic Kernel, analizadores
  EnvDoctor.Api/             ASP.NET Core Web API + worker
  EnvDoctor.Agent/           Agente local (dotnet tool)
tests/
  EnvDoctor.UnitTests/
  EnvDoctor.IntegrationTests/
frontend/                    React + Vite, servido con Nginx en Docker
prompts/                     Plantillas de prompts versionadas
samples/                     Proyectos de ejemplo con errores conocidos
docs/                        PRD, ADR, RFC, especificación y planes
.github/                     Plantillas de PR e issues, workflows
```

Las dependencias apuntan hacia el dominio: `Api → Application / Infrastructure`, `Infrastructure → Application → Domain`.

## Requisitos

- .NET SDK 8.0 (ver `global.json`)
- Node.js 22
- Docker Desktop o Docker Engine con Compose

## Cómo levantarlo

```bash
# Backend
dotnet build EnvDoctor.sln
dotnet test EnvDoctor.sln
dotnet run --project src/EnvDoctor.Api        # http://localhost:5xxx/health

# Frontend
cd frontend
npm install
npm run dev

# Todo junto con Docker
cp .env.example .env
docker compose up --build
```

Con Compose: frontend en http://localhost:3000, API en http://localhost:8080/health, PostgreSQL en el puerto 5432 y Ollama en el 11434.

## Flujo de trabajo

Ver [CONTRIBUTING.md](CONTRIBUTING.md): Git Flow simplificado (`main`, `develop`, `feature/*`, `release/*`), Conventional Commits y SemVer.

## Documentación

Toda la documentación vive en [`/docs`](docs/README.md).
