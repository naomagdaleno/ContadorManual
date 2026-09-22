namespace ContadorManual.Maui.models
{
    public class Comtador
    {
        public int _Conteo;

        public int Conteo => _Conteo;

        public Comtador()
        {
            _Conteo = 0;
        }
        public void Contar()
        {
            _Conteo++;
        }
        public void Reiniciar()
        {
            _Conteo = 0;
        }
    }
}
