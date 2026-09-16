from dataclasses import dataclass

# ==========================================
# PUNTO 3: STRUCT / RECORD EN PYTHON
# ==========================================

@dataclass
class EstudianteRecord:
    nombre: str
    edad: int
    promedio: float

print("--- PUNTO 3: STRUCT / RECORD ---")

# Inicialización de 3 instancias
est1 = EstudianteRecord("Carlos Gómez", 20, 3.8)
est2 = EstudianteRecord("María Pérez", 22, 4.2)
est3 = EstudianteRecord("Juan Rodríguez", 21, 3.5)

# Guardar en un arreglo (lista) y recorrer
lista_records = [est1, est2, est3]
print("\nLista de estudiantes (Records):")
for est in lista_records:
    print(f"Nombre: {est.nombre}, Edad: {est.edad}, Promedio: {est.promedio}")

# Modificación del promedio de un estudiante específico
est2.promedio = 4.8
print(f"\nPromedio modificado de {est2.nombre}: {est2.promedio}")


# ==========================================
# PUNTO 4: OBJETOS (CLASES E INSTANCIAS)
# ==========================================

class Estudiante:
    def __init__(self, nombre: str, edad: int, promedio: float):
        self._nombre = nombre
        self._edad = edad
        self._promedio = promedio

    def mostrarInfo(self):
        print(f"Estudiante: {self._nombre} | Edad: {self._edad} | Promedio: {self._promedio}")

    def setPromedio(self, nuevo_promedio: float):
        if 0.0 <= nuevo_promedio <= 5.0:
            self._promedio = nuevo_promedio
        else:
            print("Promedio inválido")

print("\n--- PUNTO 4: OBJETOS ---")

# Inicialización de 3 instancias
e1 = Estudiante("Ana Martínez", 19, 4.0)
e2 = Estudiante("Luis Torres", 23, 3.2)
e3 = Estudiante("Sofia Castro", 20, 4.5)

# Guardar en lista y recorrer llamando a mostrarInfo()
lista_objetos = [e1, e2, e3]
print("\nLista de estudiantes (Objetos):")
for e in lista_objetos:
    e.mostrarInfo()

# Modificación del promedio mediante setPromedio
e2.setPromedio(3.9)
print("\nDespués de modificar el promedio de Luis Torres:")
e2.mostrarInfo()
