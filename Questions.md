## 1. Vidéo Introduction .NET

### Question 1 :
Si un problème survient lors de la création d'une commande en production, 
quelles étapes devrions-nous suivre pour résoudre le problème et déployer un correctif ? 
Nous avons deux branches à notre disposition : 
la branche « dev » correspond aux développements en cours
et la branche « production » corresponds au miroir de la production.

- **Créer une branche hotFixes/creationCommande depuis la branche production**
- Créer une branche hotFixes/creationCommande depuis la branche dev 
- **Modifier le code sur la branche hotFixes/creationCommande**
- **Fusionner la branche hotFixes/creationCommande dans la branche dev**
- **Fusionner la branche hotFixes/creationCommande dans la branche production**
- **Déployer le correctif**

### Question 2 : 
Quelles sont les différences entre .NET Framework et .NET ?
- **.NET est un framework open-source et multiplateforme, tandis que .NET Framework est limité à Windows et n'est pas open-source.**
- .NET est uniquement destiné aux applications de bureau traditionnelles, tandis que .NET Framework est destiné aux applications modernes et basées sur le cloud.
- .NET Framework est un framework open-source et multiplateforme, tandis que .NET est limité à Windows et n'est pas open-source.
- .NET et .NET Framework sont identiques en termes de fonctionnalités et de portée, mais diffèrent uniquement par leur nom.

### Question 3 :
Quelle est la principale différence dans la gestion des injections de dépendances entre ASP.NET Framework et ASP.NET Core ?
- ASP.NET Framework utilise un conteneur d'injection de dépendances intégré, tandis qu'ASP.NET Core nécessite des bibliothèques tierces pour l'injection de dépendances.
- **ASP.NET Core utilise un conteneur d'injection de dépendances intégré, tandis qu'ASP.NET Framework nécessite généralement des bibliothèques tierces comme Unity ou Autofac pour gérer l'injection de dépendances.**
- ASP.NET Framework et ASP.NET Core utilisent tous deux des conteneurs d'injection de dépendances intégrés de la même manière.
- ASP.NET Core ne prend pas en charge l'injection de dépendances, tandis qu'ASP.NET Framework en fait usage intensif.


### Question 4 :
Quels frameworks sont compatibles avec Linux ou Android ?
- **.NET Core**
- **Mono**
- **Xamarin**
- .NET Framework

### Question 5 :
Parmi ces libraries quels sont celles qui sont des ORM (Object-Relational-Database) ?
- **Entity Framework Core**
- **NHibernate**
- **Dapper**
- Datadog

### Question 6 :
Quels sont les langages que Microsoft propose sur la plateforme NET ?
- **C#**
- **VB.NET**
- **F#**
- Python

## 2. Les bases du C#

### Question 1 :
Quelles sont les deux implémentations possibles d'une propriété en C# ?
- **Auto-implémentée**
- **Avec attribut privé**
- Avec méthode publique
- Avec méthode protégée

### Question 2 :
Le constructeur est-il obligatoire en C# ?
- **Non**
- Oui, toujours
- Seulement pour les classes abstraites

### Question 3 :
De quoi une classe peut-elle hériter ?
- **Une interface**
- Une structure
- **Une classe abstraite**

### Question 4 :
Quelle fonctionnalité permet d'utiliser les méthodes Add ou Remove ?
- **List**
- Array
- Queue

### Question 5 :
Que donne le code ci-dessous ?

``` C#
var variable = 10;   
variable = "Hello"; 
Console.WriteLine(variable);
```

- Le code compile et affiche "10".
- Le code compile et affiche "Hello".
- **Le code provoque une erreur de compilation.**
- Le code compile et affiche "System.Object".

### Question 6 :
Quelles sont les conditions pour créer une extension d'un type existant ?
- **La méthode doit être dans une classe "static"**
- La classe doit s'appeler "Extension"
- **La méthode doit être "static"**
- **Le premier paramètre doit avoir le mot-clé "this"**

### Question 7 :

Parmis ces deux implémentations, laquelle est la plus robuste : 

- **Proposition 1 :** 
```C#
interface CapableDeVoler
{
   void Vole();
}

abstract class Avion : CapableDeVoler
{
    public abstract void Vole();
}

abstract class Oiseau : CapableDeVoler
{
    public abstract void Vole();
}
```

- Proposition 2 :
```C#
abstract class Avion
{
 public abstract void Vole();
}

abstract class Oiseau : Avion
{

}
```
### Question 8 :
Quelle est la valeur de voiture1.Moteur à la fin de la fonction "Main" ? 
```C#
Voiture FabriquerVoiture(Voiture voitureAFabriquer)
{
    voitureAFabriquer.Moteur = "HDi";
    return voitureAFabriquer;
}

void Main(string[] args)
{
    var voiture1 = new Voiture();
    var Voiture2 = FabriquerVoiture(voiture1);
    Console.WriteLine(voiture1.Moteur);
}

```
- **"HDi"**
- null
- string.Empty
- Une exception est levée

