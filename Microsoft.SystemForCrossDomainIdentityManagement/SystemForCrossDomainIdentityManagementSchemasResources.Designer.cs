﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mod.SCIM {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SystemForCrossDomainIdentityManagementSchemasResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SystemForCrossDomainIdentityManagementSchemasResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mod.SCIM.SystemForCrossDomainIdentityManagementSchemasResources", typeof(SystemForCrossDomainIdentityManagementSchemasResources).Assembly);
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
        ///   Looks up a localized string similar to The event token has expired..
        /// </summary>
        internal static string ExceptionEventTokenExpired {
            get {
                return ResourceManager.GetString("ExceptionEventTokenExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This value is invalid for the claim, {0}: {1}..
        /// </summary>
        internal static string ExceptionEventTokenInvalidClaimValueTemplate {
            get {
                return ResourceManager.GetString("ExceptionEventTokenInvalidClaimValueTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The token is missing a value for this required claim: {0}..
        /// </summary>
        internal static string ExceptionEventTokenMissingClaimTemplate {
            get {
                return ResourceManager.GetString("ExceptionEventTokenMissingClaimTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attribute is invalid..
        /// </summary>
        internal static string ExceptionInvalidAttribute {
            get {
                return ResourceManager.GetString("ExceptionInvalidAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This identifier is invalid: {0}..
        /// </summary>
        internal static string ExceptionInvalidIdentifierTemplate {
            get {
                return ResourceManager.GetString("ExceptionInvalidIdentifierTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This type of resource can only have one resource type schema identifier: {0}..
        /// </summary>
        internal static string ExceptionMultipleQualifiedResourceTypeIdentifiersTemplate {
            get {
                return ResourceManager.GetString("ExceptionMultipleQualifiedResourceTypeIdentifiersTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value greater than zero is required for this argument: {0}..
        /// </summary>
        internal static string ExceptionPostiveIntegerRangeTemplate {
            get {
                return ResourceManager.GetString("ExceptionPostiveIntegerRangeTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following cannot be assigned to the &quot;value&quot; attribute of an Azure Active Directory role: {0}.  It exceeds the maximum permissible length for that attribute, which is this many characters: {1}..
        /// </summary>
        internal static string ExceptionRoleValueLengthExceededTemplate {
            get {
                return ResourceManager.GetString("ExceptionRoleValueLengthExceededTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only a single event was expected..
        /// </summary>
        internal static string ExceptionSingleEventExpected {
            get {
                return ResourceManager.GetString("ExceptionSingleEventExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An authentication scheme must have a name..
        /// </summary>
        internal static string ExceptionUnnamedAuthenticationScheme {
            get {
                return ResourceManager.GetString("ExceptionUnnamedAuthenticationScheme", resourceCulture);
            }
        }
    }
}
