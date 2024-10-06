using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool jouerEncore = true;

        while (jouerEncore)
        {
            // Affiche les choix possibles par le joueur
            Console.WriteLine("Choisissez: \n1. Pierre\n2. Papier\n3. Ciseaux");

            // Récupérer la réponse du joueur
            string reponseJoueur = Console.ReadLine();

            // Ont génére le choix de l'adversaire
            string reponseAdversaire = GenererChoixAdversaire();

            // Déterminer le gagnant en comparant le choix des deux adversaire
            string resultatTexte = RécupèreRésultat(reponseJoueur, reponseAdversaire);

            // Ont récupère les choix de chaque joueurs pour les afficher
            string choixJoueur = RécupèreChoix(reponseJoueur);
            string choixAdversaire = RécupèreChoix(reponseAdversaire);

            // Ont affiche le résultat
            Console.WriteLine($"\nVous avez choisi : {choixJoueur}");
            Console.WriteLine($"L'Adversaire a choisi : {choixAdversaire}");
            Console.WriteLine(resultatTexte);

            // Demander au joueur s'il veut rejouer
            Console.WriteLine("\nVoulez-vous rejouer ? (o/n)");
            string reponse = Console.ReadLine().ToLower();
            if (reponse != "o")
            {
                jouerEncore = false; // Le jeu s'arrète
            }
        }

        Console.WriteLine("Fin du jeu");
    }

    // Fonction responsable de la génération du choix de l'adversaire
    static string GenererChoixAdversaire()
    {
        Random rnd = new Random();
        int choix = rnd.Next(1, 4); // Génère un nombre entre 1 et 3
        return choix.ToString();
    }

    // Fonction responsable de déterminé le gagnant
    static string RécupèreRésultat(string joueur, string Adversaire)
    {
        string choixJoueur = RécupèreChoix(joueur);
        string choixAdversaire = RécupèreChoix(Adversaire);

        if (joueur == Adversaire)
        {
            return "Égalité!"; // Cas d'égalité
        }

        if ((choixJoueur == "Pierre" && choixAdversaire == "Ciseaux") ||  // Pierre bat Ciseaux
            (choixJoueur == "Papier" && choixAdversaire == "Pierre") ||  // Papier bat Pierre
            (choixJoueur == "Ciseaux" && choixAdversaire == "Papier"))    // Ciseaux bat Papier
        {
            return "Vous avez gagné!";
        }
        else
        {
            return "L'Adversaire a gagné!";
        }
    }

    // Fonction responsable de récupéré le choix d'un joueur a partir de leur réponse
    static string RécupèreChoix(string choix)
    {
        switch (choix)
        {
            // Le joueur a donner une réponse permit celles proposé
            // Choix pierre
            case "1":
                return "Pierre";
            case "Pierre":
                return "Pierre";
            case "pierre":
                return "Pierre";
            case "PIERRE":
                return "Pierre";

            // Choix papier
            case "2":
                return "Papier";
            case "Papier":
                return "Papier";
            case "papier":
                return "Papier";
            case "PAPIER":
                return "Papier";

            // Choix ciseaux
            case "3":
                return "Ciseaux";
            case "Ciseaux":
                return "Ciseaux";
            case "ciseaux":
                return "Ciseaux";
            case "CISEAUX":
                return "Ciseaux";

            // Le puit n'éxiste pas dans le Chifoumi !
            case "Le puit":
                return "Le puit n'est PAS un choix !";
            case "Le Puit":
                return "Le puit n'est PAS un choix !";
            case "Le PUIT":
                return "Le puit n'est PAS un choix !";
            case "le puit":
                return "Le puit n'est PAS un choix !";
            case "le Puit":
                return "Le puit n'est PAS un choix !";
            case "le PUIT":
                return "Le puit n'est PAS un choix !";
            case "LE PUIT":
                return "Le puit n'est PAS un choix !";

            // Le joueur a donner une réponse qui n'est pas parmit les choix
            default:
                return $"Mauvais choix ({choix})";
        }
    }
}
