using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerUpPanel : MonoBehaviour
{
    public PowerUp powerUp;

    private TextMeshProUGUI nameText;
    private TextMeshProUGUI descriptionText;
    private TextMeshProUGUI levelText;
    private Image iconImage;
    private GameObject player;

    public void OnClick()
    {
        if (this.powerUp != null)
        {
            PowerUpManager.instance.LevelUpPowerUp(this.powerUp.GetType());
            GameManager.instance.ChangeGameState(GameState.InGame);
        }
    }

    public void SetPowerUp(PowerUp pu)
    {
        if (pu == null)
        {
            return;
        }
        this.powerUp = pu;

        nameText.text = this.powerUp.name;
        levelText.text = "Level: " + this.powerUp.level;
        descriptionText.text = powerUp.description;
        Sprite icon = Resources.Load<Sprite>("Images/Icons/" + powerUp.iconPath);
        iconImage.sprite = icon;
    }

    void Start()
    {
        nameText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        levelText = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        descriptionText = transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        iconImage = transform.GetChild(4).GetComponent<Image>();
        player = GameObject.Find("Player");
    }
}
