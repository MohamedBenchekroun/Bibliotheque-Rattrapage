using System.Net.Sockets;

class Livre
{
    public int compteur = 0;
    public string[] livres;
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public string Editeur { get; set; }
    public List<Exemplaire> Exemplaires { get; set; }

    public string[] emprunts; // tableau pour stocker les informations sur les emprunts

    public void emprunter(string Titre, int NumExemplaire, int identifiant)
    {
        // ajouter les informations sur l'emprunt dans le tableau
        emprunts[emprunts.Length] = Titre + " " + NumExemplaire + " " + identifiant;
    }
    public void Prolonger(string NumExemplaire, string identifiant)
    { // Modification de la date de rendu du livre (exemple : ajout de 14 jours)
        DateTime nouvelleDateRendu = DateTime.Today.AddDays(14);

        // Enregistrement des informations dans un tableau
        string[] historiqueEmprunts = new string[] { NumExemplaire, identifiant, nouvelleDateRendu.ToString() };
    }
    public void Rendre() { /* code */ }
    public void Reserver(string Titre)
    {
        for (int i = 0; i < livres.Length; i++)
        {
            if (livres[i] == null)
            {
                livres[i] = Titre;
                Console.WriteLine("Le livre " + Titre + " a été ajouté à la liste des livres réservés.");
                break;
            }
        }
    }
}

class Exemplaire
{
    public int NumeroInventaire { get; set; }
    public DateTime DateAcquisition { get; set; }
    public string Etat { get; set; }
    public Livre Livre { get; set; }

    public void VerifierDisponibilite() { /* code */ }
    public void Deteriorer() { /* code */ }
    public void Restaurer() { /* code */ }
    public void Archiver() { /* code */ }
}

class Bibliotheque
{
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public string Titre { get; set; }
    public List<Livre> Livres { get; set; }
    public List<Employe> Employes { get; set; }

    public void AjouterLivre(Livre livre)
    {
        for (int i = 0; i < livre.Length; i++)
        {
            if (livre[i] == null)
            {
                livre[i] = Titre;
                Console.WriteLine("Le livre " + Titre + " a été ajouté à la liste des livres réservés.");
                break;
            }
        }
    }
    public void SupprimerLivre(Livre livre) { /* code */ }
    public void EnregistrerExemplaire(Exemplaire exemplaire) { /* code */ }
    public void ConsulterStatistiques() { /* code */ }
}

class Employe
{
    public string Nom { get; set; }
    public int NumeroEmploye { get; set; }
    public Bibliotheque Bibliotheque { get; set; }

    public void EnregistrerLivre(Livre livre) { /* code */ }
    public void IndexerLivre(Livre livre) { /* code */ }
    public void MettreDisposition(Exemplaire exemplaire) { /* code */ }
}

class Utilisateur
{
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public int NumeroMembre { get; set; }

    public void EmprunterLivre(Exemplaire exemplaire) { /* code */ }
    public void ProlongerEmprunt(Exemplaire exemplaire) { /* code */ }
    public void RendreLivre(Exemplaire exemplaire) { /* code */ }
    public void ReserverLivre(Livre livre) { /* code */ }
}