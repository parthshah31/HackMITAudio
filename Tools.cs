using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Tools
{
	public static Color Grad(float x)
	{
		/*
		// Terrain gradient color keys
		List<GradientColorKey> terrainColorKeys = new List<GradientColorKey>
		{
			new GradientColorKey(new Color(0, 0, 0.5f), 0),
			new GradientColorKey(new Color(0.125f, 0.25f, 0.5f), 0.4f),
			new GradientColorKey(new Color(0.25f, 0.375f, 0.75f), 0.48f),
			new GradientColorKey(new Color(0, 0.75f, 0), 0.5f),
			new GradientColorKey(new Color(0.75f, 0.75f, 0), 0.625f),
			new GradientColorKey(new Color(0.625f, 0.375f, 0.25f), 0.75f),
			new GradientColorKey(new Color(0.5f, 1, 1), 0.875f),
			new GradientColorKey(Color.white, 1)
		};
		
		// Generic gradient alpha keys
		var alphaKeys = new List<GradientAlphaKey> {new GradientAlphaKey(1, 0), new GradientAlphaKey(1, 1)};
		*/
		
		Gradient g = new Gradient();
		GradientColorKey[] gck;
		GradientAlphaKey[] gak;
		
		// Populate the color keys at the relative time 0 and 1 (0 and 100%)
		gck = new GradientColorKey[2];
		gck[0].color = Color.red;
		gck[0].time = 0.0f;
		gck[1].color = Color.blue;
		gck[1].time = 1.0f;
		
		// Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
		gak = new GradientAlphaKey[2];
		gak[0].alpha = 1.0f;
		gak[0].time = 0.0f;
		gak[1].alpha = 0.0f;
		gak[1].time = 1.0f;
		
		//g.SetKeys(terrainColorKeys.ToArray(), alphaKeys.ToArray());
		g.SetKeys(gck,gak);

		return g.Evaluate(x);;

	}

	public static Color CubeHelix (float x)  //between 0 and 1)
	{
		float t = x;
		float radians = Mathf.PI / 180;
		
		float ah = (300 + 120) * radians;
		float bh = (-240 + 120) * radians - ah;
		float asat = .5f;
		float bs = .5f - asat;
		float al = 0f;
		float bl = 1f - al;
		
		if (System.Single.IsNaN(bs)) bs = 0;
		asat = System.Single.IsNaN(asat) ? bs : asat;
		
		if (System.Single.IsNaN(bh)) bh = 0;
		ah = System.Single.IsNaN(ah) ? bh : ah;
		
		
		float h = ah + bh * t;
		float l = Mathf.Pow(al + bl * t, x);
		float a = (asat + bs * t) * l * (1 - l);
		float cosh = Mathf.Cos(h);
		float sinh = Mathf.Sin(h);
		
		Color clr = new Color(l + a * (-0.14861f * cosh + 1.78277f * sinh),
		                      l + a * (-0.29227f * cosh - 0.90649f * sinh),
		                      l + a * (1.97294f * cosh));
		return clr;
	}
}