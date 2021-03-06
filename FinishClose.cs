﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Repository;

namespace MyAssaysDesktopExplorer
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FinishClose recording.
    /// </summary>
    [TestModule("06e37d56-31c9-4a14-93dd-a66ae7899c4f", ModuleType.Recording, 1)]
    public partial class FinishClose : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssaysDesktopExplorerRepository repository.
        /// </summary>
        public static MyAssaysDesktopExplorerRepository repo = MyAssaysDesktopExplorerRepository.Instance;

        static FinishClose instance = new FinishClose();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FinishClose()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FinishClose Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.IndeterminateMark' at 5;5.", repo.NewProtocolWizard.SomeContainer2.IndeterminateMarkInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeContainer2.IndeterminateMark.Click("5;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.Copy_of_IndeterminateMark'.", repo.NewProtocolWizard.Copy_of_IndeterminateMarkInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.Copy_of_IndeterminateMark.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.Finish' at 30;13.", repo.NewProtocolWizard.SomeContainer2.FinishInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.SomeContainer2.Finish.Click("30;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
