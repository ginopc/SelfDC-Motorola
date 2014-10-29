﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using SelfDC.Models;
using SelfDC.Utils;

namespace SelfDC
{
    public partial class OrderForm : Form
    {
        bool ItemEdit = false;
        private List<OrderItem> listaProdotti;

        /** costruttore della classe */
        public OrderForm()
        {
            InitializeComponent();
            txtCode.Text = "";
            txtQta.Text = "";
            listBox.Items.Clear();

            listaProdotti = new List<OrderItem>();
            ScsUtils.WriteLog("Creazione maschera " + this.Name);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Caricamento maschera " + this.Name);
            // Imposto la maschera a tutto schermo
            this.WindowState = FormWindowState.Maximized;

            // server per il debug sull'emulatore
            if (System.Environment.OSVersion.Platform.ToString() == "WinCE")
                    bcReader.EnableScanner = true;
        }

        private void bcReader_OnScan(Symbol.Barcode2.ScanDataCollection scanDataCollection)
        {
            if (scanDataCollection.GetFirst == null) return;
            String code = scanDataCollection.GetFirst.Text;

            actNew(bcReader, null);

            if (code.StartsWith("$"))
            {
                // codice interno
                cbCodInterno.Checked = true;
                txtCode.Text = code.Substring(1, 7);
            }
            else
            {
                // codice ean
                cbCodInterno.Checked = false;
                txtCode.Text = code.Substring(1,13);
            }
            txtQta.Text = "1";

            actSave(bcReader, null);
        }

        /** modifica l'elemento selezionato */
        private void actEdit(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndices[0];
            ListViewItem item = listBox.Items[index];

            ScsUtils.WriteLog(string.Format("In {0}, modifica della riga {1}", this.Name, index.ToString()));

            if (item.Text == "")
            {
                cbCodInterno.Checked = true;
                txtCode.Text = item.SubItems[1].Text;
            }
            else
            {
                cbCodInterno.Checked = false;
                txtCode.Text = listBox.Items[index].Text;
            }

            txtQta.Text = listBox.Items[index].SubItems[2].Text;

            // blocco la checkbox
            cbCodInterno.Enabled = false;
            txtQta.Focus();
        }

        /** Inizia un nuovo inserimento manuale */
        private void actNew(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("In " + this.Name + ", inserimento nuova riga");

            txtCode.Text = "";
            txtCode.Enabled = true;
            txtQta.Text = "";
            txtQta.Enabled = true;
            cbCodInterno.Checked = true;
            cbCodInterno.Enabled = true;
            btnSave.Enabled = true;

            ItemEdit = false;
            txtCode.Focus();
        }

        /** Elimina l'elemento selezionato */
        private void actRemove(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Non ci sono righe da esportare", "Elimina Riga",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (listBox.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona l'elemento da eliminare","Elimina Riga");
                return;
            }

            int index = listBox.SelectedIndices[0];
            ListViewItem item = listBox.Items[index];

            DialogResult res = MessageBox.Show(
                "Vuoi eliminare la riga selezionata?"
                , "Elimina Record"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);

            if (res == DialogResult.No) return;

