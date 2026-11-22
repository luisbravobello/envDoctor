# Cómo contribuir

## Ramas (Git Flow simplificado)

| Rama | Propósito | Regla |
|------|-----------|-------|
| `main` | Código en producción; cada merge genera una versión | Protegida: solo PR desde `release/*`, CI verde, 1 aprobación |
| `develop` | Integración continua del sprint | Protegida: solo PR desde `feature/*`, CI verde, 1 aprobación |
| `feature/<id>-<nombre>` | Una historia de usuario | Nace de `develop`, vive pocos días |
| `release/<versión>` | Estabilizar la entrega al cierre del sprint | Solo correcciones; se fusiona en `main` y `develop` |

Ejemplo:

```bash
git switch develop && git pull
git switch -c feature/12-registro-proyectos
# ... cambios ...
git commit -m "feat(api): registrar proyectos"
git push -u origin feature/12-registro-proyectos
# Abrir PR hacia develop enlazando el issue #12
```

## Commits

[Conventional Commits](https://www.conventionalcommits.org/es/): `feat:`, `fix:`, `docs:`, `refactor:`, `test:`, `ci:`, `chore:`. Se puede indicar el ámbito: `feat(agent): ...`.

## Versiones

SemVer con tags `vX.Y.Z`. El conjunto de reglas de diagnóstico tiene su propia versión (`RulesVersion`), registrada en cada análisis.

## Pull Requests

- Todo cambio entra por PR y usa la plantilla.
- Cada PR enlaza su issue y necesita 1 aprobación de otro integrante.
- El CI debe estar en verde.

## Antes de abrir el PR

```bash
dotnet format EnvDoctor.sln
dotnet build EnvDoctor.sln
dotnet test EnvDoctor.sln
cd frontend && npm run lint && npm run format:check && npm run build
```

## Definición de hecho

Código revisado, pruebas en verde, cobertura de al menos 70 % en la capa de aplicación y documentación actualizada.

## Secretos

Nunca se suben `.env`, claves ni certificados. En local se usa `dotnet user-secrets`; en CI, GitHub Secrets.
