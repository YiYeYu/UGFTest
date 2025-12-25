//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityEngine;

namespace Game
{
    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {
        public static cfg.TablesComponent tablesComponent
        {
            get;
            private set;
        }

        private static void InitCustomComponents()
        {
            tablesComponent = UnityGameFramework.Runtime.GameEntry.GetComponent<cfg.TablesComponent>();
        }
    }
}
