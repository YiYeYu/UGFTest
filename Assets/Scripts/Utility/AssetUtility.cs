//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework;

public static class AssetUtility
{
    public const string GAME_NAME = "EdgeMatch";

    public static string GetLubanAsset(string assetName, string game = "")
    {
        if (string.IsNullOrEmpty(game))
        {
            game = GAME_NAME;
        }
        return Utility.Text.Format("Assets/LocalResources/{1}/Luban/bytes/{0}.bytes", assetName, game);
    }

    public static string GetEntityAsset(string assetName, string game = "")
    {
        if (string.IsNullOrEmpty(game))
        {
            game = GAME_NAME;
        }
        return Utility.Text.Format("Assets/LocalResources/{1}/Prefabs/{0}.prefab", assetName, game);
    }

    public static string GetUIFormAsset(string assetName, string game = "")
    {
        if (string.IsNullOrEmpty(game))
        {
            game = GAME_NAME;
        }
        return Utility.Text.Format("Assets/LocalResources/{1}/Prefabs/{0}.prefab", assetName, game);
    }

}