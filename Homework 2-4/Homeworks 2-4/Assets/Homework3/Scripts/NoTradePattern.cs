using UnityEngine;

public class NoTradePattern : ITrader
{
    public void Trade()
    {
        Debug.Log("Я ничего не продаю");
    }
}
