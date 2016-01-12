using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

    public float translation;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        translation = - (Time.deltaTime * 5);
        transform.Translate(new Vector3(0, translation, 0));
        Destroy(gameObject,6);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        string name = other.gameObject.name;

        if(name == "bullet(Clone)")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if(name == "Ship")
        {
            Destroy(gameObject);
        }
    }
}
