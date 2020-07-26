using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_stock_quote_alert
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        private static AbortableBackgroundWorker backgroundWorker1 = new AbortableBackgroundWorker();


        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTileIniciar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) return;
            
            metroLabel10.Text = $"Monitoramento iniciado";
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroLabel10.Text = $"Atualizado em: {DateTime.Now}";
        }

        private void metroTileParar_Click(object sender, EventArgs e)
        {

        }

        private void metroTileSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
