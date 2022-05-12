using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{


   GameObject player;
    public float horizontalPadding = 0.0f;
    public float verticalPadding = 0f;


    float maxhorizontalDistance;
    float maxverticalDistance;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("playa");

        Camera cam = GetComponent<Camera>();
        float cameraHeight = cam.orthographicSize;
        float cameraWidth = cam.aspect * cameraHeight;

        maxhorizontalDistance = cameraWidth - horizontalPadding;
        maxverticalDistance = cameraHeight - verticalPadding;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < transform.position.x - maxhorizontalDistance)
        {
            SetX(player.transform.position.x + maxhorizontalDistance);
        }
        if (player.transform.position.x > transform.position.x + maxhorizontalDistance)
        {
            SetX(player.transform.position.x - maxhorizontalDistance);
        }
        if (player.transform.position.y > transform.position.y + maxverticalDistance)
        {
            SetY(player.transform.position.y - maxverticalDistance);
        }
        if (player.transform.position.y < transform.position.y - maxverticalDistance)
        {
            SetY(player.transform.position.y + maxverticalDistance);
        }
    }
    void SetX(float newX)
    {
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    void SetY(float newY)
    {
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}





