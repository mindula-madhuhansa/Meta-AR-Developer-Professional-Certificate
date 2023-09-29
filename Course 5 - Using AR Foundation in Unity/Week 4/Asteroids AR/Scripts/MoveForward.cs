using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5;
    private Transform _myTransform;

    void Start()
    {
        _myTransform = transform;
    }


    void Update()
    {
        _myTransform.position += _myTransform.forward * (Time.deltaTime * _moveSpeed);
    }
}
