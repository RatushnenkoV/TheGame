using UnityEngine;
using System.Collections;

public class CameraMotion : MonoBehaviour {
    public Vector2 minpos, maxpos;

    float x_speed, y_speed;
    float max_speed = 0.2f;
    float zoomig_speed;
    float max_zooming_speed = 0.2f;
    float max_size = 5, min_size = 2;


	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
            x_speed += -max_speed;
        if (Input.GetKeyDown(KeyCode.D))
            x_speed += max_speed;
        if (Input.GetKeyDown(KeyCode.W))
            y_speed += max_speed;
        if (Input.GetKeyDown(KeyCode.S))
            y_speed += -max_speed;
        if (Input.GetKeyUp(KeyCode.A))
            x_speed -= -max_speed;
        if (Input.GetKeyUp(KeyCode.D))
            x_speed -= max_speed;
        if (Input.GetKeyUp(KeyCode.W))
            y_speed -= max_speed;
        if (Input.GetKeyUp(KeyCode.S))
            y_speed -= -max_speed;

        if (Input.GetKeyDown(KeyCode.E))
            zoomig_speed += max_zooming_speed;
        if (Input.GetKeyUp(KeyCode.E))
            zoomig_speed -= max_zooming_speed;
        if (Input.GetKeyDown(KeyCode.Q))
            zoomig_speed += -max_zooming_speed;
        if (Input.GetKeyUp(KeyCode.Q))
            zoomig_speed -= -max_zooming_speed;


        if (transform.position.x + x_speed < minpos.x)
            transform.position = new Vector3(minpos.x, transform.position.y, transform.position.z);
        else if (transform.position.x + x_speed > maxpos.x)
            transform.position = new Vector3(maxpos.x, transform.position.y, transform.position.z);
        else
            transform.position += new Vector3(x_speed, 0, 0);

        if (transform.position.y + y_speed < minpos.y)
            transform.position = new Vector3(transform.position.x, minpos.y, transform.position.z);
        else if (transform.position.y + y_speed > maxpos.y)
            transform.position = new Vector3(transform.position.x, maxpos.y, transform.position.z);
        else
            transform.position += new Vector3(0, y_speed, 0);

        if (Camera.main.orthographicSize + zoomig_speed > max_size)
            Camera.main.orthographicSize = max_size;
        else if (Camera.main.orthographicSize + zoomig_speed < min_size)
            Camera.main.orthographicSize = min_size;
        else
            Camera.main.orthographicSize += zoomig_speed;
    }


}
