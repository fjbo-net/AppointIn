﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppointIn.Domain.Resources {
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
    internal class AppointmentStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppointmentStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AppointIn.Domain.Resources.AppointmentStrings", typeof(AppointmentStrings).Assembly);
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
        ///   Looks up a localized string similar to Contact information is required..
        /// </summary>
        internal static string ContactRequiredValidationMessage {
            get {
                return ResourceManager.GetString("ContactRequiredValidationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appointment must have a customer selected. Customer ID must be a positive whole number..
        /// </summary>
        internal static string CustomerIdValidationMessage {
            get {
                return ResourceManager.GetString("CustomerIdValidationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Title must not exceed 255 characters long..
        /// </summary>
        internal static string TitleMaxLengthValidationMessage {
            get {
                return ResourceManager.GetString("TitleMaxLengthValidationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Title is required..
        /// </summary>
        internal static string TitleRequiredValidationMessage {
            get {
                return ResourceManager.GetString("TitleRequiredValidationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URL must not exceed 255 characters long..
        /// </summary>
        internal static string UrlMaxLengthValidationMessage {
            get {
                return ResourceManager.GetString("UrlMaxLengthValidationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appointment must have a user selected. User ID must be a positive whole number..
        /// </summary>
        internal static string UserIdValidationMessage {
            get {
                return ResourceManager.GetString("UserIdValidationMessage", resourceCulture);
            }
        }
    }
}
