using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BigliettiCinema
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int scelta = Convert.ToInt32(DropDownList1.SelectedValue);
            if (scelta == 1)
            {
                ArchiviaPrenotazione("SALA NORD");
            }
            else if (scelta == 2)
            {
                ArchiviaPrenotazione("SALA EST");
            }
            else if (scelta == 3)
            {
                ArchiviaPrenotazione("SALA SUD");
            }
            
        }
        protected void ArchiviaPrenotazione(string Sala)
        {
            Prenotazione p = new Prenotazione();
            var nome = TextBox1.Text;
            var cognome = TextBox2.Text;
            p.Nome = nome;
            p.Cognome= cognome;
            p.Sala = Sala;
            p.Ridotto = CheckBox1.Checked;
            Prenotazione.Listaprenotazioni.Add(p);
            ContaBiglietti();
            nome = "";
            cognome = "";

        }
        protected void ContaBiglietti()
        {
            int Vnord = 0;
            int Rnord = 0;
            int Vest = 0;
            int Rest = 0;
            int Vsud = 0;
            int Rsud = 0;
            foreach (Prenotazione p in Prenotazione.Listaprenotazioni)
            {
                if(p.Sala == "SALA NORD")
                {
                    Vnord += 1;
                    if(p.Ridotto == true)
                    {
                        Rnord+= 1;
                    }
                }
                else if (p.Sala == "SALA EST")
                {
                    Vest+= 1;
                    if(p.Ridotto == true)
                    {
                        Rest+= 1;
                    }
                }
                else if(p.Sala == "SALA SUD")
                {
                    Vsud += 1;
                    if(p.Ridotto== true)
                    {
                        Rsud += 1;
                    }
                }
            }
            Label1.Text= Convert.ToString(Vnord);
            Label2.Text= Convert.ToString(Rnord);
            Label3.Text= Convert.ToString(Vest);
            Label4.Text= Convert.ToString(Rest);
            Label5.Text= Convert.ToString(Vsud);
            Label6.Text= Convert.ToString(Rsud);
        }
    }

    public class Prenotazione
    {
        private string _nome;
        public string Nome { 
            get { return _nome; }
            set { _nome = value; }
        }
        private string _cognome;
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        private string _sala;
        public string Sala
        {
            get { return _sala; }
            set { _sala = value; }
        }
        private bool _ridotto;
        public bool Ridotto
        {
            get { return _ridotto; }
            set { _ridotto = value; }
        }
        private static List<Prenotazione> _listaPrenotazioni = new List<Prenotazione>();
        public static List<Prenotazione> Listaprenotazioni
        {
            get { return _listaPrenotazioni; }
            set { _listaPrenotazioni = value; }
        }
    }
}