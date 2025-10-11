[![Build and Test](https://github.com/Toenn-Vaot/toennvaotsystem/actions/workflows/dotnet-build-test.yml/badge.svg)](https://github.com/Toenn-Vaot/toennvaotsystem/actions/workflows/dotnet-build-test.yml)
[![Release to NuGet](https://github.com/Toenn-Vaot/toennvaotsystem/actions/workflows/release-to-nuget.yml/badge.svg)](https://github.com/Toenn-Vaot/toennvaotsystem/actions/workflows/release-to-nuget.yml)

# TOENN VAOT System

## ToennVaot.Components.Core
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core)


```
dotnet add package ToennVaot.Components.Core --version 1.1.0
```
Composant de base de l’écosystème **ToennVaot**.  
Il fournit les briques communes : gestionnaires (Manager/Store), constantes, attributs de sécurité, gestion d’événements, sérialisation personnalisée, et utilitaires de globalisation.  
C’est la fondation sur laquelle s’appuient les autres projets.

---

## ToennVaot.Components.Core.Api
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Api)

```
dotnet add package ToennVaot.Components.Core.Api --version 1.1.0
```
Couche d’infrastructure pour bâtir des **APIs REST**.  
Elle centralise la configuration ASP.NET Core (CORS, compression, HTTPS, fichiers statiques), ajoute des filtres (cache, journalisation, liens HAL), intègre Swagger/OpenAPI (documentation, versioning, polymorphisme) et fournit des helpers de sécurité (attributs d’autorisation, validation des droits).  
À utiliser comme point d’entrée pour exposer des services web robustes et documentés.

---

## ToennVaot.Components.Core.Api.Exceptions
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Api.Exceptions)

```
dotnet add package ToennVaot.Components.Core.Api.Exceptions --version 1.1.0
```
Module regroupant les **exceptions spécifiques aux APIs**.  
Il étend les exceptions génériques du noyau pour gérer les cas propres aux endpoints REST (droits insuffisants, codes d’erreur API).

---

## ToennVaot.Components.Core.Api.Extensions
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Api.Extensions)

```
dotnet add package ToennVaot.Components.Core.Api.Extensions --version 1.1.0
```
Bibliothèque d’**extensions réutilisables** dans la couche API.  
Elle facilite la manipulation des représentations HAL, des réponses HTTP et des identités utilisateur (Claims).  
Permet d’ajouter automatiquement des liens de navigation, d’analyser les réponses HTTP et d’extraire les informations de sécurité d’un utilisateur connecté.

---

## ToennVaot.Components.Core.Api.Interfaces
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Api.Interfaces)

```
dotnet add package ToennVaot.Components.CoreApi.Interfaces --version 1.1.0
```
Espace réservé pour les **contrats de la couche API**.  
Prévu pour accueillir les interfaces des services exposés.

---

## ToennVaot.Components.Core.Api.Models
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Api.Models)

```
dotnet add package ToennVaot.Components.Core.Api.Models --version 1.1.0
```
Contient les **modèles partagés des APIs** :  
- Modèles d’erreurs et de réponses standardisées (`ErrorModel`, `BadRequestModel`).  
- Objets HAL (`Representation`, `Link`) pour supporter l’hypermedia.  
C’est la grammaire commune des échanges entre serveur et clients.

---

## ToennVaot.Components.Core.Exceptions
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Exceptions)

```
dotnet add package ToennVaot.Components.Core.Exceptions --version 1.1.0
```
Bibliothèque centralisée des **exceptions métier et techniques**.  
Elle couvre les cas CRUD (non-existence, duplication, interdictions de modification ou suppression), les erreurs d’état, de validation ou de droits.  
Permet d’uniformiser la gestion des erreurs dans tout l’écosystème.

---

## ToennVaot.Components.Core.Extensions
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Extensions)

```
dotnet add package ToennVaot.Components.Core.Extensions --version 1.1.0
```
Ensemble d’**extensions utilitaires** pour .NET : manipulation de `DateTime`, énumérations, collections asynchrones, gestion du genre (masculin/féminin/autre).  
Facilite le code applicatif quotidien.

---

## ToennVaot.Components.Core.Interfaces
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Interfaces)

```
dotnet add package ToennVaot.Components.Core.Interfaces --version 1.1.0
```
Définit les **interfaces génériques** pour les Managers et Stores.  
Ce contrat standardise les opérations métier et les accès aux données (lecture, écriture, transactions), permettant une implémentation interchangeable (SQL, NoSQL, etc.).

---

## ToennVaot.Components.Core.Models
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Models)

```
dotnet add package ToennVaot.Components.Core.Models --version 1.1.0
```
Contient les **objets métier communs** :  
- Résultats des opérations (`ManagerRequestResult`, `StoreRequestResult`).  
- Entités de base (`Address`, `ApplicationUser`).  
- Enums (genre, direction de tri, événements religieux).  
- Globalisation (pays, langues).  
Ces modèles servent de socle aux fonctionnalités fonctionnelles et métiers.

---

## ToennVaot.Components.Core.Models.Interfaces
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Models.Interfaces)

```
dotnet add package ToennVaot.Components.Core.Models.Interfaces --version 1.1.0
```
Interfaces pour les **entités métiers** : audit, suppression logique, gestion d’état.  
Elles garantissent une cohérence sur tous les enregistrements manipulés par le système.

---

## ToennVaot.Components.Core.Security
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Security)

```
dotnet add package ToennVaot.Components.Core.Security --version 1.1.0
```
Composant de **gestion des droits et permissions**.  
Il définit les types d’authentification (application vs utilisateur), les permissions disponibles, leur sérialisation et un gestionnaire de sécurité capable de vérifier les droits dans les claims utilisateur.  
C’est le cœur du contrôle d’accès dans l’écosystème.

---

## ToennVaot.Components.Core.Web
![NuGet Version](https://img.shields.io/nuget/v/ToennVaot.Components.Core.Web)

```
dotnet add package ToennVaot.Components.Core.Web --version 1.1.0
```
Composant de **gestion des droits et permissions pour les applications web**.  
Il définit l’authentification, les permissions et le contrôle d’accès dans l’écosystème.
Il met à disposition des action results spécifiques (fichiers, téléchargements, PDF) et des helpers pour les réponses HTTP.

---
