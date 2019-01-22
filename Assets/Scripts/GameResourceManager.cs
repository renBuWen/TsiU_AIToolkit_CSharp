using TsiU;
using UnityEngine;
using System.Collections.Generic;

namespace AIToolkitDemo
{
    class GameResourceManager : TSingleton<GameResourceManager>
    {
        //! 先从字典里取，没有在LOAD

        private Dictionary<string, GameObject> _resourceDict;
        public GameResourceManager()
        {
            _resourceDict = new Dictionary<string, GameObject>();
        }
        public GameObject LoadResource(string path)
        {
            if (!_resourceDict.ContainsKey(path))
            {
                _resourceDict[path] = Resources.Load<GameObject>(path);   
            }
            if (_resourceDict[path] == null)
            {
                return null;
            }
            return GameObject.Instantiate(_resourceDict[path]) as GameObject;  
        }
    }
}
