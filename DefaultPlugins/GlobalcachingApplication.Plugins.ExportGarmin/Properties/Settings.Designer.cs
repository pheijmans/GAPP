﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalcachingApplication.Plugins.ExportGarmin.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeNeeded {
            get {
                return ((bool)(this["UpgradeNeeded"]));
            }
            set {
                this["UpgradeNeeded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public int MaxGeocacheNameLength {
            get {
                return ((int)(this["MaxGeocacheNameLength"]));
            }
            set {
                this["MaxGeocacheNameLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public int MinStartOfGeocacheName {
            get {
                return ((int)(this["MinStartOfGeocacheName"]));
            }
            set {
                this["MinStartOfGeocacheName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddFieldNotesToDescription {
            get {
                return ((bool)(this["AddFieldNotesToDescription"]));
            }
            set {
                this["AddFieldNotesToDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AddChildWaypoints {
            get {
                return ((bool)(this["AddChildWaypoints"]));
            }
            set {
                this["AddChildWaypoints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SeperateFilePerGeocache {
            get {
                return ((bool)(this["SeperateFilePerGeocache"]));
            }
            set {
                this["SeperateFilePerGeocache"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseNameAndNotCode {
            get {
                return ((bool)(this["UseNameAndNotCode"]));
            }
            set {
                this["UseNameAndNotCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddWaypointsToDescription {
            get {
                return ((bool)(this["AddWaypointsToDescription"]));
            }
            set {
                this["AddWaypointsToDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseHintsForDescription {
            get {
                return ((bool)(this["UseHintsForDescription"]));
            }
            set {
                this["UseHintsForDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseDatabaseNameForFileName {
            get {
                return ((bool)(this["UseDatabaseNameForFileName"]));
            }
            set {
                this["UseDatabaseNameForFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CreateGGZFile {
            get {
                return ((bool)(this["CreateGGZFile"]));
            }
            set {
                this["CreateGGZFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GPXVersionStr {
            get {
                return ((string)(this["GPXVersionStr"]));
            }
            set {
                this["GPXVersionStr"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CorrectedNamePrefix {
            get {
                return ((string)(this["CorrectedNamePrefix"]));
            }
            set {
                this["CorrectedNamePrefix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddImages {
            get {
                return ((bool)(this["AddImages"]));
            }
            set {
                this["AddImages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AddExtraInfoToDescription {
            get {
                return ((bool)(this["AddExtraInfoToDescription"]));
            }
            set {
                this["AddExtraInfoToDescription"] = value;
            }
        }
    }
}
