async function fetchZones() {
    const response = await fetch('/GetZones'); 
    const zones = await response.json();

    const zoneList = document.getElementById('zoneList');
    

    zoneList.innerHTML = '';

    zones.forEach(zone => {
        if (zones.length > 0) {
            const li = document.createElement('li');
            li.textContent = `Zone: ${zone.zoneName}, Price: $${zone.pricePerHour}/hr`;
            zoneList.appendChild(li);

        }
    });
}




