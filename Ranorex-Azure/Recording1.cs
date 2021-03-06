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

namespace Ranorex_Azure
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("dca509e3-728b-4b43-a3f5-40e7e0f8159d", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Ranorex_AzureRepository repository.
        /// </summary>
        public static Ranorex_AzureRepository repo = Ranorex_AzureRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 500;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FirstName' at 27;9.", repo.ApplicationUnderTest.FirstNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FirstName.Click("27;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Mubin' with focus on 'ApplicationUnderTest.FirstName'.", repo.ApplicationUnderTest.FirstNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FirstName.PressKeys("Mubin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LastName' at 30;5.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LastName.Click("30;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Kadiwala' with focus on 'ApplicationUnderTest.LastName'.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LastName.PressKeys("Kadiwala");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Gender' at 7;5.", repo.ApplicationUnderTest.GenderInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Gender.Click("7;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Music' at 30;11.", repo.ApplicationUnderTest.MusicInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Music.Click("30;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagAdd' at 23;15.", repo.ApplicationUnderTest.InputTagAddInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.InputTagAdd.Click("23;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='VIP count: 1') on item 'ApplicationUnderTest.Count'.", repo.ApplicationUnderTest.CountInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CountInfo, "InnerText", "VIP count: 1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Clear' at 31;12.", repo.ApplicationUnderTest.ClearInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Clear.Click("31;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
