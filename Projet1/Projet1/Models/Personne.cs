using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet1.Models
{
    public class Personne
    {
        public class AjoutPeronneViewModel
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
        }
    }
}