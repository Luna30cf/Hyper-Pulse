# <center> **HYPER PULSE**


## Sommaire

- [I - Jeu](#i---jeu)
- [II - Fonctionnement](#ii---fonctionnement)
- [III - Répartition](#iii---répartition)
- [IV - Crédits](#iv---crédits)


## I - Jeu

[figma](https://www.figma.com/design/Tj02VnptopQvQHEVHK5TTK/Geometry-Dash?node-id=0-1&t=mmMT3mNThdIAPVzR-1)

### Scènes
- Menu Principal:   
    - *Boutons : Play, Quitter.*
    - *Titre et un background.*
- Jeu :
    - *Caméra qui suit le joueur.*
    - *Un sol et des obstacles qui défilent automatiquement.*
    - *Bouton pause*
- Game Over :
    - *Affichage du score.*
    - *Boutons : Rejouer et Menu Principal.*

### Création de préfabs
- Joueur :
    - Un objet simple (cube ou sprite 2D).
    - Ajoute un script pour gérer le saut lorsqu'on appuie sur une touche.
- Obstacles :
    - Crée différents types d'obstacles (hauteur ou largeur variable).
    - Ajouter un Collider pour détecter les collisions avec le joueur.
- Sol défilant :
    - Un fond répétitif qui donne l’impression de mouvement.

### Events
- Mouvement du joueur :
    - Appuyer sur le bouton = sauter
- Détection des collisions :
    - Obstacle touché = Game Over
- Score :
    - Temps sans mourir

### Interface Utilisateur (UI)
- Score affiché tout le long de la partie
- Menu principal avec deux boutons évidents (jouer, quitter)
- Page de fin de partie avec score et deux options évidents (rejouer, menu)

### Principaux points de code
- Collisions
- Caméra
- Mouvement

<<<<<<< HEAD
## II Fonctionnement

**Première installation**

1. Cloner le repo

Dans votre invite de commande, Coller :  
`git clone https://github.com/Luna30cf/Hyper-Pulse.git`

Ouvrer le répository dans Unity (version 6000.0.35f1)
Puis positionnez-vous dans la scène menu et...
    - Lancer le jeu

2. Lancer le fichier : " "

**Principe du jeu**  

Le joueur contrôle une forme hexagonale qui avance automatiquement vers la droite. Il doit éviter les obstacles (triangles) en sautant au bon moment en appuyant sur une touche du clavier déjà définie. 
Si le joueur entre en collision avec un obstacle c'est GAME OVER.

**Commandes**  
_touche **ESPACE**_ : permet de sauter.

## III - Répartition

**Karl** 
- Partie graphique (obstacles, sol, fond, boutons...)
- Jump du joueur
- Page de game over
- Base de la gestion des collisions

**Luna**
- Readme
- Changement de scènes
- Reprise de la base et mise en cohérence
- Correction des erreurs et problèmes avec git et unity (d'où le retard de rendu, désolée)

**Erika**
- Créations des préfabs de base (sans le design défini)    
- Base mécanique du jeu (scripts de base des préfabs suivant le principe du jeu)    
- Readme (partie fonctionnement)    


## IV - Crédits

| Noms                         |                Adresses Mails |
| :-----------------------     |      -----------------------: |
|**Luna COLOMBAN-FERNANDEZ**   |luna.colombanfernandez@ynov.com|
|**Erika LAJUS**               |erika.lajus@ynov.com           |
|**Karl DAVAL-LECLERCQ**       |karl.davalleclercq@ynov.com    |