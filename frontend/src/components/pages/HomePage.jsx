import { Header } from "../layout/Header";
import { Hero } from "../common/Hero";
export const HomePage = () => {
  return (
    <>
      <Header />

      <section>
        <div className="mx-auto max-w-screen-xl px-4 py-16 sm:px-6 sm:py-24 lg:px-8">
          <div className="max-w-3xl">
            <h2 className="text-3xl font-bold sm:text-4xl">
              "Nutrición Inteligente: Descubre Cómo Alimentarte para Potenciar
              Tu Salud y Bienestar
            </h2>
          </div>

          <div className="mt-8 grid grid-cols-1 gap-8 lg:grid-cols-2 lg:gap-16">
            <div className="relative h-64 overflow-hidden sm:h-80 lg:h-full">
              <img
                alt="Party"
                src="https://blog.smartfit.com.mx/wp-content/uploads/2019/11/SF_NOV19_BLOG_DIA_28-1024x853.png"
                className="absolute inset-0 h-full w-full object-cover"
              />
            </div>

            <div className="lg:py-16">
              <article className="space-y-4 text-gray-600">
                <p>
                  El objetivo principal del artículo es educar a los lectores
                  sobre cómo tomar decisiones inteligentes en su dieta diaria
                  para optimizar su salud. Se destacarán los beneficios de
                  consumir una variedad de nutrientes, vitaminas y minerales
                  esenciales para el funcionamiento óptimo del cuerpo y el
                  mantenimiento de un sistema inmunológico fuerte. Además, el
                  artículo ofrecerá consejos prácticos sobre cómo incorporar
                  hábitos alimenticios saludables en la vida cotidiana, teniendo
                  en cuenta las preferencias individuales y las necesidades
                  específicas de cada persona. Se abordarán temas como la
                  importancia de la hidratación, el control del tamaño de las
                  porciones, y la reducción del consumo de alimentos procesados
                  y azúcares agregados.
                </p>
              </article>
            </div>
          </div>
        </div>
      </section>
    </>
  );
};
