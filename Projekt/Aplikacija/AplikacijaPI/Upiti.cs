using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPI
{
    class Upiti
    {
        private string varijabla;
        public Upiti(string varijabla1)
        {
            varijabla = varijabla1;
        }
        public string ProvjeraLozinke()
        {
            string lozinka = Convert.ToString(Baza.Instance.DohvatiVrijednost("select lozinka from Korisnik where korisnicko_ime='" + varijabla + "';"));
            return lozinka;
        }
        public string ProvjeraTipa()
        {
            string tip = Convert.ToString(Baza.Instance.DohvatiVrijednost("select tip_korisnika from Korisnik where korisnicko_ime='" + varijabla + "';"));
            return tip;
        }
        
    }
}
