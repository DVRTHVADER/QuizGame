# QuizGame Backend **

## Description
QuizGame est une application de quiz développée en **ASP.NET Core Web API**.  
Ce projet constitue la partie backend du jeu et gère la logique métier, la base de données, ainsi que la communication en temps réel avec les clients via **SignalR**.  

Le but est de fournir une API REST stable et extensible permettant de gérer les joueurs, les questions, les scores et la validation des réponses en temps réel.

---

## Architecture du projet
La solution est organisée selon une architecture en trois couches :

- **QuizGame.API**  
  Contient les contrôleurs, la configuration Swagger, SignalR et les middlewares.  
  Sert de point d’entrée à l’application.

- **QuizGame.Core**  
  Contient la logique métier, les entités, les interfaces et les services métier.  
  C’est la couche indépendante des technologies externes.

- **QuizGame.Infrastructure**  
  Implémente la persistance des données via **Entity Framework Core** et gère l’accès à la base de données.

---

## Technologies utilisées
- **.NET 9 / ASP.NET Core Web API**
- **Entity Framework Core**
- **SignalR** (communication temps réel)
- **Swagger / OpenAPI**
- **SQL Server ou SQLite (en développement)**
- **Serilog** (logging)

---

## Configuration initiale
Avant de lancer l’application :

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/<votre-utilisateur>/QuizGame.git
   cd QuizGame
