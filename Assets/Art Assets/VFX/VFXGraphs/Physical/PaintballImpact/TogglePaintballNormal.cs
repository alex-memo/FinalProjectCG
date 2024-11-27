using UnityEngine;
using UnityEngine.VFX;

public class TogglePaintballNormal : MonoBehaviour
{
	[SerializeField] private VisualEffect paintBallImpact;
	private bool hasNormal = true;
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			hasNormal = !hasNormal;
			paintBallImpact.SetBool("HasNormal", hasNormal);
		}
	}
}
