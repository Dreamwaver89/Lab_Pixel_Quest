using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera _Camera;

    private string CameraName = "Game_Camera";

    private void Start()
    {
        _Camera = GameObject.Find(CameraName);
    }
}
