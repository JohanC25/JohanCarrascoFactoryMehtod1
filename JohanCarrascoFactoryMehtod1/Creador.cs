namespace JohanCarrascoFactoryMehtod1
{
    public class Creador
    {
        public const int MUSTANG = 1;
        public const int TESLA = 2;
        public const int TOYOTA = 3;

        public static Carros CreadorCarro(int tipo)
        {
            switch (tipo)
            {
                case MUSTANG:
                    return new Mustang();
                case TESLA:
                    return new Tesla();
                case TOYOTA:
                    return new Toyota();
                default: return null;
            }
        }
    }
}
