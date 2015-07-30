namespace Windows_Defender
{
    partial class FormSettings
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
            if (disposing && (components != null)) {
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
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelDevInfo = new System.Windows.Forms.Label();
            this.labelDevName = new System.Windows.Forms.Label();
            this.labelSupport = new System.Windows.Forms.Label();
            this.linkLabelForum = new System.Windows.Forms.LinkLabel();
            this.labelDonate1 = new System.Windows.Forms.Label();
            this.labelDonate2 = new System.Windows.Forms.Label();
            this.groupBoxIconChoose = new System.Windows.Forms.GroupBox();
            this.radioButtonIconShield = new System.Windows.Forms.RadioButton();
            this.radioButtonIcon10 = new System.Windows.Forms.RadioButton();
            this.radioButtonIcon8 = new System.Windows.Forms.RadioButton();
            this.radioButtonIcon7 = new System.Windows.Forms.RadioButton();
            this.radioButtonLangRu = new System.Windows.Forms.RadioButton();
            this.radioButtonLangEn = new System.Windows.Forms.RadioButton();
            this.groupBoxLangChoose = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxWMR = new System.Windows.Forms.TextBox();
            this.textBoxWMZ = new System.Windows.Forms.TextBox();
            this.checkBoxContextIcons = new System.Windows.Forms.CheckBox();
            this.checkBoxOneClick = new System.Windows.Forms.CheckBox();
            this.groupBoxIconChoose.SuspendLayout();
            this.groupBoxLangChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(50, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(62, 13);
            this.labelSettings.TabIndex = 4;
            this.labelSettings.Text = "Настройки";
            // 
            // labelDevInfo
            // 
            this.labelDevInfo.AutoSize = true;
            this.labelDevInfo.Location = new System.Drawing.Point(172, 9);
            this.labelDevInfo.Name = "labelDevInfo";
            this.labelDevInfo.Size = new System.Drawing.Size(155, 13);
            this.labelDevInfo.TabIndex = 6;
            this.labelDevInfo.Text = "Информация о разработчике";
            // 
            // labelDevName
            // 
            this.labelDevName.AutoSize = true;
            this.labelDevName.Location = new System.Drawing.Point(172, 36);
            this.labelDevName.Name = "labelDevName";
            this.labelDevName.Size = new System.Drawing.Size(163, 13);
            this.labelDevName.TabIndex = 8;
            this.labelDevName.Text = "Клименков Владислав, 2015 г.";
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Location = new System.Drawing.Point(172, 75);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(219, 13);
            this.labelSupport.TabIndex = 10;
            this.labelSupport.Text = "По всем вопросам обращаться на форум";
            // 
            // linkLabelForum
            // 
            this.linkLabelForum.AutoSize = true;
            this.linkLabelForum.Location = new System.Drawing.Point(172, 98);
            this.linkLabelForum.Name = "linkLabelForum";
            this.linkLabelForum.Size = new System.Drawing.Size(184, 13);
            this.linkLabelForum.TabIndex = 11;
            this.linkLabelForum.TabStop = true;
            this.linkLabelForum.Text = "http://pcportal.org.ru/forum/8-4442-1";
            this.linkLabelForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForum_LinkClicked);
            // 
            // labelDonate1
            // 
            this.labelDonate1.AutoSize = true;
            this.labelDonate1.Location = new System.Drawing.Point(172, 135);
            this.labelDonate1.Name = "labelDonate1";
            this.labelDonate1.Size = new System.Drawing.Size(193, 13);
            this.labelDonate1.TabIndex = 12;
            this.labelDonate1.Text = "Если вам понравилась программа и";
            // 
            // labelDonate2
            // 
            this.labelDonate2.AutoSize = true;
            this.labelDonate2.Location = new System.Drawing.Point(172, 149);
            this.labelDonate2.Name = "labelDonate2";
            this.labelDonate2.Size = new System.Drawing.Size(197, 13);
            this.labelDonate2.TabIndex = 13;
            this.labelDonate2.Text = "вы хотите поддержать разработчика:";
            // 
            // groupBoxIconChoose
            // 
            this.groupBoxIconChoose.Controls.Add(this.radioButtonIconShield);
            this.groupBoxIconChoose.Controls.Add(this.radioButtonIcon10);
            this.groupBoxIconChoose.Controls.Add(this.radioButtonIcon8);
            this.groupBoxIconChoose.Controls.Add(this.radioButtonIcon7);
            this.groupBoxIconChoose.Location = new System.Drawing.Point(26, 36);
            this.groupBoxIconChoose.Name = "groupBoxIconChoose";
            this.groupBoxIconChoose.Size = new System.Drawing.Size(124, 116);
            this.groupBoxIconChoose.TabIndex = 16;
            this.groupBoxIconChoose.TabStop = false;
            this.groupBoxIconChoose.Text = "Выбор иконки";
            // 
            // radioButtonIconShield
            // 
            this.radioButtonIconShield.AutoSize = true;
            this.radioButtonIconShield.Location = new System.Drawing.Point(6, 90);
            this.radioButtonIconShield.Name = "radioButtonIconShield";
            this.radioButtonIconShield.Size = new System.Drawing.Size(54, 17);
            this.radioButtonIconShield.TabIndex = 26;
            this.radioButtonIconShield.TabStop = true;
            this.radioButtonIconShield.Tag = "3";
            this.radioButtonIconShield.Text = "Shield";
            this.radioButtonIconShield.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcon10
            // 
            this.radioButtonIcon10.AutoSize = true;
            this.radioButtonIcon10.Location = new System.Drawing.Point(6, 68);
            this.radioButtonIcon10.Name = "radioButtonIcon10";
            this.radioButtonIcon10.Size = new System.Drawing.Size(84, 17);
            this.radioButtonIcon10.TabIndex = 19;
            this.radioButtonIcon10.TabStop = true;
            this.radioButtonIcon10.Tag = "2";
            this.radioButtonIcon10.Text = "Windows 10";
            this.radioButtonIcon10.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcon8
            // 
            this.radioButtonIcon8.AutoSize = true;
            this.radioButtonIcon8.Location = new System.Drawing.Point(6, 45);
            this.radioButtonIcon8.Name = "radioButtonIcon8";
            this.radioButtonIcon8.Size = new System.Drawing.Size(78, 17);
            this.radioButtonIcon8.TabIndex = 17;
            this.radioButtonIcon8.TabStop = true;
            this.radioButtonIcon8.Tag = "1";
            this.radioButtonIcon8.Text = "Windows 8";
            this.radioButtonIcon8.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcon7
            // 
            this.radioButtonIcon7.AutoSize = true;
            this.radioButtonIcon7.Checked = true;
            this.radioButtonIcon7.Location = new System.Drawing.Point(6, 22);
            this.radioButtonIcon7.Name = "radioButtonIcon7";
            this.radioButtonIcon7.Size = new System.Drawing.Size(78, 17);
            this.radioButtonIcon7.TabIndex = 17;
            this.radioButtonIcon7.TabStop = true;
            this.radioButtonIcon7.Tag = "0";
            this.radioButtonIcon7.Text = "Windows 7";
            this.radioButtonIcon7.UseVisualStyleBackColor = true;
            // 
            // radioButtonLangRu
            // 
            this.radioButtonLangRu.AutoSize = true;
            this.radioButtonLangRu.Checked = true;
            this.radioButtonLangRu.Location = new System.Drawing.Point(6, 26);
            this.radioButtonLangRu.Name = "radioButtonLangRu";
            this.radioButtonLangRu.Size = new System.Drawing.Size(67, 17);
            this.radioButtonLangRu.TabIndex = 18;
            this.radioButtonLangRu.TabStop = true;
            this.radioButtonLangRu.Tag = "0";
            this.radioButtonLangRu.Text = "Русский";
            this.radioButtonLangRu.UseVisualStyleBackColor = true;
            // 
            // radioButtonLangEn
            // 
            this.radioButtonLangEn.AutoSize = true;
            this.radioButtonLangEn.Location = new System.Drawing.Point(6, 49);
            this.radioButtonLangEn.Name = "radioButtonLangEn";
            this.radioButtonLangEn.Size = new System.Drawing.Size(85, 17);
            this.radioButtonLangEn.TabIndex = 20;
            this.radioButtonLangEn.TabStop = true;
            this.radioButtonLangEn.Tag = "1";
            this.radioButtonLangEn.Text = "Английский";
            this.radioButtonLangEn.UseVisualStyleBackColor = true;
            // 
            // groupBoxLangChoose
            // 
            this.groupBoxLangChoose.Controls.Add(this.radioButtonLangEn);
            this.groupBoxLangChoose.Controls.Add(this.radioButtonLangRu);
            this.groupBoxLangChoose.Location = new System.Drawing.Point(26, 158);
            this.groupBoxLangChoose.Name = "groupBoxLangChoose";
            this.groupBoxLangChoose.Size = new System.Drawing.Size(124, 76);
            this.groupBoxLangChoose.TabIndex = 21;
            this.groupBoxLangChoose.TabStop = false;
            this.groupBoxLangChoose.Text = "Выбор языка";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(149, 298);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 22;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxWMR
            // 
            this.textBoxWMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWMR.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxWMR.Location = new System.Drawing.Point(175, 177);
            this.textBoxWMR.Name = "textBoxWMR";
            this.textBoxWMR.ReadOnly = true;
            this.textBoxWMR.Size = new System.Drawing.Size(133, 13);
            this.textBoxWMR.TabIndex = 23;
            this.textBoxWMR.Text = "WMR - R123374169400";
            // 
            // textBoxWMZ
            // 
            this.textBoxWMZ.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWMZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWMZ.Location = new System.Drawing.Point(175, 202);
            this.textBoxWMZ.Name = "textBoxWMZ";
            this.textBoxWMZ.Size = new System.Drawing.Size(119, 13);
            this.textBoxWMZ.TabIndex = 25;
            this.textBoxWMZ.Text = "WMZ - Z156955150889";
            // 
            // checkBoxContextIcons
            // 
            this.checkBoxContextIcons.AutoSize = true;
            this.checkBoxContextIcons.Location = new System.Drawing.Point(26, 243);
            this.checkBoxContextIcons.Name = "checkBoxContextIcons";
            this.checkBoxContextIcons.Size = new System.Drawing.Size(167, 17);
            this.checkBoxContextIcons.TabIndex = 26;
            this.checkBoxContextIcons.Text = "Иконки контекстного меню";
            this.checkBoxContextIcons.UseVisualStyleBackColor = true;
            // 
            // checkBoxOneClick
            // 
            this.checkBoxOneClick.AutoSize = true;
            this.checkBoxOneClick.Location = new System.Drawing.Point(26, 266);
            this.checkBoxOneClick.Name = "checkBoxOneClick";
            this.checkBoxOneClick.Size = new System.Drawing.Size(282, 17);
            this.checkBoxOneClick.TabIndex = 27;
            this.checkBoxOneClick.Text = "Управление защитой в один клик средней кнопки";
            this.checkBoxOneClick.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 334);
            this.Controls.Add(this.checkBoxOneClick);
            this.Controls.Add(this.checkBoxContextIcons);
            this.Controls.Add(this.textBoxWMZ);
            this.Controls.Add(this.textBoxWMR);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxLangChoose);
            this.Controls.Add(this.groupBoxIconChoose);
            this.Controls.Add(this.labelDonate2);
            this.Controls.Add(this.labelDonate1);
            this.Controls.Add(this.linkLabelForum);
            this.Controls.Add(this.labelSupport);
            this.Controls.Add(this.labelDevName);
            this.Controls.Add(this.labelDevInfo);
            this.Controls.Add(this.labelSettings);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.groupBoxIconChoose.ResumeLayout(false);
            this.groupBoxIconChoose.PerformLayout();
            this.groupBoxLangChoose.ResumeLayout(false);
            this.groupBoxLangChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelDevInfo;
        private System.Windows.Forms.Label labelDevName;
        private System.Windows.Forms.Label labelSupport;
        private System.Windows.Forms.LinkLabel linkLabelForum;
        private System.Windows.Forms.Label labelDonate1;
        private System.Windows.Forms.Label labelDonate2;
        private System.Windows.Forms.GroupBox groupBoxIconChoose;
        private System.Windows.Forms.RadioButton radioButtonIcon10;
        private System.Windows.Forms.RadioButton radioButtonIcon8;
        private System.Windows.Forms.RadioButton radioButtonIcon7;
        private System.Windows.Forms.RadioButton radioButtonLangRu;
        private System.Windows.Forms.RadioButton radioButtonLangEn;
        private System.Windows.Forms.GroupBox groupBoxLangChoose;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxWMR;
        private System.Windows.Forms.TextBox textBoxWMZ;
        private System.Windows.Forms.RadioButton radioButtonIconShield;
        private System.Windows.Forms.CheckBox checkBoxContextIcons;
        private System.Windows.Forms.CheckBox checkBoxOneClick;
    }
}