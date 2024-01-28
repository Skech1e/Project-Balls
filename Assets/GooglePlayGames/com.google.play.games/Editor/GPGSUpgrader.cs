// <copyright file="GPGSUpgrader.cs" company="Google Inc.">
// Copyright (C) 2014 Google Inc.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>

#if UNITY_ANDROID

namespace GooglePlayGames.Editor
{
    using System.IO;
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// GPGS upgrader handles performing and upgrade tasks.
    /// </summary>
    [InitializeOnLoad]
    public class GPGSUpgrader
    {
        /// <summary>
        /// Initializes static members of the <see cref="GooglePlayGames.GPGSUpgrader"/> class.
        /// </summary>
        static GPGSUpgrader()
        {
            var xstart = new System.Diagnostics.Stopwatch();
            xstart.Start();
            bool needAssetRefresh = false;
            string initialVer = GPGSProjectSettings.Instance.Get(GPGSUtil.LASTUPGRADEKEY, "00000");
            if (!initialVer.Equals(PluginVersion.VersionKey))
            {
                Debug.Log("Upgrading from format version " + initialVer + " to " + PluginVersion.VersionKey);                

                needAssetRefresh = true;
                Debug.Log("Done all upgrades to " + PluginVersion.VersionKey);

                string msg = GPGSStrings.PostInstall.Text.Replace(
                    "$VERSION",
                    PluginVersion.VersionString);
                EditorUtility.DisplayDialog(GPGSStrings.PostInstall.Title, msg, "OK");
            }

            GPGSProjectSettings.Instance.Set(GPGSUtil.LASTUPGRADEKEY, PluginVersion.VersionKey);
            GPGSProjectSettings.Instance.Set(GPGSUtil.PLUGINVERSIONKEY, PluginVersion.VersionString);
            GPGSProjectSettings.Instance.Save();

            // Check that there is a AndroidManifest.xml file
            if (!GPGSUtil.AndroidManifestExists())
            {
                GPGSUtil.GenerateAndroidManifest();
                needAssetRefresh = true;
            }

            if (needAssetRefresh)
                AssetDatabase.Refresh();

            Debug.LogFormat("GPGSUpgrader complete: took {0} ms", xstart.ElapsedMilliseconds);
        }
    }
}
#endif
