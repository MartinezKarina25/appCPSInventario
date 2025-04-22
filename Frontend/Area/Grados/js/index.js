import { getGrados, APIGradoUrl } from "../../../src/api.js";
import { crearModalDetalle, crearModalEditar, crearModalEliminar, crearModalAgregar } from "../js/modal.js";

document.addEventListener("DOMContentLoaded", () => {
    cargarGrados();
    insertarGrado();
});

document.getElementById("grado_form").addEventListener("submit", function (e) {
    e.preventDefault();
    const grado = document.getElementById("grado").value;

    fetch(APIGradoUrl, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ grado: grado })
    })
    .then(response => response.json())
    .then(() => {
        document.getElementById("grado").value = "";
        cargarGrados();
    });
});

async function cargarGrados() {
    try {
        const data = await getGrados();
        const tableBody = document.getElementById("grado_table");
        tableBody.innerHTML = "";

        data.forEach(grado => {
            const row = document.createElement("tr");
            row.innerHTML = `
                <td>${grado._abreviatura}</td>
                <td>${grado._grado}</td>
                <td>
                    <button type="button" class="btn btn-outline-primary mx-2 detalle-btn" data-id="${grado._idGrado}" data-bs-toggle="modal" data-bs-target="#modal_detalle"><i class="bi bi-file-text"></i> Detalle</button>
                    <button type="button" class="btn btn-outline-warning mx-2 editar-btn" data-id="${grado._idGrado}" data-bs-toggle="modal" data-bs-target="#modal_editar"><i class="bi bi-pencil-square"></i> Editar</button>
                    <button type="button" class="btn btn-outline-danger mx-2 eliminar-btn" data-id="${grado._idGrado}" data-bs-toggle="modal" data-bs-target="#modal_eliminar"><i class="bi bi-trash"></i> Eliminar</button>
                </td>
            `;

            tableBody.appendChild(row);

            row.querySelector(".detalle-btn").addEventListener("click", () => {
                crearModalDetalle(grado);
            });

            row.querySelector(".editar-btn").addEventListener("click", () =>{
                crearModalEditar(grado);
            })

            row.querySelector(".eliminar-btn").addEventListener("click", () =>{
                crearModalEliminar(grado);
            })

        });
    } catch (error) {
        console.error("Error cargando grados:", error);
    }
}

function insertarGrado() {
    document.querySelector(".agregar-btn").addEventListener("click", () => {
        crearModalAgregar();
    })
}


function Eliminar(_idGrado) {
    fetch(`${APIGradoUrl}/${_idGrado}`, {
        method: "DELETE"
    })
    .then(() => cargarGrados());
}