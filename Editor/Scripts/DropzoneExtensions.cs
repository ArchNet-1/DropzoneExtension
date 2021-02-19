using System.Collections.Generic;
using UnityEngine;

namespace ArchNet.Extension.DropZone
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [DROPZONE] Extension Dropzone for gameobject
    /// author : LOUIS PAKEL
    /// </summary>
    public class DropzoneExtensions : MonoBehaviour
    {
        [SerializeField, Tooltip("DropZone")]
        private  Transform _dropzone = null;

        private  List<GameObject> _entities = new List<GameObject>();


        private void OnDisable()
        {
            Close();
        }

        /// <summary>
        /// Description : Initiate the  gameobject
        /// </summary>
        public  void InitDropZone(List<GameObject> pEntities)
        {
            _entities = new List<GameObject>();

            foreach (GameObject lEntity in pEntities)
            {
                _entities.Add(Clone(lEntity));
            }
        }

        /// <summary>
        /// Description : Clone the target
        /// </summary>
        /// <param name="pTarget"></param>
        /// <returns></returns>
        private  GameObject Clone(GameObject pTarget)
        {
            GameObject lClone = Instantiate(pTarget, _dropzone);

            return lClone;
        }

        /// <summary>
        /// Description : Close the popin
        /// </summary>
        private  void Close()
        {
            for (int i = 0; i < _entities.Count; i++)
            {
                Destroy(_entities[i]);
            }

            _entities = new List<GameObject>();
        }
    }
}