## 3. Conversions de type de données

### Question 1 :
Quelle est la différence entre une conversion implicite et explicite ?
- **Une conversion implicite est automatique et sans perte de données ; une conversion explicite nécessite un casting et peut perdre des données.**
- Une conversion implicite est toujours plus rapide que la conversion explicite.
- Une conversion implicite ne fonctionne que pour les types de valeur ; une conversion explicite fonctionne pour tous les types.
- Une conversion explicite est automatique ; une conversion implicite nécessite un casting.

### Question 1 :
Laquelle de ces formulations permet de caster le véhicule "jeep" en "voiture" ?
- **(Voiture) jeep**
- jeep as vvoiture
- Convert.ToVoiture(jeep)

### Question 2 :
Est-ce qu'il est possible de créer une conversion implicite pour un type personnalisé ?
- **Oui, en définissant un opérateur de conversion implicite dans le type personnalisé.**
- Non, seules les conversions explicites sont possibles pour les types personnalisés.
- Oui, mais seulement vers les types primitifs comme `int` et `double`.
- Non, les conversions implicites sont réservées aux types de base uniquement.

## 4. Les délégués

### Question 1 :
Un délégué est-il réassignable ?
- **Oui**
- Non, jamais

### Question 2 :
Si j'ajoute plusieurs méthodes à un même délégué, que se passe-t-il ?
- **Toutes les méthodes sont appelées dans l'ordre où elles ont été ajoutées.**
- Seule la dernière méthode ajoutée est appelée lorsque le délégué est invoqué.
- Une exception est levée si plusieurs méthodes sont ajoutées au délégué.
- Les méthodes sont ajoutées mais ne seront pas appelées lorsque le délégué est invoqué.

### Question 3 :
Combien de paramètres peut avoir un délégué personnalisé ?
- **Aucun nombre fixe**
- Jusqu'à 10 paramètres maximum.
- Uniquement 1 ou 2 paramètres.
- Uniquement 5 paramètres. 

### Question 3 :
Est-ce que le code suivant décrit un délégué valide en c# ? 
```C#
Action<string> print = message => Console.WriteLine(message);
print("Hello World!");
```
- **Oui**
- Non

## 5. Création d'une Exception

### Question 1 :
Laquelle de ces déclaration d'exception personnalisée est correcte : 
- **public class MyException : Exception**
- public class MyException : Application
- public class MyException : Error

### Question 2 :
A partir de cette classe d'exception personnalisée : 
```c#
public class MyException : Exception
{
    public MyException() { }
}
```

Lequel de ces lancement d'exception est correcte :
- `throw new MyException();`
- `throw MyException();`
- `throw new MyException;`
- `throw MyException;`


## 6. LINQ

### Question 1 :
Quelles sont les deux méthodes possibles pour travailler avec LINQ ?
- **Requête**
- **Méthodes**
- SQL
- Appel de données

### Question 2 :
À quoi sert "Distinct" ?
- **Récupérer les éléments non dupliqués**
- Récupérer les éléments non flottants
- Récupérer les éléments un par un

### Question 3 :
Laquelle de ces expressions permet de renvoyer un tableau avec l'âge des personnes ?
- **people.Select(p => p.Age).ToArray()**
- people.Select(p => new { p.Age })
- people.Select(p => p.Name)

### Question 4 : 
Vous avez une liste d'élèves, où chaque élève a une liste de notes : 
```C#
public class Eleve
{
    public string Nom { get; set; }
    public List<int> Notes { get; set; }
}

List<Eleve> eleves = new List<Eleve>
{
    new Eleve { Nom = "Alice", Notes = new List<int> { 80, 85, 90 } },
    new Eleve { Nom = "Bob", Notes = new List<int> { 70, 75, 80 } },
    new Eleve { Nom = "Charlie", Notes = new List<int> { 60, 65, 70 } }
};
```
Laquelle des propositions suivantes permet d'obtenir un tableau a une dimension contenant toutes les notes de tous les élèves de la liste eleves ?

- **Réponse A :**
```C#
var toutesLesNotes = eleves.SelectMany(eleve => eleve.Notes);
```
- Réponse B :
```C#
var toutesLesNotes = eleves.Select(eleve => eleve.Notes);
```
- Réponse C :
```C#
var eleves.SelectMany(function(eleve) { return eleve.Notes; }).ToList();
```


## 7. Applications Multi-couches

### Question 1 :
Quelles sont les trois couches habituelles d'une application ?
- **Contrôleurs**
- **Services**
- **Modèles**
- Vues

### Question 2 :
Peut-on avoir différents contrôleurs pour un même Service/Modèle ?
- **Oui**
- Non