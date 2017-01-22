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
    public partial class frmMain : Form
    {
        SmartPlayList _playList;
        bool _loading = false;

        public frmMain()
        {
            InitializeComponent();
            setState(false);
            cmbType.AddEnum<SmartPlayList.Types>();
            cmbMatch.AddEnum<SmartPlayList.MatchOptions>();
            cmbDirection.AddEnum<IRule.SortOptions>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmRule ruleForm = new frmRule(_playList);
                ruleForm.ShowDialog(this);
                if (ruleForm.DialogResult == DialogResult.OK)
                {
                    _playList.Rules.Add(ruleForm.Rule);
                    lstRules.Items.Add(_playList.Rules[ruleForm.Rule.GetType()]);
                }
            }
            catch (Exception ex)
            {
                ex.Show();
            }
        }

        private void setState(bool state)
        {
            foreach (Control c in this.Controls)
                setControlState(state, c);
        }

        private void setControlState(bool state, Control c)
        {
            if (!(c is MenuStrip))
                c.Enabled = state;
            foreach (Control cc in c.Controls)
                setControlState(state, cc);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _playList = new SmartPlayList();
            setState(true);
            DoPlaylist();
        }

        private void DoPlaylist()
        {
            cmbOrder.AddArray(_playList.GetAvailableOrderBy(), true);
            cmbGroup.AddArray(_playList.GetAvailableGroups(), true);
            cmbDirection.Set<IRule.SortOptions>(IRule.SortOptions.Ascending);
            cmbOrder.Check(() => { cmbDirection.Enabled = true; }, () => { cmbDirection.Enabled = false; });
            cmbGroup.Check(() => { }, () => { chkMixed.Enabled = false; });
            lstRules.Items.Clear();
            chkMixed.Checked = false;
            numLimit.Value = 0;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            _playList.Name = txtName.Text;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_playList != null)
            {
                _playList.MediaType = (SmartPlayList.Types)cmbType.SelectedItem;
                DoPlaylist();
            }
        }

        private void cmbMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_playList != null)
                _playList.MatchOn = (SmartPlayList.MatchOptions)cmbMatch.SelectedValue;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedItem == null)
                return;

            frmRule ruleForm = new frmRule(_playList);
            ruleForm.Rule = (IRule)lstRules.SelectedItem;
            ruleForm.ShowDialog(this);

            if (ruleForm.DialogResult == DialogResult.OK)
            {
                _playList.Rules[ruleForm.Rule.GetType()] = ruleForm.Rule;
                int inx = lstRules.SelectedIndex;
                lstRules.Items.RemoveAt(inx);
                lstRules.Items.Insert(inx, _playList.Rules[ruleForm.Rule.GetType()]);
            }
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            _playList.OrderBy = (cmbOrder.SelectedItem is IRule)
                 ? (IRule)cmbOrder.SelectedItem
                : null;
            cmbDirection_SelectedIndexChanged(null, null);
        }

        private void cmbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            if (_playList?.OrderBy != null)
                _playList.OrderBy.Sort = (IRule.SortOptions)cmbDirection.SelectedItem;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            _playList.Group = (cmbGroup.SelectedItem is IGroup)
                ? (IGroup)cmbGroup.SelectedItem
                : null;

            chkMixed.Enabled = _playList.Group == null
                ? false
                : _playList.Group.AllowMixed;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedItem == null)
                return;

            IRule rule = (IRule)lstRules.SelectedItem;
            lstRules.Items.RemoveAt(lstRules.SelectedIndex);
            _playList.Rules.Remove(rule);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_playList == null)
                return;

            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;
            try
            {
                _playList.Save(saveFileDialog1.FileName, true);
            }
            catch (Exception ex)
            {
                ex.Show();
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;

            LoadPlayList(openFileDialog1.FileName);
        }

        private void LoadPlayList(string sFile)
        {
            _loading = true;
            try
            {
                _playList = SmartPlayList.LoadFromFile(sFile);
                cmbType.Set<SmartPlayList.Types>(_playList.MediaType);

                txtName.Text = _playList.Name;

                cmbMatch.Set<SmartPlayList.MatchOptions>(_playList.MatchOn);

                foreach (IRule rule in _playList.Rules)
                    lstRules.Items.Add(rule);

                cmbOrder.Set<IRule>(_playList.OrderBy);
                if (_playList.OrderBy != null)
                    cmbDirection.Set<IRule.SortOptions>(_playList.OrderBy.Sort);

                cmbGroup.Set<IGroup>(_playList.Group);
                if (_playList.Group != null)
                    chkMixed.Checked = _playList.Group.Mixed;

                numLimit.Value = _playList.Limit;
                setState(true);
            }
            catch (Exception ex)
            {
                ex.Show();
            }
            finally
            {
                _loading = false;
            }
        }

        private void numLimit_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            _playList.Limit = Convert.ToInt32(numLimit.Value);
        }

        private void chkMixed_CheckedChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            if (_playList.Group != null)
                _playList.Group.Mixed = chkMixed.Checked;
        }

        private void lstRules_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(null, null);
        }
    }
}