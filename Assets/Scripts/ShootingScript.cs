using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    public GameObject particleSystemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0.0f));
            Destroy(Instantiate(particleSystemPrefab,transform.position,transform.rotation),3);
            if (Physics.Raycast(ray, out hit)) 
            {
                TurretComponent tc =  hit.collider.gameObject.GetComponent<TurretComponent>();
                if (tc != null)
                {
                    tc.ProcessHit();
                }
                // DO things
            }
        }
    }
}
