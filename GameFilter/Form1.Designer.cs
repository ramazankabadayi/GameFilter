namespace GameFilter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHizli = new System.Windows.Forms.Label();
            this.lblTeketek = new System.Windows.Forms.Label();
            this.lblRovans = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblBahisAraligi = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.seciciBar = new System.Windows.Forms.TrackBar();
            this.lblSecim = new System.Windows.Forms.Label();
            this.hizli = new CustomControls.CustomControls.ToggleButton();
            this.lblHizliHayir = new System.Windows.Forms.Label();
            this.lblHizliEvet = new System.Windows.Forms.Label();
            this.lblTeketekEvet = new System.Windows.Forms.Label();
            this.lblTeketekHayir = new System.Windows.Forms.Label();
            this.teketek = new CustomControls.CustomControls.ToggleButton();
            this.lblRovansEvet = new System.Windows.Forms.Label();
            this.lblRovansHayir = new System.Windows.Forms.Label();
            this.rovans = new CustomControls.CustomControls.ToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.seciciBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHizli
            // 
            resources.ApplyResources(this.lblHizli, "lblHizli");
            this.lblHizli.Name = "lblHizli";
            // 
            // lblTeketek
            // 
            resources.ApplyResources(this.lblTeketek, "lblTeketek");
            this.lblTeketek.Name = "lblTeketek";
            // 
            // lblRovans
            // 
            resources.ApplyResources(this.lblRovans, "lblRovans");
            this.lblRovans.Name = "lblRovans";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblBahisAraligi
            // 
            resources.ApplyResources(this.lblBahisAraligi, "lblBahisAraligi");
            this.lblBahisAraligi.Name = "lblBahisAraligi";
            // 
            // lblMin
            // 
            resources.ApplyResources(this.lblMin, "lblMin");
            this.lblMin.Name = "lblMin";
            // 
            // lblMax
            // 
            resources.ApplyResources(this.lblMax, "lblMax");
            this.lblMax.Name = "lblMax";
            // 
            // seciciBar
            // 
            resources.ApplyResources(this.seciciBar, "seciciBar");
            this.seciciBar.Name = "seciciBar";
            this.seciciBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblSecim
            // 
            resources.ApplyResources(this.lblSecim, "lblSecim");
            this.lblSecim.Name = "lblSecim";
            // 
            // hizli
            // 
            resources.ApplyResources(this.hizli, "hizli");
            this.hizli.Name = "hizli";
            this.hizli.OffBackColor = System.Drawing.Color.Gray;
            this.hizli.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.hizli.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.hizli.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.hizli.UseVisualStyleBackColor = true;
            // 
            // lblHizliHayir
            // 
            resources.ApplyResources(this.lblHizliHayir, "lblHizliHayir");
            this.lblHizliHayir.Name = "lblHizliHayir";
            // 
            // lblHizliEvet
            // 
            resources.ApplyResources(this.lblHizliEvet, "lblHizliEvet");
            this.lblHizliEvet.Name = "lblHizliEvet";
            // 
            // lblTeketekEvet
            // 
            resources.ApplyResources(this.lblTeketekEvet, "lblTeketekEvet");
            this.lblTeketekEvet.Name = "lblTeketekEvet";
            // 
            // lblTeketekHayir
            // 
            resources.ApplyResources(this.lblTeketekHayir, "lblTeketekHayir");
            this.lblTeketekHayir.Name = "lblTeketekHayir";
            // 
            // teketek
            // 
            resources.ApplyResources(this.teketek, "teketek");
            this.teketek.Name = "teketek";
            this.teketek.OffBackColor = System.Drawing.Color.Gray;
            this.teketek.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.teketek.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.teketek.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.teketek.UseVisualStyleBackColor = true;
            // 
            // lblRovansEvet
            // 
            resources.ApplyResources(this.lblRovansEvet, "lblRovansEvet");
            this.lblRovansEvet.Name = "lblRovansEvet";
            // 
            // lblRovansHayir
            // 
            resources.ApplyResources(this.lblRovansHayir, "lblRovansHayir");
            this.lblRovansHayir.Name = "lblRovansHayir";
            // 
            // rovans
            // 
            resources.ApplyResources(this.rovans, "rovans");
            this.rovans.Name = "rovans";
            this.rovans.OffBackColor = System.Drawing.Color.Gray;
            this.rovans.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rovans.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rovans.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rovans.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRovansEvet);
            this.Controls.Add(this.lblRovansHayir);
            this.Controls.Add(this.rovans);
            this.Controls.Add(this.lblTeketekEvet);
            this.Controls.Add(this.lblTeketekHayir);
            this.Controls.Add(this.teketek);
            this.Controls.Add(this.lblHizliEvet);
            this.Controls.Add(this.lblHizliHayir);
            this.Controls.Add(this.hizli);
            this.Controls.Add(this.lblSecim);
            this.Controls.Add(this.seciciBar);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblBahisAraligi);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblRovans);
            this.Controls.Add(this.lblTeketek);
            this.Controls.Add(this.lblHizli);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seciciBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHizli;
        private Label lblTeketek;
        private Label lblRovans;
        private Button btnOk;
        private Label lblBahisAraligi;
        private Label lblMin;
        private Label lblMax;
        private TrackBar seciciBar;
        private Label lblSecim;
        private CustomControls.CustomControls.ToggleButton hizli;
        private Label lblHizliHayir;
        private Label lblHizliEvet;
        private Label lblTeketekEvet;
        private Label lblTeketekHayir;
        private CustomControls.CustomControls.ToggleButton teketek;
        private Label lblRovansEvet;
        private Label lblRovansHayir;
        private CustomControls.CustomControls.ToggleButton rovans;
    }
}