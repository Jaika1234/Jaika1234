using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private Slider slider;

    [SerializeField] private Image dashImage;
    [SerializeField] private float dashCooldown;

    private void Start()
    {
        if(playerStats!= null)
            playerStats.onHealthChanged += upDateHealthUI;

        dashCooldown = SkillManager.instance.dash.cooldown;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            SetCooldownOf(dashImage);

        CheckCooldownof(dashImage,dashCooldown);

    }

    private void upDateHealthUI()
    {
        slider.maxValue = playerStats.GetMaxHealthValue();
        slider.value = playerStats.currentHealth;
    }
    private void SetCooldownOf(Image _image)
    {
        if (_image.fillAmount <= 0)
            _image.fillAmount = 1;
    }

    private void CheckCooldownof(Image _image,float _cooldown)
    {
        if (_image.fillAmount >0 )
            _image.fillAmount -= 1 /_cooldown *Time.deltaTime; 
    }


}
