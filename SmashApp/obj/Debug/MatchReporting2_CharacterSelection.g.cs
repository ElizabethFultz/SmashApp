#pragma checksum "..\..\MatchReporting2_CharacterSelection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9AFE87929CC36C7CEADA42D37C33234EFECB5528FE70A9EEFC7F3ECED4E4D740"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SmashApp;
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


namespace SmashApp {
    
    
    /// <summary>
    /// MatchReporting2_CharacterSelection
    /// </summary>
    public partial class MatchReporting2_CharacterSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Logo;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CharacterSelection_Label;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Player1Character_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Player2Character_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContinueToStageSelection;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Player1Name_Textblock;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\MatchReporting2_CharacterSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Player2Name_Textblock;
        
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
            System.Uri resourceLocater = new System.Uri("/SmashApp;component/matchreporting2_characterselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MatchReporting2_CharacterSelection.xaml"
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
            this.Logo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.CharacterSelection_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Player1Character_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Player2Character_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ContinueToStageSelection = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\MatchReporting2_CharacterSelection.xaml"
            this.ContinueToStageSelection.Click += new System.Windows.RoutedEventHandler(this.ContinueToStageSelection_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Player1Name_Textblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Player2Name_Textblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

