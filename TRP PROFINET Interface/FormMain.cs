using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROFINET_STEP_7.Profinet;

namespace PROFINET_STEP_7
{
    public partial class FormMain : Form
    {
        private PLC plc = null;
        private ExceptionCode errCode;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetEnabledBotton(true);
                cboxPLCs.SelectedIndex = 2;
                txtIPaddress.Text = "192.168.0.1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIPaddress.Text)) throw new Exception("Input your PLC IP first");
                int selectionIndex = cboxPLCs.SelectedIndex;
                CPU_Type cpuType = CPU_Type.S7200;
                string ipAddress = txtIPaddress.Text;
                switch (selectionIndex)
                {
                    case 0:
                        cpuType = CPU_Type.S7200;
                        break;
                    case 1:
                        cpuType = CPU_Type.S7300;
                        break;
                    case 2:
                        cpuType = CPU_Type.S7400;
                        break;
                    case 3:
                        cpuType = CPU_Type.S71200;
                        break;
                    case 4:
                        cpuType = CPU_Type.S71500;
                        break;
                    default:
                        cboxPLCs.SelectedIndex = 3;
                        cpuType = CPU_Type.S71200;
                        break;
                }
                plc = new PLC(cpuType, ipAddress, (short)numericUpDownRack.Value, (short)numericUpDownSlot.Value);
                if (!plc.IsAvailable) throw new Exception("Not possible to find your PLC, try again");
                errCode = plc.Open();
                if (errCode != ExceptionCode.ExceptionNo) throw new Exception(plc.lastErrorString);
                this.SetEnabledBotton(false);
                status.Text = "Succesfully connected";
                MessageBox.Show("Succesfully connected", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnection_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetEnabledBotton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetEnabledBotton(bool flag)
        {
            btnConnection.Enabled = flag;
            txtIPaddress.Enabled = flag;
            cboxPLCs.Enabled = flag;
            numericUpDownRack.Enabled = flag;
            numericUpDownSlot.Enabled = flag;
            btnDisconnection.Enabled = !btnConnection.Enabled;
            btnReadReal.Enabled = !btnConnection.Enabled;
            btnWriteReal.Enabled = !btnConnection.Enabled;
        }

        //private int db;
        //private int startByteAddr;

        private void btnReadReal_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                //
                // Estação automática 80 
                //
                status.Text = "flag0";

                // Informaçoes de aperto
                status.Text = "flag1";
                var haste_traverssa_anterior_DX_OK = plc.Read("DB4809.DBX159.0").ToString();
                var haste_traverssa_anterior_DX_KO = plc.Read("DB4809.DBX159.1").ToString();

                var haste_traverssa_anterior_SX_OK = plc.Read("DB4809.DBX161.0").ToString();
                var haste_traverssa_anterior_SX_KO = plc.Read("DB4809.DBX161.1.0").ToString();

                var haste_traverssa_anterior_GRP_DX_OK = plc.Read("DB4809.DBX163.0").ToString();
                var haste_traverssa_anterior_GRP_DX_KO = plc.Read("DB4809.DBX163.1").ToString();

                var haste_traverssa_anterior_GRP_SX_OK = plc.Read("DB4809.DBX165.0").ToString();
                var haste_traverssa_anterior_GRP_SX_KO = plc.Read("DB4809.DBX165.1").ToString();

                var haste_traverssa_posterior_DX_OK = plc.Read("DB4809.DBX167.0").ToString();
                var haste_traverssa_posterior_DX_KO = plc.Read("DB4809.DBX167.1").ToString();

                var haste_traverssa_posterior_SX_OK = plc.Read("DB4809.DBX169.0").ToString();
                var haste_traverssa_posterior_SX_KO = plc.Read("DB4809.DBX169.1").ToString();

                var barra_estabilizadora_baixa_DX_OK = plc.Read("DB4809.DBX175.0").ToString();
                var barra_estabilizadora_baixa_DX_KO = plc.Read("DB4809.DBX175.1").ToString();

                var barra_estabilizadora_baixa_SX_OK = plc.Read("DB4809.DBX177.0").ToString();
                var barra_estabilizadora_baixa_SX_KO = plc.Read("DB4809.DBX177.0").ToString();

                var barra_estabilizadora_alta_DX_OK = plc.Read("DB4809.DBX179.0").ToString();
                var barra_estabilizadora_alta_DX_KO = plc.Read("DB4809.DBX179.0").ToString();

                var barra_estabilizadora_alta_SX_OK = plc.Read("DB4809.DBX181.0").ToString();
                var barra_estabilizadora_alta_SX_KO = plc.Read("DB4809.DBX181.0").ToString();
                status.Text = "flag2";
                // Tipo e tração
                //double tipo_ST80 = 0;
                //var tipo_ST80 = Types.String.FromByteArray((byte[])plc.Read("DB4809.DBB2546")).ToString();
                //status.Text = "flag3";
                var tracao_ST80 = plc.Read("DB4809.DBX2555.6").ToString();
                status.Text = "flag3";
                //status.Text = tipo_ST80;
                watchdog_time.Text = "500";

                //
                //status.Text = plc.Read("DB4809.DBW16").ToString();
                debug_value.Text = plc.Read(debug_read.Text).ToString();
                status.Text = "read Succesfull";
                //double value = 0;
                //value = Types.Double.FromDWord((uint)plc.Read(txtRealOutput.Text));
                //txtRealInput.Text = value.ToString("0.#");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteReal_Click(object sender, EventArgs e)
        {
            try
            {
                if (errCode != ExceptionCode.ExceptionNo) return;
                // Save in data table or sql
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout frmAbout = new FormAbout();
            frmAbout.ShowDialog();
        }

        private void cboxPLCs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRealOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWordOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIPaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBoxConnection_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void debug_value_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
