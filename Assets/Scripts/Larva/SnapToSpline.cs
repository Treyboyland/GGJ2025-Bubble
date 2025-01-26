using UnityEngine;
using UnityEngine.Splines;

/// <summary>
/// Find the spine object, snap this Spline animation component to that spline, then begin the animation at that snapped to point.
/// </summary>
[RequireComponent(typeof(SplineAnimate))]
public class SnapToSpline : MonoBehaviour
{
    [SerializeField] string pathTagName = "larvaPath";

    void Start()
    {
        var splineContainerObj = GameObject.FindGameObjectWithTag(pathTagName);
        var splineContainer = splineContainerObj.GetComponent<SplineContainer>();

        if (splineContainer)
        {
            SplineUtility.GetNearestPoint(
                splineContainer.Spline,
                splineContainer.transform.InverseTransformPoint(transform.position),
                out var _,
                out var t
            );

            var splineAnim = GetComponent<SplineAnimate>();
            splineAnim.Container = splineContainer;
            splineAnim.StartOffset = t;
            splineAnim.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
