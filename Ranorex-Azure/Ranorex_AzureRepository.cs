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

namespace Ranorex_Azure
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Ranorex_AzureRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("af63ee45-0729-4e07-8cb4-06dce4c71f5a")]
    public partial class Ranorex_AzureRepository : RepoGenBaseFolder
    {
        static Ranorex_AzureRepository instance = new Ranorex_AzureRepository();
        Ranorex_AzureRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the Ranorex_AzureRepository element repository.
        /// </summary>
        [RepositoryFolder("af63ee45-0729-4e07-8cb4-06dce4c71f5a")]
        public static Ranorex_AzureRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Ranorex_AzureRepository() 
            : base("Ranorex_AzureRepository", "/", null, 0, false, "af63ee45-0729-4e07-8cb4-06dce4c71f5a", ".\\RepositoryImages\\Ranorex_AzureRepositoryaf63ee45.rximgres")
        {
            _applicationundertest = new Ranorex_AzureRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("af63ee45-0729-4e07-8cb4-06dce4c71f5a")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("cd6efaac-9fd2-4c37-8f48-49486e37ff95")]
        public virtual Ranorex_AzureRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Ranorex_AzureRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("cd6efaac-9fd2-4c37-8f48-49486e37ff95")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _genderInfo;
            RepoItemInfo _musicInfo;
            RepoItemInfo _inputtagaddInfo;
            RepoItemInfo _countInfo;
            RepoItemInfo _clearInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "cd6efaac-9fd2-4c37-8f48-49486e37ff95", "")
            {
                _firstnameInfo = new RepoItemInfo(this, "FirstName", ".//input[#'FirstName']", 30000, null, "1a1c629e-78cc-4565-b094-9c0085cdff07");
                _lastnameInfo = new RepoItemInfo(this, "LastName", ".//input[#'LastName']", 30000, null, "ff9b3c98-e4b5-40eb-9a41-a46040b72d71");
                _genderInfo = new RepoItemInfo(this, "Gender", ".//td[#'gender']/table//input[@name='Gender' and @type='radio' and @value='male']", 30000, null, "7138a0fc-6e3c-4744-82f9-f1c3bc8ab386");
                _musicInfo = new RepoItemInfo(this, "Music", ".//select[#'Category']/option[@value='Music']", 30000, null, "afa26c6e-4fe8-4c82-94c2-ccce7a8bef6c");
                _inputtagaddInfo = new RepoItemInfo(this, "InputTagAdd", ".//input[#'Add']", 30000, null, "ad834b89-3d89-42b1-b1c2-f8840c098090");
                _countInfo = new RepoItemInfo(this, "Count", ".//td[#'count']", 30000, null, "b34e588b-45e4-4d4f-8333-e99bcfa5bb57");
                _clearInfo = new RepoItemInfo(this, "Clear", ".//input[#'Clear']", 30000, null, "a62d3e4e-1707-47db-b51e-68b63b3e6ddf");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cd6efaac-9fd2-4c37-8f48-49486e37ff95")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cd6efaac-9fd2-4c37-8f48-49486e37ff95")]
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
            [RepositoryItem("1a1c629e-78cc-4565-b094-9c0085cdff07")]
            public virtual Ranorex.InputTag FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("1a1c629e-78cc-4565-b094-9c0085cdff07")]
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
            [RepositoryItem("ff9b3c98-e4b5-40eb-9a41-a46040b72d71")]
            public virtual Ranorex.InputTag LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("ff9b3c98-e4b5-40eb-9a41-a46040b72d71")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Gender item.
            /// </summary>
            [RepositoryItem("7138a0fc-6e3c-4744-82f9-f1c3bc8ab386")]
            public virtual Ranorex.InputTag Gender
            {
                get
                {
                    return _genderInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Gender item info.
            /// </summary>
            [RepositoryItemInfo("7138a0fc-6e3c-4744-82f9-f1c3bc8ab386")]
            public virtual RepoItemInfo GenderInfo
            {
                get
                {
                    return _genderInfo;
                }
            }

            /// <summary>
            /// The Music item.
            /// </summary>
            [RepositoryItem("afa26c6e-4fe8-4c82-94c2-ccce7a8bef6c")]
            public virtual Ranorex.OptionTag Music
            {
                get
                {
                    return _musicInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The Music item info.
            /// </summary>
            [RepositoryItemInfo("afa26c6e-4fe8-4c82-94c2-ccce7a8bef6c")]
            public virtual RepoItemInfo MusicInfo
            {
                get
                {
                    return _musicInfo;
                }
            }

            /// <summary>
            /// The InputTagAdd item.
            /// </summary>
            [RepositoryItem("ad834b89-3d89-42b1-b1c2-f8840c098090")]
            public virtual Ranorex.InputTag InputTagAdd
            {
                get
                {
                    return _inputtagaddInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagAdd item info.
            /// </summary>
            [RepositoryItemInfo("ad834b89-3d89-42b1-b1c2-f8840c098090")]
            public virtual RepoItemInfo InputTagAddInfo
            {
                get
                {
                    return _inputtagaddInfo;
                }
            }

            /// <summary>
            /// The Count item.
            /// </summary>
            [RepositoryItem("b34e588b-45e4-4d4f-8333-e99bcfa5bb57")]
            public virtual Ranorex.TdTag Count
            {
                get
                {
                    return _countInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The Count item info.
            /// </summary>
            [RepositoryItemInfo("b34e588b-45e4-4d4f-8333-e99bcfa5bb57")]
            public virtual RepoItemInfo CountInfo
            {
                get
                {
                    return _countInfo;
                }
            }

            /// <summary>
            /// The Clear item.
            /// </summary>
            [RepositoryItem("a62d3e4e-1707-47db-b51e-68b63b3e6ddf")]
            public virtual Ranorex.InputTag Clear
            {
                get
                {
                    return _clearInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Clear item info.
            /// </summary>
            [RepositoryItemInfo("a62d3e4e-1707-47db-b51e-68b63b3e6ddf")]
            public virtual RepoItemInfo ClearInfo
            {
                get
                {
                    return _clearInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
