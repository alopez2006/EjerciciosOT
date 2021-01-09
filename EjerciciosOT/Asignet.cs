using System.Linq;

namespace EjerciciosOT
{
    static class Asignet
    {
        /*
			input: nodes = { 3, 3, -1, 2, 2 };
			output: 2

              3 
             / \ 
            1   2 
               / \ 
              4   5 
            
			input: nodes = { 5, 6, 6, 2, 3, -1, 4 }
			output: 1
            
              6 
             / \ 
            2   3 
           /     \ 
          4       5 
         /         \
        7           1

		*/

        public static int GetFullNodes(int[] nodes)
        {
            return nodes.GroupBy(v => v).Where(x => x.Count() == 2).Count();
        }

    }
}
