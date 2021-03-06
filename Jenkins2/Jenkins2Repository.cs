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
        Jenkins2RepositoryFolders.FormVipApplicationAppFolder _formvipapplication;

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
            _formvipapplication = new Jenkins2RepositoryFolders.FormVipApplicationAppFolder(this);
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

        /// <summary>
        /// The FormVipApplication folder.
        /// </summary>
        [RepositoryFolder("a067d6c4-68b6-472d-8969-ac1dcc06a177")]
        public virtual Jenkins2RepositoryFolders.FormVipApplicationAppFolder FormVipApplication
        {
            get { return _formvipapplication; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class Jenkins2RepositoryFolders
    {
        /// <summary>
        /// The FormVipApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("a067d6c4-68b6-472d-8969-ac1dcc06a177")]
        public partial class FormVipApplicationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _musicInfo;
            RepoItemInfo _rbmaleInfo;
            RepoItemInfo _btaddInfo;
            RepoItemInfo _btdeleteInfo;
            RepoItemInfo _closeInfo;

            /// <summary>
            /// Creates a new FormVipApplication  folder.
            /// </summary>
            public FormVipApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FormVipApplication", "/form[@controlname='formVipApplication']", parentFolder, 30000, null, true, "a067d6c4-68b6-472d-8969-ac1dcc06a177", "")
            {
                _firstnameInfo = new RepoItemInfo(this, "FirstName", "?/?/text[@accessiblename='First Name:']", 30000, null, "ba3fb369-7a00-44a3-bfc7-f42c5035ef4f");
                _lastnameInfo = new RepoItemInfo(this, "LastName", "?/?/text[@accessiblename='Last Name:']", 30000, null, "b8e3a5f2-146a-434d-8720-e4a719b17a6a");
                _musicInfo = new RepoItemInfo(this, "Music", "list[@controlname='lbCategory']/?/?/listitem[@accessiblename='Music']", 30000, null, "dc0d2286-81dd-40d2-be6f-0e96a8d9fd1f");
                _rbmaleInfo = new RepoItemInfo(this, "RbMale", "?/?/radiobutton[@controlname='rbMale']", 30000, null, "eb3a4269-7500-4c12-9503-1ca87744d57e");
                _btaddInfo = new RepoItemInfo(this, "BtAdd", "button[@controlname='btAdd']", 30000, null, "db9759f4-ed82-4ce8-9f77-045ce33040f0");
                _btdeleteInfo = new RepoItemInfo(this, "BtDelete", "button[@controlname='btDelete']", 30000, null, "68f2d159-14c0-4dfa-b7c0-b87003ed44cb");
                _closeInfo = new RepoItemInfo(this, "Close", "?/?/button[@accessiblename='Close']", 30000, null, "b5e01868-9ea3-4aa9-8234-0a5472f887f4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a067d6c4-68b6-472d-8969-ac1dcc06a177")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a067d6c4-68b6-472d-8969-ac1dcc06a177")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("ba3fb369-7a00-44a3-bfc7-f42c5035ef4f")]
            public virtual Ranorex.Text FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("ba3fb369-7a00-44a3-bfc7-f42c5035ef4f")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("b8e3a5f2-146a-434d-8720-e4a719b17a6a")]
            public virtual Ranorex.Text LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("b8e3a5f2-146a-434d-8720-e4a719b17a6a")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Music item.
            /// </summary>
            [RepositoryItem("dc0d2286-81dd-40d2-be6f-0e96a8d9fd1f")]
            public virtual Ranorex.ListItem Music
            {
                get
                {
                    return _musicInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Music item info.
            /// </summary>
            [RepositoryItemInfo("dc0d2286-81dd-40d2-be6f-0e96a8d9fd1f")]
            public virtual RepoItemInfo MusicInfo
            {
                get
                {
                    return _musicInfo;
                }
            }

            /// <summary>
            /// The RbMale item.
            /// </summary>
            [RepositoryItem("eb3a4269-7500-4c12-9503-1ca87744d57e")]
            public virtual Ranorex.RadioButton RbMale
            {
                get
                {
                    return _rbmaleInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RbMale item info.
            /// </summary>
            [RepositoryItemInfo("eb3a4269-7500-4c12-9503-1ca87744d57e")]
            public virtual RepoItemInfo RbMaleInfo
            {
                get
                {
                    return _rbmaleInfo;
                }
            }

            /// <summary>
            /// The BtAdd item.
            /// </summary>
            [RepositoryItem("db9759f4-ed82-4ce8-9f77-045ce33040f0")]
            public virtual Ranorex.Button BtAdd
            {
                get
                {
                    return _btaddInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtAdd item info.
            /// </summary>
            [RepositoryItemInfo("db9759f4-ed82-4ce8-9f77-045ce33040f0")]
            public virtual RepoItemInfo BtAddInfo
            {
                get
                {
                    return _btaddInfo;
                }
            }

            /// <summary>
            /// The BtDelete item.
            /// </summary>
            [RepositoryItem("68f2d159-14c0-4dfa-b7c0-b87003ed44cb")]
            public virtual Ranorex.Button BtDelete
            {
                get
                {
                    return _btdeleteInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtDelete item info.
            /// </summary>
            [RepositoryItemInfo("68f2d159-14c0-4dfa-b7c0-b87003ed44cb")]
            public virtual RepoItemInfo BtDeleteInfo
            {
                get
                {
                    return _btdeleteInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("b5e01868-9ea3-4aa9-8234-0a5472f887f4")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("b5e01868-9ea3-4aa9-8234-0a5472f887f4")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}