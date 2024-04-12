using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

}
