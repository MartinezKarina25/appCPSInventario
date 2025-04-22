export const APIGradoUrl = "http://localhost:5119/api/grado";
export const APIPersonalUrl = "http://localhost:5119/api/personal";

export async function getGrados()
{
	try {
		const response = await fetch(APIGradoUrl);
		if (!response.ok) {
			throw new Error("Error al obtener los grados");
		}
		const data = await response.json();
		return data;
	} catch (error) {
		console.error("Error en getGrados:", error);
		return [];
	}
}

export async function getPersonal() {
	try {
		const response = await fetch(APIPersonalUrl);
		if (!response.ok) {
			throw new Error("Error al obtener el personal");
		}
		const data = await response.json();
		return data;
	} catch (error) {
		console.error("Error en getPersonal:", error);
		return [];
	}
}
