## Architecture

- CloudNativeApp (API Gateway)
- GreetingService (Internal microservice)
- Kubernetes Service for internal DNS
- ConfigMaps for externalized configuration

## Technologies Used
- .NET 9
- Docker
- Kubernetes
- ConfigMaps
- ClusterIP Services

## Kubernetes Features Demonstrated

- Pod recreation and self-healing via Deployments
- Horizontal scaling with multiple replicas
- Internal service discovery using Kubernetes DNS
- Load balancing across pods using ClusterIP Services
- Externalized configuration using ConfigMaps
- Zero-downtime rolling updates

## Architecture

Browser → CloudNativeApp → GreetingService
