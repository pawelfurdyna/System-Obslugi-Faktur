﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;



namespace ProjektBD
{
    public partial class FormStawkaVAT : Form
    {
        private bool edycja;
        private string nazwa;
        string encja = "STAWKA_VAT";
        string klucz = "ID_VAT";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "ID_VAT", "PROCENT_VAT" };
        ObslugaBazy ob = new ObslugaBazy();


        public FormStawkaVAT(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbNazwa, tbProcentVAT };
            this.Load += FormStawkaVAT_Load;
        }

        private void FormStawkaVAT_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb , atrybuty);
                tbNazwa.Enabled = false;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            #region Walidacja
            if (string.IsNullOrWhiteSpace(tbNazwa.Text))
            {
                errorProvider1.SetError(tbNazwa, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbNazwa, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbNazwa, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(tbProcentVAT.Text))
            {
                errorProvider2.SetError(tbProcentVAT, string.Empty);
                errorProvider1.SetError(tbProcentVAT, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbProcentVAT, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbProcentVAT, string.Empty);
            }
            #endregion
            if (!string.IsNullOrWhiteSpace(tbNazwa.Text) &&
                !string.IsNullOrWhiteSpace(tbProcentVAT.Text))
            {

                if (edycja)
                {
                    ob.EdytujRekord(encja, klucz, nazwa, tb, atrybuty);
                    this.Close();
                }
                else
                {
                    if (ob.CzyNazwaJestWBazie(encja, "ID_VAT", tbNazwa.Text))
                    {
                        MessageBox.Show("Proszę zmienić nazwę stawki");
                    }
                    else
                    {
                        ob.DodajRekord(encja, tb, atrybuty);
                        this.Close();
                    }
                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbProcentVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e,true))
            {
                errorProvider1.SetError(tbProcentVAT, string.Empty);
                errorProvider2.SetError(tbProcentVAT, "Wprowadz wartość z użyciem cyfr i przecinka jako speratatora dziesiętnego!");
                errorProvider2.Icon = new IconEx(IconEx.SystemIcons.Warning, SystemInformation.SmallIconSize).Icon;
                this.errorProvider2.SetIconPadding(this.tbProcentVAT, -20);
            }
            else
            {
                errorProvider1.SetError(tbProcentVAT, string.Empty);
            }
        }

        private void tbProcentVAT_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbProcentVAT, string.Empty);
        }
    }
}
