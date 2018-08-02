using Bibliotheque;


namespace Bibliotheque.Exo1
{
    public class Email
    {
        public string Sujet { get; set; }
        public string Destinataire { get; set; }
        public string Contenu { get; set; }
        public string[] DestinatiareEnCopie { get; set; }

        public List<PieceJointe> PiecesJointes { get; set; }

    }


       { public Email Email { get; set; }
    public DateTime DateAjout { get; set; }
    public FileInfo Fichier { get; set; }
}
}



