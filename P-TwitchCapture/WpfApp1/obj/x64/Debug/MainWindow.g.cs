﻿#pragma checksum "..\..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8AC13753946B11F7354167361BB62546A65EF1FB04AD6F827915E0DEE34FED1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SoundCapture;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PTwitchCapture {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLog;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress_P2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butReset;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress_P1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slide_Bal;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVar;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtP1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtP2;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkPause;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkAutoReset;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkOneside;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox apgInterface;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkData_on;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLog_Data;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butData_reset;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butData_export;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butData_open;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butData_stop;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkData_autoStart;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkSentiment;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkV2;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butApply;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkFTG_HP;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFile;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkFTG;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkFTG2;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_oneSide_numParticipant;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_oneSide_label1;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_oneSide_rate;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_oneSide_label1_Copy;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button but_oneSide_cal;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_oneSide_avg;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboFavor;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sent_input;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sent_but;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sent_output;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P-TwitchCapture;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtLog = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.txtLog.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtLog_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.progress_P2 = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 3:
            this.butReset = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.butReset.Click += new System.Windows.RoutedEventHandler(this.butTune_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.progress_P1 = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.slide_Bal = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.txtVar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtP1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtP2 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.checkPause = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.checkPause.Checked += new System.Windows.RoutedEventHandler(this.checkPause_Checked);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.checkPause.Unchecked += new System.Windows.RoutedEventHandler(this.checkPause_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.checkAutoReset = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.checkOneside = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.checkOneside.Checked += new System.Windows.RoutedEventHandler(this.checkOneSide_Checked);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.checkOneside.Unchecked += new System.Windows.RoutedEventHandler(this.checkOneSide_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.apgInterface = ((System.Windows.Controls.CheckBox)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.apgInterface.Checked += new System.Windows.RoutedEventHandler(this.checkOneSide_Checked);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.apgInterface.Unchecked += new System.Windows.RoutedEventHandler(this.checkOneSide_Checked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.checkData_on = ((System.Windows.Controls.CheckBox)(target));
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.checkData_on.Unchecked += new System.Windows.RoutedEventHandler(this.checkData_on_Checked);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.checkData_on.Checked += new System.Windows.RoutedEventHandler(this.checkData_on_Checked);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txtLog_Data = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.butData_reset = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.butData_reset.Click += new System.Windows.RoutedEventHandler(this.butData_reset_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.butData_export = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\MainWindow.xaml"
            this.butData_export.Click += new System.Windows.RoutedEventHandler(this.butData_export_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.butData_open = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\MainWindow.xaml"
            this.butData_open.Click += new System.Windows.RoutedEventHandler(this.butData_open_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.butData_stop = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.butData_stop.Click += new System.Windows.RoutedEventHandler(this.butData_stop_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.checkData_autoStart = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.checkData_autoStart.Unchecked += new System.Windows.RoutedEventHandler(this.checkData_autoStart_Checked);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.checkData_autoStart.Checked += new System.Windows.RoutedEventHandler(this.checkData_autoStart_Checked);
            
            #line default
            #line hidden
            return;
            case 20:
            this.checkSentiment = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 21:
            this.checkV2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 22:
            this.butApply = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\MainWindow.xaml"
            this.butApply.Click += new System.Windows.RoutedEventHandler(this.ButApply_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.checkFTG_HP = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 24:
            this.txtFile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 25:
            this.checkFTG = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 26:
            this.checkFTG2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 27:
            this.txt_oneSide_numParticipant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 28:
            this.txt_oneSide_label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.txt_oneSide_rate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 30:
            this.txt_oneSide_label1_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 31:
            this.but_oneSide_cal = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\MainWindow.xaml"
            this.but_oneSide_cal.Click += new System.Windows.RoutedEventHandler(this.but_oneSide_cal_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            this.txt_oneSide_avg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 33:
            this.comboFavor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 93 "..\..\..\MainWindow.xaml"
            this.comboFavor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboFavor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 34:
            this.sent_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.sent_but = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\MainWindow.xaml"
            this.sent_but.Click += new System.Windows.RoutedEventHandler(this.sent_but_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            this.sent_output = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

