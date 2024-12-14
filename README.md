#  Application MVC - Gestion des Enseignants, Étudiants et Événements

Bienvenue dans cette application **MVC** conçue pour gérer des enseignants, des étudiants et des événements. Ce projet repose sur le framework **ASP.NET Core MVC** avec une base de données MySQL.

---

##  Fonctionnalités

### Gestion des enseignants
- **Ajouter un enseignant** : Créez un nouvel enseignant en fournissant son prénom, nom, email et site web.
- **Modifier un enseignant** : Mettez à jour les informations d’un enseignant existant.
- **Supprimer un enseignant** : Supprimez un enseignant après confirmation.
- **Consulter les détails d’un enseignant** : Consultez les informations détaillées d’un enseignant.
- **Lister les enseignants** : Affichez tous les enseignants disponibles dans l'application.

---

### Gestion des étudiants
- **Ajouter un étudiant** : Créez un nouvel étudiant avec des détails comme le prénom, le nom, l'âge, la spécialité et la date d'admission.
- **Modifier un étudiant** : Mettez à jour les informations d’un étudiant existant.
- **Supprimer un étudiant** : Supprimez un étudiant après confirmation.
- **Consulter les détails d’un étudiant** : Consultez les informations détaillées d’un étudiant.
- **Lister les étudiants** : Affichez tous les étudiants enregistrés.

---

### Gestion des événements
- **Créer un événement** : Organisez un événement en définissant un titre, une description, une date, un lieu, et un nombre maximum de participants.
- **Modifier un événement** : Mettez à jour les informations d’un événement existant.
- **Supprimer un événement** : Supprimez un événement après confirmation.
- **Consulter les détails d’un événement** : Consultez les informations détaillées d’un événement.
- **Lister les événements** : Affichez tous les événements enregistrés.

---

### Authentification et sécurité
- **Connexion** : Permet aux utilisateurs de se connecter à l’application via un formulaire dédié.

---

### Pages générales et navigation
- **Page d'accueil** : Une vue d'ensemble de l'application avec des liens pour naviguer vers les différentes sections.
- **Navigation globale** : Une barre de navigation accessible sur toutes les pages.

---

## Guide pour démarrer le projet

### Prérequis
1. Installez le **.NET SDK 8.0**: [Télécharger .NET](https://dotnet.microsoft.com/download/dotnet).
2. Installez **MySQL** via XAMPP ou un autre serveur MySQL.
3. Configurez votre base de données dans `appsettings.json` :
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=nom_de_votre_bd;Uid=root;Pwd=;"
   }

---

## Étapes pour exécuter le projet
Restaurez les dépendances :
1. Ouvrez un terminal dans le répertoire racine du projet et exécutez :
```bash
    dotnet restore
```   
2. Appliquez les migrations pour créer la base de données :
```bash
    dotnet ef database update
```
3. Démarrez l'application :
```bash
    dotnet run
```
## Dépannage

- Si `dotnet ef` ne fonctionne pas, installez-le avec :
```bash
dotnet tool install --global dotnet-ef
```
- Si vous avez plusieurs fichiers `.csproj` dans le dossier, précisez le fichier cible :
```bash
dotnet ef database update --project mvc.csproj
```