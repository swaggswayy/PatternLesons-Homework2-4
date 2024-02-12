using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Trader : MonoBehaviour
{
    private ITrader _traderPattern;

    public void ChangeTraderPattern(ITrader traderPattern)
    {
        _traderPattern = traderPattern;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IBuyer buyer))
        {
            _traderPattern.Trade();
        }
    }
}
