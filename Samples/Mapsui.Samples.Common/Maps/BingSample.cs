﻿using BruTile.Predefined;
using Mapsui.Layers;

namespace Mapsui.Samples.Common.Maps
{
    public static class BingSample
    {
        public static Map CreateMap()
        {
            var map = new Map();
            var apiKey = "Enter your api key here"; // Contact Microsoft about how to use this
            map.Layers.Add(new TileLayer(KnownTileSources.Create(KnownTileSource.BingAerial, apiKey))
            {
                Name = "Bing Aerial"
            });
            return map;
        }
    }
}