var southWest = L.latLng(24.396308, -179.148909); // Punto más sureño y más al oeste (incluyendo Alaska y la parte continental)
var northEast = L.latLng(71.538800, -64.934570); // Punto más al norte y más al este (considerando solo la parte continental)
var bounds = L.latLngBounds(southWest, northEast);

var map = L.map('map', {
	center: [36.890333, -95.968110],
	    zoom: 1,
    minZoom: 4,
    maxBounds: bounds,
    maxBoundsViscosity: 1.0

});

L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19
}).addTo(map);
let dataGlobal; 

fetch('php.php')
    .then(response => response.json())
    .then(data => {
	dataGlobal = data
        fetch('../States.json')
            .then(response => response.json())
            .then(geojsonData => {
                L.geoJson(geojsonData, {
                    style: function(feature) {
                        var densidad = data[feature.properties.NAME];
                        return {
                            fillColor: getColor(densidad),
                            weight: 2,
                            opacity: 1,
                            color: 'black',
                            dashArray: '3',
                            fillOpacity: .9
                        };
                    },
                    onEachFeature: onEachFeature
                }).addTo(map);
            });

        updateTable(data);
    });

function getColor(densidad) {
    return densidad > 80 ? '#FA2A9F' :
           densidad > 60  ? '#C632D9' :
           densidad > 40  ? '#9F43F0' :
           densidad > 20   ? '#5032D9' :
           densidad > 0   ? '#3A5AFC' :
                              '#FFFFFF';
}
function getMessage(densidad) {
    if (densidad > 100) return "<br>It's extremely hot! Stay hydrated and avoid prolonged exposure to the sun.";
    if (densidad > 85) return "<br>It's quite hot outside. Wear light clothing and drink plenty of water.";
    if (densidad > 70) return "<br>Warm weather. A great day to be outdoors, but don't forget your sunscreen.";
    if (densidad > 55) return "<br>Mild temperature. You might need a light jacket in the evening.";
    if (densidad > 32) return "<br>It's cold outside. Wear warm clothing and limit exposure if it's windy.";
    if (densidad <= 32) return "<br>Freezing temperatures. Bundle up and be cautious of icy conditions.";
    return "<br>No records available for this status.";
}


function updateTable(data) {
    const tbody = document.getElementById('dataBody');
    tbody.innerHTML = '';
    const sortedData = Object.entries(data).sort((a, b) => b[1] - a[1]);
    for (const [estado, cantidad] of sortedData) {
        const row = tbody.insertRow();
        const cell1 = row.insertCell(0);
        const cell2 = row.insertCell(1);
        cell1.innerHTML = estado;
        cell2.innerHTML = cantidad;
    }
}

function highlightFeature(e) {
    var layer = e.target;
  

    if (!L.Browser.ie && !L.Browser.opera && !L.Browser.edge) {
        layer.bringToFront();
    }

    layer.openTooltip();
}


function resetHighlight(e) {
    var layer = e.target;
    geojsonLayer.resetStyle(layer);
    layer.closeTooltip(); 
}


function onEachFeature(feature, layer) {
    const temp = dataGlobal[feature.properties.NAME];
    const mensajeAdicional = getMessage(temp);
    const mensaje = `The temperature is ${temp} °F${mensajeAdicional}`;
    layer.bindTooltip(mensaje);

    layer.on({
        mouseover: highlightFeature,
        mouseout: resetHighlight
    });
}
