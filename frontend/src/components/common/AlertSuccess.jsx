export const AlertSuccess = ({ message }) => {
  return (
    <div
      className="bg-green-100 border border-green-400 text-green-700 px-4 py-2 rounded relative"
      role="alert"
    >
      <strong className="font-bold">Éxito: </strong>
      <span className="block sm:inline">{message}</span>
    </div>
  );
};
