using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InstructionsController : MonoBehaviour
{
   
    
   public TextMeshProUGUI inputField;
   public  Rigidbody player;
   public void SetContent(){
       //in the futur a list of instructions will be set here
       
       print("ipnut content "+ inputField.text);
       String method = inputField.text.Substring(0,4);
       print("method called "+ method);
       String rotation = inputField.text.Substring(4,3);
       print("rotation set "+ rotation);
       String power = inputField.text.Substring(7,3);
       print("power set "+ power);
       float rot = Int32.Parse(rotation);
       float pow = Int32.Parse(power);
       print( rot+" "+pow);
       float x = pow *(float)Math.Cos(rot);
       float z = pow *(float)Math.Sin(rot); 
       player.velocity = new Vector3 ( x ,5,z );
       
       
   }
}
