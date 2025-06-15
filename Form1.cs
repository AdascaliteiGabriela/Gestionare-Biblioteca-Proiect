using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form1 : Form
    {
      
       
        public Form1()
        {
            InitializeComponent();
            Meniu.SelectedTab = CitTab;
            
        }
        
        private List<Cititor> cititori = new List<Cititor>();
        private List<Carte> carti = new List<Carte>();
        private List<Imprumut> imprumuturi = new List<Imprumut>();
        private void AfiseazaCititori()
        {
            gvCititori.Rows.Clear();
            foreach (var c in cititori)
            {
                gvCititori.Rows.Add(c.Id, c.Nume, c.Prenume, c.Telefon,c.Email);
            }
        }
        private void AfiseazaCarti()
        {
            gvCarti.Rows.Clear();
            foreach (var carte in carti)
            {
                gvCarti.Rows.Add(carte.IdCarte, carte.Titlu,carte.Autor, carte.Editura, carte.AnAparitie, carte.Cota);
            }
        }

        private void AfiseazaImprumuturi()
        {
            gvImprumuturi.Rows.Clear();

            foreach (var i in imprumuturi)
            {
                gvImprumuturi.Rows.Add(
                    i.Cititor.Id,
                    i.Carte.IdCarte,
                    i.DataImprumut.ToShortDateString(),
                    i.DataScadenta.ToShortDateString(),
                    i.DataReturnare.HasValue ? i.DataReturnare.Value.ToShortDateString() : "Nereturnata!"
                );
            }
        }

        
        private void AdCarti_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitlu.Text) || string.IsNullOrWhiteSpace(tbAutor.Text) ||string.IsNullOrWhiteSpace(tbEdit.Text) ||string.IsNullOrWhiteSpace(tbAn.Text))
            {
                MessageBox.Show("Nu ai completat toate campurile obligatorii..","Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbAn.Text, out int anAparitie))
            {
                MessageBox.Show("Anul apariției trebuie să fie un număr valid.","Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Carte carte = new Carte(
                tbTitlu.Text,
                tbAutor.Text,
                tbEdit.Text,
                anAparitie,
                tbCod.Text
            );

            carti.Add(carte);
            AfiseazaCarti();

            
            tbTitlu.Clear();
            tbAutor.Clear();
            tbEdit.Clear();
            tbAn.Clear();
            tbCod.Clear();
        }

        private void AdCi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCitNume.Text) || string.IsNullOrWhiteSpace(tbCitPren.Text))
            {
                MessageBox.Show("Completează numele și prenumele.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbCitTlf.Text.Length != 10 || !tbCitTlf.Text.All(char.IsDigit))
            {
                MessageBox.Show("Numărul de telefon trebuie să aibă exact 10 cifre.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cititor c = new Cititor(
                tbCitNume.Text,
                tbCitPren.Text,
                tbEmail.Text,
                tbCitTlf.Text
            );

            cititori.Add(c);
            AfiseazaCititori();
            tbCitNume.Clear();
            tbCitPren.Clear();
            tbCitTlf.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCitImp.Text, out int idCititor) || !int.TryParse(tbCarteImp.Text, out int idCarte))
            {
                MessageBox.Show("ID-urile nu sunt numere valide", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cititor cititor = cititori.FirstOrDefault(c => c.Id == idCititor);
            Carte carte = carti.FirstOrDefault(c => c.IdCarte == idCarte);

            if (cititor == null || carte == null)
            {
                MessageBox.Show("Nu am gasit cititorul sau cartea..", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataImp = dtImpr.Value;
            DateTime dataScad = dtScad.Value;

            Imprumut imprumutNou = new Imprumut(cititor, carte, dataImp, dataScad);
            imprumuturi.Add(imprumutNou);
            AfiseazaImprumuturi();

            tbCitImp.Clear();
            tbCarteImp.Clear();
            dtImpr.Value = DateTime.Today;
            dtScad.Value = DateTime.Today.AddDays(14);

        }

        private void stergCit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdCit.Text, out int idCautat))
            {
                MessageBox.Show("Introduceți un ID valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cititor cititorDeSters = cititori.FirstOrDefault(c => c.Id == idCautat);

            if (cititorDeSters == null)
            {
                MessageBox.Show("Cititorul cu acest ID nu există.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmare = MessageBox.Show( $"Ești sigur că vrei să ștergi cititorul {cititorDeSters.Nume} {cititorDeSters.Prenume}?", "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                cititori.Remove(cititorDeSters);
                AfiseazaCititori();
                tbIdCit.Clear();
            }
        }

        private void stergCarti_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdCart.Text, out int idCarte))
            {
                MessageBox.Show("Introduceți un ID valid pentru carte.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Carte carteDeSters = carti.FirstOrDefault(c => c.IdCarte == idCarte);

            if (carteDeSters == null)
            {
                MessageBox.Show("Cartea cu acest ID nu există.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmare = MessageBox.Show(
                $"Ești sigur că vrei să ștergi cartea „{carteDeSters.Titlu}” de {carteDeSters.Autor}?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                carti.Remove(carteDeSters);
                AfiseazaCarti();
                IdCart.Clear();
            }
        }

        private void btStgImpr_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCitImp.Text, out int idCititor) || !int.TryParse(tbCarteImp.Text, out int idCarte))
            {
                MessageBox.Show("ID ul pentru carte sau cititor nu a fost valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var imprumutDeSters = imprumuturi.FirstOrDefault(i => i.Cititor.Id == idCititor && i.Carte.IdCarte == idCarte);

            if (imprumutDeSters == null)
            {
                MessageBox.Show("Nu am gasit niciun împrumut cu aceste ID-uri.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmare = MessageBox.Show(
                $"Esti sigur că vrei sa stergi imprumutul pentru „{imprumutDeSters.Carte.Titlu}” de la {imprumutDeSters.Cititor.Nume} {imprumutDeSters.Cititor.Prenume}?","Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                imprumuturi.Remove(imprumutDeSters);
                AfiseazaImprumuturi(); 
                tbCitImp.Clear();
                tbCarteImp.Clear();
            }
        }

        private void modifCit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdCit.Text, out int idCititor))
            {
                MessageBox.Show("ID ul introdus nu e valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cititor cititorDeModificat = cititori.FirstOrDefault(c => c.Id == idCititor);

            if (cititorDeModificat == null)
            {
                MessageBox.Show("Cititorul cu acest ID nu exista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrWhiteSpace(tbCitNume.Text))
                cititorDeModificat.Nume = tbCitNume.Text;

            if (!string.IsNullOrWhiteSpace(tbCitPren.Text))
                cititorDeModificat.Prenume = tbCitPren.Text;

            if (!string.IsNullOrWhiteSpace(tbCitTlf.Text))
                cititorDeModificat.Telefon = tbCitTlf.Text;

            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
                cititorDeModificat.Email = tbEmail.Text;

            AfiseazaCititori();
            MessageBox.Show("Campurile completate au fost modificate.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbIdCit.Clear();
            tbCitNume.Clear();
            tbCitPren.Clear();
            tbCitTlf.Clear();
            tbEmail.Clear();

        }

        private void ModifCarti_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdCart.Text, out int idCarte))
            {
                MessageBox.Show("Nu ai introdus un ID valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Carte carteDeModificat = carti.FirstOrDefault(c => c.IdCarte == idCarte);

            if (carteDeModificat == null)
            {
                MessageBox.Show("Cartea cu acest ID nu exista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrWhiteSpace(tbTitlu.Text))
                carteDeModificat.Titlu = tbTitlu.Text;

            if (!string.IsNullOrWhiteSpace(tbAutor.Text))
                carteDeModificat.Autor = tbAutor.Text;

            if (!string.IsNullOrWhiteSpace(tbEdit.Text))
                carteDeModificat.Editura = tbEdit.Text;

            if (!string.IsNullOrWhiteSpace(tbAn.Text))
            {
                if (int.TryParse(tbAn.Text, out int anAparitie))
                    carteDeModificat.AnAparitie = anAparitie;
                else
                {
                    MessageBox.Show("Anul apariției nu este corect.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(tbCod.Text))
                carteDeModificat.Cota = tbCod.Text;

            AfiseazaCarti();
            MessageBox.Show("Au fost modificate campurile completate.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            IdCart.Clear();
            tbTitlu.Clear();
            tbAutor.Clear();
            tbEdit.Clear();
            tbAn.Clear();
            tbCod.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCitImp.Text, out int idCititor) || !int.TryParse(tbCarteImp.Text, out int idCarte))
            {
                MessageBox.Show("Introdu ID-uri valide pentru cititor si carte.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var imprumut = imprumuturi.FirstOrDefault(i => i.Cititor.Id == idCititor && i.Carte.IdCarte == idCarte);

            if (imprumut == null)
            {
                MessageBox.Show("Imprumutul specificat nu exista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dtImpr.Value != imprumut.DataImprumut)
                imprumut.DataImprumut = dtImpr.Value;

            if (dtScad.Value != imprumut.DataScadenta)
                imprumut.DataScadenta = dtScad.Value;

            if (dtRetur.Checked)
            {
                if (dtRetur.Value < dtImpr.Value)
                {
                    MessageBox.Show("Data returnarii nu poate fi inaintea datei de imprumut.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                imprumut.DataReturnare = dtRetur.Value;
            }
            else
            {
                imprumut.DataReturnare = null;
            }

            AfiseazaImprumuturi();
            MessageBox.Show("Campurile completate au fost modificate.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbCitImp.Clear();
            tbCarteImp.Clear();
            dtImpr.Value = DateTime.Today;
            dtScad.Value = DateTime.Today.AddDays(14);
            dtRetur.Value = DateTime.Today;
            dtRetur.Checked = false;
        }


        private void AfisCit_Click(object sender, EventArgs e)
        {
            string pathCititori = Path.Combine(Application.StartupPath, "Resurse", "Cititori.txt");
            if (!File.Exists(pathCititori))
            {
                MessageBox.Show(pathCititori);
                return;
            }

            string[] linii = File.ReadAllLines(pathCititori);
            foreach (string linie in linii)
            {
                var valori = linie.Split(',');
                if (valori.Length >= 5)
                {
                    int id = int.Parse(valori[0]);
                    string nume = valori[1];
                    string prenume = valori[2];
                    string telefon = valori[3];
                    string email = valori[4];

                    Cititor c = new Cititor(nume, prenume, email, telefon);
                    c.Id = id;
                    cititori.Add(c);
                }
            }

            AfiseazaCititori();
        }

        private void AfisCarti_Click(object sender, EventArgs e)
        {
            string pathCarti = Path.Combine(Application.StartupPath, "Resurse", "Carti.txt");
            if (!File.Exists(pathCarti))
            {
                MessageBox.Show("Fisierul nu a fost gasit.");
                return;
            }

            
            string[] linii = File.ReadAllLines(pathCarti);

            foreach (string linie in linii)
            {
                string[] campuri = linie.Split(',');

                if (campuri.Length >= 6 && int.TryParse(campuri[4], out int anAparitie))
                {
                    Carte c = new Carte(
                        campuri[1], 
                        campuri[2], 
                        campuri[3],
                        anAparitie,
                        campuri[5]  
                    );
                    carti.Add(c);
                }
            }

            AfiseazaCarti();
        }

        private void AfiseazaGR_Click(object sender, EventArgs e)
        {
            Grafic f = new Grafic(imprumuturi);
            f.Show();
        }
    }
    
}
