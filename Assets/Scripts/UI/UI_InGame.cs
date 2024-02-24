using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private Slider slider;

    [SerializeField] private Image dashImage;
    [SerializeField] private Image parryImage;
    [SerializeField] private Image swordImage;
    [SerializeField] private Image flaskImage;

    [SerializeField] private TextMeshProUGUI healthText;

    private SkillManager skills;
    private void Start()
    {
        if (playerStats != null)
            playerStats.onHealthChanged += upDateHealthUI;

        skills = SkillManager.instance;
        healthText = slider.GetComponentInChildren<TextMeshProUGUI>();
        healthText.text = $"{playerStats.currentHealth} / {playerStats.GetMaxHealthValue()}";
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            SetCooldownOf(dashImage);

        if(Input.GetKeyDown(KeyCode.Mouse1))
            SetCooldownOf(swordImage);

        if (Input.GetKeyDown(KeyCode.Alpha1) && Inventory.instance.GetEquipment(EquipmentType.Flask) != null)
        {
            Debug.Log("flask is cool down"+ Inventory.instance.flaskCooldown);
            SetCooldownOf(flaskImage);
        }
            


        CheckCooldownof(dashImage, skills.dash.cooldown);
        CheckCooldownof(swordImage, skills.sword.cooldown);
        CheckCooldownof(flaskImage, Inventory.instance.flaskCooldown);
    }

    private void upDateHealthUI()
    {
        slider.maxValue = playerStats.GetMaxHealthValue();
        slider.value = playerStats.currentHealth;

        healthText.text = $"{playerStats.currentHealth} / {playerStats.GetMaxHealthValue()}";
    }
    private void SetCooldownOf(Image _image)
    {
        if (_image.fillAmount <= 0)
            _image.fillAmount = 1;
    }

    private void CheckCooldownof(Image _image, float _cooldown)
    {
        if (_image.fillAmount > 0)
            _image.fillAmount -= 1 / _cooldown * Time.deltaTime;
    }


}
