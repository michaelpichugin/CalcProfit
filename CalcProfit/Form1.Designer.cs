namespace CalcProfit
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.btnTaxes = new MaterialSkin.Controls.MaterialSwitch();
            this.btnSteam = new MaterialSkin.Controls.MaterialButton();
            this.btnDmarket = new MaterialSkin.Controls.MaterialButton();
            this.btnBuff = new MaterialSkin.Controls.MaterialButton();
            this.btnTm = new MaterialSkin.Controls.MaterialButton();
            this.btnI = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtBuy
            // 
            this.txtBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBuy.Location = new System.Drawing.Point(177, 74);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(219, 38);
            this.txtBuy.TabIndex = 0;
            this.txtBuy.TextChanged += new System.EventHandler(this.txtBuy_TextChanged);
            // 
            // txtSell
            // 
            this.txtSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSell.Location = new System.Drawing.Point(177, 118);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(219, 38);
            this.txtSell.TabIndex = 1;
            this.txtSell.TextChanged += new System.EventHandler(this.txtSell_TextChanged);
            // 
            // txtRent
            // 
            this.txtRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRent.Location = new System.Drawing.Point(210, 191);
            this.txtRent.Name = "txtRent";
            this.txtRent.ReadOnly = true;
            this.txtRent.Size = new System.Drawing.Size(219, 31);
            this.txtRent.TabIndex = 2;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRent.ForeColor = System.Drawing.Color.Green;
            this.lblRent.Location = new System.Drawing.Point(210, 167);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(219, 29);
            this.lblRent.TabIndex = 3;
            this.lblRent.Text = "Рентабельность";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuy.Location = new System.Drawing.Point(20, 83);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(151, 25);
            this.lblBuy.TabIndex = 4;
            this.lblBuy.Text = "Цена покупки";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSell.Location = new System.Drawing.Point(14, 124);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(157, 25);
            this.lblSell.TabIndex = 5;
            this.lblSell.Text = "Цена продажи";
            // 
            // txtTaxes
            // 
            this.txtTaxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaxes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTaxes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTaxes.Location = new System.Drawing.Point(409, 121);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.ReadOnly = true;
            this.txtTaxes.Size = new System.Drawing.Size(198, 31);
            this.txtTaxes.TabIndex = 6;
            // 
            // btnTaxes
            // 
            this.btnTaxes.AutoSize = true;
            this.btnTaxes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaxes.Depth = 0;
            this.btnTaxes.Location = new System.Drawing.Point(420, 81);
            this.btnTaxes.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaxes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnTaxes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaxes.Name = "btnTaxes";
            this.btnTaxes.Ripple = true;
            this.btnTaxes.Size = new System.Drawing.Size(166, 37);
            this.btnTaxes.TabIndex = 8;
            this.btnTaxes.Text = "Комиссия 13%";
            this.btnTaxes.UseVisualStyleBackColor = true;
            this.btnTaxes.CheckedChanged += new System.EventHandler(this.btnTaxes_CheckedChanged);
            // 
            // btnSteam
            // 
            this.btnSteam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSteam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSteam.Depth = 0;
            this.btnSteam.HighEmphasis = true;
            this.btnSteam.Icon = null;
            this.btnSteam.Location = new System.Drawing.Point(7, 237);
            this.btnSteam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSteam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSteam.Name = "btnSteam";
            this.btnSteam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSteam.Size = new System.Drawing.Size(70, 36);
            this.btnSteam.TabIndex = 9;
            this.btnSteam.Text = "Steam";
            this.btnSteam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSteam.UseAccentColor = false;
            this.btnSteam.UseVisualStyleBackColor = true;
            this.btnSteam.Click += new System.EventHandler(this.btnSteam_Click);
            // 
            // btnDmarket
            // 
            this.btnDmarket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDmarket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDmarket.Depth = 0;
            this.btnDmarket.HighEmphasis = true;
            this.btnDmarket.Icon = null;
            this.btnDmarket.Location = new System.Drawing.Point(85, 237);
            this.btnDmarket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDmarket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDmarket.Name = "btnDmarket";
            this.btnDmarket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDmarket.Size = new System.Drawing.Size(89, 36);
            this.btnDmarket.TabIndex = 10;
            this.btnDmarket.Text = "Dmarket";
            this.btnDmarket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDmarket.UseAccentColor = false;
            this.btnDmarket.UseVisualStyleBackColor = true;
            this.btnDmarket.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnBuff
            // 
            this.btnBuff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuff.Depth = 0;
            this.btnBuff.HighEmphasis = true;
            this.btnBuff.Icon = null;
            this.btnBuff.Location = new System.Drawing.Point(182, 237);
            this.btnBuff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuff.Name = "btnBuff";
            this.btnBuff.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuff.Size = new System.Drawing.Size(64, 36);
            this.btnBuff.TabIndex = 11;
            this.btnBuff.Text = "BUFF";
            this.btnBuff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuff.UseAccentColor = false;
            this.btnBuff.UseVisualStyleBackColor = true;
            this.btnBuff.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btnTm
            // 
            this.btnTm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTm.Depth = 0;
            this.btnTm.HighEmphasis = true;
            this.btnTm.Icon = null;
            this.btnTm.Location = new System.Drawing.Point(254, 237);
            this.btnTm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTm.Name = "btnTm";
            this.btnTm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTm.Size = new System.Drawing.Size(64, 36);
            this.btnTm.TabIndex = 12;
            this.btnTm.Text = "TM";
            this.btnTm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTm.UseAccentColor = false;
            this.btnTm.UseVisualStyleBackColor = true;
            this.btnTm.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // btnI
            // 
            this.btnI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnI.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnI.Depth = 0;
            this.btnI.HighEmphasis = true;
            this.btnI.Icon = null;
            this.btnI.Location = new System.Drawing.Point(509, 237);
            this.btnI.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnI.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnI.Name = "btnI";
            this.btnI.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnI.Size = new System.Drawing.Size(97, 36);
            this.btnI.TabIndex = 13;
            this.btnI.Text = "pecheNka";
            this.btnI.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnI.UseAccentColor = false;
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(555, 212);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "ver. 1.0";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 282);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnTm);
            this.Controls.Add(this.btnBuff);
            this.Controls.Add(this.btnDmarket);
            this.Controls.Add(this.btnSteam);
            this.Controls.Add(this.btnTaxes);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.txtSell);
            this.Controls.Add(this.txtBuy);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(257, 216);
            this.Name = "frmMain";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Калькулятор рентабельности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuy;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.TextBox txtTaxes;
        private MaterialSkin.Controls.MaterialSwitch btnTaxes;
        private MaterialSkin.Controls.MaterialButton btnSteam;
        private MaterialSkin.Controls.MaterialButton btnDmarket;
        private MaterialSkin.Controls.MaterialButton btnBuff;
        private MaterialSkin.Controls.MaterialButton btnTm;
        private MaterialSkin.Controls.MaterialButton btnI;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

