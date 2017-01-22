using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodi.Utilities.SampleApp
{
    public partial class frmRule : Form
    {
        SmartPlayList _playList;
        IRule _rule;
        public frmRule(SmartPlayList playlist)
        {
            InitializeComponent();
            _playList = playlist;
            iRuleBindingSource.DataSource = playlist.GetAvailableFields();
        }

        public IRule Rule
        {
            get { return _rule; }
            set
            {
                _rule = value;
                cmbField.Set<IRule>(_rule);
                cmbOperator.Set<IOperator>(_rule.Operator);
                txtValue.Text = string.Empty;
                foreach (string val in _rule.Values.GetValuesAsString())
                {
                    if (txtValue.Text.Length > 0)
                        txtValue.AppendText(Environment.NewLine);
                    txtValue.AppendText(val);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _rule.Values.Clear();
                _rule.Values.AddRange(txtValue.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ex.Show();
            }
        }

        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            _rule = (IRule)cmbField.SelectedItem;
            iOperatorBindingSource.DataSource = _rule.GetAvailableOperators();
            if (_rule.IsMultipleValuesAllowed)
            {
                txtValue.Multiline = true;
                this.Height = 248;
                txtValue.Height = 120;
            }
            else
            {
                txtValue.Multiline = false;
                this.Height = 148;
                txtValue.Height = 20;
            }
            cmbOperator_SelectedIndexChanged(null, null);
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            IOperator oper = (IOperator)cmbOperator.SelectedItem;
            _rule.Operator = oper;
            txtValue.Enabled = !oper.NoValue;
        }

        private void frmRule_Load(object sender, EventArgs e)
        {
            cmbField_SelectedIndexChanged(null, null);
        }

        private void txtValue_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtValue.Enabled)
                txtValue.Text = string.Empty;
        }
    }
}
