﻿using UnityEngine;

namespace MM26
{
    /// <summary>
    /// Describes how the scene can be loaded. Should be configured
    /// after <c>DataFetched</c> event
    /// </summary>
    [CreateAssetMenu(menuName = "Configuration/Scene Configuration", fileName = "SceneConfiguration")]
    public class SceneConfiguration : ScriptableObject
    {
        /// <summary>
        /// Name of the board
        /// </summary>
        public string BoardName = "pvp";

        /// <summary>
        /// URL to connect websocket to
        /// </summary>
        public string WebSocketURL;
    }
}


