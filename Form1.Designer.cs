
namespace GestionParking
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button_reini = new System.Windows.Forms.Button();
            this.button_actualiser_space = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_save_v = new System.Windows.Forms.Button();
            this.textBox_largeur = new System.Windows.Forms.TextBox();
            this.textBox_temps = new System.Windows.Forms.TextBox();
            this.textBox_longueur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.button_actualiser_place = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button_place = new System.Windows.Forms.Button();
            this.textBox_largeur_place = new System.Windows.Forms.TextBox();
            this.textBox_longueur_place = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_actualiser_l_a = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.attribution = new System.Windows.Forms.TabPage();
            this.button_liberer_v = new System.Windows.Forms.Button();
            this.comboBox_liste_vp = new System.Windows.Forms.ComboBox();
            this.button1_attribution = new System.Windows.Forms.Button();
            this.comboBox_voiture = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.attribution.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 379);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button_reini);
            this.panel2.Controls.Add(this.button_actualiser_space);
            this.panel2.Location = new System.Drawing.Point(856, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 336);
            this.panel2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(7, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tableau de Bord";
            // 
            // button_reini
            // 
            this.button_reini.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_reini.Location = new System.Drawing.Point(20, 165);
            this.button_reini.Name = "button_reini";
            this.button_reini.Size = new System.Drawing.Size(106, 32);
            this.button_reini.TabIndex = 3;
            this.button_reini.Text = "réinitialiser";
            this.button_reini.UseVisualStyleBackColor = true;
            // 
            // button_actualiser_space
            // 
            this.button_actualiser_space.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_actualiser_space.Location = new System.Drawing.Point(20, 97);
            this.button_actualiser_space.Name = "button_actualiser_space";
            this.button_actualiser_space.Size = new System.Drawing.Size(106, 32);
            this.button_actualiser_space.TabIndex = 2;
            this.button_actualiser_space.Text = "actualiser";
            this.button_actualiser_space.UseVisualStyleBackColor = true;
            this.button_actualiser_space.Click += new System.EventHandler(this.button_liste_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.attribution);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.button_save_v);
            this.tabPage1.Controls.Add(this.textBox_largeur);
            this.tabPage1.Controls.Add(this.textBox_temps);
            this.tabPage1.Controls.Add(this.textBox_longueur);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nouveau ";
            // 
            // button_save_v
            // 
            this.button_save_v.Location = new System.Drawing.Point(465, 260);
            this.button_save_v.Name = "button_save_v";
            this.button_save_v.Size = new System.Drawing.Size(169, 33);
            this.button_save_v.TabIndex = 7;
            this.button_save_v.Text = "enregistrer";
            this.button_save_v.UseVisualStyleBackColor = true;
            this.button_save_v.Click += new System.EventHandler(this.button_save_v_Click);
            // 
            // textBox_largeur
            // 
            this.textBox_largeur.Location = new System.Drawing.Point(385, 115);
            this.textBox_largeur.Name = "textBox_largeur";
            this.textBox_largeur.Size = new System.Drawing.Size(249, 27);
            this.textBox_largeur.TabIndex = 6;
            // 
            // textBox_temps
            // 
            this.textBox_temps.Location = new System.Drawing.Point(385, 165);
            this.textBox_temps.Name = "textBox_temps";
            this.textBox_temps.Size = new System.Drawing.Size(249, 27);
            this.textBox_temps.TabIndex = 5;
            // 
            // textBox_longueur
            // 
            this.textBox_longueur.Location = new System.Drawing.Point(385, 72);
            this.textBox_longueur.Name = "textBox_longueur";
            this.textBox_longueur.Size = new System.Drawing.Size(249, 27);
            this.textBox_longueur.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(255, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "temps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(255, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "largeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(255, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Longueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(388, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ajouter une Voiture";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "liste des voitures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(723, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(347, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Liste des Voitures";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.button_actualiser_place);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.button_place);
            this.tabPage3.Controls.Add(this.textBox_largeur_place);
            this.tabPage3.Controls.Add(this.textBox_longueur_place);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(839, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Place";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(32, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "PLACE";
            // 
            // button_actualiser_place
            // 
            this.button_actualiser_place.Location = new System.Drawing.Point(730, 115);
            this.button_actualiser_place.Name = "button_actualiser_place";
            this.button_actualiser_place.Size = new System.Drawing.Size(75, 23);
            this.button_actualiser_place.TabIndex = 6;
            this.button_actualiser_place.Text = "actualiser";
            this.button_actualiser_place.UseVisualStyleBackColor = true;
            this.button_actualiser_place.Click += new System.EventHandler(this.button_actualiser_place_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 163);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(833, 163);
            this.dataGridView3.TabIndex = 5;
            // 
            // button_place
            // 
            this.button_place.Location = new System.Drawing.Point(730, 60);
            this.button_place.Name = "button_place";
            this.button_place.Size = new System.Drawing.Size(75, 23);
            this.button_place.TabIndex = 4;
            this.button_place.Text = "enregistrer";
            this.button_place.UseVisualStyleBackColor = true;
            this.button_place.Click += new System.EventHandler(this.button_place_Click);
            // 
            // textBox_largeur_place
            // 
            this.textBox_largeur_place.Location = new System.Drawing.Point(353, 115);
            this.textBox_largeur_place.Name = "textBox_largeur_place";
            this.textBox_largeur_place.Size = new System.Drawing.Size(153, 23);
            this.textBox_largeur_place.TabIndex = 3;
            // 
            // textBox_longueur_place
            // 
            this.textBox_longueur_place.Location = new System.Drawing.Point(353, 60);
            this.textBox_longueur_place.Name = "textBox_longueur_place";
            this.textBox_longueur_place.Size = new System.Drawing.Size(153, 23);
            this.textBox_longueur_place.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(218, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "largeur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(218, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Longueur";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_actualiser_l_a);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(839, 332);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Liste d\'attente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_actualiser_l_a
            // 
            this.button_actualiser_l_a.Location = new System.Drawing.Point(758, 56);
            this.button_actualiser_l_a.Name = "button_actualiser_l_a";
            this.button_actualiser_l_a.Size = new System.Drawing.Size(75, 23);
            this.button_actualiser_l_a.TabIndex = 2;
            this.button_actualiser_l_a.Text = "Actualiser";
            this.button_actualiser_l_a.UseVisualStyleBackColor = true;
            this.button_actualiser_l_a.Click += new System.EventHandler(this.button_actualiser_l_a_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(310, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Liste d\'attente des voitures";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 97);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(827, 229);
            this.dataGridView4.TabIndex = 0;
            // 
            // attribution
            // 
            this.attribution.Controls.Add(this.button_liberer_v);
            this.attribution.Controls.Add(this.comboBox_liste_vp);
            this.attribution.Controls.Add(this.button1_attribution);
            this.attribution.Controls.Add(this.comboBox_voiture);
            this.attribution.Controls.Add(this.label11);
            this.attribution.Location = new System.Drawing.Point(4, 24);
            this.attribution.Name = "attribution";
            this.attribution.Padding = new System.Windows.Forms.Padding(3);
            this.attribution.Size = new System.Drawing.Size(839, 332);
            this.attribution.TabIndex = 4;
            this.attribution.Text = "attribution";
            this.attribution.UseVisualStyleBackColor = true;
            // 
            // button_liberer_v
            // 
            this.button_liberer_v.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_liberer_v.Location = new System.Drawing.Point(514, 252);
            this.button_liberer_v.Name = "button_liberer_v";
            this.button_liberer_v.Size = new System.Drawing.Size(75, 23);
            this.button_liberer_v.TabIndex = 4;
            this.button_liberer_v.Text = "liberer";
            this.button_liberer_v.UseVisualStyleBackColor = true;
            this.button_liberer_v.Click += new System.EventHandler(this.button_liberer_v_Click);
            // 
            // comboBox_liste_vp
            // 
            this.comboBox_liste_vp.FormattingEnabled = true;
            this.comboBox_liste_vp.Location = new System.Drawing.Point(250, 206);
            this.comboBox_liste_vp.Name = "comboBox_liste_vp";
            this.comboBox_liste_vp.Size = new System.Drawing.Size(339, 23);
            this.comboBox_liste_vp.TabIndex = 3;
            // 
            // button1_attribution
            // 
            this.button1_attribution.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_attribution.Location = new System.Drawing.Point(514, 155);
            this.button1_attribution.Name = "button1_attribution";
            this.button1_attribution.Size = new System.Drawing.Size(75, 23);
            this.button1_attribution.TabIndex = 2;
            this.button1_attribution.Text = "attribuer";
            this.button1_attribution.UseVisualStyleBackColor = true;
            this.button1_attribution.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_voiture
            // 
            this.comboBox_voiture.FormattingEnabled = true;
            this.comboBox_voiture.Location = new System.Drawing.Point(250, 106);
            this.comboBox_voiture.Name = "comboBox_voiture";
            this.comboBox_voiture.Size = new System.Drawing.Size(339, 23);
            this.comboBox_voiture.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(290, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "ATTRIBUTION DES VOITURES";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(839, 332);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Occupation";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(827, 254);
            this.dataGridView2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(326, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Voitures et Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION PARKING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.attribution.ResumeLayout(false);
            this.attribution.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_save_v;
        private System.Windows.Forms.TextBox textBox_largeur;
        private System.Windows.Forms.TextBox textBox_temps;
        private System.Windows.Forms.TextBox textBox_longueur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_place;
        private System.Windows.Forms.TextBox textBox_largeur_place;
        private System.Windows.Forms.TextBox textBox_longueur_place;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button_reini;
        private System.Windows.Forms.Button button_actualiser_space;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button_actualiser_l_a;
        private System.Windows.Forms.TabPage attribution;
        private System.Windows.Forms.Button button1_attribution;
        private System.Windows.Forms.ComboBox comboBox_voiture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_actualiser_place;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_liberer_v;
        private System.Windows.Forms.ComboBox comboBox_liste_vp;
    }
}

