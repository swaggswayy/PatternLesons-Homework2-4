using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    private void Update()
    {
        transform.Translate(transform.forward * _bulletSpeed * Time.deltaTime);
    }
}
