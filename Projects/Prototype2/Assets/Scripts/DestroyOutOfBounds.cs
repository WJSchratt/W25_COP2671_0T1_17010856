using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private float topBound = 30;
   private float lowerBound = -20;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if object passes player it removes object
        if (transform.position.z > topBound )
        {
            Destroy(gameObject);
        }
        else if ( transform.position.z < lowerBound)
        {
            Debug.Log("GameOver!");
            Destroy(gameObject);
        }
    
    }
}
