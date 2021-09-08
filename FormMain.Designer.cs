namespace WinFormsProj
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.groupBoxPizza = new System.Windows.Forms.GroupBox();
            this.radioHawaiian = new System.Windows.Forms.RadioButton();
            this.radioMargarita = new System.Windows.Forms.RadioButton();
            this.radioChicken = new System.Windows.Forms.RadioButton();
            this.radioFourCheese = new System.Windows.Forms.RadioButton();
            this.radioDoublePepperoni = new System.Windows.Forms.RadioButton();
            this.radioPepperoni = new System.Windows.Forms.RadioButton();
            this.groupDrinks = new System.Windows.Forms.GroupBox();
            this.checkGreenTea = new System.Windows.Forms.CheckBox();
            this.checkBlackTea = new System.Windows.Forms.CheckBox();
            this.checkFanta = new System.Windows.Forms.CheckBox();
            this.checkSprite = new System.Windows.Forms.CheckBox();
            this.checkPepsi = new System.Windows.Forms.CheckBox();
            this.checkCola = new System.Windows.Forms.CheckBox();
            this.buttonBonus = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelSumm = new System.Windows.Forms.Label();
            this.labelPromo = new System.Windows.Forms.Label();
            this.textBoxPromo = new System.Windows.Forms.TextBox();
            this.labelFinal = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.saveCheck = new System.Windows.Forms.SaveFileDialog();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureHawaiian = new System.Windows.Forms.PictureBox();
            this.pictureMargarita = new System.Windows.Forms.PictureBox();
            this.pictureChicken = new System.Windows.Forms.PictureBox();
            this.pictureFourCheese = new System.Windows.Forms.PictureBox();
            this.pictureDoublePepperoni = new System.Windows.Forms.PictureBox();
            this.picturePepperoni = new System.Windows.Forms.PictureBox();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxPizza.SuspendLayout();
            this.groupDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHawaiian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMargarita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFourCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoublePepperoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePepperoni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioLarge);
            this.groupBoxSize.Controls.Add(this.radioMedium);
            this.groupBoxSize.Controls.Add(this.radioSmall);
            this.groupBoxSize.Location = new System.Drawing.Point(13, 14);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(344, 69);
            this.groupBoxSize.TabIndex = 0;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Выберите размер пиццы";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(233, 29);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(105, 17);
            this.radioLarge.TabIndex = 2;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Большая - 40см";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.CheckedChanged += new System.EventHandler(this.radioLarge_CheckedChanged);
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(112, 30);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(106, 17);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Средняя -  30см";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(6, 29);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(93, 17);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Малая - 23см";
            this.radioSmall.UseVisualStyleBackColor = true;
            this.radioSmall.CheckedChanged += new System.EventHandler(this.radioSmall_CheckedChanged);
            // 
            // groupBoxPizza
            // 
            this.groupBoxPizza.Controls.Add(this.radioHawaiian);
            this.groupBoxPizza.Controls.Add(this.radioMargarita);
            this.groupBoxPizza.Controls.Add(this.radioChicken);
            this.groupBoxPizza.Controls.Add(this.radioFourCheese);
            this.groupBoxPizza.Controls.Add(this.radioDoublePepperoni);
            this.groupBoxPizza.Controls.Add(this.radioPepperoni);
            this.groupBoxPizza.Controls.Add(this.pictureHawaiian);
            this.groupBoxPizza.Controls.Add(this.pictureMargarita);
            this.groupBoxPizza.Controls.Add(this.pictureChicken);
            this.groupBoxPizza.Controls.Add(this.pictureFourCheese);
            this.groupBoxPizza.Controls.Add(this.pictureDoublePepperoni);
            this.groupBoxPizza.Controls.Add(this.picturePepperoni);
            this.groupBoxPizza.Location = new System.Drawing.Point(13, 89);
            this.groupBoxPizza.Name = "groupBoxPizza";
            this.groupBoxPizza.Size = new System.Drawing.Size(419, 376);
            this.groupBoxPizza.TabIndex = 1;
            this.groupBoxPizza.TabStop = false;
            this.groupBoxPizza.Text = "Выберите пиццу";
            // 
            // radioHawaiian
            // 
            this.radioHawaiian.AutoSize = true;
            this.radioHawaiian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioHawaiian.Location = new System.Drawing.Point(292, 322);
            this.radioHawaiian.Name = "radioHawaiian";
            this.radioHawaiian.Size = new System.Drawing.Size(79, 17);
            this.radioHawaiian.TabIndex = 11;
            this.radioHawaiian.TabStop = true;
            this.radioHawaiian.Text = "Гавайская";
            this.radioHawaiian.UseVisualStyleBackColor = true;
            this.radioHawaiian.CheckedChanged += new System.EventHandler(this.radioHawaiian_CheckedChanged);
            // 
            // radioMargarita
            // 
            this.radioMargarita.AutoSize = true;
            this.radioMargarita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioMargarita.Location = new System.Drawing.Point(151, 322);
            this.radioMargarita.Name = "radioMargarita";
            this.radioMargarita.Size = new System.Drawing.Size(80, 17);
            this.radioMargarita.TabIndex = 10;
            this.radioMargarita.TabStop = true;
            this.radioMargarita.Text = "Маргарита";
            this.radioMargarita.UseVisualStyleBackColor = true;
            this.radioMargarita.CheckedChanged += new System.EventHandler(this.radioMargarita_CheckedChanged);
            // 
            // radioChicken
            // 
            this.radioChicken.AutoSize = true;
            this.radioChicken.Location = new System.Drawing.Point(17, 322);
            this.radioChicken.Name = "radioChicken";
            this.radioChicken.Size = new System.Drawing.Size(76, 17);
            this.radioChicken.TabIndex = 9;
            this.radioChicken.TabStop = true;
            this.radioChicken.Text = "С курицей";
            this.radioChicken.UseVisualStyleBackColor = true;
            this.radioChicken.CheckedChanged += new System.EventHandler(this.radioChicken_CheckedChanged);
            // 
            // radioFourCheese
            // 
            this.radioFourCheese.AutoSize = true;
            this.radioFourCheese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioFourCheese.Location = new System.Drawing.Point(292, 165);
            this.radioFourCheese.Name = "radioFourCheese";
            this.radioFourCheese.Size = new System.Drawing.Size(60, 17);
            this.radioFourCheese.TabIndex = 8;
            this.radioFourCheese.TabStop = true;
            this.radioFourCheese.Text = "4 сыра";
            this.radioFourCheese.UseVisualStyleBackColor = true;
            this.radioFourCheese.CheckedChanged += new System.EventHandler(this.radioFourCheese_CheckedChanged);
            // 
            // radioDoublePepperoni
            // 
            this.radioDoublePepperoni.AutoSize = true;
            this.radioDoublePepperoni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioDoublePepperoni.Location = new System.Drawing.Point(151, 158);
            this.radioDoublePepperoni.Name = "radioDoublePepperoni";
            this.radioDoublePepperoni.Size = new System.Drawing.Size(81, 30);
            this.radioDoublePepperoni.TabIndex = 7;
            this.radioDoublePepperoni.TabStop = true;
            this.radioDoublePepperoni.Text = "Двойная \r\nПепперони";
            this.radioDoublePepperoni.UseVisualStyleBackColor = true;
            this.radioDoublePepperoni.CheckedChanged += new System.EventHandler(this.radioDoublePepperoni_CheckedChanged);
            // 
            // radioPepperoni
            // 
            this.radioPepperoni.AutoSize = true;
            this.radioPepperoni.Location = new System.Drawing.Point(17, 165);
            this.radioPepperoni.Name = "radioPepperoni";
            this.radioPepperoni.Size = new System.Drawing.Size(81, 17);
            this.radioPepperoni.TabIndex = 6;
            this.radioPepperoni.TabStop = true;
            this.radioPepperoni.Text = "Пепперони";
            this.radioPepperoni.UseVisualStyleBackColor = true;
            this.radioPepperoni.CheckedChanged += new System.EventHandler(this.radioPepperoni_CheckedChanged);
            // 
            // groupDrinks
            // 
            this.groupDrinks.Controls.Add(this.checkGreenTea);
            this.groupDrinks.Controls.Add(this.checkBlackTea);
            this.groupDrinks.Controls.Add(this.checkFanta);
            this.groupDrinks.Controls.Add(this.checkSprite);
            this.groupDrinks.Controls.Add(this.checkPepsi);
            this.groupDrinks.Controls.Add(this.checkCola);
            this.groupDrinks.Location = new System.Drawing.Point(439, 13);
            this.groupDrinks.Name = "groupDrinks";
            this.groupDrinks.Size = new System.Drawing.Size(242, 163);
            this.groupDrinks.TabIndex = 2;
            this.groupDrinks.TabStop = false;
            this.groupDrinks.Text = "Выберите напитки (цена за 0,5 л)";
            // 
            // checkGreenTea
            // 
            this.checkGreenTea.AutoSize = true;
            this.checkGreenTea.Location = new System.Drawing.Point(113, 119);
            this.checkGreenTea.Name = "checkGreenTea";
            this.checkGreenTea.Size = new System.Drawing.Size(121, 17);
            this.checkGreenTea.TabIndex = 5;
            this.checkGreenTea.Text = "Зелёный чай (82р.)";
            this.checkGreenTea.UseVisualStyleBackColor = true;
            this.checkGreenTea.CheckStateChanged += new System.EventHandler(this.checkGreenTea_CheckStateChanged);
            // 
            // checkBlackTea
            // 
            this.checkBlackTea.AutoSize = true;
            this.checkBlackTea.Location = new System.Drawing.Point(113, 76);
            this.checkBlackTea.Name = "checkBlackTea";
            this.checkBlackTea.Size = new System.Drawing.Size(116, 17);
            this.checkBlackTea.TabIndex = 4;
            this.checkBlackTea.Text = "Чёрный чай (80р.)";
            this.checkBlackTea.UseVisualStyleBackColor = true;
            this.checkBlackTea.CheckStateChanged += new System.EventHandler(this.checkBlackTea_CheckStateChanged);
            // 
            // checkFanta
            // 
            this.checkFanta.AutoSize = true;
            this.checkFanta.Location = new System.Drawing.Point(113, 31);
            this.checkFanta.Name = "checkFanta";
            this.checkFanta.Size = new System.Drawing.Size(83, 17);
            this.checkFanta.TabIndex = 3;
            this.checkFanta.Text = "Fanta (75р.)";
            this.checkFanta.UseVisualStyleBackColor = true;
            this.checkFanta.CheckStateChanged += new System.EventHandler(this.checkFanta_CheckStateChanged);
            // 
            // checkSprite
            // 
            this.checkSprite.AutoSize = true;
            this.checkSprite.Location = new System.Drawing.Point(11, 119);
            this.checkSprite.Name = "checkSprite";
            this.checkSprite.Size = new System.Drawing.Size(83, 17);
            this.checkSprite.TabIndex = 2;
            this.checkSprite.Text = "Sprite (68р.)";
            this.checkSprite.UseVisualStyleBackColor = true;
            this.checkSprite.CheckStateChanged += new System.EventHandler(this.checkSprite_CheckStateChanged);
            // 
            // checkPepsi
            // 
            this.checkPepsi.AutoSize = true;
            this.checkPepsi.Location = new System.Drawing.Point(11, 76);
            this.checkPepsi.Name = "checkPepsi";
            this.checkPepsi.Size = new System.Drawing.Size(82, 17);
            this.checkPepsi.TabIndex = 1;
            this.checkPepsi.Text = "Pepsi (83р.)";
            this.checkPepsi.UseVisualStyleBackColor = true;
            this.checkPepsi.CheckStateChanged += new System.EventHandler(this.checkPepsi_CheckStateChanged);
            // 
            // checkCola
            // 
            this.checkCola.AutoSize = true;
            this.checkCola.Location = new System.Drawing.Point(11, 31);
            this.checkCola.Name = "checkCola";
            this.checkCola.Size = new System.Drawing.Size(105, 17);
            this.checkCola.TabIndex = 0;
            this.checkCola.Text = "Coca-Cola (78р.)";
            this.checkCola.UseVisualStyleBackColor = true;
            this.checkCola.CheckStateChanged += new System.EventHandler(this.checkCola_CheckStateChanged);
            // 
            // buttonBonus
            // 
            this.buttonBonus.Location = new System.Drawing.Point(439, 413);
            this.buttonBonus.Name = "buttonBonus";
            this.buttonBonus.Size = new System.Drawing.Size(242, 23);
            this.buttonBonus.TabIndex = 3;
            this.buttonBonus.Text = "Бонусные предложения";
            this.buttonBonus.UseVisualStyleBackColor = true;
            this.buttonBonus.Click += new System.EventHandler(this.buttonBonus_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(568, 442);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(439, 442);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(123, 23);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Информация";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(439, 384);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(242, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить заказ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(439, 355);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(242, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Подтвердить заказ и сохранить чек";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(438, 202);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(101, 13);
            this.labelSumm.TabIndex = 8;
            this.labelSumm.Text = "Сумма заказа: 0р.";
            // 
            // labelPromo
            // 
            this.labelPromo.AutoSize = true;
            this.labelPromo.Location = new System.Drawing.Point(439, 239);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(181, 13);
            this.labelPromo.TabIndex = 9;
            this.labelPromo.Text = "Введите промокод (если имеется)";
            // 
            // textBoxPromo
            // 
            this.textBoxPromo.Location = new System.Drawing.Point(439, 256);
            this.textBoxPromo.Name = "textBoxPromo";
            this.textBoxPromo.Size = new System.Drawing.Size(242, 20);
            this.textBoxPromo.TabIndex = 10;
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(436, 325);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(0, 13);
            this.labelFinal.TabIndex = 11;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(439, 283);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(242, 23);
            this.buttonApply.TabIndex = 12;
            this.buttonApply.Text = "Применить промокод";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::WinFormsProj.Properties.Resources.Logo;
            this.pictureLogo.Location = new System.Drawing.Point(363, 14);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(69, 69);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 13;
            this.pictureLogo.TabStop = false;
            // 
            // pictureHawaiian
            // 
            this.pictureHawaiian.Image = global::WinFormsProj.Properties.Resources.Hawaiian;
            this.pictureHawaiian.Location = new System.Drawing.Point(292, 202);
            this.pictureHawaiian.Name = "pictureHawaiian";
            this.pictureHawaiian.Size = new System.Drawing.Size(100, 100);
            this.pictureHawaiian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHawaiian.TabIndex = 5;
            this.pictureHawaiian.TabStop = false;
            // 
            // pictureMargarita
            // 
            this.pictureMargarita.Image = global::WinFormsProj.Properties.Resources.Margarita;
            this.pictureMargarita.Location = new System.Drawing.Point(151, 202);
            this.pictureMargarita.Name = "pictureMargarita";
            this.pictureMargarita.Size = new System.Drawing.Size(100, 100);
            this.pictureMargarita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMargarita.TabIndex = 4;
            this.pictureMargarita.TabStop = false;
            // 
            // pictureChicken
            // 
            this.pictureChicken.Image = global::WinFormsProj.Properties.Resources.Chicken;
            this.pictureChicken.Location = new System.Drawing.Point(17, 202);
            this.pictureChicken.Name = "pictureChicken";
            this.pictureChicken.Size = new System.Drawing.Size(100, 100);
            this.pictureChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureChicken.TabIndex = 3;
            this.pictureChicken.TabStop = false;
            // 
            // pictureFourCheese
            // 
            this.pictureFourCheese.Image = global::WinFormsProj.Properties.Resources.Fourcheese;
            this.pictureFourCheese.Location = new System.Drawing.Point(292, 42);
            this.pictureFourCheese.Name = "pictureFourCheese";
            this.pictureFourCheese.Size = new System.Drawing.Size(100, 100);
            this.pictureFourCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFourCheese.TabIndex = 2;
            this.pictureFourCheese.TabStop = false;
            // 
            // pictureDoublePepperoni
            // 
            this.pictureDoublePepperoni.Image = global::WinFormsProj.Properties.Resources.DoublePepperoni;
            this.pictureDoublePepperoni.Location = new System.Drawing.Point(151, 42);
            this.pictureDoublePepperoni.Name = "pictureDoublePepperoni";
            this.pictureDoublePepperoni.Size = new System.Drawing.Size(100, 100);
            this.pictureDoublePepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDoublePepperoni.TabIndex = 1;
            this.pictureDoublePepperoni.TabStop = false;
            // 
            // picturePepperoni
            // 
            this.picturePepperoni.Image = global::WinFormsProj.Properties.Resources.Pepperoni;
            this.picturePepperoni.Location = new System.Drawing.Point(17, 42);
            this.picturePepperoni.Name = "picturePepperoni";
            this.picturePepperoni.Size = new System.Drawing.Size(100, 100);
            this.picturePepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePepperoni.TabIndex = 0;
            this.picturePepperoni.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 477);
            this.ControlBox = false;
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.textBoxPromo);
            this.Controls.Add(this.labelPromo);
            this.Controls.Add(this.labelSumm);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBonus);
            this.Controls.Add(this.groupDrinks);
            this.Controls.Add(this.groupBoxPizza);
            this.Controls.Add(this.groupBoxSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria";
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxPizza.ResumeLayout(false);
            this.groupBoxPizza.PerformLayout();
            this.groupDrinks.ResumeLayout(false);
            this.groupDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHawaiian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMargarita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFourCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoublePepperoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePepperoni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.GroupBox groupBoxPizza;
        private System.Windows.Forms.GroupBox groupDrinks;
        private System.Windows.Forms.Button buttonBonus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioHawaiian;
        private System.Windows.Forms.RadioButton radioMargarita;
        private System.Windows.Forms.RadioButton radioChicken;
        private System.Windows.Forms.RadioButton radioFourCheese;
        private System.Windows.Forms.RadioButton radioDoublePepperoni;
        private System.Windows.Forms.RadioButton radioPepperoni;
        private System.Windows.Forms.PictureBox pictureHawaiian;
        private System.Windows.Forms.PictureBox pictureMargarita;
        private System.Windows.Forms.PictureBox pictureChicken;
        private System.Windows.Forms.PictureBox pictureFourCheese;
        private System.Windows.Forms.PictureBox pictureDoublePepperoni;
        private System.Windows.Forms.PictureBox picturePepperoni;
        private System.Windows.Forms.CheckBox checkGreenTea;
        private System.Windows.Forms.CheckBox checkBlackTea;
        private System.Windows.Forms.CheckBox checkFanta;
        private System.Windows.Forms.CheckBox checkSprite;
        private System.Windows.Forms.CheckBox checkPepsi;
        private System.Windows.Forms.CheckBox checkCola;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelSumm;
        private System.Windows.Forms.Label labelPromo;
        private System.Windows.Forms.TextBox textBoxPromo;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.SaveFileDialog saveCheck;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}

