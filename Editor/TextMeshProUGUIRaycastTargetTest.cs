using NUnit.Framework;
using TMPro;
using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class TextMeshProUGUIRaycastTargetTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void TextMeshProUGUI_の_Raycast_Target_がオフになっているか()
		{
			bool IsValid( GameObject gameObject )
			{
				var textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();
				return textMeshProUGUI == null || !textMeshProUGUI.raycastTarget;
			}

			AllGameObjectTester.Test( IsValid );
		}
	}
}