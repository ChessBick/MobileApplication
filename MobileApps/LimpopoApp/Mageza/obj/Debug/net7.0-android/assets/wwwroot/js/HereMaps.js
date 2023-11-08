
function LoadAndDisplayMap(){
    var platform = new H.service.Platform({
        'apikey': 'QNKoaO1cnhu0IIFH81SxTEP11zcplDKR5SN-OByvZs4'
    });

    var defaultLayers = platform.createDefaultLayers();

    // Instantiate (and display) a map object:
    var map = new H.Map(
        document.getElementById('mapContainer'),
        defaultLayers.vector.normal.map,
        {
            zoom: 10,
            center: { lat: 52.5, lng: 13.4 }
        });
}