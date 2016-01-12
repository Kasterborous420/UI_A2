using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float translation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        translation = Time.deltaTime * 8;
        transform.Translate(new Vector3(0, translation, 0));

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
	}
}
