using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpManager : MonoBehaviour
{
    [SerializeField]
    private List<Type> powerUpList = new List<Type>();
    [SerializeField]
    private List<GameObject> powerUpPanelList;
    public static PowerUpManager instance;
    public Dictionary<Type, int> powerUpLevelDict = new Dictionary<Type, int>();

    public void RollPowerUp()
    {
        foreach (GameObject panel in powerUpPanelList)
        {
            AttachRandomPowerUp(panel, PowerUpType.StatusChange);
        }
    }

    private void AttachRandomPowerUp(GameObject target, PowerUpType type)
    {
        Type selectedScript = null;
        selectedScript = powerUpList[UnityEngine.Random.Range(0, powerUpList.Count)];

        PowerUpPanel panel = target.GetComponent<PowerUpPanel>();
        panel.SetPowerUp(selectedScript);
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
    }
    void Start()
    {
        powerUpList.Add(typeof(WeightUp));
        powerUpList.Add(typeof(SpeedUp));
        powerUpList.Add(typeof(SizeUp));
        powerUpList.Add(typeof(DashPower));
        powerUpList.Add(typeof(DashCycle));
        powerUpList.Add(typeof(StageSizeUp));

        powerUpList.Add(typeof(Bomb));
        powerUpList.Add(typeof(AntiGeavityField));
        powerUpList.Add(typeof(Wind));

        foreach (Type type in powerUpList)
        {
            powerUpLevelDict.Add(type, 0);
        }
        RollPowerUp();
    }

    void Update()
    {
    }
}
