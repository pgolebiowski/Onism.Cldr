﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onism.Cldr.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CldrJsonSchemas {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CldrJsonSchemas() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Onism.Cldr.Resources.CldrJsonSchemas", typeof(CldrJsonSchemas).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;availableLocales&quot;: { &quot;$ref&quot;: &quot;#/definitions/availableLocales&quot; }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;availableLocales&quot; ],
        ///
        ///  &quot;definitions&quot;: {
        ///    
        ///    &quot;availableLocales&quot;: {
        ///      &quot;type&quot;: &quot;object&quot;,
        ///      &quot;properties&quot;: {
        ///      	&quot;modern&quot;: { &quot;$ref&quot;: &quot;#/definitions/modern&quot; },
        ///    	&quot;full&quot;: { &quot;$ref&quot;: &quot;#/definitions/full&quot; }
        ///      },
        ///      &quot;additionalProperties&quot;: false,
        ///	  &quot;requi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AvailableLocales {
            get {
                return ResourceManager.GetString("AvailableLocales", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;defaultContent&quot;: {
        ///      &quot;type&quot;: &quot;array&quot;,
        ///      &quot;items&quot;: { &quot;type&quot;: &quot;string&quot; },
        ///      &quot;uniqueItems&quot;: true
        ///    }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;defaultContent&quot; ]
        ///}
        ///.
        /// </summary>
        internal static string DefaultContent {
            get {
                return ResourceManager.GetString("DefaultContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;main&quot;:						{ &quot;$ref&quot;: &quot;#/definitions/main&quot; }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;main&quot; ],
        ///
        ///  &quot;definitions&quot;: {
        ///
        ///    &quot;main&quot;: {
        ///      &quot;type&quot;: &quot;object&quot;,
        ///      &quot;patternProperties&quot;: {
        ///        &quot;^[a-zA-Z0-9-]+$&quot;:		{ &quot;$ref&quot;: &quot;#/definitions/locale&quot; }
        ///      },
        ///      &quot;additionalProperties&quot;: false,
        ///      &quot;minProperties&quot;: 1,
        ///      &quot;maxProperties&quot;: 1
        ///    },
        ///
        ///    &quot;locale&quot;: {
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Main {
            get {
                return ResourceManager.GetString("Main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;rbnf&quot;:						{ &quot;$ref&quot;: &quot;#/definitions/rbnf&quot; }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;rbnf&quot; ],
        ///
        ///  &quot;definitions&quot;: {
        ///
        ///    &quot;rbnf&quot;: {
        ///      &quot;type&quot;: &quot;object&quot;,
        ///      &quot;properties&quot;: {
        ///        &quot;identity&quot;:				{ &quot;$ref&quot;: &quot;#/definitions/identity&quot; },
        ///        &quot;rbnf&quot;:					{ &quot;type&quot;: &quot;object&quot; }
        ///      },
        ///      &quot;additionalProperties&quot;: false,
        ///      &quot;required&quot;: [ &quot;identity&quot;, &quot;rbnf&quot; ]
        ///    },
        ///
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Rbnf {
            get {
                return ResourceManager.GetString("Rbnf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;scriptMetadata&quot;: {
        ///      &quot;type&quot;: &quot;object&quot;
        ///    }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;scriptMetadata&quot; ]
        ///}
        ///.
        /// </summary>
        internal static string ScriptMetadata {
            get {
                return ResourceManager.GetString("ScriptMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;segments&quot;: { &quot;$ref&quot;: &quot;#/definitions/segments&quot; }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;segments&quot; ],
        ///
        ///  &quot;definitions&quot;: {
        ///    
        ///    &quot;segments&quot;: {
        ///      &quot;type&quot;: &quot;object&quot;,
        ///      &quot;properties&quot;: {
        ///        &quot;identity&quot;:       { &quot;$ref&quot;: &quot;#/definitions/identity&quot; },
        ///        &quot;segmentations&quot;:  { &quot;type&quot;: &quot;object&quot; }
        ///      },
        ///      &quot;additionalProperties&quot;: false,
        ///      &quot;required&quot;: [ &quot;identity [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Segments {
            get {
                return ResourceManager.GetString("Segments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///
        ///  &quot;type&quot;: &quot;object&quot;,
        ///  &quot;properties&quot;: {
        ///    &quot;supplemental&quot;: { &quot;$ref&quot;: &quot;#/definitions/supplemental&quot; }
        ///  },
        ///  &quot;additionalProperties&quot;: false,
        ///  &quot;required&quot;: [ &quot;supplemental&quot; ],
        ///
        ///  &quot;definitions&quot;: {
        ///    
        ///    &quot;supplemental&quot;: {
        ///      &quot;type&quot;: &quot;object&quot;,
        ///      &quot;properties&quot;: {
        ///        &quot;version&quot;: { &quot;$ref&quot;: &quot;#/definitions/version&quot; }
        ///      },
        ///      &quot;patternProperties&quot;: {
        ///        &quot;^[a-zA-Z-]+$&quot;:    { &quot;type&quot;: &quot;object&quot; }
        ///      },
        ///      &quot;additionalPr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Supplemental {
            get {
                return ResourceManager.GetString("Supplemental", resourceCulture);
            }
        }
    }
}
