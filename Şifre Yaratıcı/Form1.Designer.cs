namespace Şifre_Yaratıcı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSayi = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbBuyuk = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbOzel = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbKucuk = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtsifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.sifreuzunlugu = new MaterialSkin.Controls.MaterialSlider();
            this.btnolustur = new MaterialSkin.Controls.MaterialButton();
            this.swTema = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // cbSayi
            // 
            this.cbSayi.AutoSize = true;
            this.cbSayi.BackColor = System.Drawing.Color.Transparent;
            this.cbSayi.Depth = 0;
            this.cbSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSayi.Location = new System.Drawing.Point(255, 250);
            this.cbSayi.Margin = new System.Windows.Forms.Padding(0);
            this.cbSayi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbSayi.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbSayi.Name = "cbSayi";
            this.cbSayi.ReadOnly = false;
            this.cbSayi.Ripple = true;
            this.cbSayi.Size = new System.Drawing.Size(66, 37);
            this.cbSayi.TabIndex = 13;
            this.cbSayi.Text = "Sayı";
            this.cbSayi.UseVisualStyleBackColor = false;
            // 
            // cbBuyuk
            // 
            this.cbBuyuk.AutoSize = true;
            this.cbBuyuk.BackColor = System.Drawing.Color.Transparent;
            this.cbBuyuk.Depth = 0;
            this.cbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBuyuk.Location = new System.Drawing.Point(81, 186);
            this.cbBuyuk.Margin = new System.Windows.Forms.Padding(0);
            this.cbBuyuk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbBuyuk.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbBuyuk.Name = "cbBuyuk";
            this.cbBuyuk.ReadOnly = false;
            this.cbBuyuk.Ripple = true;
            this.cbBuyuk.Size = new System.Drawing.Size(129, 37);
            this.cbBuyuk.TabIndex = 14;
            this.cbBuyuk.Text = "BÜYÜK HARF";
            this.cbBuyuk.UseVisualStyleBackColor = false;
            // 
            // cbOzel
            // 
            this.cbOzel.AutoSize = true;
            this.cbOzel.BackColor = System.Drawing.Color.Transparent;
            this.cbOzel.Depth = 0;
            this.cbOzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOzel.Location = new System.Drawing.Point(81, 250);
            this.cbOzel.Margin = new System.Windows.Forms.Padding(0);
            this.cbOzel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbOzel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbOzel.Name = "cbOzel";
            this.cbOzel.ReadOnly = false;
            this.cbOzel.Ripple = true;
            this.cbOzel.Size = new System.Drawing.Size(148, 37);
            this.cbOzel.TabIndex = 15;
            this.cbOzel.Text = "Özel karakter(#)";
            this.cbOzel.UseVisualStyleBackColor = false;
            // 
            // cbKucuk
            // 
            this.cbKucuk.AutoSize = true;
            this.cbKucuk.BackColor = System.Drawing.Color.Transparent;
            this.cbKucuk.Depth = 0;
            this.cbKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKucuk.Location = new System.Drawing.Point(255, 186);
            this.cbKucuk.Margin = new System.Windows.Forms.Padding(0);
            this.cbKucuk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbKucuk.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbKucuk.Name = "cbKucuk";
            this.cbKucuk.ReadOnly = false;
            this.cbKucuk.Ripple = true;
            this.cbKucuk.Size = new System.Drawing.Size(110, 37);
            this.cbKucuk.TabIndex = 16;
            this.cbKucuk.Text = "küçük harf";
            this.cbKucuk.UseVisualStyleBackColor = false;
            // 
            // txtsifre
            // 
            this.txtsifre.AnimateReadOnly = false;
            this.txtsifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtsifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtsifre.Depth = 0;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtsifre.HideSelection = true;
            this.txtsifre.LeadingIcon = null;
            this.txtsifre.Location = new System.Drawing.Point(98, 311);
            this.txtsifre.MaxLength = 32767;
            this.txtsifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '\0';
            this.txtsifre.PrefixSuffixText = null;
            this.txtsifre.ReadOnly = true;
            this.txtsifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtsifre.SelectedText = "";
            this.txtsifre.SelectionLength = 0;
            this.txtsifre.SelectionStart = 0;
            this.txtsifre.ShortcutsEnabled = true;
            this.txtsifre.Size = new System.Drawing.Size(250, 48);
            this.txtsifre.TabIndex = 12;
            this.txtsifre.TabStop = false;
            this.txtsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsifre.TrailingIcon = null;
            this.txtsifre.UseSystemPasswordChar = false;
            // 
            // sifreuzunlugu
            // 
            this.sifreuzunlugu.Depth = 0;
            this.sifreuzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreuzunlugu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sifreuzunlugu.Location = new System.Drawing.Point(98, 133);
            this.sifreuzunlugu.MouseState = MaterialSkin.MouseState.HOVER;
            this.sifreuzunlugu.Name = "sifreuzunlugu";
            this.sifreuzunlugu.RangeMax = 20;
            this.sifreuzunlugu.Size = new System.Drawing.Size(250, 40);
            this.sifreuzunlugu.TabIndex = 11;
            this.sifreuzunlugu.TabStop = false;
            this.sifreuzunlugu.Text = "Şifre Uzunluğu";
            this.sifreuzunlugu.Value = 4;
            this.sifreuzunlugu.ValueMax = 20;
            // 
            // btnolustur
            // 
            this.btnolustur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnolustur.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnolustur.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnolustur.Depth = 0;
            this.btnolustur.HighEmphasis = true;
            this.btnolustur.Icon = null;
            this.btnolustur.Location = new System.Drawing.Point(150, 383);
            this.btnolustur.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnolustur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnolustur.Size = new System.Drawing.Size(128, 36);
            this.btnolustur.TabIndex = 10;
            this.btnolustur.Text = "Şifre Oluştur";
            this.btnolustur.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnolustur.UseAccentColor = false;
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // swTema
            // 
            this.swTema.AutoSize = true;
            this.swTema.BackColor = System.Drawing.Color.Transparent;
            this.swTema.Depth = 0;
            this.swTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.swTema.Location = new System.Drawing.Point(110, 78);
            this.swTema.Margin = new System.Windows.Forms.Padding(0);
            this.swTema.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.swTema.Name = "swTema";
            this.swTema.Ripple = true;
            this.swTema.Size = new System.Drawing.Size(224, 37);
            this.swTema.TabIndex = 9;
            this.swTema.Text = "Aydınlık/Karanlık Tema";
            this.swTema.UseVisualStyleBackColor = false;
            this.swTema.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 455);
            this.Controls.Add(this.cbSayi);
            this.Controls.Add(this.cbBuyuk);
            this.Controls.Add(this.cbOzel);
            this.Controls.Add(this.cbKucuk);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.sifreuzunlugu);
            this.Controls.Add(this.btnolustur);
            this.Controls.Add(this.swTema);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Şifre Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox cbSayi;
        private MaterialSkin.Controls.MaterialCheckbox cbBuyuk;
        private MaterialSkin.Controls.MaterialCheckbox cbOzel;
        private MaterialSkin.Controls.MaterialCheckbox cbKucuk;
        private MaterialSkin.Controls.MaterialTextBox2 txtsifre;
        private MaterialSkin.Controls.MaterialSlider sifreuzunlugu;
        private MaterialSkin.Controls.MaterialButton btnolustur;
        private MaterialSkin.Controls.MaterialSwitch swTema;
    }
}

