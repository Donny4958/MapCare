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
        fetch('States.json')
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
                            fillOpacity: 0.8
                        };
                    },
                    onEachFeature: onEachFeature
                }).addTo(map);
            });

        updateTable(data);
    });

function getColor(densidad) {
    return densidad > 600000 ? '#3A5AFC' :
           densidad > 350000  ? '#5032D9' :
           densidad > 150000  ? '#9F43F0' :
           densidad > 82000   ? '#C632D9' :
           densidad > 0   ? '#FA2A9F' :
                              '#FFFFFF';
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
    const densidad = dataGlobal[feature.properties.NAME];

    
    const mensaje = `El estado es: ${feature.properties.NAME} y su cantidad es de ${densidad}`;

   
    layer.bindTooltip(mensaje);

    layer.on({
        mouseover: highlightFeature,
        mouseout: resetHighlight
    });
}



