using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_stock_quote_alert
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        private static AbortableBackgroundWorker backgroundWorker1 = new AbortableBackgroundWorker();

        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        public FormMain()
        {
            InitializeComponent();
            AtualizaCamposConfiguracao();
            
        }
        private void AtualizaCamposConfiguracao()
        {
            try
            {
                metroTextBoxEmailPara.Text = config.AppSettings.Settings["EmailTo"].Value;
                metroTextBoxEmailDe.Text = config.AppSettings.Settings["EmailFrom"].Value;
                metroTextBoxCredencialEmail.Text = config.AppSettings.Settings["CredentialEmail"].Value;
                metroTextBoxCredencialSenha.Text = config.AppSettings.Settings["CredentialPassword"].Value;
                metroTextBoxSMTPHost.Text = config.AppSettings.Settings["SMTPHost"].Value;
                metroTextBoxSMTPPort.Text = config.AppSettings.Settings["SMTPPort"].Value;
                metroTextBoxAPIKey.Text = config.AppSettings.Settings["APIKey"].Value;
            }
            catch (Exception)
            {
                //Aqui estou adicionando configurações padrões para o app

                config.AppSettings.Settings.Add("EmailTo", "");
                config.AppSettings.Settings.Add("EmailFrom", "");
                config.AppSettings.Settings.Add("CredentialEmail", "");
                config.AppSettings.Settings.Add("CredentialPassword", "");
                config.AppSettings.Settings.Add("SMTPHost", "");
                config.AppSettings.Settings.Add("SMTPPort", "");
                config.AppSettings.Settings.Add("APIKey", "");
                config.AppSettings.Settings.Add("Culture", "");
                config.Save(ConfigurationSaveMode.Modified);
                config.AppSettings.Settings["EmailTo"].Value = "johnycruz00@gmail.com";
                config.AppSettings.Settings["EmailFrom"].Value = "JohnyInoa@gmail.com";
                config.AppSettings.Settings["CredentialEmail"].Value = "JohnyInoa@gmail.com";
                config.AppSettings.Settings["CredentialPassword"].Value = "teste#1aoni";
                config.AppSettings.Settings["SMTPHost"].Value = "smtp.gmail.com";
                config.AppSettings.Settings["SMTPPort"].Value = "587";
                config.AppSettings.Settings["APIKey"].Value = "9368a2aa";
                config.AppSettings.Settings["Culture"].Value = "en-US";

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                AtualizaCamposConfiguracao();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTileIniciar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) return;
            
            if (!validaEntradaDoUsuario("monitor"))
            {
                MessageBox.Show("Favor preencher todos os campos antes de iniciar");
                return;
            }

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
            if (backgroundWorker1.IsBusy)
            {
                metroLabel10.Text = $"Aplicação foi parada pelo usuário";
                backgroundWorker1.Abort();
            }
        }

        private void metroTileSalvar_Click(object sender, EventArgs e)
        {

            if (!validaEntradaDoUsuario("config"))
            {
                MessageBox.Show("Favor preencher todos os campos antes de salvar");
                return;
            }

            try
            {
                new MailAddress(metroTextBoxEmailPara.Text.Trim());
                new MailAddress(metroTextBoxEmailDe.Text.Trim());
                new MailAddress(metroTextBoxCredencialEmail.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Todos os e-mails devem estar no formato correto.");
                return;
            }

            config.AppSettings.Settings["EmailTo"].Value = metroTextBoxEmailPara.Text;
            config.AppSettings.Settings["EmailFrom"].Value = metroTextBoxEmailDe.Text;
            config.AppSettings.Settings["CredentialEmail"].Value = metroTextBoxCredencialEmail.Text;
            config.AppSettings.Settings["CredentialPassword"].Value = metroTextBoxCredencialSenha.Text;
            config.AppSettings.Settings["SMTPHost"].Value = metroTextBoxSMTPHost.Text;
            config.AppSettings.Settings["SMTPPort"].Value = metroTextBoxSMTPPort.Text;
            config.AppSettings.Settings["APIKey"].Value = metroTextBoxAPIKey.Text;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Configurações atualizadas com sucesso.");
        }

        public bool validaEntradaDoUsuario(string aba)
        {
            if (aba == "monitor")
            {
                if (string.IsNullOrEmpty(metroTextBoxAtivo.Text.Trim())) return false;
                if (string.IsNullOrEmpty(metroTextBoxRefCompra.Text.Trim())) return false;
                if (string.IsNullOrEmpty(metroTextBoxRefVenda.Text.Trim())) return false;
            }

            if (string.IsNullOrEmpty(metroTextBoxEmailPara.Text.Trim())) return false;
            if (string.IsNullOrEmpty(metroTextBoxEmailDe.Text.Trim())) return false;
            if (string.IsNullOrEmpty(metroTextBoxCredencialEmail.Text.Trim())) return false;
            if (string.IsNullOrEmpty(metroTextBoxCredencialSenha.Text.Trim())) return false;
            if (string.IsNullOrEmpty(metroTextBoxSMTPHost.Text.Trim())) return false;
            if (string.IsNullOrEmpty(metroTextBoxSMTPPort.Text.Trim())) return false;
            if (string.IsNullOrEmpty(metroTextBoxAPIKey.Text.Trim())) return false;

            return true;
        }
    }
}
