using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Balloon : MonoBehaviour
{
    [SerializeField] private Colors _color;
    public enum Colors
    {
        Red, Green, Blue
    }

    public Colors Color => _color;

    public event Action<Colors> BreakBalloon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Character character))
        {
            BreakBalloon?.Invoke(_color);
            Destroy(gameObject);
        }
    }
}
