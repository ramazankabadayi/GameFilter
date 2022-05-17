namespace GameFilter
{
    public partial class MainForm : Form
    {


        
        List<Masa> MasaListesi = new List<Masa>();

        public MainForm()
        {
            InitializeComponent();
            initTables(); //Rastege masalarin listeye eklenmesi

        }

        private void initTables() //Rastgele masa olusturan fonksiyon
        { 
            for (int i = 0; i < 100; i++)// 100 adet rastgele masa eklenmesi
            {
                MasaListesi.Add(new Masa(
                    i,
                    new Random().Next(200, 5001),// Bahis icin 200-5000 arasi sayilar
                    new Random().Next(0, 8))//Masa tipinin flag enum icin degeri
                    );
            }
        }

        private void filtrele()
        {
            int tip = 0;
            if (hizli.Checked) tip += (int)MasaTipi.Hizli;// Evet olarak isaretlenen masa tiplerine gore, filtre icin toplam degerin bulunmasi
            if (teketek.Checked) tip += (int)MasaTipi.TekeTek;
            if (rovans.Checked) tip += (int)MasaTipi.Rovans;
            if (tip == 0) MessageBox.Show("Lütfen Masa Tipi Seçiniz.");
            else
            {
                List<Masa> filtered = MasaListesi.FindAll(m => m.MasaTipi == tip & m.Bahis <= seciciBar.Value);//Filtreye uygun masalarin bulunup, filtelenenler listesine eklenmesi, filtrelenen masalar bu listede tutuluyor
                string masalar = "";
                foreach (Masa m in filtered) masalar += "Masa " + m.ID + ",  (" + (MasaTipi)m.MasaTipi + "),  " + m.Bahis + "$\n";//Filtrelenen masalarin ozelliklerinin masalar string'ine eklenmesi
                if (masalar == "") masalar = "Seçiminize uygun masa bulunamadý.";
                MessageBox.Show(masalar, "UYGUN MASALAR");
            }
            
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblSecim.Text = seciciBar.Value.ToString() + "$";// Secilen bahis miktarinin, uzerindeki labelde yazdirilmasi
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seciciBar.Minimum = 200;// Bahis miktarinin maksimum-minimum degerleri
            seciciBar.Maximum = 5000;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            filtrele();
            
        }

   
    }
}