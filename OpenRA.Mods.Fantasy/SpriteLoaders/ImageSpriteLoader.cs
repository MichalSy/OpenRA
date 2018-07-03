using OpenRA.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OpenRA.Mods.Fantasy.SpriteLoaders
{
	public class ImageSpriteLoader : ISpriteLoader
	{
		public bool TryParseSprite(Stream s, out ISpriteFrame[] frames)
		{
			frames = new ISpriteFrame[0];
			return false;
		}
	}
}
