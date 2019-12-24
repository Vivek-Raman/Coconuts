using Cinemachine;
using UnityEngine;

public class FrameAllPlayers : MonoBehaviour
{
    [Range(0f, 1f)]
    public float zoomRate = 0.7f;
    public PlayersManager manager = null;

    private LensSettings originalSettings = LensSettings.Default;
    private CinemachineVirtualCamera vCam = null;
    private LensSettings targetSettings;

    private void Awake()
    {
        vCam = this.GetComponent<CinemachineVirtualCamera>();
        originalSettings = vCam.m_Lens;
        targetSettings = originalSettings;
    }

    void Update()
    {
        float targetFOV = DetermineTargetFOV();
        targetSettings.FieldOfView = targetFOV;
        vCam.m_Lens = LensSettings.Lerp(vCam.m_Lens, targetSettings, zoomRate);
    }

    private float DetermineTargetFOV()
    {
        
        return 50f;
    }
}

