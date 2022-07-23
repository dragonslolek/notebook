
using System;

namespace notatnik
{
    partial class Notatnik
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweOknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ustawieniaStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.znajdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźNastępnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdźPoprzednieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godzinadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zawijanieWierszyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekStanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatnikInformacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stopka = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.liczba_znakow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pozycja_kursora = new System.Windows.Forms.ToolStripStatusLabel();
            this.wielkosc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textbox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.Stopka.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.noweOknoToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripSeparator1,
            this.ustawieniaStronyToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.toolStripSeparator2,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // noweOknoToolStripMenuItem
            // 
            this.noweOknoToolStripMenuItem.Name = "noweOknoToolStripMenuItem";
            this.noweOknoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.noweOknoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.noweOknoToolStripMenuItem.Text = "Nowe okno";
            this.noweOknoToolStripMenuItem.Click += new System.EventHandler(this.noweOknoToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz...";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // ustawieniaStronyToolStripMenuItem
            // 
            this.ustawieniaStronyToolStripMenuItem.Name = "ustawieniaStronyToolStripMenuItem";
            this.ustawieniaStronyToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.ustawieniaStronyToolStripMenuItem.Text = "Ustawienia strony...";
            this.ustawieniaStronyToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaStronyToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.drukujToolStripMenuItem.Text = "Drukuj...";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripSeparator3,
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.toolStripSeparator4,
            this.znajdźToolStripMenuItem,
            this.znajdźNastępnyToolStripMenuItem,
            this.znajdźPoprzednieToolStripMenuItem,
            this.toolStripSeparator5,
            this.zaznaczWszystkoToolStripMenuItem,
            this.godzinadataToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            this.edycjaToolStripMenuItem.Click += new System.EventHandler(this.edycjaToolStripMenuItem_Click);
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(278, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(278, 6);
            // 
            // znajdźToolStripMenuItem
            // 
            this.znajdźToolStripMenuItem.Name = "znajdźToolStripMenuItem";
            this.znajdźToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.znajdźToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.znajdźToolStripMenuItem.Text = "Znajdź...";
            this.znajdźToolStripMenuItem.Click += new System.EventHandler(this.znajdźToolStripMenuItem_Click);
            // 
            // znajdźNastępnyToolStripMenuItem
            // 
            this.znajdźNastępnyToolStripMenuItem.Name = "znajdźNastępnyToolStripMenuItem";
            this.znajdźNastępnyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.znajdźNastępnyToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.znajdźNastępnyToolStripMenuItem.Text = "Znajdź następny";
            this.znajdźNastępnyToolStripMenuItem.Click += new System.EventHandler(this.znajdźNastępnyToolStripMenuItem_Click);
            // 
            // znajdźPoprzednieToolStripMenuItem
            // 
            this.znajdźPoprzednieToolStripMenuItem.Name = "znajdźPoprzednieToolStripMenuItem";
            this.znajdźPoprzednieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.znajdźPoprzednieToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.znajdźPoprzednieToolStripMenuItem.Text = "Znajdź poprzednie";
            this.znajdźPoprzednieToolStripMenuItem.Click += new System.EventHandler(this.znajdźPoprzednieToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(278, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // godzinadataToolStripMenuItem
            // 
            this.godzinadataToolStripMenuItem.Name = "godzinadataToolStripMenuItem";
            this.godzinadataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.godzinadataToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.godzinadataToolStripMenuItem.Text = "Godzina/data";
            this.godzinadataToolStripMenuItem.Click += new System.EventHandler(this.godzinadataToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Checked = true;
            this.formatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zawijanieWierszyToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // zawijanieWierszyToolStripMenuItem
            // 
            this.zawijanieWierszyToolStripMenuItem.AutoToolTip = true;
            this.zawijanieWierszyToolStripMenuItem.Checked = true;
            this.zawijanieWierszyToolStripMenuItem.CheckOnClick = true;
            this.zawijanieWierszyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zawijanieWierszyToolStripMenuItem.Name = "zawijanieWierszyToolStripMenuItem";
            this.zawijanieWierszyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zawijanieWierszyToolStripMenuItem.Text = "Zawijanie wierszy";
            this.zawijanieWierszyToolStripMenuItem.Click += new System.EventHandler(this.zawijanieWierszyToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.czcionkaToolStripMenuItem.Text = "Czcionka...";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasekStanuToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pasekStanuToolStripMenuItem
            // 
            this.pasekStanuToolStripMenuItem.Checked = true;
            this.pasekStanuToolStripMenuItem.CheckOnClick = true;
            this.pasekStanuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pasekStanuToolStripMenuItem.Name = "pasekStanuToolStripMenuItem";
            this.pasekStanuToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.pasekStanuToolStripMenuItem.Text = "Pasek stanu";
            this.pasekStanuToolStripMenuItem.Click += new System.EventHandler(this.pasekStanuToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notatnikInformacjeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // notatnikInformacjeToolStripMenuItem
            // 
            this.notatnikInformacjeToolStripMenuItem.Name = "notatnikInformacjeToolStripMenuItem";
            this.notatnikInformacjeToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.notatnikInformacjeToolStripMenuItem.Text = "O programie";
            this.notatnikInformacjeToolStripMenuItem.Click += new System.EventHandler(this.notatnikInformacjeToolStripMenuItem_Click);
            // 
            // Stopka
            // 
            this.Stopka.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Stopka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.liczba_znakow,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel3,
            this.pozycja_kursora,
            this.wielkosc,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.Stopka.Location = new System.Drawing.Point(0, 528);
            this.Stopka.Name = "Stopka";
            this.Stopka.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.Stopka.Size = new System.Drawing.Size(1067, 26);
            this.Stopka.TabIndex = 1;
            this.Stopka.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(93, 20);
            this.toolStripStatusLabel2.Text = "Ilość znaków";
            // 
            // liczba_znakow
            // 
            this.liczba_znakow.Name = "liczba_znakow";
            this.liczba_znakow.Size = new System.Drawing.Size(17, 20);
            this.liczba_znakow.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(605, 20);
            this.toolStripStatusLabel7.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(110, 20);
            this.toolStripStatusLabel3.Text = "Pozycja kursora";
            // 
            // pozycja_kursora
            // 
            this.pozycja_kursora.Name = "pozycja_kursora";
            this.pozycja_kursora.Size = new System.Drawing.Size(17, 20);
            this.pozycja_kursora.Text = "0";
            // 
            // wielkosc
            // 
            this.wielkosc.Name = "wielkosc";
            this.wielkosc.Size = new System.Drawing.Size(45, 20);
            this.wielkosc.Text = "100%";
            this.wielkosc.Click += new System.EventHandler(this.wielkosc_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(112, 20);
            this.toolStripStatusLabel5.Text = "Windows(CRLF)";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(48, 20);
            this.toolStripStatusLabel6.Text = "UTF-8";
            // 
            // textbox1
            // 
            this.textbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox1.Location = new System.Drawing.Point(0, 28);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.MaximumSize = new System.Drawing.Size(2559, 1328);
            this.textbox1.MinimumSize = new System.Drawing.Size(1065, 496);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(1067, 500);
            this.textbox1.TabIndex = 2;
            this.textbox1.Text = "";
            this.textbox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.textbox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Notatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Stopka);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notatnik";
            this.Text = "Notatnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Stopka.ResumeLayout(false);
            this.Stopka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void zmieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void wielkosc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void wyślijOpinięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void wyświetlPomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweOknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaStronyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem znajdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźNastępnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdźPoprzednieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godzinadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zawijanieWierszyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasekStanuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatnikInformacjeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Stopka;
        private System.Windows.Forms.RichTextBox textbox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel wielkosc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel liczba_znakow;
        private System.Windows.Forms.ToolStripStatusLabel pozycja_kursora;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

