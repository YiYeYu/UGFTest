using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using UnityGameFramework.Editor;
using UnityGameFramework.Editor.ResourceTools;
using System.IO;

public static class GFConfig
{
    [BuildSettingsConfigPath]
    public static string BuildSettingsConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "Configs/BuildSettings.xml"));

    [ResourceCollectionConfigPath]
    public static string ResourceCollectionConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "Configs/ResourceCollection.xml"));

    [ResourceEditorConfigPath]
    public static string ResourceEditorConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "Configs/ResourceEditor.xml"));

    [ResourceBuilderConfigPath]
    public static string ResourceBuilderConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "Configs/ResourceBuilder.xml"));
}
