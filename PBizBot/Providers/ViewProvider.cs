﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Providers
{
    using View;
    using Model;

    public class ViewProvider
    {
        private Main m_mainForm;
        private AppSettings m_appSettings;
        private AccountList m_accountList;
        private AttackList m_attackList;

        public Main MainForm
        {
            set { this.m_mainForm = value; }
        }

        public AppSettings AppSettings
        {
            set { this.m_appSettings = value; }
        }

        public AccountList AccountList
        {
            set { this.m_accountList = value; }
        }

        public AttackList AttackList
        {
            set { this.m_attackList = value; }
        }

        public Boolean IsON
        {
            get { return !m_mainForm.btON.Enabled; }
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            foreach (AccountListItem item in m_accountList.pAccounts.Controls)
            {
                accounts.Add((Account)item.Account);
            }

            return accounts;
        }

        public void UpdateAccountInformation(Account account)
        {
            foreach (AccountListItem item in m_accountList.pAccounts.Controls)
            {
                if (item.Account.Login.Equals(account.Login))
                {
                    item.Account = account;
                    return;
                }
            }
        }

        public void SetTime()
        {
            foreach (AccountListItem item in m_accountList.pAccounts.Controls)
            {
                Account account = item.Account;
                if (account.Enabled)
                {
                    TimeSpan interval = account.SchedulerTrigger.StartTimeUtc - DateTime.UtcNow;
                    item.Account.NextLoginTime = interval;

                    m_accountList.pAccounts.Invoke((Action)(delegate
                    {
                        item.tbNextLogin.Text = interval.ToString(@"hh\:mm\:ss");
                    }));
                }
                else
                {
                    m_accountList.pAccounts.Invoke((Action)(delegate
                    {
                        item.tbNextLogin.Text = "Nie wystartowany!";
                    }));
                }
            }
        }

        public void PrintLog(String message)
        {
            try
            {
                m_mainForm.Invoke((Action)(delegate
                {
                    m_mainForm.rtbMainLog.AppendText(message);
                }));
            }
            catch { }
        }
    }
}
