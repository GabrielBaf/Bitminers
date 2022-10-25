using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner
{
	//bronze,iron,silver,gold,diamond
	private int[] rarity = {};
	private float startingMiningSpeed;
	private float presenteMiningSpeed;
	private float maxMiningSpeed;
	private float upgradeTimeMiningSpeed;
	private float[] mineChance = {};
	private float[] maxMineChance = {};
	private float[] presentMineChance = {};

	public int[] Rarity{
		get{return rarity;}
		set{rarity = value;}
	}
}
