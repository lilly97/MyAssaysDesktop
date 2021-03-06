﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssaysDesktopExplorer
{
    public partial class CloseNPW
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_Закрити()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Закрити' at 19;17.", repo.NewProtocolWizard.ЗакритиInfo);
            repo.NewProtocolWizard.Закрити.Click();

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'MyAssaysExplorer'.", repo.MyAssaysExplorer.SelfInfo, new RecordItemIndex(4));
            Host.Local.CloseApplication(repo.MyAssaysExplorer.Self, new Duration(0));
            Delay.Milliseconds(0);
        }

    }
}