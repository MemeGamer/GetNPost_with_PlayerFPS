using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThirdPersonBehaviour : MonoBehaviour
{
    //intallect ,ethics ,honesty ,kindness
    [Range(1,3)]
    public int intallect=0;
    [Range(1,3)]
    public int ethics=0;
    [Range(1,3)]
    public int honesty=0;
    [Range(1,3)]
    public int kindness=0;
    public TextMeshProUGUI  Intellect_txt;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider target){
        if (target.tag=="Ball")
        {
            GameObject.Find("ServerUpdate").GetComponent<PostMethod>().PostData();
            Destroy(target.gameObject);
            intallect=3;
            Intellect_txt.text= "Intellect: " +intallect.ToString();
        }
    }
}
