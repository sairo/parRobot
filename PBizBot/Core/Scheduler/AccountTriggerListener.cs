﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;


namespace PBizBot.Core.Scheduler
{
    using Providers;
    using Spring.Scheduling.Quartz;

    public class AccountTriggerListener : ITriggerListener
    {
        private SqlDataProvider m_sqlDataProvider;
        private IScheduler m_schedulerFactory;

        public SqlDataProvider SqlDataProvider
        {
            set { this.m_sqlDataProvider = value; }
        }

        public IScheduler SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }

        public string Name
        {
            get { return "AccountTriggerListener"; }
        }

        public void TriggerComplete(Trigger trigger, JobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            //SimpleTriggerObject oldTrigger = (SimpleTriggerObject)trigger;

            //oldTrigger.RepeatInterval = new TimeSpan(0, 0, 10);

            //oldTrigger.AfterPropertiesSet();

           // m_schedulerFactory.RescheduleJob(oldTrigger.Name, oldTrigger.Group, oldTrigger);

        }

        public void TriggerFired(Trigger trigger, JobExecutionContext context)
        {

        }

        public void TriggerMisfired(Trigger trigger)
        {
            
        }

        public bool VetoJobExecution(Trigger trigger, JobExecutionContext context)
        {
            return false;
        }
    }
}