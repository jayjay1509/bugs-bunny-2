using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escalierdeplacement : MonoBehaviour
{
    
public Transform destination;
public Transform _target;
    
//private float rajoutY = 1f;
private float rajoutz = 10f;
private cooldwon cooldownManager;
private Animator _anim;


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
            
                
        }
            
    }
        
}
}

