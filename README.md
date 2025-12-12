 ASP.NET Core + Angular Full-Stack Application (In Progress)

A practical, end-to-end web application built with ASP.NET Core and Angular, following real-world full-stack best practices.
Although still a work in progress, it already provides a solid foundation for building scalable, production-ready applications.

 Overview

This project was started as part of a personal learning and professional development goal to build a full-stack application from scratch using ASP.NET Core 9.0 and Angular 20.

The goal is to create a maintainable, real-world architecture that covers both the backend API and the Angular frontend — including authentication, CRUD operations, reactive forms, file uploads, and eventually full deployment to Azure.

 Current Features
ASP.NET Core Web API setup using DotNet CLI
Angular 20 frontend setup using Angular CLI
Configured routing and base component structure
API <-> Client communication via HttpClient
Shared interfaces and services for clean architecture
Error handling for client/server responses
TailwindCSS + DaisyUI integration for modern UI styling


Planned Features
JWT-based authentication and client registration
CRUD endpoints for core entities
Reactive forms and validation
File/photo upload functionality
API resource paging, sorting, and filtering
Real-time messaging with SignalR
CI/CD pipeline and Azure deployment
SQL Server or PostgreSQL database integration


 Tech Stack
Frontend	Angular 20, TypeScript, TailwindCSS, DaisyUI
Backend	ASP.NET Core 9 Web API
Database	SQL Server (planned)
Real-time	SignalR
Deployment	Azure (planned)

 Getting Started
Clone the repository:
git clone https://github.com/FatimaIlhan/DatingApp-net9.git
Backend
cd api
dotnet restore
dotnet run
Frontend
cd client
npm install
ng serve

Project Status

This project is still under  development, but the groundwork is already in place.
It showcases key architectural decisions inspired by production-grade apps and serves as a strong base for future expansion — including authentication, UI enhancements, and Azure deployment.
Stay tuned for more updates!
