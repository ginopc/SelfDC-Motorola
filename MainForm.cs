using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SelfDC
{
    public partial class MainForm : Form
    {
        static string OUT_FILE = "outfile.txt";

        /** costruttore della classe */
        public MainForm()
        {
            InitializeComponent();
        }

        /** Caricamento della maschera */
        private void FormLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bcReader.EnableScanner = true;
            panEdit.Visible = false;
        }

        /** evento di scansione dello scanner */
        private void bcReader_OnScan(Symbol.Barcode2.ScanDataCollection scanDataCollection)
        {
            if (scanDataCollection.GetFirst == null) return;
            ListViewItem item = new ListViewItem(scanDataCollection.GetFirst.Text);
            item.SubItems.Add("1");
            listBox.Items.Add(item);
        }

        /** modifica l'elemento selezionato */
        private void actEdit(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndices[0];
            txtCode.Text = listBox.Items[index].Text;
            txtQta.Text = listBox.Items[index].SubItems[1].Text;
            panEdit.Visible = true;
        }

        /** Elimina l'elemento selezionato */
        private void actDelete(object sender, EventArgs e)
        {
            if (listBox.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona l'elemento da eliminare","Elimina Riga");
                return;
            }

            DialogResult res = MessageBox.Show(
                "Vuoi eliminare la riga selezionata?"
                , "Elimina Record"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);

            if (res == DialogResult.No) return;

            listBox.Items.Remove(listBox.Items[listBox.SelectedIndices[0]]);
        }

        private void FormResize(object sender, EventArgs e)
        {
            double ctlWidth = (double) ClientSize.Width;

            /** Resize listBox */
            listBox.Width = (int) ctlWidth;
            listBox.Columns[0].Width = (int) (ctlWidth * 0.67);
            listBox.Columns[1].Width = (int) (ctlWidth * 0.30);
        }

        private void bcReader_OnStatus(Symbol.Barcode2.StatusData statusData)
        {
            statusBar.Text = statusData.Text;
        }

        private void actQuit(object sender, EventArgs e)
        {
            this.Close();
        }

        /** Esporta la lista in un file */
        private void actExport(object sender, EventArgs e)
        {
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

            StreamWriter sw;
            try
            {
                sw = new StreamWriter(OUT_FILE);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Errore di creazione del file dati" + ex.StackTrace
                    , "Errore"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation
                    , MessageBoxDefaultButton.Button1);
                return;
            }

            // Esporta i dati
            string line;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                line = listBox.Items[i].Text + ";" + listBox.Items[i].SubItems[1].Text;
                sw.WriteLine(line);
            }
            sw.Close();
            listBox.Items.Clear();

            MessageBox.Show("File esportato con successo","Esporta Dati");
        }

        /** Abilita menu di modifica solo se è selezionata un riga della lista */
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable Edit menu if nothing is selected
            if (listBox.SelectedIndices.Count > 0)
            {
                mnuEdit.Enabled = true;
                mnuDelete.Enabled = true;
            }
            else {
                mnuEdit.Enabled = false;
                mnuDelete.Enabled = false;
            }

            // Disable Edit context menu if nothing is selected
            if (listBox.SelectedIndices.Count > 0)
            {
                cmnuEdit.Enabled = true;
                cmnuDelete.Enabled = true;
            }
            else
            {
                cmnuEdit.Enabled = false;
                cmnuDelete.Enabled = false;
            }
                
        }

        /** Salva modifica */
        private void btnSave_Click(object sender, EventArgs e)
        {
            ListViewItem item;

            if (listBox.SelectedIndices.Count > 0)
            {
                item = listBox.Items[listBox.SelectedIndices[0]];
                item.Text = txtCode.Text;
                item.SubItems[1].Text = txtQta.Text;
            }

            panEdit.Visible = false;

        }

        /** Annulla modifica */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panEdit.Visible = false;
        }


        private void menuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SCS SelfDC \nVer. 0.1\nAuthor: M. Aru"
                , "Info"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Asterisk
                ,MessageBoxDefaultButton.Button1);
        }

        private void MainForm2_Closing(object sender, CancelEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Vuoi uscire dall'applicazione?"
                , "Uscita"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);

            if (res == DialogResult.No) e.Cancel=true;
        }

        private void MainForm2_Closed(object sender, EventArgs e)
        {
            // Prima di chiudere disabilito lo scanner
            bcReader.EnableScanner = false;
        }
    }
}