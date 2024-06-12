using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpManager : MonoBehaviour
{
    [SerializeField]
    private List<Type> powerUpList = new List<Type>();
    private List<PowerUp> powerUpInstanceList = new List<PowerUp>();
    [SerializeField]
    private List<PowerUpPanel> powerUpPanelList;
    public static PowerUpManager instance;

    public void RollPowerUp()
    {
        foreach (PowerUpPanel panel in powerUpPanelList)
        {
            AttachRandomPowerUp(panel);
        }
    }

    private void AttachRandomPowerUp(PowerUpPanel target)
    {
        PowerUp powerUp = powerUpInstanceList[UnityEngine.Random.Range(0, powerUpInstanceList.Count)];
        target.SetPowerUp(powerUp);
    }

    public void LevelUpPowerUp(Type type)
    {
        PowerUp powerUp = powerUpInstanceList.FirstOrDefault(pu => pu.GetType() == type);
        if (powerUp)
        {
            powerUp.LevelUp();
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        powerUpList.Add(typeof(WeightUp));
        powerUpList.Add(typeof(SpeedUp));
        powerUpList.Add(typeof(SizeUp));
        powerUpList.Add(typeof(DashPower));
        powerUpList.Add(typeof(DashCycle));
        powerUpList.Add(typeof(StageSizeUp));

        powerUpList.Add(typeof(Bomb));
        powerUpList.Add(typeof(AntiGeavityField));
        powerUpList.Add(typeof(Wind));
        powerUpList.Add(typeof(Garlic));
    }
    void Start()
    {
        foreach (Type type in powerUpList)
        {
            PowerUp pu = this.gameObject.AddComponent(type) as PowerUp;
            pu.SetStatus();
            powerUpInstanceList.Add(pu);
        }
    }
}
