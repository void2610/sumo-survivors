using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpManager : MonoBehaviour
{
    [SerializeField]
    private List<Type> statusChangeList = new List<Type>();
    [SerializeField]
    private List<Type> summonList = new List<Type>();
    [SerializeField]
    private List<GameObject> powerUpPanelList;

    public static PowerUpManager instance;

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
        switch (type)
        {
            case PowerUpType.StatusChange:
                selectedScript = statusChangeList[UnityEngine.Random.Range(0, statusChangeList.Count)];
                break;
            case PowerUpType.Summon:
                selectedScript = summonList[UnityEngine.Random.Range(0, summonList.Count)];
                break;
            default:
                break;
        }
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
        statusChangeList.Add(typeof(WeightUp));
        statusChangeList.Add(typeof(SpeedUp));
        RollPowerUp();
    }

    void Update()
    {
    }
}
