using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraMotion : MonoBehaviour
{
    Vector3 LeftUpperAngle, CentreAngle, RightUpperAngle, targetAngle, targetPos, CentrePos, LeftUpperPos, RightUpperPos;
    List<Vector3> angles, positions;
    [SerializeField] Button POV;
    [SerializeField] float speed;

    int counter;


    private void Awake()
    {
        CentreAngle = Vector3.zero;
        LeftUpperAngle = new Vector3(6.9f, 15f, 0f);
        RightUpperAngle = new Vector3(6.9f, -15f, 0f);

        CentrePos = transform.position;
        LeftUpperPos = new Vector3(13.5f, CentrePos.y, 20f);
        RightUpperPos = new Vector3(10.5f, CentrePos.y, 20f);
        counter = 0;

        angles = new()
        {
            CentreAngle,
            LeftUpperAngle,
            RightUpperAngle
        };

        positions = new()
        {
            CentrePos,
            LeftUpperPos,
            RightUpperPos
        };
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += GetPOVButton;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= GetPOVButton;
    }
    // Start is called before the first frame update
    void Start()
    {
        targetAngle = CentreAngle;
        speed = 0.042f;
    }

    // Update is called once per frame
    void Update()
    {
        POVShift();
    }

    void GetPOVButton(Scene scene, LoadSceneMode mode)
    {
        print("k");
        POV = GameObject.FindGameObjectWithTag("POV").GetComponent<Button>();
        POV.onClick.AddListener(() => POVShiftToggle());
    }

    void POVShiftToggle()
    {
        counter += counter < 2 ? 1 : -counter;
        targetAngle = angles[counter];
        targetPos = positions[counter];        
    }

    void POVShift()
    {
        if(transform.eulerAngles != targetAngle && transform.position != targetPos)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetAngle), speed);
            transform.position = Vector3.Slerp(transform.position, targetPos, speed);
        }            
    }
}
