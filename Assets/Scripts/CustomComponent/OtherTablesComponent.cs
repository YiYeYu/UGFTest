
using Luban;
using GameFramework;
using UnityGameFramework.Runtime;
using System.Threading.Tasks;
using System.IO;
using UnityEngine;
using GameFramework.Resource;
using System;

namespace cfg
{
    public partial class TablesComponent : GameFrameworkComponent
    {
        protected override void Awake()
        {
            base.Awake();
        }

        async void Start()
        {
            // 等待gf初始化完成
            await Task.Delay(500);

            Task<ByteBuf> loader(string assetName)
            {
                string file = AssetUtility.GetLubanAsset(assetName);
                Debug.LogFormat("start Load Luban asset: {0}: {1}", assetName, file);
                var tcs = new TaskCompletionSource<ByteBuf>();
                var resourceComponent = GameEntry.GetComponent<ResourceComponent>();
                resourceComponent.LoadAsset(
                    file,
                    typeof(TextAsset),
                    new LoadAssetCallbacks(
                        (assetName, asset, duration, userData) =>
                        {
                            Debug.LogFormat("Load Luban asset: {0}: {1}", assetName, file);
                            tcs.SetResult(new ByteBuf((asset as TextAsset).bytes));
                        },
                        (assetName, status, errorMessage, userData) =>
                        {
                            tcs.SetException(new Exception(errorMessage));
                        }
                    )
                );
                return tcs.Task;
            }

            UnityEngine.Debug.Log("LoadAsync Luban TablesComponent before start");
            await LoadAsync(loader);
        }
    }
}
