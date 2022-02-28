using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    [SerializeField] private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void SetCoins(int coins)
    {
        text.text = "Coins: " + coins;
    }
}
