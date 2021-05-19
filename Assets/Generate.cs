using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject g;
    public List<GameObject> list = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Increase(g);
    }

    void Increase(GameObject gameObject)
    {
        float a = 2;
        for (int i = 0; i < 10; i++) {
            
            for(int j=0; j < 10; j++)
            {
                
                for (int k = 0; k < 10; k++)
                {
                    
                    list[100*k+10*j+i] = Instantiate(gameObject, this.gameObject.transform.position + new Vector3(a*i, a*j, a*k), Quaternion.identity);
                }
            }
    }
    }

}
