﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBizBot.View
{
    using Model;

    public partial class AccountListItem : UserControl
    {
        private Account m_account;

        public Account Account
        {
            get 
            {
                bindForm();
                return this.m_account; 
            }
            set
            {
                this.m_account = value;
                setForm();
            }
        }

        private void bindForm()
        {
            m_account.Passwd = tbPasswd.Text;
            m_account.SentMail = cbSentEmail.Checked;
            m_account.Selected = rbSelectedAccount.Checked;
            m_account.Enabled = cbEnabled.Checked;
        }

        private void setForm()
        {
           tbPasswd.Text = m_account.Passwd;
           cbSentEmail.Checked = m_account.SentMail;
           rbSelectedAccount.Checked = m_account.Selected;
           cbEnabled.Checked = m_account.Enabled;
        }

        public AccountListItem(Account account)
        {
            this.m_account = account;
            InitializeComponent();
        }

        private void tbPasswd_MouseEnter(object sender, EventArgs e)
        {
            tbPasswd.ReadOnly = false;
        }

        private void tbPasswd_MouseLeave(object sender, EventArgs e)
        {
            tbPasswd.ReadOnly = true;
        }

        private void rbSelectedAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedAccount.Checked)
            {
                ControlCollection allAccounts = rbSelectedAccount.Parent.Parent.Controls;

                foreach (Control control in allAccounts)
                {
                    AccountListItem accountDetailsControl = (AccountListItem)control;
                    if (!accountDetailsControl.rbSelectedAccount.Equals(sender))
                    {
                        accountDetailsControl.rbSelectedAccount.Checked = false;
                    }
                }
            }
        }

        private void AccountDetailsControl_Load(object sender, EventArgs e)
        {
            this.cbEnabled.Checked = m_account.Enabled;
            this.cbSentEmail.Checked = m_account.SentMail;
            this.rbSelectedAccount.Checked = m_account.Selected;
            this.tbLogin.Text = m_account.Login;
            this.tbPasswd.Text = m_account.Passwd;
            this.tbCash.Text = m_account.Attributes.CashAsString;
            this.tbSafe.Text = m_account.Attributes.SafeAsString;
            this.tbNextLogin.Text = m_account.NextLoginTime.ToString(@"hh\:mm\:ss");
            this.tbMailMessages.Text = m_account.Attributes.NewMailNo.ToString();
            this.tbHitCount.Text = m_account.HitCount.ToString();
            this.tbAttack.Text = m_account.Units.Attack.ToString();
            this.tbDefense.Text = m_account.Units.Defense.ToString();
        }

        private void cbTransferToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pbMinus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć konto \"" + m_account.Login + "\"?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);

            if (result.Equals(DialogResult.Yes))
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnabled.Checked)
            {
                this.cbSentEmail.Enabled = true;
                this.rbSelectedAccount.Enabled = true;
                this.tbLogin.Enabled = true;
                this.tbPasswd.Enabled = true;
                this.tbCash.Enabled = true;
                this.tbSafe.Enabled = true;
                this.tbNextLogin.Enabled = true;
                this.tbMailMessages.Enabled = true;
                this.tbHitCount.Enabled = true;
                this.tbAttack.Enabled = true;
                this.tbDefense.Enabled = true;
            }
            else
            {
                this.cbSentEmail.Enabled = false;
                this.rbSelectedAccount.Enabled = false;
                this.tbLogin.Enabled = false;
                this.tbPasswd.Enabled = false;
                this.tbCash.Enabled = false;
                this.tbSafe.Enabled = false;
                this.tbNextLogin.Enabled = false;
                this.tbMailMessages.Enabled = false;
                this.tbHitCount.Enabled = false;
                this.tbAttack.Enabled = false;
                this.tbDefense.Enabled = false;
            }
        }
    }
}
