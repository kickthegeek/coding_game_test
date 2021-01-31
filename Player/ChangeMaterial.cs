using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ChangeMaterial : MonoBehaviour
{

    public Material[] material;
    public TextMeshProUGUI statText;
    Renderer rend;
    public int stat;
    // Start is called before the first frame update
    void Start()
    {
        statText.text = "No mushroom";
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        stat = 0;
    }

     private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("red_mushroom"))
        {
            rend.sharedMaterial = material[1];
            stat = 1;
            print("have eaten to red mushroom");
            statText.text = "RED mushroom";

        }else if (collision.collider.CompareTag("green_mushroom")){
            
            rend.sharedMaterial = material[2];
            stat = 2;
            print("have eaten to green mushroom");
            statText.text = "GREEN mushroom";
        
        }else if (collision.collider.CompareTag("blue_mushroom")){
            
            rend.sharedMaterial = material[3];
            stat = 3;
            print("have eaten to blue mushroom");
            statText.text = "BLUE mushroom";
        }
    }
}
