$.get("Profesion/listarTodo", function (data) {
    var cantFilas = data.length;
    alert(cantFilas);
});
$.get("Profesion/listarTodo", function (data) {

    var contenido = "";
    contenido += "<table id='miTabla' class='table'>";
    contenido += "<thead>";
    contenido += "<tr>";
    contenido += "<td>Codigo</td>";
    contenido += "<td>Nombre</td>";
    contenido += "<td>Descripcion</td>";
    contenido += "</tr>";
    contenido += "</thead>";

    contenido += "<tbody>";
    for (var i = 0; i < data.length; i++) {
        contenido += "<tr>";
        contenido += "<td>" + data[i].Codigo + "</td>";
        contenido += "<td>" + data[i].Nombre + "</td>";
        contenido += "<td>" + data[i].Descripcion + "</td>";
        contenido += "</tr>";
    }
    contenido += "</tbody>";
    contenido += "</table>";
    document.getElementById("miTabla").innerHTML = contenido;
});











