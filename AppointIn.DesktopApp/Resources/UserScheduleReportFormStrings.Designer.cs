﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppointIn.DesktopApp.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UserScheduleReportFormStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserScheduleReportFormStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AppointIn.DesktopApp.Resources.UserScheduleReportFormStrings", typeof(UserScheduleReportFormStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1} {2} schedule for user &quot;{0}&quot;:.
        /// </summary>
        internal static string AppointmentsFoundForUserMessage {
            get {
                return ResourceManager.GetString("AppointmentsFoundForUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduled appointments for all users between the dates:.
        /// </summary>
        internal static string DescriptionLabelText {
            get {
                return ResourceManager.GetString("DescriptionLabelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To:.
        /// </summary>
        internal static string EndLabelText {
            get {
                return ResourceManager.GetString("EndLabelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &quot;{0}&quot; has no appointments scheduled..
        /// </summary>
        internal static string NoAppointmentsFoundForUserMessage {
            get {
                return ResourceManager.GetString("NoAppointmentsFoundForUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from {0} to {1}..
        /// </summary>
        internal static string ReportDateRangeMessage {
            get {
                return ResourceManager.GetString("ReportDateRangeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to From:.
        /// </summary>
        internal static string StartLabelText {
            get {
                return ResourceManager.GetString("StartLabelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Report: Users Schedule.
        /// </summary>
        internal static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}
