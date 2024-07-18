using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    new private Rigidbody rigidbody;
    [SerializeField] private float speed;
    private float currentPosX;
    private float currentPosY;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform player;
    /*[SerializeField] private Transform player2;
    [SerializeField] private Transform player3;
    [SerializeField] private Transform player4;
    [SerializeField] private Transform player5;*/
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;
    private void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);
        transform.position = new Vector3(player.position.x +  lookAhead, transform.position.y,  transform.position.z);
        
        /*transform.position = new Vector3(player2.position.x +  lookAhead, transform.position.y,  transform.position.z);
        transform.position = new Vector3(player3.position.x +  lookAhead, transform.position.y,  transform.position.z);
        transform.position = new Vector3(player4.position.x +  lookAhead, transform.position.y,  transform.position.z);
        transform.position = new Vector3(player5.position.x +  lookAhead, transform.position.y,  transform.position.z);*/
        //lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
       // currentPosX = _newRoom.position.x;
    }
}
