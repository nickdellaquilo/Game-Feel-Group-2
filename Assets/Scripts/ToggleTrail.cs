using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTrail : MonoBehaviour
{
    public GlobalVars globalVars;
    TrailRenderer trailComponent;
    private bool trail = true;
    // Start is called before the first frame update
    void Start()
    {
        globalVars = GameObject.Find("GlobalVars").GetComponent<GlobalVars>();
        trailComponent = transform.GetComponent<TrailRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        trail = globalVars.trailOn;

        if(trail){
            trailComponent.enabled = true;
        }
        else{
            trailComponent.enabled = false;
        }
    }
}
