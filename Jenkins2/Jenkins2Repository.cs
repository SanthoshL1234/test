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

namespace Jenkins2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Jenkins2Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("eef1f75e-5a0e-4d40-b1ee-871467b39539")]
    public partial class Jenkins2Repository : RepoGenBaseFolder
    {
        static Jenkins2Repository instance = new Jenkins2Repository();

        /// <summary>
        /// Gets the singleton class instance representing the Jenkins2Repository element repository.
        /// </summary>
        [RepositoryFolder("eef1f75e-5a0e-4d40-b1ee-871467b39539")]
        public static Jenkins2Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Jenkins2Repository() 
            : base("Jenkins2Repository", "/", null, 0, false, "eef1f75e-5a0e-4d40-b1ee-871467b39539", ".\\RepositoryImages\\Jenkins2Repositoryeef1f75e.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("eef1f75e-5a0e-4d40-b1ee-871467b39539")]
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
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class Jenkins2RepositoryFolders
    {
    }
#pragma warning restore 0436
}