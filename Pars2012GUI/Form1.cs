namespace Pars2012GUI
{
    public partial class Form1 : Form
    {
        List<Versenyzo> versenyzok = new List<Versenyzo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using StreamReader sr = new("./../../../../src/Selejtezo2012.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
                versenyzok.Add(new Versenyzo(sr.ReadLine().Split(";")));

            foreach (Versenyzo versenyzo in versenyzok)
                cbNevek.Items.Add(versenyzo.Nev);

            cbNevek.SelectedItem = "Pars Krisztián";
        }

        private void cbNevek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Versenyzo v = versenyzok.Where(v => v.Nev == cbNevek.SelectedItem.ToString()).FirstOrDefault();
            lblCsoport.Text = lblCsoport.Text.Substring(0, lblCsoport.Text.IndexOf(":") + 1) + $" {v.Csoport}";
            lblNemzet.Text = lblNemzet.Text.Substring(0, lblNemzet.Text.IndexOf(":") + 1) + $" {v.Nemzet}";
            lblKod.Text = lblKod.Text.Substring(0, lblKod.Text.IndexOf(":") + 1) + $" {v.Kod}";
            lblSorozat.Text = lblSorozat.Text.Substring(0, lblSorozat.Text.IndexOf(":") + 1) + $" {v.DobasokStr}";
            lblEredmeny.Text = lblEredmeny.Text.Substring(0, lblEredmeny.Text.IndexOf(":") + 1) + $" {v.Eredmeny}";

            pbZaszlo.ImageLocation = $"./../../../../src/Images/{v.Kod}.png";
        }
    }
}