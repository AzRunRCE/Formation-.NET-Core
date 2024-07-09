
# .NET - Développer avec ASP.NET Core 6

Dans cette section vous apprendrez à développer avec ASP.NET Core.

## .NET 6 - ASP NET MVC
🎥 [Vidéo](https://www.youtube.com/watch?v=om3rGvicuGA)

Qu’elles sont les affirmations Vrais concernant la différence entre ViewBag, ViewData, et TempData ?

- ViewData et TempData sont des dictionnaires (clé, valeur)
- Tous permettent de passer des données à la vue de la même manière.
- TempData permet de passer des données entre deux actions de Contrôleur
- ViewBag et TempData permet de passer des données entre deux actions de Contrôleur


> 
En effet, ViewData et TempData sont des dictionnaires (clé, valeur).
TempData dans l'application ASP.NET Core MVC est l'un des mécanismes permettant de

- transmettre une petite quantité de données temporaires d'une méthode d'action de contrôleur à une vue
- d'une méthode d'action de contrôleur à une autre méthode d'action au sein du même contrôleur ou à un contrôleur différent.

La valeur TempData deviendra nulle une fois la requête suivante terminée par défaut.
Mais si vous le souhaitez, vous pouvez modifier ce comportement par défaut. Si vous regardez la définition de la classe Controller, vous trouverez la signature suivante de la propriété TempData


📝 [Exercice 04 - MVC](https://htmlpreview.github.io/?https://github.com/AzRunRCE/Formation-.NET-Core/blob/main/Ex04_MVC/Ex04_MVC.html)


📝 [Exercice 05 - MVC_Attribut](https://htmlpreview.github.io/?https://github.com/AzRunRCE/Formation-.NET-Core/blob/main/Ex05_MVC_Attribut/Ex05%20MVC_Attribut.html)


## Entity Framework
🎥 [Vidéo](https://www.youtube.com/watch?v=RewB8WtY1XI)

📝 [Exercice 06 - EntityFramework Console](https://htmlpreview.github.io/?https://github.com/AzRunRCE/Formation-.NET-Core/blob/main/Ex06_EntityFramework_Console/ex06.html)


## Web API

🎥 [Vidéo](https://www.youtube.com/watch?v=DhCasNXEPBo)

📝 [Exercice 07 - EntityFramework ASP.NET](https://htmlpreview.github.io/?https://github.com/AzRunRCE/Formation-.NET-Core/blob/main/Ex07_EntityFramework_ASP_NET/ex07.html)

### Questions
**Texte à trou**

Le terme __ signifie Representational State Transfert State Transfer. Il s'agit d'un style architectural pour les systèmes distribués, particulièrement les services web.

Ce style architectural est basés sur le protocole HTTP et utilisent des méthodes telles que GET, , PUT, et DELETE pour effectuer des opérations. 

Un principe clé de __ est la __, ce qui signifie que chaque requête du client au serveur doit contenir toutes les informations nécessaires pour comprendre et traiter la requête. 

## Les Cookies WEB
🎥 [Vidéo](https://youtu.be/DRzpqkqusYo)
👀 [Démo](/Demos/DemoCookieASP.NET/)


## Authentification & Autorisation

🎥 [Vidéo](https://youtu.be/JrWXqhCSE-g)

📝 [Exercice 08 - Authentification Et Authorisation ASP.NET](https://htmlpreview.github.io/?https://github.com/AzRunRCE/Formation-.NET-Core/blob/main/Ex08_Authentification_Et_Authorisation/ex08.html)



## Tests Unitaires
🎥 [Vidéo](https://www.youtube.com/watch?v=XXJni5YyC98)
