# ProcurementSolution

A modular, .NET-based backend solution for managing procurement / ordering workflows.

## Overview

`ProcurementSolution` aims to provide a structured, maintainable architecture for procurement-related operations: order processing, domain logic, event handling, notification APIs, and more.  
The solution is implemented in C# and organized into multiple projects to separate concerns (domain, APIs, events, notifications, etc.).  

## Architecture & Project Layout

The solution consists of the following projects:

| Project / Folder | Responsibility |
|------------------|----------------|
| `Procurement.Domain` | Core domain entities and business logic for procurement. |
| `Procurement.Events` | Event definitions / event-driven logic related to procurement processes. |
| `Procurement.Notifications.Api` | API service for sending notifications (e.g. order status, alerts, updates). |
| `Procurement.Orders.Api` | API service for handling orders: creation, retrieval, updates, order-related operations. |
| `ProcurementSolution.AppHost` | Host / entry point to wire up services, dependency injection, configuration, startup logic. |
| `ProcurementSolution.ServiceDefaults` | Default/shared service settings / configuration across the application. |
| `TestAppHost` | A test host / sandbox for testing or quick prototyping. |

This separation helps isolate concerns, simplifies testing and maintenance, and supports scalability/extension in the future.

## Features (Planned / Implemented)

- Clean domain-driven design for procurement logic  
- API endpoints for orders management  
- Notification system via separate API to decouple concerns  
- Event-driven architecture (through `Procurement.Events`) — enabling asynchronous workflows, audit logs or integration with messaging/bus systems  
- Configurable service defaults, making it easier to set up in different environments (development, staging, production)  
- Modular structure enabling incremental extension (e.g. adding partners, suppliers, approval workflows, etc.)  

## Getting Started

### Prerequisites

- .NET SDK (version X.Y or later)  
- A supported runtime (Windows / Linux / macOS)  
- (Optional) API client / HTTP tool such as Postman or curl for testing the APIs.

### Setup

1. Clone the repository  
   ```bash
   git clone https://github.com/vst121/ProcurementSolution.git
   cd ProcurementSolution
