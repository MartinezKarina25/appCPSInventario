export function crearModalDetalle(grado) {
    const modalHtml = `
    <div class="modal" id="modal_detalle" tabindex="-1" aria-labelledby="modalDetalleLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="modalDetalleLabel">Detalle del Grado</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="mb-3">
                        <label for="abreviatura" class="form-label">Abreviatura</label>
                        <input type="text" class="form-control" id="abreviatura" value="${grado._abreviatura}" readonly>
                    </div>
                    <div class="mb-3">
                        <label for="grado" class="form-label">Grado</label>
                        <input type="text" class="form-control" id="grado" value="${grado._grado}" readonly>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                    <button type="button" class="btn btn-warning editar-btn" data-id="${grado._idGrado}" data-bs-toggle="modal" data-bs-target="#modal_editar"></i> Editar</button>
                    <button type="button" class="btn btn-danger eliminar-btn" data-id="${grado._idGrado}" data-bs-toggle="modal" data-bs-target="#modal_eliminar">Eliminar</button>
                </div>
            </div>
        </div>
    </div>`;

    const oldModal = document.getElementById("modalDetalle");
    if (oldModal) oldModal.remove();

    document.body.insertAdjacentHTML("beforeend", modalHtml);

    document.querySelector("#modalDetalle .editar-btn").addEventListener("click", () => {
        crearModalEditar(grado);
        bootstrap.Modal.getInstance(document.getElementById("modalDetalle")).hide();
    });

    document.querySelector("#modalDetalle .eliminar-btn").addEventListener("click", () => {
        crearModalEliminar(grado);
        bootstrap.Modal.getInstance(document.getElementById("modalDetalle")).hide();
    });

    const modalBootstrap = new bootstrap.Modal(document.getElementById("modalDetalle"));
    modalBootstrap.show();
}

export function crearModalEditar(grado) {
	let modal = `Agregar el modal creado por ustedes`;

	document.querySelector('#staticBackdrop').innerHTML = modal;
	new bootstrap.Modal(document.querySelector('#staticBackdrop')).show();
}

export function crearModalEliminar(grado) {
	let modal = `Agregar el modal creado por ustedes`;

	document.querySelector('#staticBackdrop').innerHTML = modal;
	new bootstrap.Modal(document.querySelector('#staticBackdrop')).show();
}

export function crearModalAgregar() {
	let modal = `Agregar el modal creado por ustedes`;

	document.querySelector('#staticBackdrop').innerHTML = modal;
	new bootstrap.Modal(document.querySelector('#staticBackdrop')).show();
}