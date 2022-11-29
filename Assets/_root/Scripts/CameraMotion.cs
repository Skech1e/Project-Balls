using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraMotion : MonoBehaviour
{
    Vector3 LeftUpper, Centre, RightUpper;
    List<Vector3> angles;
    [SerializeField] Button POV;

    int counter;
    bool POVPressed;
  

    private void Awake()
    {
        Centre = Vector3.zero;
        LeftUpper = new Vector3(6.9f, 15f, 0f);
        RightUpper = new Vector3(6.9f, -15f, 0f);
        counter = 0;

        angles = new()
        {
            Centre,
            LeftUpper,
            RightUpper
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

    }

    // Update is called once per frame
    void Update()
    {
        if (POVPressed == true)
            POVShiftToggle();
    }

    void GetPOVButton(Scene scene, LoadSceneMode mode)
    {
        POV = GameObject.FindGameObjectWithTag("POV").GetComponent<Button>();
        POV.onClick.AddListener(() => POVPressed = true);
    }

    void POVShiftToggle()
    {
        var source = angles[counter];
        counter += counter < 2 ? 1 : -counter;
        var target = angles[counter];
    }

    void POVShift(Vector3 source, Vector3 target)
    {
        transform.eulerAngles = Vector3.Lerp(source, target, 0.5f);
        POVPressed = transform.eulerAngles != target;
    }
}
