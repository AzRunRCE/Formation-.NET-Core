### 1. Vidéo Introduction • .NET

**Question :**
Si un problème survient lors de la création d'une commande en production, 
quelles étapes devrions-nous suivre pour résoudre le problème et déployer un correctif ? 
Nous avons deux branches à notre disposition : 
la branche « dev » correspond aux développements en cours
et la branche « production » corresponds au miroir de la production.

**Créer une branche hotFixes/creationCommande depuis la production**
Créer une branche hotFixes/creationCommande depuis le développement 
**Modifier le code sur la branche hotFixes/creationCommande**
**Fusionner la branche hotFixes/creationCommande dans le développement**
**Fusionner la branche hotFixes/creationCommande en production**
**Déployer le correctif**



Quelles sont les différences entre .NET Framework et .NET ?
**-.NET est un framework open-source et multiplateforme, tandis que .NET Framework est limité à Windows et n'est pas open-source.**
-.NET est uniquement destiné aux applications de bureau traditionnelles, tandis que .NET Framework est destiné aux applications modernes et basées sur le cloud.
-.NET Framework est un framework open-source et multiplateforme, tandis que .NET est limité à Windows et n'est pas open-source.
-.NET et .NET Framework sont identiques en termes de fonctionnalités et de portée, mais diffèrent uniquement par leur nom.


Quelle est la principale différence dans la gestion des injections de dépendances entre ASP.NET Framework et ASP.NET Core ?
ASP.NET Framework utilise un conteneur d'injection de dépendances intégré, tandis qu'ASP.NET Core nécessite des bibliothèques tierces pour l'injection de dépendances.
**ASP.NET Core utilise un conteneur d'injection de dépendances intégré, tandis qu'ASP.NET Framework nécessite généralement des bibliothèques tierces comme Unity ou Autofac pour gérer l'injection de dépendances.**
ASP.NET Framework et ASP.NET Core utilisent tous deux des conteneurs d'injection de dépendances intégrés de la même manière.
ASP.NET Core ne prend pas en charge l'injection de dépendances, tandis qu'ASP.NET Framework en fait usage intensif.


Quels frameworks sont compatibles avec Linux ou Android ?
- **.NET Core**
- **Mono**
- **Xamarin**
- .NET Framework

**Question :**
Parmi ces libraries quels sont celles qui sont des ORM (Object-Relational-Database) ?
- **Entity Framework Core**
- **NHibernate**
- **Dapper**
- Datadog

**Question :**
Quels sont les langages que Microsoft propose sur la plateforme NET ?
- **C#**
- **VB.NET**
- **F#**
- Python

### 2. Les bases du C#

**Question :**
Quelles sont les deux implémentations possibles d'une propriété en C# ?
- **Auto-implémentée**
- **Avec attribut privé**
- Avec méthode publique
- Avec méthode protégée

**Question :**
Le constructeur est-il obligatoire en C# ?
- **Non**
- Oui, toujours
- Seulement pour les classes abstraites

**Question :**
De quoi une classe peut-elle hériter ?
- **a) Une interface**
- b) Une structure
- **c) Une classe abstraite**

**Question :**
Quelle fonctionnalité permet d'utiliser les méthodes Add ou Remove ?
- **List**
- Array
- Queue

**Question :**
Que donne le code ci-dessous ?

var variable = 10;   
variable = "Hello"; 
Console.WriteLine(variable);

-Le code compile et affiche "10".
-Le code compile et affiche "Hello".
-**Le code provoque une erreur de compilation.**
-Le code compile et affiche "System.Object".

**Question :**
Quelles sont les conditions pour créer une extension d'un type existant ?
- **La méthode doit être dans une classe "static"**
- La classe doit s'appeler "Extension"
- **La méthode doit être "static"**
- **Le premier paramètre doit avoir le mot-clé "this"**

### 3. Conversions de type de données

**Question :**
Laquelle de ces formulations permet de caster le véhicule "jeep" en "voiture" ?
- **a) (Voiture) jeep**
- b) jeep as vvoiture
- c) Convert.ToVoiture(jeep)

### 4. Les délégués

**Question :**
Un délégué est-il réassignable ?
- **Oui**
- Non, jamais

### 5. Création d'une Exception

**Question :**
Montrer plusieurs classes d'Exceptions et demander laquelle est valide.
- **public class MyException : Exception**
- public class MyException : Application
- public class MyException : Error

### 6. LINQ

**Question :**
Quelles sont les deux méthodes possibles pour travailler avec LINQ ?
- **Requête**
- **Méthodes**
- SQL
- Appel de données

**Question :**
À quoi sert "Distinct" ?
- **Récupérer les éléments non dupliqués**
- Récupérer les éléments non flottants
- Récupérer les éléments un par un

**Question :**
Montrer différents "Select" et demander lequel permet de renvoyer un tableau avec l'âge des personnes.
- **people.Select(p => p.Age).ToArray()**
- people.Select(p => new { p.Age })
- people.Select(p => p.Name)

### 7. Applications Multi-couches

**Question :**
Quelles sont les trois couches habituelles d'une application ?
- **Contrôleurs**
- **Services**
- **Modèles**
- Vues

**Question :**
Peut-on avoir différents contrôleurs pour un même Service/Modèle ?
- **Oui**
- Non