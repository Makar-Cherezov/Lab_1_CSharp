
namespace CSharp_Lab1
{
    partial class Lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRand = new System.Windows.Forms.Button();
            this.comboBoxValues = new System.Windows.Forms.ComboBox();
            this.comboBoxSuites = new System.Windows.Forms.ComboBox();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOpp = new System.Windows.Forms.TextBox();
            this.buttonOpp = new System.Windows.Forms.Button();
            this.textBoxCompare = new System.Windows.Forms.TextBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.comboBoxTrump = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задайте свою карту:";
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(206, 215);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(163, 23);
            this.buttonRand.TabIndex = 2;
            this.buttonRand.Text = "Случайная карта";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
            // 
            // comboBoxValues
            // 
            this.comboBoxValues.FormattingEnabled = true;
            this.comboBoxValues.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "валет",
            "дама",
            "король",
            "туз"});
            this.comboBoxValues.Location = new System.Drawing.Point(63, 126);
            this.comboBoxValues.Name = "comboBoxValues";
            this.comboBoxValues.Size = new System.Drawing.Size(121, 24);
            this.comboBoxValues.TabIndex = 3;
            this.comboBoxValues.Text = "Значение";
            // 
            // comboBoxSuites
            // 
            this.comboBoxSuites.FormattingEnabled = true;
            this.comboBoxSuites.Items.AddRange(new object[] {
            "черви",
            "пики",
            "бубны",
            "крести"});
            this.comboBoxSuites.Location = new System.Drawing.Point(63, 87);
            this.comboBoxSuites.Name = "comboBoxSuites";
            this.comboBoxSuites.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSuites.TabIndex = 4;
            this.comboBoxSuites.Text = "Масть";
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(219, 87);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(131, 63);
            this.textBoxShow.TabIndex = 5;
            this.textBoxShow.Text = "Ваша карта:";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(219, 172);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(131, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Создайте карту оппонента \r\n(выберите значения из списков слева):";
            // 
            // textBoxOpp
            // 
            this.textBoxOpp.Enabled = false;
            this.textBoxOpp.Location = new System.Drawing.Point(443, 87);
            this.textBoxOpp.Multiline = true;
            this.textBoxOpp.Name = "textBoxOpp";
            this.textBoxOpp.Size = new System.Drawing.Size(131, 63);
            this.textBoxOpp.TabIndex = 8;
            this.textBoxOpp.Text = "Карта оппонента:";
            // 
            // buttonOpp
            // 
            this.buttonOpp.Location = new System.Drawing.Point(443, 172);
            this.buttonOpp.Name = "buttonOpp";
            this.buttonOpp.Size = new System.Drawing.Size(131, 23);
            this.buttonOpp.TabIndex = 9;
            this.buttonOpp.Text = "Создать";
            this.buttonOpp.UseVisualStyleBackColor = true;
            this.buttonOpp.Click += new System.EventHandler(this.buttonOpp_Click);
            // 
            // textBoxCompare
            // 
            this.textBoxCompare.Location = new System.Drawing.Point(663, 63);
            this.textBoxCompare.Multiline = true;
            this.textBoxCompare.Name = "textBoxCompare";
            this.textBoxCompare.Size = new System.Drawing.Size(131, 87);
            this.textBoxCompare.TabIndex = 10;
            this.textBoxCompare.Text = "Сравнить карты:";
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(663, 172);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(131, 23);
            this.buttonCompare.TabIndex = 11;
            this.buttonCompare.Text = "Сравнить карты";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // comboBoxTrump
            // 
            this.comboBoxTrump.FormattingEnabled = true;
            this.comboBoxTrump.Items.AddRange(new object[] {
            "черви",
            "пики",
            "бубны",
            "крести"});
            this.comboBoxTrump.Location = new System.Drawing.Point(811, 87);
            this.comboBoxTrump.Name = "comboBoxTrump";
            this.comboBoxTrump.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTrump.TabIndex = 12;
            this.comboBoxTrump.Text = "Козырь";
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.comboBoxTrump);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.textBoxCompare);
            this.Controls.Add(this.buttonOpp);
            this.Controls.Add(this.textBoxOpp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.comboBoxSuites);
            this.Controls.Add(this.comboBoxValues);
            this.Controls.Add(this.buttonRand);
            this.Controls.Add(this.label1);
            this.Name = "Lab1";
            this.Text = "Card Game";
            this.Load += new System.EventHandler(this.Lab1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.ComboBox comboBoxValues;
        private System.Windows.Forms.ComboBox comboBoxSuites;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOpp;
        private System.Windows.Forms.Button buttonOpp;
        private System.Windows.Forms.TextBox textBoxCompare;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.ComboBox comboBoxTrump;
    }
}

