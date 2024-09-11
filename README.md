# CQRS Project with DDD and MediatR

## Overview

This project demonstrates a clean architecture using Domain-Driven Design (DDD) and Command Query Responsibility Segregation (CQRS) with the MediatR library. The project is structured into multiple class libraries to ensure separation of concerns and to adhere to best practices in building scalable and maintainable systems.

## Project Structure

### 1. **API Project**

- **Purpose**: Contains the HTTP controllers that handle incoming requests and route them to the appropriate commands or queries.
- **Dependencies**: 
  - MediatR

### 2. **Manager Class Library**

- **Purpose**: Implements the business logic, including command and query handlers. This is where MediatR is used to manage the handling of commands and queries.
- **Dependencies**: 
  - MediatR

### 3. **Entity and Repository Class Library**

- **Purpose**: Contains domain entities and repository interfaces. This library focuses on the domain model and data access layer.
- **Dependencies**: No direct dependency on MediatR.

## Getting Started

### Prerequisites

- .NET SDK (version compatible with this project)
- NuGet packages for MediatR and its dependencies

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/your-repo.git
   cd your-repo
