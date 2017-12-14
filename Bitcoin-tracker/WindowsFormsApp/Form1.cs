﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTapi;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public List<Bitcoin> lBitcoin;
        REST rest = new REST();
        public Form1()
        {
            InitializeComponent();           
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            rest.GetURL();
            lBitcoin = rest.getBitcoinPriceIndex();
            dataGridViewBPI.DataSource = lBitcoin;

        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sCurrency = (string)comboBoxCurrency.SelectedItem;
        }
    }
}