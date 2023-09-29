using UnityEngine;
using UnityEngine.Events;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float _destroyDelay = 0.1f;
    [SerializeField] private UnityEvent onDestroy;

    public void DestroyWithDelay()
    {
        onDestroy?.Invoke();
        Destroy(gameObject, _destroyDelay);
    }
}
