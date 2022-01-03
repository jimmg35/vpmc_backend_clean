
document.getElementById('LandMarkCounty').onchange = () => { updateTownDropdown('LandMarkCounty','LandMarkVillage')};
document.getElementById('BuildMarkCounty').onchange = () => { updateTownDropdown('BuildMarkCounty', 'BuildMarkVillage') };
document.getElementById('BuildAddressCounty').onchange = () => { updateTownDropdown('BuildAddressCounty','BuildAddressVillage')}

function updateTownDropdown(county,village) {
    var county = document.getElementById(county).value;
    
    $.ajax({
        url: "getTownList",
        method: "POST",
        data: { "countyName": county },
        dataType: 'html',
        success: (result) => {
            console.log('Success!');
            console.log(result);
            $('#'+village).html(result);
        },
        error: () => {
            console.log('Failed')
        }
    });
}

