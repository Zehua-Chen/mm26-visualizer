﻿using UnityEngine;
using UnityEngine.Events;

namespace MM26
{
    /// <summary>
    /// Expose events for different components to connect to
    /// </summary>
    [CreateAssetMenu(menuName = "Scene Life Cycle", fileName = "SceneLifeCycle")]
    public class SceneLifeCycle : ScriptableObject
    {
        [Header("Events")]
        [SerializeField]
        UnityEvent _fetchData = new UnityEvent();

        [SerializeField]
        UnityEvent _dataFetched = new UnityEvent();

        [SerializeField]
        UnityEvent _createBoard = new UnityEvent();

        [SerializeField]
        UnityEvent _boardCreated = new UnityEvent();

        [SerializeField]
        UnityEvent _play = new UnityEvent();

        [SerializeField]
        UnityEvent _update = new UnityEvent();

        [SerializeField]
        UnityEvent _reset = new UnityEvent();

        /// <summary>
        /// Invoked when it's about to fetch data
        /// </summary>
        public UnityEvent FetchData => _fetchData;

        /// <summary>
        /// Invoked when data has been fetched
        /// </summary>
        public UnityEvent DataFetched => _dataFetched;

        /// <summary>
        /// Invoked when it's time to create the board
        /// </summary>
        public UnityEvent CreateBoard => _createBoard;

        /// <summary>
        /// Invoked when the board has been created
        /// </summary>
        public UnityEvent BoardCreated => _boardCreated;

        /// <summary>
        /// Invoked when the game can start playing
        /// </summary>
        public UnityEvent Play => _play;

        /// <summary>
        /// Invoked per frame
        /// </summary>
        public UnityEvent Update => _update;

        /// <summary>
        /// Invoked during reset (during game tear down)
        /// </summary>
        public UnityEvent Reset => _reset;

        private void OnEnable()
        {
        }
    }
}
