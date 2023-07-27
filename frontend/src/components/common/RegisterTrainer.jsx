import { PhotoIcon, UserCircleIcon } from "@heroicons/react/24/solid";

export const RegisterTrainer = () => {
  return (
    <form className="max-w-md mx-auto p-6 bg-white shadow-md rounded-lg">
      <div className="pb-6">
        <h2 className="text-2xl font-semibold text-gray-900">
          Informacion Personal
        </h2>

        <p className="mt-2 text-sm text-gray-600">
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Eveniet neque
          nostrum reprehenderit id accusantium in nihil, nobis voluptatibus
          molestiae architecto, nisi corrupti dignissimos cum illum aliquid
          magni inventore ducimus quibusdam.
        </p>
      </div>

      <div className="grid grid-cols-1 gap-y-6">
        <div>
          <label
            htmlFor="name"
            className="block text-sm font-medium text-gray-900"
          >
            Nombre
          </label>
          <input
            type="text"
            name="name"
            id="name"
            autoComplete="given-name"
            className="w-full rounded-md border border-gray-300 px-3 py-2 text-gray-900 placeholder-gray-400 focus:ring-2 focus:ring-indigo-600 focus:border-indigo-600 sm:text-sm"
          />
        </div>

        <div>
          <label
            htmlFor="age"
            className="block text-sm font-medium text-gray-900"
          >
            Edad
          </label>
          <input
            type="text"
            name="age"
            id="age"
            autoComplete="age"
            className="w-full rounded-md border border-gray-300 px-3 py-2 text-gray-900 placeholder-gray-400 focus:ring-2 focus:ring-indigo-600 focus:border-indigo-600 sm:text-sm"
          />
        </div>

        <div>
          <label
            htmlFor="speciality"
            className="block text-sm font-medium text-gray-900"
          >
            Especialidad
          </label>
          <input
            id="speciality"
            name="speciality"
            type="text"
            autoComplete="speciality"
            className="w-full rounded-md border border-gray-300 px-3 py-2 text-gray-900 placeholder-gray-400 focus:ring-2 focus:ring-indigo-600 focus:border-indigo-600 sm:text-sm"
          />
        </div>

        <div>
          <label
            htmlFor="experience"
            className="block text-sm font-medium text-gray-900"
          >
            Experiencia
          </label>
          <input
            type="text"
            name="experience"
            id="experience"
            autoComplete="experience"
            className="w-full rounded-md border border-gray-300 px-3 py-2 text-gray-900 placeholder-gray-400 focus:ring-2 focus:ring-indigo-600 focus:border-indigo-600 sm:text-sm"
          />
        </div>

        <div>
          <label
            htmlFor="about"
            className="block text-sm font-medium text-gray-900"
          >
            Descripcion
          </label>
          <textarea
            id="about"
            name="about"
            rows={3}
            className="w-full rounded-md border border-gray-300 px-3 py-2 text-gray-900 placeholder-gray-400 focus:ring-2 focus:ring-indigo-600 focus:border-indigo-600 sm:text-sm"
            defaultValue={""}
          />
        </div>
      </div>

      <div className="mt-6 flex justify-end gap-x-4">
        <button
          type="button"
          className="text-sm font-semibold text-gray-900 hover:text-indigo-600"
        >
          Cancel
        </button>
        <button
          type="submit"
          className="rounded-md bg-indigo-600 px-4 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-700 focus:ring-2 focus:ring-offset-2 focus:ring-indigo-600 focus:ring-offset-indigo-600"
        >
          Save
        </button>
      </div>
    </form>
  );
};
