﻿using System.Web.Mvc;

namespace Ext.Net.MVC.Examples.Areas.Kitchen_Sink_Panels
{
    public class Kitchen_Sink_PanelsAreaRegistration : AreaRegistration
    {

        private string areaName;

        public override string AreaName
        {
            get
            {
                if (areaName == null)
                {
                    areaName = ExampleAreaRegistration.ParseAreaName(GetType());
                }

                return areaName;
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            ExampleAreaRegistration.RegisterArea(context, AreaName);
        }
    }
}
