# Cloud Native .NET App

## Features
- Stateless API
- Dockerized
- Kubernetes Deployment + Service
- ConfigMap for externalized configuration

## CI/CD Pipeline (GitHub Actions)

This project uses **GitHub Actions** for continuous integration.

### Pipeline Capabilities
- Triggers on every push to `main`
- Builds Docker images for each microservice independently
- Supports monorepo structure with multiple .NET services

### Services Built
- `CloudNativeApp`
- `GreetingService`

### Key Design
Each microservice has:
- Its own Dockerfile
- Its own build context
- Is built independently to avoid monorepo conflicts

This ensures scalable CI/CD as more services are added.

