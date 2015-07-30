using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows_Defender
{
    public partial class FormSettings : Form
    {
        string icon;
        string language;
        string contextIcons;
        string oneClick;

        public FormSettings()
        {
            InitializeComponent();
            System.IO.StreamReader fileIn =
                new System.IO.StreamReader("DefenderUiSettings.ini");
            icon = fileIn.ReadLine();
            language = fileIn.ReadLine();
            contextIcons = fileIn.ReadLine();
            oneClick = fileIn.ReadLine();

            fileIn.Close();
            fileIn.Dispose();

            // Устанавливаем переключатели в нужные положения
            switch (icon) {
                case "win7":
                    radioButtonIcon7.Checked = true;
                    break;
                case "win8":
                    radioButtonIcon8.Checked = true;
                    break;
                case "win10":
                    radioButtonIcon10.Checked = true;
                    break;
                case "shield":
                    radioButtonIconShield.Checked = true;
                    break;
                default:
                    radioButtonIcon7.Checked = true;
                    break;
            }

            switch (language) {
                case "en-US":
                    radioButtonLangEn.Checked = true;
                    break;
                case "ru-RU":
                    radioButtonLangRu.Checked = true;
                    break;
                default:
                    radioButtonLangRu.Checked = true;
                    break;
            }

            if (contextIcons == "icons") {
                checkBoxContextIcons.Checked = true;
            } else {
                checkBoxContextIcons.Checked = false;
            }

            if (oneClick == "oneClickProtection") {
                checkBoxOneClick.Checked = true;
            } else {
                checkBoxOneClick.Checked = false;
            }           
        }

        private void labelLanguage_Click(object sender, EventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string newIcon;
            string newLang;
            string newContextIcons;
            string newOneClick;

            switch (GetRadioIndex(groupBoxIconChoose)) {
                case 0:
                    newIcon = "win7";
                    break;
                case 1:
                    newIcon = "win8";
                    break;
                case 2:
                    newIcon = "win10";
                    break;
                case 3:
                    newIcon = "shield";
                    break;
                default:
                    newIcon = "win8";
                    break;
            }

            switch (GetRadioIndex(groupBoxLangChoose)) {
                case 0:
                    newLang = "ru-RU";
                    break;
                case 1:
                    newLang = "en-US";
                    break;
                default:
                    newLang = "en-US";
                    break;
            }

            if (checkBoxContextIcons.Checked) {
                newContextIcons = "icons";
            } else {
                newContextIcons = "noicons";
            }

            if (checkBoxOneClick.Checked) {
                newOneClick = "oneClickProtection";
            } else {
                newOneClick = "noOneClickProtection";
            }

            if ((language == newLang) && (icon == newIcon) &&
                (contextIcons == newContextIcons)) {
                this.Close();
                this.Dispose();
            } else {
                System.IO.StreamWriter fileOut =
                    new System.IO.StreamWriter("DefenderUiSettings.ini");
                fileOut.WriteLine(newIcon);
                fileOut.WriteLine(newLang);
                fileOut.WriteLine(newContextIcons);
                fileOut.WriteLine(newOneClick);
                fileOut.Close();
                fileOut.Dispose();

                this.Close();
                this.Dispose();

                Application.Restart();
            }
        }

        int GetRadioIndex(GroupBox group)
        {
            foreach (Control control in group.Controls)
                if (control is RadioButton)
                    if (((RadioButton)control).Checked)
                        return int.Parse(control.Tag.ToString());
            return -1;
        }

        private void linkLabelForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelForum.Text);
        }
    }
}
