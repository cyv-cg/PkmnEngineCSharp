using Godot;

namespace PkmnEngine.GodotV.Sprites {
	public static class MonSprites {
		/// <summary>
		/// For now, always returns the default front sprite.
		/// </summary>
		/// <param name="species"></param>
		public static Texture2D GetSprite(Species species) {
			return ResourceLoader.Load<Texture2D>($"sprites/pokemon/{NationalDex.NationalDexNum[species]}.png");
		}
	}
}