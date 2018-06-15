using UnityEngine;
using System.Collections;
using System.Collections.Generic;


 [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {
	
	[Header("General info")]
	
	public string CardName;
	public Sprite CardFront;
	public Sprite CardBack;
}