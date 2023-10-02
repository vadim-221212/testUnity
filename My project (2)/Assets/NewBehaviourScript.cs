using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class NewBehaviourScript : MonoBehaviour 
{ 
    public Color newColor; 
    public float speed; 
 
    private Renderer rend; 
 
    void Start() 
    { 
        rend = GetComponent<Renderer>(); 
    } 
 
    public void Update() 
    { 
        rend.material.color = newColor; 
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
        

    } 
}