using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Image i = GetComponent<Image>();
        Sprite s = Resources.Load<Sprite>("waiwai");
        Debug.Log(System.IO.File.Exists("Assets/Resources/waiwai.png"));
        Debug.Log(s);
        i.sprite = s;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
