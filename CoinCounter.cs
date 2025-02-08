using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{


    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.MaxValue = player.maxHealth;
        healthSlider.value = player.health;

        coinsCounterText.text = player.coins.ToString();
    }
}
