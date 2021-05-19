using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Computer : MonoBehaviour
{
    [SerializeField] private TMP_Text chatText = null;
    [SerializeField] private TMP_InputField inputField = null;
    float day, hour, min, money, num = 0f;
    // Start is called before the first frame update
    void Start()
    {
        FundRate(1.08f);
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FundRate(float fundrate)
    {
         num = Mathf.Pow(fundrate, 3*30);
        
    }
    void ChangeFromString(string str)
    {
        float.TryParse(str, out num);
    }
}
