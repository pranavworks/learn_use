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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace WindowsApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the WindowsAppRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3631cd05-2756-4ffd-b625-cbd4e1085288")]
    public partial class WindowsAppRepository : RepoGenBaseFolder
    {
        static WindowsAppRepository instance = new WindowsAppRepository();

        /// <summary>
        /// Gets the singleton class instance representing the WindowsAppRepository element repository.
        /// </summary>
        [RepositoryFolder("3631cd05-2756-4ffd-b625-cbd4e1085288")]
        public static WindowsAppRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public WindowsAppRepository() 
            : base("WindowsAppRepository", "/", null, 0, false, "3631cd05-2756-4ffd-b625-cbd4e1085288", ".\\RepositoryImages\\WindowsAppRepository3631cd05.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3631cd05-2756-4ffd-b625-cbd4e1085288")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class WindowsAppRepositoryFolders
    {
    }
#pragma warning restore 0436
}
