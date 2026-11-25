// ArchNet · Dropzone Extension
// Fills a container (a layout group, a list…) with copies of prefabs, and removes them
// when the container is disabled. Handy for popups that show a list of items.
// Docs: https://archnet-plateform.fr/#DropzoneExtension

using System.Collections.Generic;
using UnityEngine;

namespace ArchNet.Extension
{
    [AddComponentMenu("ArchNet/Dropzone")]
    public class DropzoneExtensions : MonoBehaviour
    {
        [Tooltip("Where the copies go. Empty = this object.")]
        [SerializeField] Transform _dropzone;

        readonly List<GameObject> _items = new List<GameObject>();

        /// <summary>The copies currently in the dropzone.</summary>
        public IReadOnlyList<GameObject> Items => _items;

        Transform Container => _dropzone != null ? _dropzone : transform;

        /// <summary>Replaces the content of the dropzone with a copy of each prefab.</summary>
        public void Fill(IEnumerable<GameObject> prefabs)
        {
            Clear();
            foreach (GameObject prefab in prefabs)
            {
                if (prefab != null) _items.Add(Instantiate(prefab, Container));
            }
        }

        /// <summary>Removes every copy.</summary>
        public void Clear()
        {
            foreach (GameObject item in _items)
            {
                if (item != null) Destroy(item);
            }
            _items.Clear();
        }

        void OnDisable() => Clear();
    }
}
