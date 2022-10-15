using UnityEngine;

namespace Sgorey.Unity.Utils.Runtime
{
    public class Boot : MonoBehaviour
    {
        [SerializeField] private string _startScene;

        private void Awake()
        {
            SceneHelper.AddSceneAsync(_startScene, () =>
            {
                Destroy(gameObject);
            });
        }
    }
}
