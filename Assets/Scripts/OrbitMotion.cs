using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbitMotion : MonoBehaviour
{
    public Transform orbitingObject;
    public Ellipse orbitPath;

    [Range(0f,1f)]
    public float orbitProgress = 0f;
    public float orbitPeriod = 3f;
    public bool orbitActive = true;
    

    void Start()
    {
        if(orbitingObject == null)
        {
            orbitActive = false;
            return; 
        }
        SetOrbitingObjectPosition();
        StartCoroutine(AnimateOrbit());
    }

    
    void SetOrbitingObjectPosition()
    {
        Vector3 orbitPos = orbitPath.Evaluate(orbitProgress);
        orbitingObject.localPosition = new Vector3(orbitPos.x, 0, orbitPos.z);
    }
    

IEnumerator AnimateOrbit()
    {
        if (orbitPeriod < .1f)
            orbitPeriod = .1f;

        
        while (orbitActive)
        {
            float orbitSpeed = 1f / orbitPeriod;
            orbitProgress += Time.deltaTime * orbitSpeed;
            orbitProgress %= 1f;
            SetOrbitingObjectPosition();
            yield return null;
        }
    }
    private bool faster = false;
    public Text buttonText;
    
    
    public void Speed2x()
    {
        if (!faster)
        {
            
            orbitPeriod /= 2;

            
            faster = true;
            
        }
        else
        {
            
            orbitPeriod *= 2;

            
            faster = false;
        }

        


    }
}
