using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class teleporte : MonoBehaviour
{
    public Transform destination;
    public Transform _target;
    
    //private float rajoutY = 1f;
    private float rajoutz = 10f;
    private cooldwon cooldownManager;
    private Animator _anim;


    private bool is_door; 
   
    
    

    
    
    
    void Start()
    {
        // Trouver le CooldownManager dans la scène
        
        cooldownManager = GameObject.FindObjectOfType<cooldwon>();
        _anim = GetComponent<Animator>();
        
        
        
        // Vérifier si le CooldownManager a été trouvé
        if (cooldownManager == null)
        {
            Debug.LogError("CooldownManager non trouvé dans la scène. Assurez-vous qu'il est attaché à un objet.");
        }
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.W) && cooldownManager.CanTeleport())
            {
                Vector3 newPosition = new Vector3(destination.position.x, destination.position.y , destination.position.z + rajoutz);
                _target.position = newPosition;
                
                
                
                cooldownManager.UpdateTeleportTime();
                is_door = true;
                Debug.Log("lanimation de la porte est lance ");
                
                if (is_door = true)
                {
                    _anim.SetBool("test2",true);
                    Debug.Log("lanimation de la porte est lance : " + is_door );
                }
                
            }
            
        }
        
    }

  

    
}

    