            listBox.Items.Remove(listBox.Items[index]);
            ScsUtils.WriteLog("In " + this.Name + ", modifica della riga " + item.Text);
        }

        /*  Form Resize */
        private void OrderForm_Resize(object sender, EventArgs e)
        {
            double ctlWidth = (double)ClientSize.Width;

            /** Resize listBox */
            listBox.Width = (int)ctlWidth;
            listBox.Columns[0].Width = (int)(ctlWidth * 0.50);
            listBox.Columns[1].Width = (int)(ctlWidth * 0.30);
            listBox.Columns[1].Width = (int)(ctlWidth * 0.20);
        }

        // Visualizza lo stato dello scanner nella barra di stato
        private void bcReader_OnStatus(Symbol.Barcode2.StatusData statusData)
        {
            statusBar.Text = statusData.Text;
        }

        private void actQuit(object sender, EventArgs e)
        {
            bcReader.EnableScanner = false;
            this.Hide();
        }

        /** Esporta la lista in un file */
        private void actExport(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("In {0}, esportazione dati su file {1}", this.Name, Settings.OrdineFileName));

            // check if there is some lines
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show(
                    "Nessun dato da esportare"
                    ,"ATTENZIONE!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Asterisk
                    , MessageBoxDefaultButton.Button1);
                return;
            }

            // User confirm?
            DialogResult res = MessageBox.Show(
                                    "Vuoi esportare il file?", 
                                    "Esporta Etichette", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question, 
                                    MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No) return;

            Order ordine = new Order();
            foreach (ListViewItem item in listBox.Items)
            {
                ordine.Add(new OrderItem(item.Text, item.SubItems[1].Text, Convert.ToInt32(item.SubItems[2].Text)));
            }
            if (ordine.ToFile(Settings.OrdineFileName) < 0)
            {
                return;
            }

            listBox.Items.Clear();
            listBox_SelectedIndexChanged(sender, e);
            listaProdotti.Clear();

            MessageBox.Show("File esportato con successo","Esporta Dati");
        }

        /** Abilita menu di modifica solo se è selezionata un riga della lista */
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBox.Items.Count == 0) || (listBox.SelectedIndices.Count == 0))
            {
                txtCode.Enabled = false;
                txtQta.Enabled = false;
                cbCodInterno.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            int index = listBox.SelectedIndices[0];

            // Disable Edit menu if nothing is selected
            if (index >= 0)
            {
                // editing abilitato
                ItemEdit = true;
                mnuRemove.Enabled = true;
                cmnuDelete.Enabled = true;

                txtQta.Enabled = true;
                btnSave.Enabled = true;

                txtQta.SelectAll();
                actEdit(sender, e);
            }
            else {
                // editing disabilitato
                ItemEdit = false;
                mnuRemove.Enabled = false;
                cmnuDelete.Enabled = false;


                txtCode.Enabled = true;
                txtQta.Enabled = true;

                btnSave.Enabled = false;
            }
        }

        /** Salva modifica */
        private void actSave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Niente da inserire", "Salva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
				actFieldReset();
            }

            // disabilito i campi x evitare modifiche durante il salvataggio
            txtCode.Enabled = false;
            txtQta.Enabled = false;
            cbCodInterno.Enabled = false;

            // se ci sono elementi selezionati => è una modifica
            ListViewItem item;
            if ((listBox.SelectedIndices.Count > 0) && ItemEdit)
            {
                item = listBox.Items[listBox.SelectedIndices[0]];
                if (cbCodInterno.Checked)
                    item.SubItems[1].Text = txtCode.Text; // cod interno
                else
                    item.Text = txtCode.Text; // ean
                item.SubItems[2].Text = txtQta.Text; // qta
                ItemEdit = false;
            }
            else // Nuovo inserimento manuale
            {
                item = new ListViewItem();
                if (cbCodInterno.Checked) 
                {
                    item.Text = "";
                    item.SubItems.Add(txtCode.Text);
                }
                else
                {
                    item.Text = txtCode.Text;
                    item.SubItems.Add("");
                }

                if (txtQta.Text == "") txtQta.Text = "1";
                item.SubItems.Add(txtQta.Text);

                listBox.Items.Add(item);
            }

            // pulisco e disabilito i campi
            actFieldReset();
        }

        /** Reimposta ai controlli della maschera */
        private void actFieldReset()
        {
            txtCode.Text = "";
            txtCode.Enabled = false;
            txtQta.Text = "";
            txtQta.Enabled = false;
            cbCodInterno.Checked = true;
            cbCodInterno.Enabled = false;
            btnSave.Enabled = false;
        }

        /** Annulla modifica */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            actFieldReset();
        }

        /** Elimina tutte le righe dell'ordine */
        private void actRemoveAll(object sender, EventArgs e)
        {
            DialogResult res;

			ScsUtils.WriteLog("In " + this.Name + ", elimino tutti gli elementi");
			
			res = MessageBox.Show("Confermi l'eliminazine completa?", "Elimina Tutto"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No)
                return;

            this.listBox.Items.Clear();
        }

        private void txtQta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                actSave(sender, e);

                
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                actSave(sender, e);
        }

        private void cbCodInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                actSave(sender, e);

        }

        /** richiesta chiusura */
        private void OrderForm_Closing(object sender, CancelEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                            "Vuoi uscire dall'applicazione?"
                            , "Uscita"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question
                            , MessageBoxDefaultButton.Button1);

            if (res == DialogResult.No) e.Cancel = true;
        }

        /** dopo conferma chiusura */
        private void OrderForm_Closed(object sender, EventArgs e)
        {
            // Salvo le impostazioni
            Settings.SaveToFile(Settings.AppCfgFileName);

            // TODO: se esiste un ordine in fase di compilazione lo esporto su un file temporaneo

            // Prima di chiudere disabilito lo scanner
            if (System.Environment.OSVersion.Platform.ToString() == "WinCE")
                if (bcReader.EnableScanner) bcReader.EnableScanner = false;

        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("Maschera {0} attivata", this.Name));
            bcReader.EnableScanner = true;
        }
    }
}