﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emscripten.Build.CppTasks.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Emscripten.Build.CppTasks.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   Tracking command: に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Native_TrackingCommandMessage {
            get {
                return ResourceManager.GetString("Native_TrackingCommandMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   MSB8016: Can not turn on Unicode output for &quot;{0}&quot;. Some Unicode characters will be improperly displayed. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TrackedVCToolTask_CreateUnicodeOutputPipeFailed {
            get {
                return ResourceManager.GetString("TrackedVCToolTask.CreateUnicodeOutputPipeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Forcing rebuild of all source files due to a change in the command line since the last build. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TrackedVCToolTask_RebuildingAllSourcesCommandLineChanged {
            get {
                return ResourceManager.GetString("TrackedVCToolTask.RebuildingAllSourcesCommandLineChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   MSB8014: Forcing a rebuild of all sources due to an error with the tracking logs. {0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TrackedVCToolTask_RebuildingDueToInvalidTLog {
            get {
                return ResourceManager.GetString("TrackedVCToolTask.RebuildingDueToInvalidTLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   MSB8015: Forcing a rebuild of all source files due to the contents of &quot;{0}&quot; being invalid. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TrackedVCToolTask_RebuildingDueToInvalidTLogContents {
            get {
                return ResourceManager.GetString("TrackedVCToolTask.RebuildingDueToInvalidTLogContents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Forcing rebuild of all source files due to missing command tlog &quot;{0}&quot;. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TrackedVCToolTask_RebuildingNoCommandTLog {
            get {
                return ResourceManager.GetString("TrackedVCToolTask.RebuildingNoCommandTLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Forcing rebuild of source file &quot;{0}&quot; due to a change in the command line since the last build. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TrackedVCToolTask_RebuildingSourceCommandLineChanged {
            get {
                return ResourceManager.GetString("TrackedVCToolTask.RebuildingSourceCommandLineChanged", resourceCulture);
            }
        }
    }
}
