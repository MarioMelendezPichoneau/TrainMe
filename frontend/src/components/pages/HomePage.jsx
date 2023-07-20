export const HomePage = () => {
  return (
    <div className="bg-gray-100 min-h-screen">
      <header className="bg-white py-4 shadow-md">
        <div className="container mx-auto px-4">
          <h1 className="text-2xl font-semibold text-gray-800">Bienvenido a TrainMe</h1>
        </div>
      </header>

      <section className="py-8">
        <div className="container mx-auto px-4">
          <p className="text-lg text-gray-600">
            TrainMe es una plataforma en línea que te ayuda a encontrar entrenadores
            para tus sesiones de entrenamiento personalizado.
          </p>
        </div>
      </section>

      <section className="py-8">
        <div className="container mx-auto px-4 grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-4">
          <div className="bg-white rounded-lg shadow-md p-6">
            <img
              src="https://via.placeholder.com/300"
              alt="Entrenador 1"
              className="w-full h-48 object-cover mb-4 rounded-lg"
            />
            <h3 className="text-lg font-semibold text-gray-800">Entrenador 1</h3>
            <p className="text-gray-600">Especialidad: Fitness</p>
            <button className="mt-4 bg-blue-500 hover:bg-blue-600 text-white font-semibold py-2 px-4 rounded">
              Reservar sesión
            </button>
          </div>
        </div>
      </section>
    </div>
  );
};