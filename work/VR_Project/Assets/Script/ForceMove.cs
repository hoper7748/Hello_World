using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMove : MonoBehaviour
{
    public GameObject[] goPointList;
    public float rotSpeed = 2.0f;
    public float moveSpeed = 0.8f;
    private int curGoPointIdx = 0;
    private int numGoPoints = 0;
    private Transform curTransform;
    // Start is called before the first frame update
    void Start()
    {
        curGoPointIdx = 0;  // 현재 .GoPoint의 인덱스
        curTransform = GetComponent<Transform>();   //  현재 Player의 Transform    
        goPointList = GameObject.FindGameObjectsWithTag("GoPoint"); // 지정한 GoPoint들
        numGoPoints = goPointList.Length; // GoPointList 총 갯수

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Player가 가야할 방향 결정
        Vector3 goDirection = goPointList[curGoPointIdx].transform.position - curTransform.position;
        // Player 가 바라볼 방향의 Rot값을 쿼터니언을 통해서 구함.
        Quaternion goRotation = Quaternion.LookRotation(goDirection);
        // 해당 방향으로 회전
        curTransform.rotation = Quaternion.Slerp(curTransform.rotation, goRotation, Time.deltaTime * rotSpeed);

        // 해당 방향으로 이동
        curTransform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GoPoint"))
        {
            curGoPointIdx++;
            if (curGoPointIdx == numGoPoints)
            {
                curGoPointIdx = 0;
            }

            Debug.Log("Trigger Enter: " + other.name);
        }
    }
}
