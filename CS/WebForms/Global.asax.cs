﻿using System;
using Reports;

namespace WebForms {
    public class Global : System.Web.HttpApplication {

        void Application_Start(object sender, EventArgs e) {
            ProductReport prod = new ProductReport();
        }

        void Application_End(object sender, EventArgs e) {
        }

        void Application_Error(object sender, EventArgs e) {
        }

        void Session_Start(object sender, EventArgs e) {
        }

        void Session_End(object sender, EventArgs e) {
        }
    }
}
