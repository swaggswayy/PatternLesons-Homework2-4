using UnityEngine;

public class Player : MonoBehaviour, IBuyer
{
    [SerializeField] private int _reputation;

    public int Reputation => _reputation;
}
