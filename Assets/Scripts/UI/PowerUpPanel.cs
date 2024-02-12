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
    private Image iconImage;

    public void SetPowerUp(Type powerUpType)
    {

        PowerUp powerUp = this.gameObject.AddComponent(powerUpType) as PowerUp;
        if (!powerUp || powerUp.name == null || powerUp.description == null || powerUp.iconPath == null)
        {
            return;
        }

        this.powerUp = powerUp;
        nameText.text = this.powerUp.name;
        descriptionText.text = powerUp.description;
        Debug.Log(System.IO.File.Exists("Assets/Resources/Images/Icons/WeightUp.png"));
        var icon = Resources.Load<Sprite>("waiwai");
        Debug.Log(icon);
        iconImage.sprite = icon;
    }

    void Start()
    {
        //子オブジェクトのTextMeshProUGUIコンポーネントを取得
        nameText = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        descriptionText = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        iconImage = transform.GetChild(3).GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {

    }
}
