using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Trader _trader;
    private void Update()
    {
        if (_player.Reputation <= 15)
        {
            _trader.ChangeTraderPattern(new NoTradePattern());
        }
        else if (_player.Reputation > 15 && _player.Reputation <= 65)
        {
            _trader.ChangeTraderPattern(new FruitsTradePattern());
        }
        else if (_player.Reputation > 65)
        {
            _trader.ChangeTraderPattern(new ArmorTradePattern());
        }
    }
}
