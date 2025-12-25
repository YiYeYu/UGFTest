//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.DataTable;
using System;
using UnityGameFramework.Runtime;

namespace Game
{
    public static class EntityExtension
    {
        // 关于 EntityId 的约定：
        // 0 为自动生成一个不重复id
        // 正值用于和服务器通信的实体（如玩家角色、NPC、怪等，服务器只产生正值）
        // 负值用于本地生成的临时实体（如特效、FakeObject等）
        private static int s_SerialId = 0;

        public static Entity GetGameEntity(this EntityComponent entityComponent, int entityId)
        {
            UnityGameFramework.Runtime.Entity entity = entityComponent.GetEntity(entityId);
            if (entity == null)
            {
                return null;
            }

            return (Entity)entity.Logic;
        }

        public static void HideEntity(this EntityComponent entityComponent, Entity entity)
        {
            entityComponent.HideEntity(entity.Entity);
        }

        public static void AttachEntity(this EntityComponent entityComponent, Entity entity, int ownerId, string parentTransformPath = null, object userData = null)
        {
            entityComponent.AttachEntity(entity.Entity, ownerId, parentTransformPath, userData);
        }

        public static int ShowEntity<T>(this EntityComponent entityComponent, cfg.Entity.EntityID id, int serialId = 0, int priority = 0)
        {
            var data = GameEntry.tablesComponent.TbEntityLogic.Get(id);
            if (data == null)
            {
                Log.Warning("Data is invalid.");
                return serialId;
            }

            var groupInfo = GameEntry.tablesComponent.TbGroup.Get(data.Group);

            if (priority <= 0)
            {
                priority = data.Priority;
            }

            if (serialId == 0)
            {
                serialId = entityComponent.GenerateSerialId();
            }

            entityComponent.ShowEntity(serialId, typeof(T), AssetUtility.GetEntityAsset(data.AssetName), groupInfo.GroupName, priority, data);

            return serialId;
        }

        public static int GenerateSerialId(this EntityComponent entityComponent)
        {
            return --s_SerialId;
        }
    }
}
