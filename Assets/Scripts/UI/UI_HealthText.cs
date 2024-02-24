using TMPro;
using UnityEngine;

public class Health_Text : MonoBehaviour
{
    [SerializeField]private TextMeshPro myText;
    private Player player;
    private int TextMaxHealth;
    private int TextCurrentHealth;
    private string TextHealth;


    void Start()
    {
        myText = GetComponent<TextMeshPro>();
        player = PlayerManager.instance.player;
        player.stats.currentHealth = TextMaxHealth;

    }
    void Update()
    {
        TextCurrentHealth = player.stats.currentHealth;
        myText.text = $"{TextCurrentHealth} / {TextMaxHealth}";
    }
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;

//public class Health_Text : MonoBehaviour
//{
//    private TextMeshPro myText;
//    private Player player;

//    private void Start()
//    {
//        myText = GetComponent<TextMeshPro>();
//        player = PlayerManager.instance.player;

//        player.stats.onHealthChanged += OnHealthChanged;
//    }

//    private void OnHealthChanged()
//    {
//        int TextCurrentHealth = player.stats.currentHealth;
//        int TextMaxHealth = player.stats.GetMaxHealthValue();
//        myText.text = $"{TextCurrentHealth} / {TextMaxHealth}";
//    }

//    private void OnDestroy()
//    {
//        player.stats.onHealthChanged -= OnHealthChanged;
//    }
//}
