namespace WebApiAutores.Servicios
{
    public interface IServicio
    {
        void RealizarTarea();
    }

    public class ServicioA : IServicio
    {
        private readonly ILogger logger;
        public ServicioA(ILogger<ServicioA> logger) 
        {
            this.logger = logger;
        }
        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }

    public class ServicioB : IServicio
    {
        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }
}
