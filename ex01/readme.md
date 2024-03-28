
<!DOCTYPE html>
<html lang="fr">
    <h1>Instructions</h1>
    <h2>Exercice 01 - Garage</h2>
    <p>Dans votre dépot git créer un nouveau dossier <b>ex01_Garage</b></p>
<div>
<p>Vous allez mettre en pratique une bonne partie de ce que vous avez appris de ce cours :</p>
<ul>
<li>cr&eacute;ation de classes;</li>
<li>h&eacute;ritage;</li>
<li>namespace;</li>
<li>&eacute;num&eacute;ration;</li>
<li>g&eacute;n&eacute;rique;</li>
<li>fichiers.</li>
</ul>
<p><br />Voici un diagramme de classes vous repr&eacute;sentant l&rsquo;exercice :</p>
<p><a href="http://sdz-upload.s3.amazonaws.com/prod/upload/P2PA%20-%20Voiture.png"><img src="http://sdz-upload.s3.amazonaws.com/prod/upload/P2PA%20-%20Voiture.png" alt="Diagramme UML de l'exercice" width="878" height="440" /></a></p>
<p>Vous l&rsquo;aurez compris, vous allez devoir cr&eacute;er un garage, mais vous allez devoir aussi le sauvegarder dans un fichier&hellip; Le but &eacute;tant qu&rsquo;&agrave; chaque fois que vous ajoutez un nouveau v&eacute;hicule dans votre garage, celui-ci se sauvegarde automatiquement dans un fichier. Il faudra aussi automatiquement charger le garage lors de son instanciation.</p>
<p>&nbsp;</p>
<p>&Eacute;tant d&rsquo;un naturel magnanime, je vous donne une classe de test pour votre programme :</p>
<pre>public class Program {
    public static void Main(string[] args) {
   	 Garage garage = new Garage();   
   	 Console.WriteLine(garage);
   	 
   	 Vehicule lag1 = new Lagouna();
   	 lag1.SetMoteur(new MoteurEssence("150 Chevaux", 10256d));
   	 lag1.AddOption(new GPS());
   	 lag1.AddOption(new SiegeChauffant());
   	 lag1.AddOption(new VitreElectrique());
   	 garage.AddVoiture(lag1);
   		 
   	 Vehicule A300B_2 = new A300B();
   	 A300B_2.SetMoteur(new MoteurElectrique("1500 W", 1234d));
   	 A300B_2.AddOption(new Climatisation());
   	 A300B_2.AddOption(new BarreDeToit());
   	 A300B_2.AddOption(new SiegeChauffant());
   	 garage.AddVoiture(A300B_2);
   	 
   	 Vehicule d4_1 = new D4();
   	 d4_1.SetMoteur(new MoteurDiesel("200 Hdi", 25684.80d));
   	 d4_1.AddOption(new BarreDeToit());
   	 d4_1.AddOption(new Climatisation());
   	 d4_1.AddOption(new GPS());
   	 garage.AddVoiture(d4_1);   	 
   	 
   	 Vehicule lag2 = new Lagouna();
   	 lag2.SetMoteur(new MoteurDiesel("500 Hdi", 456987d));
   	 garage.AddVoiture(lag2);
   	 
   	 Vehicule A300B_1 = new A300B();
   	 A300B_1.SetMoteur(new MoteurHybride("ESSENCE/Electrique", 12345.95d));
   	 A300B_1.AddOption(new VitreElectrique());
   	 A300B_1.AddOption(new BarreDeToit());
   	 garage.AddVoiture(A300B_1);
   	 
   	 Vehicule d4_2 = new D4();
   	 d4_2.SetMoteur(new MoteurElectrique("100 KW", 1224d));
   	 d4_2.AddOption(new SiegeChauffant());
   	 d4_2.AddOption(new BarreDeToit());
   	 d4_2.AddOption(new Climatisation());
   	 d4_2.AddOption(new GPS());
   	 d4_2.AddOption(new VitreElectrique());
   	 garage.AddVoiture(d4_2);   			 
    }
}</pre>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Et pour que vous ayez&nbsp;une id&eacute;e de ce que ce programme pourrait vous donner, voici deux screenshots, celui-ci&nbsp;lors du premier lancement de cette classe de test :</p>
<pre>
Aucune voiture sauvegardée !
**************************
*     Garage .NET        *
**************************
</pre>
<p>&nbsp;</p>
<p>Et&nbsp;celui-l&agrave;&nbsp;apr&egrave;s le deuxi&egrave;me lancement (vous constaterez que mon garage n&rsquo;est plus vide &agrave; ce moment-l&agrave;) :</p>
<p><pre>
+ Voiture RENO : Lagouna Noteur ESSENCE 150 Chevaux (23123.0€) [GPS (113.5€), Siége chauffant (562.9€), Vitre electrique (212.35€)] d'une valeur totale de 24011.75 €
+ Voiture PIGEOT : A330B Moteur ELECTATQUE 1508 W (28457.8€) (Climatisation (347.3€), Barre de toit (29.9€), Sitge chauffant (562.9€)] d'une valeur totale de 29397,100000900082 €
+ Woiture TROEM : 04 Moteur DIESEL 208 Hei (25147.0€) [Barre de toit (29.9€), Climatisation (347.3€), GPS (113.5¢€}] d'une valeur totale de 25637.? €
+ Voiture REWO : Lagouna Moteur DIESEL 508 Hdi (23123.¢€) [] d'une valeur totale de 23123.0 €
+ Wolture PIGEOT ; A3303 Moteur HYBRIDE ESSEMCE/Electrique (28457.8€) [Vitre electrique (212.35€), Barre de toit (29.9€)] d'une valeur totale de 28699.25 €
+ Voiture TROEM : 04 Moteur ELECTRIQUE 108 KW (25147.0€) [Siége chauffant (562.9€), Barre de toit (29.9€}, Climatisation (347.34), GPS (113.5€), Vitre electrique (212.35€)] d'une
</pre></p>
<p>&nbsp;</p>
<p>C'est &agrave; vous !</p>
<p>&nbsp;</p>
    </div>



    
  </body>
</html>
