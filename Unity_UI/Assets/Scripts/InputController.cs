using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputController : MonoBehaviour {

    //Debug Print Text
    public Text debugPrint;
    public Image ThumbStick;
    public Image Plane;
    
	// Use this for initialization
	void Start () 
    {
        debugPrint.text = "Started";
	}
	
	// Update is called once per frame
	void Update () 
    {
        //debugPrint.text = "Updating";
	}

    public void ClickedA()
    {
        debugPrint.text = "Clicked Button A";
    }

    public void ClickedB()
    {
        debugPrint.text = "Clicked Button B";
    }

    public void EnterThumb()
    {
        debugPrint.text = "Enter Thumb";
    }

    public void ExitThumb()
    {
        debugPrint.text = "Exit Thumb";
    }

    public void dragThumbStick()
    {
        debugPrint.text = "Dragging" + Input.mousePosition.x + "," + Input.mousePosition.y;
        Vector3 newPos = new Vector3(Input.mousePosition.x , Input.mousePosition.y , 1);
        if (newPos.x < 115 && newPos.x > 46 && newPos.y < 112 && newPos.y > 42)
        {
            ThumbStick.rectTransform.position = newPos;
        }
        //MovePlane();
        
    }

    public void returnJoyStickForeGround()
    {
        ThumbStick.rectTransform.position = new Vector3(ThumbStick.rectTransform.position.x  , ThumbStick.rectTransform.position.y , 1);
    }

    public void MovePlane()
    {
        Vector3 newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        //Upwards Movement
        if (newPos.y > 76)
        {
            Plane.rectTransform.position = new Vector3(Plane.rectTransform.position.x, Plane.rectTransform.position.y + 5, 1);
        }
        //Downwards Movement
        if(newPos.y < 76)
        {
            Plane.rectTransform.position = new Vector3(Plane.rectTransform.position.x, Plane.rectTransform.position.y - 5, 1);
        }
        //Left Movement
        if(newPos.x > 80)
        {
            Plane.rectTransform.position = new Vector3(Plane.rectTransform.position.x + 5, Plane.rectTransform.position.y, 1);
        }
        //Right Movement
        if(newPos.x < 80)
        {
            Plane.rectTransform.position = new Vector3(Plane.rectTransform.position.x - 5, Plane.rectTransform.position.y, 1);
        }
    }

}
