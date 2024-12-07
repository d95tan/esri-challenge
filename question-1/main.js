require([
    "esri/Map",
    "esri/views/MapView",
    "esri/layers/GraphicsLayer",
    "esri/Graphic",
], function (Map, MapView, GraphicsLayer, Graphic) {
    // Given location
    const longitude = 103.793393;
    const latitude = 1.293889;

    // You should configure it to use the "streets" basemap.
    const map = new Map({
        basemap: "streets",
    });

    // Center the map to the above-mentioned location with the appropriate zoom level.
    new MapView({
        container: "viewDiv",
        map: map,
        center: [longitude, latitude],
        zoom: 16,
    });

    // Plot a Point symbol in BLUE at the same location as a Graphic object
    // With appropriate geometry and symbol defined
    const pointGraphic = new Graphic({
        geometry: {
            type: "point",
            longitude,
            latitude,
        },
        symbol: {
            type: "simple-marker",
            color: "blue",
            outline: {
                color: "white",
                width: 1,
            },
        },
    });

    // Add it to a GraphicLayer
    const graphicsLayer = new GraphicsLayer();
    graphicsLayer.add(pointGraphic);

    // Finally, add the layer to the map
    map.add(graphicsLayer);
});
