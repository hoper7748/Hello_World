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
        curGoPointIdx = 0;  // ���� .GoPoint�� �ε���
        curTransform = GetComponent<Transform>();   //  ���� Player�� Transform    
        goPointList = GameObject.FindGameObjectsWithTag("GoPoint"); // ������ GoPoint��
        numGoPoints = goPointList.Length; // GoPointList �� ����

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Player�� ������ ���� ����
        Vector3 goDirection = goPointList[curGoPointIdx].transform.position - curTransform.position;
        // Player �� �ٶ� ������ Rot���� ���ʹϾ��� ���ؼ� ����.
        Quaternion goRotation = Quaternion.LookRotation(goDirection);
        // �ش� �������� ȸ��
        curTransform.rotation = Quaternion.Slerp(curTransform.rotation, goRotation, Time.deltaTime * rotSpeed);

        // �ش� �������� �̵�
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
