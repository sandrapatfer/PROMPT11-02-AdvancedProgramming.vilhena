namespace Mod02_AdvProgramming.Assignments {
    using System;
    using System.Collections.Generic;

    public class Ex1 {

        //1.Complete o m�todo LessThan, que recebe um objecto de refer�ncia
        //    , de tipo gen�rico, e uma colec��o gen�rica
        //        , cujos elementos s�o do tipo anul�vel correspondente 
        //            ao tipo do objecto de refer�ncia. LessThan devolve a 
        //                lista dos valores dos elementos da colec��o de entrada
        //                    que s�o menores do que o objecto de refer�ncia.

        public static List<Prm> LessThan<Prm>(ICollection<Prm?> col, Prm r)
            where Prm : struct, IComparable<Prm>
        {
            var retList = new List<Prm>();
            if (col != null)
            {
                foreach (var prm in col)
                {
                    if (prm.HasValue && prm.Value.CompareTo(r) < 0)
                        retList.Add(prm.Value);
                }
            }
            return retList;
        }


    }
}