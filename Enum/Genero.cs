namespace DIO.Series
{
    public enum Genero
    {
        Acao = 1,
        Aventura = 2,
        Comedia = 3,
        Documentario = 4,
        Drama = 5,
        Espionagem = 6,
        Faroeste = 7,
        Fantasia = 8,
        Ficcao_Cientifica = 9,
        Musical = 10,
        Romance = 11,
        Suspense = 12,
        Terror = 13

    }
}using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}