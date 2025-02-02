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
    - Nombres d'obstacles passés ?
    - Distance parcourue ?
    - Temps sans mourir ?

### Interface Utilisateur (UI)
- Score affiché tout le long de la partie
- Menu principal avec deux boutons évidents (jouer, quitter)
- Page de fin de partie avec score et deux options évidents (rejouer, menu)

### Principaux points de code
- Collisions
- Caméra
- Mouvement

## II - Fonctionnement


## III - Répartition


## IV - Crédits

| Noms                         |                Adresses Mails |
| :-----------------------     |      -----------------------: |
|**Luna COLOMBAN-FERNANDEZ**   |luna.colombanfernandez@ynov.com|
|**Erika LAJUS**               |erika.lajus@ynov.com           |
|**Karl DAVAL-LECLERCQ**       |karl.davalleclercq@ynov.com    |