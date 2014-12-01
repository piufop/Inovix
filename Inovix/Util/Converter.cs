using System.Linq;

namespace Inovix.Util
{
    public class Converter
    {
        public static TRetorno Convert<TEntrada, TRetorno>(TEntrada objEntrada) where TRetorno : class, new()
        {
            if (objEntrada == null)
            {
                return null;
            }

            TRetorno objRetorno = new TRetorno();

            System.Reflection.PropertyInfo propObjRetorno;

            // Para cada propriedade do objeto de entrada, preenche igualmente as propriedades do objeto de retorno
            objEntrada.GetType().GetProperties().ToList().ForEach(propObjEntrada =>
            {
                propObjRetorno = objRetorno.GetType().GetProperties().ToList().Find(p => p.Name == propObjEntrada.Name);
                if (propObjRetorno != null)
                {
                    propObjRetorno.SetValue(objRetorno, propObjEntrada.GetValue(objEntrada));
                }
            });

            return objRetorno;
        }
    }

}